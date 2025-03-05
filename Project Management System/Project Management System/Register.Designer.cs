namespace Project_Management_System
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            ShowPasswordCheckBox = new CheckBox();
            Lbl_Login = new Label();
            Lbl_Genser = new Label();
            CB_Gender = new ComboBox();
            Lbl_Phone = new Label();
            Txt_Phone = new TextBox();
            Lbl_Email = new Label();
            Txt_Email = new TextBox();
            Lbl_Clear = new Label();
            Btn_Register = new Button();
            Txt_Password = new TextBox();
            Lbl_Password = new Label();
            Lbl_Name = new Label();
            Txt_UserName = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.wallpaper65;
            panel1.Controls.Add(ShowPasswordCheckBox);
            panel1.Controls.Add(Lbl_Login);
            panel1.Controls.Add(Lbl_Genser);
            panel1.Controls.Add(CB_Gender);
            panel1.Controls.Add(Lbl_Phone);
            panel1.Controls.Add(Txt_Phone);
            panel1.Controls.Add(Lbl_Email);
            panel1.Controls.Add(Txt_Email);
            panel1.Controls.Add(Lbl_Clear);
            panel1.Controls.Add(Btn_Register);
            panel1.Controls.Add(Txt_Password);
            panel1.Controls.Add(Lbl_Password);
            panel1.Controls.Add(Lbl_Name);
            panel1.Controls.Add(Txt_UserName);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 598);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.BackColor = Color.LavenderBlush;
            ShowPasswordCheckBox.Cursor = Cursors.Hand;
            ShowPasswordCheckBox.Font = new Font("Segoe UI", 9.75F);
            ShowPasswordCheckBox.Location = new Point(292, 393);
            ShowPasswordCheckBox.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(148, 27);
            ShowPasswordCheckBox.TabIndex = 23;
            ShowPasswordCheckBox.Text = "Show Password";
            ShowPasswordCheckBox.UseVisualStyleBackColor = false;
            ShowPasswordCheckBox.CheckedChanged += ShowPasswordCheckBox_CheckedChanged;
            // 
            // Lbl_Login
            // 
            Lbl_Login.AutoSize = true;
            Lbl_Login.BackColor = Color.Goldenrod;
            Lbl_Login.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Login.Location = new Point(331, 545);
            Lbl_Login.Name = "Lbl_Login";
            Lbl_Login.Size = new Size(50, 20);
            Lbl_Login.TabIndex = 22;
            Lbl_Login.Text = "Login";
            Lbl_Login.Click += Lbl_Login_Click;
            // 
            // Lbl_Genser
            // 
            Lbl_Genser.AutoSize = true;
            Lbl_Genser.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Genser.ForeColor = Color.Black;
            Lbl_Genser.Location = new Point(118, 296);
            Lbl_Genser.Name = "Lbl_Genser";
            Lbl_Genser.Size = new Size(82, 28);
            Lbl_Genser.TabIndex = 21;
            Lbl_Genser.Text = "Gender";
            // 
            // CB_Gender
            // 
            CB_Gender.FormattingEnabled = true;
            CB_Gender.Items.AddRange(new object[] { "Male", "Female" });
            CB_Gender.Location = new Point(260, 296);
            CB_Gender.Name = "CB_Gender";
            CB_Gender.Size = new Size(258, 28);
            CB_Gender.TabIndex = 20;
            // 
            // Lbl_Phone
            // 
            Lbl_Phone.AutoSize = true;
            Lbl_Phone.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Phone.ForeColor = Color.Black;
            Lbl_Phone.Location = new Point(118, 251);
            Lbl_Phone.Name = "Lbl_Phone";
            Lbl_Phone.Size = new Size(72, 28);
            Lbl_Phone.TabIndex = 19;
            Lbl_Phone.Text = "Phone";
            // 
            // Txt_Phone
            // 
            Txt_Phone.Location = new Point(260, 255);
            Txt_Phone.Name = "Txt_Phone";
            Txt_Phone.Size = new Size(258, 27);
            Txt_Phone.TabIndex = 18;
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Email.ForeColor = Color.Black;
            Lbl_Email.Location = new Point(118, 206);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(64, 28);
            Lbl_Email.TabIndex = 17;
            Lbl_Email.Text = "Email";
            // 
            // Txt_Email
            // 
            Txt_Email.Location = new Point(260, 206);
            Txt_Email.Name = "Txt_Email";
            Txt_Email.Size = new Size(258, 27);
            Txt_Email.TabIndex = 16;
            // 
            // Lbl_Clear
            // 
            Lbl_Clear.AutoSize = true;
            Lbl_Clear.BackColor = Color.Goldenrod;
            Lbl_Clear.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Clear.Location = new Point(332, 504);
            Lbl_Clear.Name = "Lbl_Clear";
            Lbl_Clear.Size = new Size(49, 20);
            Lbl_Clear.TabIndex = 15;
            Lbl_Clear.Text = "Clear";
            Lbl_Clear.Click += label4_Click_1;
            // 
            // Btn_Register
            // 
            Btn_Register.BackColor = Color.White;
            Btn_Register.Location = new Point(301, 438);
            Btn_Register.Name = "Btn_Register";
            Btn_Register.Size = new Size(118, 41);
            Btn_Register.TabIndex = 14;
            Btn_Register.Text = "Register";
            Btn_Register.UseVisualStyleBackColor = false;
            Btn_Register.Click += button1_Click_1;
            // 
            // Txt_Password
            // 
            Txt_Password.Location = new Point(260, 349);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.Size = new Size(258, 27);
            Txt_Password.TabIndex = 13;
            Txt_Password.UseSystemPasswordChar = true;
            // 
            // Lbl_Password
            // 
            Lbl_Password.AutoSize = true;
            Lbl_Password.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Password.ForeColor = Color.Black;
            Lbl_Password.Location = new Point(118, 349);
            Lbl_Password.Name = "Lbl_Password";
            Lbl_Password.Size = new Size(102, 28);
            Lbl_Password.TabIndex = 12;
            Lbl_Password.Text = "Password";
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Name.ForeColor = Color.Black;
            Lbl_Name.Location = new Point(118, 144);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(68, 28);
            Lbl_Name.TabIndex = 11;
            Lbl_Name.Text = "Name";
            // 
            // Txt_UserName
            // 
            Txt_UserName.Location = new Point(260, 148);
            Txt_UserName.Name = "Txt_UserName";
            Txt_UserName.Size = new Size(258, 27);
            Txt_UserName.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 17);
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
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(689, 601);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
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
        private Button Btn_Register;
        private TextBox Txt_Password;
        private Label Lbl_Password;
        private Label Lbl_Name;
        private TextBox Txt_UserName;
        private PictureBox pictureBox1;
        private Label label1;
        private Label Lbl_Phone;
        private TextBox Txt_Phone;
        private Label Lbl_Email;
        private TextBox Txt_Email;
        private Label Lbl_Genser;
        private ComboBox CB_Gender;
        private Label Lbl_Login;
        private CheckBox ShowPasswordCheckBox;
    }
}
