using Newtonsoft.Json;
using System.Windows.Forms;
using static Navigator.Storage;

namespace Navigator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //HTTPSClient.POSTLogin(tbLogin.Text, tbPassword.Text);
            HTTPSClient.Init();
            await HTTPSClient.POSTLogin(tbLogin.Text, tbPassword.Text);
            if (root != null)
            {
                lblStatusLogin.Text = "Успешно!";

                dgvGroups.DataSource = groups;
                dgvGroups.Columns["eventid"].Visible = false;
                dgvGroups.Columns["type"].Visible = false;
                dgvGroups.Columns["size"].Visible = false;
                dgvGroups.Columns["isdeleted"].Visible = false;
                dgvGroups.Columns["datecreated"].Visible = false;
                dgvGroups.Columns["sportstageid"].Visible = false;
                dgvGroups.Columns["sporttrainingyear"].Visible = false;
                dgvGroups.Columns["entranceexamsenabled"].Visible = false;
                dgvGroups.Columns["iseventaddress"].Visible = false;
                dgvGroups.Columns["address"].Visible = false;
                dgvGroups.Columns["municipalityid"].Visible = false;
                dgvGroups.Columns["municipalityregionid"].Visible = false;
                dgvGroups.Columns["eventstate"].Visible = false;
                dgvGroups.Columns["partnerid"].Visible = false;
                dgvGroups.Columns["eventmunicipalityid"].Visible = false;
                dgvGroups.Columns["urlcode"].Visible = false;
                dgvGroups.Columns["availableordercurrentyear"].Visible = false;
                dgvGroups.Columns["availableordernextyear"].Visible = false;
                dgvGroups.Columns["hasschedule"].Visible = false;
                dgvGroups.Columns["programtype"].Visible = false;
                dgvGroups.Columns["ispfdod"].Visible = false;
                dgvGroups.Columns["costhourmanual"].Visible = false;
                dgvGroups.Columns["islocked"].Visible = false;
                dgvGroups.Columns["islockednextyear"].Visible = false;
                dgvGroups.Columns["availablenextyearorderfrom"].Visible = false;
                dgvGroups.Columns["availablenextyearorderto"].Visible = false;
                dgvGroups.Columns["year"].Visible = false;

                dgvGroups.Columns["id"].HeaderText = "ID";
                dgvGroups.Columns["name"].HeaderText = "Название";
                dgvGroups.Columns["teacher"].HeaderText = "Педагог";
                dgvGroups.Columns["ageto"].HeaderText = "Макс Возраст";
                dgvGroups.Columns["agefrom"].HeaderText = "Мин Возраст";
                dgvGroups.Columns["sizemin"].HeaderText = "Минимальный размер";
                dgvGroups.Columns["hoursyear"].HeaderText = "Часов в год";
                dgvGroups.Columns["datestart"].HeaderText = "Начало программы";
                dgvGroups.Columns["dateend"].HeaderText = "Завершение программы";
                dgvGroups.Columns["orderfrom"].HeaderText = "Принимать с";
                dgvGroups.Columns["orderto"].HeaderText = "Окончание приёма";
                dgvGroups.Columns["programname"].HeaderText = "Программа";


                foreach (DataGridViewColumn column in dgvGroups.Columns)
                    column.ReadOnly = true;

                dgvGroups.AutoResizeColumns();
            }
            else
            {
                lblStatusLogin.Text = "Авторизация не успешна!";
            }
        }

        private async void dgvGroups_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int currentMouseOverRow = dgvGroups.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                    MessageBox.Show(currentMouseOverRow.ToString());
            }

        }

        private async void dgvGroup_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvGroup.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                string kid_id = dgvGroup["kid_id", currentMouseOverRow].Value.ToString();
                var info = HTTPSClient.GETChildInfo(kid_id);
                Child child = await info;
                new FormChildInfo(child).Show();
            }
        }

        private async void dgvGroups_MouseDoubleClickAsync(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgvGroups.HitTest(e.X, e.Y).RowIndex;
            if (currentMouseOverRow >= 0)
            {
                string eventid = (string)dgvGroups["id", currentMouseOverRow].Value;
                var taskMembers = HTTPSClient.GETChilds(eventid, tbYear.Text);
                List<ChildMember> childrens = await taskMembers;
                dgvGroup.DataSource = childrens;
                dgvGroup.Columns["id"].Visible = false;
                dgvGroup.Columns["type"].Visible = false;
                dgvGroup.Columns["order_id"].Visible = false;
                dgvGroup.Columns["kid_id"].Visible = false;
                dgvGroup.Columns["kid_birthday"].Visible = false;
                dgvGroup.Columns["type_code"].Visible = false;
                dgvGroup.Columns["type_active"].Visible = false;
                dgvGroup.Columns["type_details"].Visible = false;
                dgvGroup.Columns["state"].Visible = false;
                dgvGroup.Columns["info"].Visible = false;
                dgvGroup.Columns["actual_financing_source"].Visible = false;

                dgvGroup.Columns["kid_last_name"].HeaderText = "Фамилия";
                dgvGroup.Columns["kid_first_name"].HeaderText = "Имя";
                dgvGroup.Columns["kid_patro_name"].HeaderText = "Отчество";
                dgvGroup.Columns["kid_is_approved"].HeaderText = "Подтверждён";
                dgvGroup.Columns["kid_age"].HeaderText = "Возраст";

                dgvGroup.AutoResizeColumns();
                dgvGroup.ReadOnly = true;

                lblGroupName.Text = (string)dgvGroups["programname", currentMouseOverRow].Value +
                    (string)dgvGroups["name", currentMouseOverRow].Value;
            }
        }
    }
}