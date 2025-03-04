namespace Project_Management_System
{
    partial class Projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            dataGridViewProject = new DataGridView();
            Btn_Delete = new Button();
            Btn_Edit = new Button();
            Btn_Add = new Button();
            Txt_Description = new TextBox();
            label10 = new Label();
            CB_Status = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            Txt_Name = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            Lbl_LogOut = new Label();
            Lbl_Reports = new Label();
            Lbl_Tasks = new Label();
            Lbl_Projects = new Label();
            Lbl_Employee = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            Btn_Clear = new Button();
            panel1 = new Panel();
            label11 = new Label();
            dateTimePickerSD = new DateTimePicker();
            label12 = new Label();
            dateTimePickerED = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProject
            // 
            dataGridViewProject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProject.BackgroundColor = Color.FloralWhite;
            dataGridViewProject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProject.GridColor = SystemColors.ActiveCaptionText;
            dataGridViewProject.Location = new Point(333, 410);
            dataGridViewProject.Name = "dataGridViewProject";
            dataGridViewProject.RowHeadersWidth = 51;
            dataGridViewProject.Size = new Size(1095, 297);
            dataGridViewProject.TabIndex = 31;
            dataGridViewProject.RowHeaderMouseDoubleClick += dataGridViewProject_RowHeaderMouseDoubleClick;
            // 
            // Btn_Delete
            // 
            Btn_Delete.BackColor = Color.White;
            Btn_Delete.Location = new Point(833, 341);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(124, 41);
            Btn_Delete.TabIndex = 29;
            Btn_Delete.Text = "Delete";
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.BackColor = Color.White;
            Btn_Edit.Location = new Point(661, 338);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(124, 41);
            Btn_Edit.TabIndex = 28;
            Btn_Edit.Text = "Edit";
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Add
            // 
            Btn_Add.BackColor = Color.White;
            Btn_Add.Location = new Point(509, 338);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(124, 41);
            Btn_Add.TabIndex = 27;
            Btn_Add.Text = "Add";
            Btn_Add.UseVisualStyleBackColor = false;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // Txt_Description
            // 
            Txt_Description.Location = new Point(593, 236);
            Txt_Description.Name = "Txt_Description";
            Txt_Description.Size = new Size(192, 27);
            Txt_Description.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(593, 191);
            label10.Name = "label10";
            label10.Size = new Size(123, 28);
            label10.TabIndex = 25;
            label10.Text = "Description";
            // 
            // CB_Status
            // 
            CB_Status.FormattingEnabled = true;
            CB_Status.Items.AddRange(new object[] { "Pending", "InProgress", "Completed" });
            CB_Status.Location = new Point(1284, 235);
            CB_Status.Name = "CB_Status";
            CB_Status.Size = new Size(144, 28);
            CB_Status.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1284, 191);
            label9.Name = "label9";
            label9.Size = new Size(72, 28);
            label9.TabIndex = 23;
            label9.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(378, 191);
            label8.Name = "label8";
            label8.Size = new Size(142, 28);
            label8.TabIndex = 22;
            label8.Text = "Project Name";
            // 
            // Txt_Name
            // 
            Txt_Name.Location = new Point(378, 236);
            Txt_Name.Name = "Txt_Name";
            Txt_Name.Size = new Size(168, 27);
            Txt_Name.TabIndex = 21;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(11, 633);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(78, 64);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(11, 495);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(72, 52);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 409);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 307);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 61);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 190);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Lbl_LogOut
            // 
            Lbl_LogOut.AutoSize = true;
            Lbl_LogOut.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_LogOut.ForeColor = Color.Black;
            Lbl_LogOut.Location = new Point(116, 669);
            Lbl_LogOut.Name = "Lbl_LogOut";
            Lbl_LogOut.Size = new Size(84, 28);
            Lbl_LogOut.TabIndex = 4;
            Lbl_LogOut.Text = "LogOut";
            Lbl_LogOut.Click += Lbl_LogOut_Click;
            // 
            // Lbl_Reports
            // 
            Lbl_Reports.AutoSize = true;
            Lbl_Reports.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Reports.ForeColor = Color.Black;
            Lbl_Reports.Location = new Point(116, 519);
            Lbl_Reports.Name = "Lbl_Reports";
            Lbl_Reports.Size = new Size(87, 28);
            Lbl_Reports.TabIndex = 4;
            Lbl_Reports.Text = "Reports";
            Lbl_Reports.Click += Lbl_Reports_Click;
            // 
            // Lbl_Tasks
            // 
            Lbl_Tasks.AutoSize = true;
            Lbl_Tasks.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Tasks.ForeColor = Color.Black;
            Lbl_Tasks.Location = new Point(116, 422);
            Lbl_Tasks.Name = "Lbl_Tasks";
            Lbl_Tasks.Size = new Size(63, 28);
            Lbl_Tasks.TabIndex = 4;
            Lbl_Tasks.Text = "Tasks";
            Lbl_Tasks.Click += Lbl_Tasks_Click;
            // 
            // Lbl_Projects
            // 
            Lbl_Projects.AutoSize = true;
            Lbl_Projects.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Projects.ForeColor = Color.Black;
            Lbl_Projects.Location = new Point(116, 340);
            Lbl_Projects.Name = "Lbl_Projects";
            Lbl_Projects.Size = new Size(89, 28);
            Lbl_Projects.TabIndex = 4;
            Lbl_Projects.Text = "Projects";
            Lbl_Projects.Click += Lbl_Projects_Click;
            // 
            // Lbl_Employee
            // 
            Lbl_Employee.AutoSize = true;
            Lbl_Employee.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl_Employee.ForeColor = Color.Black;
            Lbl_Employee.Location = new Point(116, 216);
            Lbl_Employee.Name = "Lbl_Employee";
            Lbl_Employee.Size = new Size(115, 28);
            Lbl_Employee.TabIndex = 4;
            Lbl_Employee.Text = "Employees";
            Lbl_Employee.Click += Lbl_Employee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(625, 38);
            label1.Name = "label1";
            label1.Size = new Size(308, 27);
            label1.TabIndex = 18;
            label1.Text = "Project Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Btn_Clear
            // 
            Btn_Clear.BackColor = Color.White;
            Btn_Clear.Location = new Point(1017, 341);
            Btn_Clear.Name = "Btn_Clear";
            Btn_Clear.Size = new Size(124, 41);
            Btn_Clear.TabIndex = 30;
            Btn_Clear.Text = "Clear";
            Btn_Clear.UseVisualStyleBackColor = false;
            Btn_Clear.Click += Btn_Clear_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(Lbl_LogOut);
            panel1.Controls.Add(Lbl_Reports);
            panel1.Controls.Add(Lbl_Tasks);
            panel1.Controls.Add(Lbl_Projects);
            panel1.Controls.Add(Lbl_Employee);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(4, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 716);
            panel1.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(833, 191);
            label11.Name = "label11";
            label11.Size = new Size(110, 28);
            label11.TabIndex = 33;
            label11.Text = "Start Date";
            // 
            // dateTimePickerSD
            // 
            dateTimePickerSD.Location = new Point(833, 234);
            dateTimePickerSD.Name = "dateTimePickerSD";
            dateTimePickerSD.Size = new Size(198, 27);
            dateTimePickerSD.TabIndex = 34;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(1066, 191);
            label12.Name = "label12";
            label12.Size = new Size(99, 28);
            label12.TabIndex = 35;
            label12.Text = "End Date";
            // 
            // dateTimePickerED
            // 
            dateTimePickerED.Location = new Point(1066, 236);
            dateTimePickerED.Name = "dateTimePickerED";
            dateTimePickerED.Size = new Size(198, 27);
            dateTimePickerED.TabIndex = 36;
            // 
            // Projects
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1440, 719);
            Controls.Add(dateTimePickerED);
            Controls.Add(label12);
            Controls.Add(dateTimePickerSD);
            Controls.Add(label11);
            Controls.Add(dataGridViewProject);
            Controls.Add(Btn_Delete);
            Controls.Add(Btn_Edit);
            Controls.Add(Btn_Add);
            Controls.Add(Txt_Description);
            Controls.Add(label10);
            Controls.Add(CB_Status);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(Txt_Name);
            Controls.Add(label1);
            Controls.Add(Btn_Clear);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Projects";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Projects";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProject).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProject;
        private Button Btn_Delete;
        private Button Btn_Edit;
        private Button Btn_Add;
        private TextBox Txt_Description;
        private Label label10;
        private ComboBox CB_Status;
        private Label label9;
        private Label label8;
        private TextBox Txt_Name;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label Lbl_LogOut;
        private Label Lbl_Reports;
        private Label Lbl_Tasks;
        private Label Lbl_Projects;
        private Label Lbl_Employee;
        private Label label1;
        private PictureBox pictureBox1;
        private Button Btn_Clear;
        private Panel panel1;
        private Label label11;
        private DateTimePicker dateTimePickerSD;
        private Label label12;
        private DateTimePicker dateTimePickerED;
    }
}