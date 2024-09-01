using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Navigator
{
    public partial class FormChildInfo : Form
    {
        Storage.Child child;
        public FormChildInfo(Storage.Child child)
        {
            InitializeComponent();
            this.child = child;
        }

        private void FormChildInfo_Load(object sender, EventArgs e)
        {
            Text = string.Format("Обучающийся: {0} {1} {2}", child.last_name, child.first_name, child.patro_name);


            List<string> values = new List<string>();
            values.Add(string.Format("{0} : {1}\r\n", "Фамилия", child.last_name));
            values.Add(string.Format("{0} : {1}\r\n", "Имя", child.first_name));
            values.Add(string.Format("{0} : {1}\r\n", "Отчество", child.patro_name));
            values.Add(string.Format("{0} : {1}\r\n", "Дата рождения", child.birthday));
            values.Add(string.Format("{0} : {1}\r\n", "Возраст", child.age));
            values.Add(string.Format("{0} : {1}\r\n", "Родитель", child.parent_fio));
            values.Add(string.Format("{0} : {1}\r\n", "Родитель email", child.parent_email));
            values.Add(string.Format("{0} : {1}\r\n", "Родитель номер", child.parent_phone));
            values.Add(string.Format("{0} : {1}\r\n", "Муниципалитет", child.municipality_name));

            tbInfo.Text = "";
            tbInfo.ReadOnly = true;
            tbInfo.BorderStyle = 0;
            tbInfo.BackColor = this.BackColor;
            tbInfo.TabStop = false;
            tbInfo.Multiline = true;
            foreach (var v in values)
            {
                tbInfo.Text += v.ToString();
            }

        }
    }
}
