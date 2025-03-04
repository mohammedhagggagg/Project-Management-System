using System.Data;
using Management_System;
using Microsoft.EntityFrameworkCore;
using Project_Management_System.Contexts;
using Project_Management_System.Models;

namespace Project_Management_System
{
    public partial class TaskResult : Form
    {
        PMSDbContext context = new PMSDbContext();
        private int loggedInEmployeeId;
        public TaskResult(int id)
        {
            InitializeComponent();
            this.loggedInEmployeeId = id;
            DisplayTasks();
           
        }

        #region NotUsed
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Display Tasks commented
        // private void DisplayTasks(string searchQuery = "", string statusFilter = "All", string priorityFilter = "All")
        //{
        //    try
        //    {
        //        IQueryable<TaskItem> query = context.Tasks;
        //        if (!string.IsNullOrEmpty(searchQuery))
        //        {
        //            query = query.Include(x => x.Employee).Where(x => x.Name.Contains(searchQuery) || x.Description.Contains(searchQuery) || x.Employee.Name.Contains(searchQuery));
        //        }
        //        if (statusFilter != "All" && priorityFilter != "All")
        //        {
        //            query = query.Where(x => x.Status.ToString() == statusFilter && x.Priority.ToString() == priorityFilter);
        //        }
        //        else if (statusFilter != "All")
        //        {
        //            query = query.Where(x => x.Status.ToString() == statusFilter);
        //        }
        //        else if (priorityFilter != "All")
        //        {
        //            query = query.Where(x => x.Priority.ToString() == priorityFilter);
        //        }


        //        var tasks = context.Tasks
        //                         .Select
        //                         (t => new
        //                         {
        //                             t.Id,
        //                             t.Name,
        //                             t.Description,
        //                             t.DueDate,
        //                             Priority = t.Priority.ToString(),
        //                             Status = t.Status.ToString(),
        //                             projectName = t.Project.Name
        //                         }).ToList();
        //        dataGridViewTasks.DataSource = tasks;
        //        CB_Project.DataSource = context.Projects.ToList();
        //        CB_Project.ValueMember = "Id";
        //        CB_Project.DisplayMember = "Name";
        //        CB_Status.DataSource = Enum.GetValues(typeof(Models.TaskStatus));
        //        CB_Priority.DataSource = Enum.GetValues(typeof(Models.TaskPriority));
        //        CB_AssToEmp.DataSource = context.Employees.ToList();
        //        CB_AssToEmp.ValueMember = "Id";
        //        CB_AssToEmp.DisplayMember = "Name";

        //        #region RefreshData
        //        Txt_Name.Clear();
        //        Txt_Description.Clear();
        //        dateTimePickerDueDate.Value = DateTime.Now;
        //        CB_AssToEmp.SelectedIndex = -1;
        //        CB_Project.SelectedIndex = -1;
        //        CB_Priority.SelectedIndex = -1;
        //        CB_Status.SelectedIndex = -1;
        //        Btn_Add.Visible = true;
        //        Btn_Edit.Visible = false;
        //        Btn_Delete.Visible = false;
        //        Btn_Clear.Visible = true;
        //        selectedTaskid = -1;
        //        #endregion 


        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);

        //    }
        //}
        #endregion
      
