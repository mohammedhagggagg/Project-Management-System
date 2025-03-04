namespace Project_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            Lbl_Registration = new Label();
            Lbl_Clear = new Label();
            Btn_Login = new Button();
            Txt_Password = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Txt_UserName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ShowPasswordCheckBox = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(Lbl_Registration);
            panel1.Controls.Add(Lbl_Clear);
            panel1.Controls.Add(Btn_Login);
            panel1.Controls.Add(Txt_Password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Txt_UserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 598);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // Lbl_Registration
            // 
            Lbl_Registration.AutoSize = true;
            Lbl_Registration.BackColor = Color.Goldenrod;
            Lbl_Registration.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Registration.Location = new Point(317, 550);
            Lbl_Registration.Name = "Lbl_Registration";
            Lbl_Registration.Size = new Size(72, 20);
            Lbl_Registration.TabIndex = 16;
            Lbl_Registration.Text = "Register";
            Lbl_Registration.Click += Lbl_Registration_Click;
            // 
            // Lbl_Clear
            // 
            Lbl_Clear.AutoSize = true;
            Lbl_Clear.BackColor = Color.Goldenrod;
            Lbl_Clear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Clear.Location = new Point(329, 509);
            Lbl_Clear.Name = "Lbl_Clear";
            Lbl_Clear.Size = new Size(49, 20);
            Lbl_Clear.TabIndex = 15;
            Lbl_Clear.Text = "Clear";
            Lbl_Clear.Click += label4_Click_1;
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.White;
            Btn_Login.Location = new Point(301, 438);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(118, 41);
            Btn_Login.TabIndex = 14;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += button1_Click_1;
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(260, 349);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(258, 27);
            Txt_Password.TabIndex = 13;
            Txt_Password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(118, 349);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(118, 272);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 11;
            label2.Text = "UserName";
            // 
            // Txt_UserName
            // 
            Txt_UserName.Location = new Point(260, 276);
            Txt_UserName.Name = "Txt_UserName";
            Txt_UserName.Size = new Size(258, 27);
            Txt_UserName.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(283, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(216, 73);
            label1.Name = "label1";
            label1.Size = new Size(308, 27);
            label1.TabIndex = 8;
            label1.Text = "Project Management System";
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.BackColor = Color.LavenderBlush;
            ShowPasswordCheckBox.Cursor = Cursors.Hand;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 9.75F);
            ShowPasswordCheckBox.Location = new Point(283, 393);
            ShowPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(148, 27);
            ShowPasswordCheckBox.TabIndex = 17;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(689, 601);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Lbl_Clear;
        private Button Btn_Login;
        private TextBox Txt_Password;
        private Label label3;
        private Label label2;
        private TextBox Txt_UserName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Lbl_Registration;
        private CheckBox ShowPasswordCheckBox;
    }
}
