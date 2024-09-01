namespace Navigator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            lblStatusLogin = new Label();
            label2 = new Label();
            label1 = new Label();
            tbPassword = new TextBox();
            tbLogin = new TextBox();
            dgvGroups = new DataGridView();
            panel1 = new Panel();
            tbYear = new TextBox();
            label4 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvGroup = new DataGridView();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            tbSearchMain = new TextBox();
            label3 = new Label();
            label5 = new Label();
            lblGroupName = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroup).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(lblStatusLogin);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbLogin);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Авторизация";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(6, 32);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(45, 66);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblStatusLogin
            // 
            lblStatusLogin.AutoSize = true;
            lblStatusLogin.Location = new Point(6, 104);
            lblStatusLogin.Name = "lblStatusLogin";
            lblStatusLogin.Size = new Size(116, 15);
            lblStatusLogin.TabIndex = 4;
            lblStatusLogin.Text = "Статус авторизации";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 57);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 16);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Логин";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(57, 75);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.PlaceholderText = "Пароль";
            tbPassword.Size = new Size(137, 23);
            tbPassword.TabIndex = 1;
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(57, 32);
            tbLogin.Name = "tbLogin";
            tbLogin.PlaceholderText = "Логин";
            tbLogin.Size = new Size(137, 23);
            tbLogin.TabIndex = 0;
            // 
            // dgvGroups
            // 
            dgvGroups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroups.Dock = DockStyle.Fill;
            dgvGroups.Location = new Point(0, 0);
            dgvGroups.Name = "dgvGroups";
            dgvGroups.RowTemplate.Height = 25;
            dgvGroups.Size = new Size(741, 549);
            dgvGroups.TabIndex = 1;
            dgvGroups.MouseClick += dgvGroups_MouseClick;
            dgvGroups.MouseDoubleClick += dgvGroups_MouseDoubleClickAsync;
            // 
            // panel1
            // 
            panel1.Controls.Add(tbYear);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tabControl1);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(489, 592);
            panel1.TabIndex = 2;
            // 
            // tbYear
            // 
            tbYear.Location = new Point(221, 47);
            tbYear.Name = "tbYear";
            tbYear.PlaceholderText = "2023";
            tbYear.Size = new Size(66, 23);
            tbYear.TabIndex = 3;
            tbYear.Text = "2023";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(223, 22);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 2;
            label4.Text = "Учебный год с";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Bottom;
            tabControl1.Location = new Point(0, 144);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(489, 448);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblGroupName);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(dgvGroup);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(481, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список группы";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvGroup
            // 
            dgvGroup.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGroup.Dock = DockStyle.Bottom;
            dgvGroup.Location = new Point(3, 68);
            dgvGroup.Name = "dgvGroup";
            dgvGroup.RowTemplate.Height = 25;
            dgvGroup.Size = new Size(475, 349);
            dgvGroup.TabIndex = 0;
            dgvGroup.MouseDoubleClick += dgvGroup_MouseDoubleClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(481, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Пол";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(489, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(741, 592);
            panel2.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(dgvGroups);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 43);
            panel4.Name = "panel4";
            panel4.Size = new Size(741, 549);
            panel4.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(tbSearchMain);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(741, 43);
            panel3.TabIndex = 2;
            // 
            // tbSearchMain
            // 
            tbSearchMain.Location = new Point(55, 8);
            tbSearchMain.Name = "tbSearchMain";
            tbSearchMain.Size = new Size(135, 23);
            tbSearchMain.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 11);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Поиск";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 16);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 1;
            label5.Text = "Группа";
            // 
            // lblGroupName
            // 
            lblGroupName.AutoSize = true;
            lblGroupName.Location = new Point(65, 16);
            lblGroupName.Name = "lblGroupName";
            lblGroupName.Size = new Size(0, 15);
            lblGroupName.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 592);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Навигатор дополнительго образования Архангельск";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroups).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGroup).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogin;
        private Label lblStatusLogin;
        private Label label2;
        private Label label1;
        private TextBox tbPassword;
        private TextBox tbLogin;
        private DataGridView dgvGroups;
        private Panel panel1;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel4;
        private Panel panel3;
        private TextBox tbSearchMain;
        private Label label3;
        private DataGridView dgvGroup;
        private TextBox tbYear;
        private Label label4;
        private Label lblGroupName;
        private Label label5;
    }
}