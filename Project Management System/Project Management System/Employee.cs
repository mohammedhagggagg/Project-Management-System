using System.Data;
using Project_Management_System.Contexts;
using Project_Management_System.Models;

namespace Project_Management_System
{
    public partial class Employee : Form
    {
        PMSDbContext context = new PMSDbContext();
        public Employee()
        {
            InitializeComponent();
            DisplayEmployees();
        }
        private void DisplayEmployees()
        {
            try
            {
                var employees = context.Employees
                                 .Select
                                 (e => new
                                 { e.Id, e.Name, e.Email, e.Phone, Gender = e.Gender.ToString(), projectName = e.Project.Name }).ToList();
                dataGridViewEmp.DataSource = employees;
                CB_Project.DataSource = context.Projects.ToList();
                CB_Project.ValueMember = "Id";
                CB_Project.DisplayMember = "Name";
                CB_Gender.DataSource = Enum.GetValues(typeof(Gender));

                #region RefreshData
                Txt_Name.Clear();
                Txt_Email.Clear();
                Txt_Password.Clear();
                Txt_Phone.Clear();
                CB_Gender.SelectedIndex = -1;
                CB_Project.SelectedIndex = -1;
                Btn_Add.Visible = true;
                Btn_Edit.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Clear.Visible = true;
                selectedemployeeid = -1;
                #endregion 


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {



        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Email.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Password.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Phone.Text) ||
                    CB_Gender.SelectedItem == null ||
                    CB_Project.SelectedValue == null)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                else
                {
                    Models.Employee employee = new Models.Employee()
                    {
                        Name = Txt_Name.Text,
                        Email = Txt_Email.Text,
                        Phone = Txt_Phone.Text,
                        Password = Txt_Password.Text,
                        ProjectId = (int)CB_Project.SelectedValue,
                        Gender = (Gender)CB_Gender.SelectedItem,
                    };
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    MessageBox.Show("Employee Added Successfully");
                    RefreshData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }


        int selectedemployeeid = -1;
        private void dataGridViewEmp_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewEmp.SelectedRows.Count > 0)
                {
                    selectedemployeeid = (int)dataGridViewEmp.SelectedRows[0].Cells[0].Value;
                    Models.Employee employee = context.Employees.FirstOrDefault(e => e.Id == selectedemployeeid);
                    if (employee != null)
                    {
                        Txt_Name.Text = employee.Name.ToString();
                        Txt_Email.Text = employee.Email.ToString();
                        Txt_Password.Text = employee.Password.ToString();
                        Txt_Phone.Text = employee.Phone.ToString();
                        CB_Gender.SelectedItem = employee.Gender;
                        //CB_Project.SelectedValue = employee.ProjectId;
                        if (employee.ProjectId != null) 
                        {
                            CB_Project.SelectedValue = employee.ProjectId;
                        }
                        else
                        {
                            CB_Project.SelectedIndex = -1; 
                        }
                        Btn_Add.Visible = false;
                        Btn_Edit.Visible = true;
                        Btn_Delete.Visible = true;
                        Btn_Clear.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: Employee not found");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row first");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedemployeeid == -1)
                {
                    MessageBox.Show("No employee selected for editing.");
                    return;

                }
                if (string.IsNullOrWhiteSpace(Txt_Name.Text) ||
                   string.IsNullOrWhiteSpace(Txt_Email.Text) ||
                   string.IsNullOrWhiteSpace(Txt_Password.Text) ||
                   string.IsNullOrWhiteSpace(Txt_Phone.Text) ||
                   CB_Gender.SelectedItem == null ||
                   CB_Project.SelectedValue == null)
                {
                    MessageBox.Show("Missing Information please fill in all fields.");
                    return;
                }
                Models.Employee employee = context.Employees.FirstOrDefault(e => e.Id == selectedemployeeid);
                if (employee != null)
                {
                    employee.Name = Txt_Name.Text;
                    employee.Email = Txt_Email.Text;
                    employee.Password = Txt_Password.Text;
                    employee.Phone = Txt_Phone.Text;
                    employee.Gender = (Gender)CB_Gender.SelectedItem;
                    employee.ProjectId = (int)CB_Project.SelectedValue;
                    context.SaveChanges();
                    MessageBox.Show("Employee Updated Successfully");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Error Employee not found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedemployeeid == -1)
                {
                    MessageBox.Show("No employee selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var confirmResult = MessageBox.Show("Are you sure you want to delete this employee?",
                                            "Confirm Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    Models.Employee employee = context.Employees.FirstOrDefault(e => e.Id == selectedemployeeid);
                    if (employee != null)
                    {
                        context.Employees.Remove(employee);
                        context.SaveChanges();
                        MessageBox.Show("Employee Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error: Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            DisplayEmployees();
            Txt_Name.Clear();
            Txt_Email.Clear();
            Txt_Password.Clear();
            Txt_Phone.Clear();
            CB_Gender.SelectedIndex = -1;
            CB_Project.SelectedIndex = -1;
            Btn_Add.Visible = true;
            Btn_Edit.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Clear.Visible = true;
            selectedemployeeid = -1;
        }

        private void Lbl_LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Lbl_Project_Click(object sender, EventArgs e)
        {
            Project_Management_System.Projects project = new Projects();
            project.Show();
            this.Hide();

        }

        private void Lbl_Tasks_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            this.Hide();
        }

        private void Lbl_Reports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }
    }
}
