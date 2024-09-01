namespace Navigator
{
    partial class FormChildInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbInfo = new TextBox();
            SuspendLayout();
            // 
            // tbInfo
            // 
            tbInfo.Dock = DockStyle.Fill;
            tbInfo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbInfo.Location = new Point(0, 0);
            tbInfo.Multiline = true;
            tbInfo.Name = "tbInfo";
            tbInfo.Size = new Size(510, 625);
            tbInfo.TabIndex = 1;
            // 
            // FormChildInfo
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 625);
            Controls.Add(tbInfo);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormChildInfo";
            Text = "FormChildInfo";
            Load += FormChildInfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbInfo;
    }
}