using System.Data;
using Project_Management_System.Contexts;
using Project_Management_System.Models;

namespace Project_Management_System
{

    public partial class Projects : Form
    {
        PMSDbContext context = new PMSDbContext();
        public Projects()
        {
            InitializeComponent();
            DisplayProjects();
        }

        private void DisplayProjects()
        {
            try
            {
                var projects = context.Projects
                                .Select(p => new
                                {
                                    p.Id,
                                    p.Name,
                                    p.Description,
                                    p.StartDate,
                                    p.EndDate,
                                    Status = p.Status.ToString()
                                }).ToList();

                dataGridViewProject.DataSource = projects;


                CB_Status.DataSource = Enum.GetValues(typeof(ProjectStatus));

                #region RefreshData
                Txt_Name.Clear();
                Txt_Description.Clear();
                dateTimePickerSD.Value = DateTime.Now;
                dateTimePickerED.Value = DateTime.Now;
                CB_Status.SelectedIndex = -1;
                Btn_Add.Visible = true;
                Btn_Edit.Visible = false;
                Btn_Delete.Visible = false;
                Btn_Clear.Visible = true;


                selectedProjectId = -1;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_Name.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Description.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePickerSD.Text) ||
                    string.IsNullOrWhiteSpace(dateTimePickerED.Text) ||
                    CB_Status.SelectedItem == null)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                else
                {
                    Models.Project project = new Models.Project()
                    {
                        Name = Txt_Name.Text,
                        Description = Txt_Description.Text,
                        StartDate = dateTimePickerSD.Value,
                        EndDate = dateTimePickerED.Value,

                        Status = (ProjectStatus)CB_Status.SelectedItem,
                    };
                    context.Projects.Add(project);
                    context.SaveChanges();

                    MessageBox.Show("Project Added Successfully");
                    RefreshData();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }

        int selectedProjectId = -1;

        private void dataGridViewProject_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewProject.SelectedRows.Count > 0)
                {
                    selectedProjectId = (int)dataGridViewProject.SelectedRows[0].Cells[0].Value;
                    Models.Project project = context.Projects.FirstOrDefault(p => p.Id == selectedProjectId);
                    if (project != null)
                    {
                        Txt_Name.Text = project.Name.ToString();
                        Txt_Description.Text = project.Description.ToString();
                        dateTimePickerSD.Value = project.StartDate;
                        dateTimePickerED.Value = project.EndDate;
                        CB_Status.SelectedItem = project.Status;


                        Btn_Add.Visible = false;
                        Btn_Edit.Visible = true;
                        Btn_Delete.Visible = true;
                        Btn_Clear.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: Project not found");
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
                if (selectedProjectId == -1)
                {
                    MessageBox.Show("No Project selected for editing.");
                    return;

                }
                if (string.IsNullOrWhiteSpace(Txt_Name.Text) ||
                   string.IsNullOrWhiteSpace(Txt_Description.Text) ||
                   CB_Status.SelectedItem == null)
                {
                    MessageBox.Show("Missing Information please fill in all required fields.");
                    return;
                }
                Models.Project project = context.Projects.FirstOrDefault(e => e.Id == selectedProjectId);
                if (project != null)
                {
                    project.Name = Txt_Name.Text;
                    project.Description = Txt_Description.Text;
                    project.StartDate = dateTimePickerSD.Value;
                    project.EndDate = dateTimePickerED.Value;
                    project.Status = (ProjectStatus)CB_Status.SelectedItem;

                    context.SaveChanges();
                    MessageBox.Show("Project Updated Successfully");
                    RefreshData();
                }
                else
                {
                    MessageBox.Show("Error Project not found.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while updating project: " + ex.Message);
            }
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedProjectId == -1)
                {
                    MessageBox.Show("No Project selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var confirmResult = MessageBox.Show("Are you sure you want to delete this project?",
                                            "Confirm Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    Models.Project project = context.Projects.FirstOrDefault(p => p.Id == selectedProjectId);
                    if (project != null)
                    {
                        context.Projects.Remove(project);
                        context.SaveChanges();
                        MessageBox.Show("Project Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error: Project not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while deleting project: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            DisplayProjects();
            Txt_Name.Clear();
            Txt_Description.Clear();
            dateTimePickerSD.Value = DateTime.Now;
            dateTimePickerED.Value = DateTime.Now;

            CB_Status.SelectedIndex = -1;
            Btn_Add.Visible = true;
            Btn_Edit.Visible = false;
            Btn_Delete.Visible = false;
            Btn_Clear.Visible = true;
            selectedProjectId = -1;
        }

        private void Lbl_LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Lbl_Employee_Click(object sender, EventArgs e)
        {
            Project_Management_System.Employee employee = new Project_Management_System.Employee();
            employee.Show();
            this.Hide();
        }

        private void Lbl_Projects_Click(object sender, EventArgs e)
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