        private void DisplayTasks(string searchQuery = "", string statusFilter = "All", string priorityFilter = "All")
        {
            try
            {
                var query = context.Tasks
                    .Include(t => t.Employee)
                    .Include(t => t.Project)
                    .AsQueryable();

                // 🔹 فلترة المهام حسب الموظف المسجّل
                if (loggedInEmployeeId > 0)
                {
                    query = query.Where(x => x.EmployeeId == loggedInEmployeeId);
                }

                if (!string.IsNullOrEmpty(searchQuery))
                {
                    query = query.Where(x =>
                        x.Name.Contains(searchQuery) ||
                        x.Description.Contains(searchQuery) ||
                        x.Employee.Name.Contains(searchQuery));
                }

                if (statusFilter != "All")
                {
                    query = query.Where(x => x.Status.ToString() == statusFilter);
                }

                if (priorityFilter != "All")
                {
                    query = query.Where(x => x.Priority.ToString() == priorityFilter);
                }

                var tasks = query
                    .Select(t => new
                    {
                        t.Id,
                        t.Name,
                        t.Description,
                        t.DueDate,
                        Priority = t.Priority.ToString(),
                        Status = t.Status.ToString(),
                        ProjectName = t.Project.Name
                    })
                    .ToList();

                dataGridViewTasks.DataSource = tasks;

                if (CB_Project.DataSource == null)
                {
                    CB_Project.DataSource = context.Projects.ToList();
                    CB_Project.ValueMember = "Id";
                    CB_Project.DisplayMember = "Name";

                    CB_Status.DataSource = Enum.GetValues(typeof(Models.TaskStatus));
                    CB_Priority.DataSource = Enum.GetValues(typeof(Models.TaskPriority));

                    CB_AssToEmp.DataSource = context.Employees.ToList();
                    CB_AssToEmp.ValueMember = "Id";
                    CB_AssToEmp.DisplayMember = "Name";
                }

                Txt_Name.Clear();
                Txt_Name.Visible = false;
                Txt_Description.Clear();
                Txt_Description.Visible = false;
                dateTimePickerDueDate.Value = DateTime.Now;
                dateTimePickerDueDate.Visible = false;
                CB_AssToEmp.SelectedIndex = -1;
                CB_AssToEmp.Visible = false;
                CB_Project.SelectedIndex = -1;
                CB_Project.Visible = false;

                CB_Priority.SelectedIndex = -1;
                //CB_Priority.Visible = false;
                CB_Status.SelectedIndex = -1;
                //CB_Status.Visible = false;
                Btn_Add.Visible = false;
                Btn_Edit.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Clear.Visible = true;
                selectedTaskid = -1;
                label7.Visible = false;
                label8.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                //label9.Visible = false;
                //label13.Visible = false;
                Lbl_Employees.Visible = false;
                Lbl_Projects.Visible = false;
                Lbl_Reports.Visible = false;
                Lbl_Tasks.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadTasksGroupedByPriority()
        {
            try
            {
                
                    string statusFilter = CB_FStatus.SelectedItem?.ToString() ?? "All";
                    string priorityFilter = CB_FPriority.SelectedItem?.ToString() ?? "All";
                    string searchText = Txt_Search.Text.Trim();

                    var query = context.Tasks
                        .Include(x => x.Employee)
                        .Include(x => x.Project)
                        .AsQueryable(); 

                    
                    if (!string.IsNullOrWhiteSpace(searchText))
                    {
                        query = query.Where(x =>
                            x.Name.Contains(searchText) ||
                            x.Description.Contains(searchText) ||
                            x.Project.Name.Contains(searchText)
                        );
                    }

                    
                    if (statusFilter != "All")
                    {
                        query = query.Where(x => x.Status.ToString() == statusFilter);
                    }

                    if (priorityFilter != "All")
                    {
                        query = query.Where(x => x.Priority.ToString() == priorityFilter);
                    }

                    
                    var tasks = query
                        .Select(e => new
                        {
                            e.Id,
                            e.Name,
                            e.Description,
                            e.DueDate,
                            e.Priority,
                            e.Status,
                            ProjectName = e.Project.Name,
                            EmployeeName = e.Employee.Name,
                        })
                        .OrderBy(t => t.Priority) 
                        .ThenBy(t => t.DueDate)   
                        .ThenBy(t => t.Id)       
                        .ToList();

                  
                    dataGridViewTasks.DataSource = tasks;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void Tasks_Load(object sender, EventArgs e)
        {
            CB_FStatus.SelectedItem = "All";

            CB_FStatus.SelectedIndexChanged += (s, e) =>
                DisplayTasks(Txt_Search.Text.Trim(), CB_FStatus.SelectedItem.ToString(), CB_FPriority.SelectedItem.ToString());

            CB_FStatus.TextChanged += (s, e) =>
                DisplayTasks(Txt_Search.Text.Trim(), CB_FStatus.SelectedItem.ToString(), CB_FPriority.SelectedItem.ToString());

            Txt_Search.TextChanged += (s, e) =>
                 DisplayTasks(Txt_Search.Text.Trim(), CB_FStatus.SelectedItem.ToString(), CB_FPriority.SelectedItem.ToString());
            CB_FPriority.SelectedItem = "All";

            CB_FPriority.SelectedIndexChanged += (s, e) =>
                DisplayTasks(Txt_Search.Text.Trim(), CB_FStatus.SelectedItem.ToString(), CB_FPriority.SelectedItem.ToString());


        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Description.Text) ||
                    CB_Status.SelectedItem == null ||
                    CB_Project.SelectedItem == null ||
                    CB_Priority.SelectedItem == null ||
                    CB_AssToEmp.SelectedItem == null)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                if (!int.TryParse(CB_AssToEmp.SelectedValue?.ToString(), out int employeeId) ||
                    !int.TryParse(CB_Project.SelectedValue?.ToString(), out int projectId))
                {
                    MessageBox.Show("Invalid selection for Employee or Project.");
                    return;
                }

                Models.TaskItem task = new Models.TaskItem()
                {
                    Name = Txt_Name.Text,
                    Description = Txt_Description.Text,
                    DueDate = dateTimePickerDueDate.Value,
                    EmployeeId = (int)CB_AssToEmp.SelectedValue,
                    ProjectId = (int)CB_Project.SelectedValue,
                    Priority = (TaskPriority)CB_Priority.SelectedItem,
                    Status = (Models.TaskStatus)CB_Status.SelectedItem,
                };
                context.Tasks.Add(task);
                context.SaveChanges();
                MessageBox.Show("Task Added Successfully");
                RefreshData();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }
        private void RefreshData()
        {
            DisplayTasks();
            Txt_Name.Clear();
            Txt_Name.Enabled = false;
            Txt_Description.Clear();
            Txt_Description.Enabled = false;
            Txt_Search.Clear();
            dateTimePickerDueDate.Value = DateTime.Now;
            dateTimePickerDueDate.Enabled = false;
            CB_AssToEmp.SelectedIndex = -1;
            CB_AssToEmp.Enabled = false;
            CB_Project.SelectedIndex = -1;
            CB_Project.Enabled = false;
            CB_Priority.SelectedIndex = -1;
         
            CB_Status.SelectedIndex = -1;
          
            CB_FStatus.SelectedItem = "All";
            CB_FPriority.SelectedItem = "All";
            Btn_Add.Visible = false;
            Btn_Edit.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Clear.Visible = true;
            Btn_GroupbyPriority.Visible = true;
            selectedTaskid = -1;
        }
        int selectedTaskid = -1;
        private void dataGridViewTasks_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewTasks.SelectedRows.Count > 0)
                {
                    selectedTaskid = (int)dataGridViewTasks.SelectedRows[0].Cells[0].Value;
                    Models.TaskItem task = context.Tasks.FirstOrDefault(e => e.Id == selectedTaskid);
                    if (task != null)
                    {
                        Txt_Name.Text = task.Name;
                        Txt_Description.Text = task.Description;
                        CB_Project.SelectedValue = task.ProjectId;
                        CB_AssToEmp.SelectedValue = task.EmployeeId;
                        CB_Priority.SelectedItem = task.Priority;
                        CB_Status.SelectedItem = task.Status;

                        Btn_Add.Visible = false;
                        Btn_Edit.Visible = true;
                        Btn_Delete.Visible = false;
                        Btn_Clear.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: Task not found");
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
                if (selectedTaskid == -1)
                {
                    MessageBox.Show("No Task selected for editing.");
                    return;

                }
                if (string.IsNullOrWhiteSpace(Txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Description.Text) ||
                    CB_Status.SelectedItem == null ||
                    CB_Project.SelectedItem == null ||
                    CB_Priority.SelectedItem == null ||
                    CB_AssToEmp.SelectedItem == null)
                {
                    MessageBox.Show("Missing Information please fill in all fields.");
                    return;
                }
                if (!int.TryParse(CB_AssToEmp.SelectedValue?.ToString(), out int employeeId) ||
                    !int.TryParse(CB_Project.SelectedValue?.ToString(), out int projectId))
                {
                    MessageBox.Show("Invalid selection for Employee or Project.");
                    return;
                }
                Models.TaskItem task = context.Tasks.FirstOrDefault(e => e.Id == selectedTaskid);
                if (task != null)
                {
                    task.Name = Txt_Name.Text;
                    task.Description = Txt_Description.Text;
                    task.DueDate = dateTimePickerDueDate.Value;
                    task.Status = (Models.TaskStatus)CB_Status.SelectedItem;
                    task.Priority = (TaskPriority)CB_Priority.SelectedItem;
                    task.ProjectId = (int)CB_Project.SelectedValue;
                    task.EmployeeId = (int)CB_AssToEmp.SelectedValue;
                    context.SaveChanges();
                    MessageBox.Show("Task Updated Successfully");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Error Task not found.");
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
                if (selectedTaskid == -1)
                {
                    MessageBox.Show("No Project selected for deletion.");
                    return;

                }
                var confirmResult = MessageBox.Show("Are you sure you want to delete this task?",
                                            "Confirm Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    Models.TaskItem task = context.Tasks.FirstOrDefault(p => p.Id == selectedTaskid);
                    if (task != null)
                    {
                        context.Tasks.Remove(task);
                        context.SaveChanges();
                        MessageBox.Show("Task Deleted Successfully");

                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error: Task not found.");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while deleting task: " + ex.Message);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Lbl_LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Lbl_Employees_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.Show();
            this.Hide();
        }

        private void Lbl_Projects_Click(object sender, EventArgs e)
        {
            Projects projects = new Projects();
            projects.Show();
            this.Hide();
        }

        private void Lbl_Tasks_Click(object sender, EventArgs e)
        {
            TaskResult tasks = new TaskResult(loggedInEmployeeId);
            tasks.Show();
            this.Hide();
        }

        private void Lbl_Reports_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void Btn_GroupbyPriority_Click(object sender, EventArgs e)
        {
            //LoadTasksGroupedByPriority();
            //Btn_GroupbyPriority.Visible = false;
            ReportsForm reportsForm = new ReportsForm(loggedInEmployeeId);
            reportsForm.Show();
            this.Hide();
        }
    }
}
