using System.Data;
using System.Drawing.Printing;
using Microsoft.EntityFrameworkCore;
using Project_Management_System.Contexts;
using Project_Management_System.Models;

namespace Project_Management_System
{
    public partial class Reports : Form
    {
        PMSDbContext context = new PMSDbContext();
        public Reports()
        {
            InitializeComponent();
            DisplayReports();
        }
        private void DisplayReports()
        {
            try
            {
                var reports = context.Reports
                                 .Select
                                 (r => new
                                 {
                                     r.Id,
                                     ProjectName=r.Project.Name,
                                     r.TotalTasks,
                                     r.CompletedTasks,
                                     r.PendingTasks,
                                     r.InProgressTasks,
                                     r.GeneratedOn
                                 }).ToList();
                dataGridViewReports.DataSource = reports;
                if (CB_ProjectName.DataSource == null)
                {
                    CB_ProjectName.DataSource = context.Projects.AsNoTracking().ToList();
                    CB_ProjectName.ValueMember = "Id";
                    CB_ProjectName.DisplayMember = "Name";
                }
                dateTimePickerGenOn.Value = DateTime.Now;

                //Txt_CompletedTasks.Text;
                //Txt_PendingTasks.Text;
                //Txt_TotalTasks.Text;


                #region RefreshData
                Txt_CompletedTasks.Clear();
                Txt_PendingTasks.Clear();
                Txt_TotalTasks.Clear();
                CB_ProjectName.SelectedIndex = -1;
                Btn_Add.Visible = true;
                Btn_Print.Visible = true;
                Btn_Delete.Visible = false;
                Btn_Clear.Visible = true;
                //selectedemployeeid = -1;
                #endregion 


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

       
        private void DisplayTaskStatus()
        {
            try
            {
                if (CB_ProjectName.Items.Count == 0 || CB_ProjectName.SelectedItem == null)
                {
                    return;
                }

                if (CB_ProjectName.SelectedItem is Project selectedProject)
                {
                    int projectId = selectedProject.Id;

                    var tasks = context.Tasks.Where(t => t.ProjectId == projectId).ToList();

                    int totalTasks = tasks.Count;
                    int completedTasks = tasks.Count(t => t.Status == Models.TaskStatus.Completed);
                    int pendingTasks = tasks.Count(t => t.Status == Models.TaskStatus.Pending);
                    int inProgressTasks = tasks.Count(t => t.Status == Models.TaskStatus.InProgress);

                    Txt_TotalTasks.Text = totalTasks.ToString();
                    Txt_CompletedTasks.Text = completedTasks.ToString();
                    Txt_PendingTasks.Text = pendingTasks.ToString();
                    Txt_InprogressTasks.Text = inProgressTasks.ToString();
                }
                else
                {
                    MessageBox.Show("Error: Could not retrieve project ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

                dataGridViewReports.DataSource = projects;


                CB_ProjectName.DataSource = context.Projects.AsNoTracking().ToList();
                CB_ProjectName.ValueMember = "Id";
                CB_ProjectName.DisplayMember = "Name";

                #region RefreshData
                Txt_CompletedTasks.Clear();
                Txt_InprogressTasks.Clear();
                dateTimePickerGenOn.Value = DateTime.Now;

                CB_ProjectName.SelectedIndex = -1;
                Btn_Add.Visible = true;
                Btn_Print.Visible = true;
                Btn_Delete.Visible = false;
                Btn_Clear.Visible = true;


                //selectedProjectId = -1;
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //DisplayProjects();
            DisplayReports();
            Txt_TotalTasks.Clear();
            Txt_CompletedTasks.Clear();
            Txt_PendingTasks.Clear();
            Txt_InprogressTasks.Clear();

            CB_ProjectName.SelectedIndex = -1;
            selectedReportId = -1;
        }

        private void Lbl_Employess_Click(object sender, EventArgs e)
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

        private void Lbl_LogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void CB_ProjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_ProjectName.SelectedIndex == -1)
                return;

            DisplayTaskStatus();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_CompletedTasks.Text) ||
                    string.IsNullOrWhiteSpace(Txt_InprogressTasks.Text) ||
                    string.IsNullOrWhiteSpace(Txt_PendingTasks.Text) ||
                    string.IsNullOrWhiteSpace(Txt_TotalTasks.Text) ||
                    CB_ProjectName.SelectedItem == null)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                if (!int.TryParse(CB_ProjectName.SelectedValue?.ToString(), out int projectId))
                {
                    MessageBox.Show("Invalid project selection");
                    return;
                }

                Models.Reports report = new Models.Reports()
                {
                    TotalTasks = int.Parse(Txt_TotalTasks.Text),
                    InProgressTasks = int.Parse(Txt_InprogressTasks.Text),
                    PendingTasks = int.Parse(Txt_PendingTasks.Text),
                    CompletedTasks = int.Parse(Txt_CompletedTasks.Text),
                    GeneratedOn = dateTimePickerGenOn.Value,
                    ProjectId = projectId,
                };
                context.Reports.Add(report);
                context.SaveChanges();

                MessageBox.Show("Report Added Successfully");
                RefreshData();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);

            }
        }


        int selectedReportId = -1;
        private void dataGridViewReports_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridViewReports.SelectedRows.Count > 0)
                {
                    selectedReportId = (int)dataGridViewReports.SelectedRows[0].Cells[0].Value;
                    Models.Reports report = context.Reports.FirstOrDefault(p => p.Id == selectedReportId);
                    if (report != null)
                    {
                        Txt_CompletedTasks.Text = report.CompletedTasks.ToString();
                        Txt_InprogressTasks.Text = report.InProgressTasks.ToString();
                        dateTimePickerGenOn.Value = report.GeneratedOn;
                        Txt_PendingTasks.Text = report.PendingTasks.ToString();
                        Txt_TotalTasks.Text = report.TotalTasks.ToString();
                        CB_ProjectName.SelectedValue = report.ProjectId;


                        Btn_Add.Visible = false;
                        Btn_Print.Visible = true;
                        Btn_Delete.Visible = true;
                        Btn_Clear.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Error: Report not found");
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

        private void RefreshData()
        {
            DisplayReports();
            Txt_TotalTasks.Clear();
            Txt_CompletedTasks.Clear();
            Txt_PendingTasks.Clear();
            Txt_InprogressTasks.Clear();
            CB_ProjectName.SelectedIndex = -1;
            Btn_Add.Visible = true;
            Btn_Print.Visible = true;
            Btn_Delete.Visible = false;
            Btn_Clear.Visible = true;
            Btn_DisPlayPrj.Visible = true;
            selectedReportId = -1;

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedReportId == -1)
                {
                    MessageBox.Show("No report selected for deletion.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                var confirmResult = MessageBox.Show("Are you sure you want to delete this report?",
                                            "Confirm Deletion",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    Models.Reports report = context.Reports.FirstOrDefault(r => r.Id == selectedReportId);
                    if (report != null)
                    {
                        context.Reports.Remove(report);
                        context.SaveChanges();
                        MessageBox.Show("Report Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Error: Report not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while deleting report: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void Btn_DisPlayPrj_Click(object sender, EventArgs e)
        {
            DisplayProjects();
            Txt_TotalTasks.Clear();
            Txt_CompletedTasks.Clear();
            Txt_PendingTasks.Clear();
            Txt_InprogressTasks.Clear();
            CB_ProjectName.SelectedIndex = -1;
            Btn_Add.Visible = true;
            Btn_Print.Visible = true;
            Btn_Delete.Visible = false;
            Btn_Clear.Visible = true;
            Btn_DisPlayPrj.Visible = false;
            selectedReportId = -1;
        }
        private void Btn_Print_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printGrid);

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog()
            {
                Document = printDocument
            };
            printPreviewDialog.ShowDialog();

        }

       


        private void printGrid(object sender, PrintPageEventArgs e)
        {
            int pageWidth = e.PageBounds.Width - 60; 
            int padding = 50;
            int x = (e.PageBounds.Width - pageWidth) / 2;
            int y = 120;
            int rowHeight = 45;

            Font headerFont = new Font("Arial", 11, FontStyle.Bold);
            Font tableFont = new Font("Arial", 10);
            Brush headerBrush = new SolidBrush(Color.FromArgb(44, 62, 80));
            Brush textBrush = Brushes.Black;
            Brush projectNameBrush = new SolidBrush(Color.FromArgb(52, 73, 94));
            Brush alternateRowBrush = new SolidBrush(Color.FromArgb(236, 240, 241));
            Pen borderPen = new Pen(Color.Black, 1);

            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            
            int columnCount = dataGridViewReports.Columns.Count;
            int columnWidth = pageWidth / columnCount; 

            
            string title = "Project Report";
            SizeF titleSize = e.Graphics.MeasureString(title, new Font("Arial", 16, FontStyle.Bold));
            float titleX = (e.PageBounds.Width - titleSize.Width) / 2;
            e.Graphics.DrawString(title, new Font("Arial", 16, FontStyle.Bold), Brushes.Black, titleX, 50);

            string generationOn = "Generated On: " + DateTime.Now.ToString("dd/MM/yyyy - hh:mm tt");
            e.Graphics.DrawString(generationOn, new Font("Arial", 10, FontStyle.Italic), textBrush, x, 90);

            
            int tempX = x;
            e.Graphics.FillRectangle(headerBrush, tempX, y, pageWidth, rowHeight);
            e.Graphics.DrawRectangle(borderPen, tempX, y, pageWidth, rowHeight);

            for (int i = 0; i < columnCount; i++)
            {
                e.Graphics.DrawRectangle(borderPen, tempX, y, columnWidth, rowHeight);
                e.Graphics.DrawString(dataGridViewReports.Columns[i].HeaderText, headerFont, Brushes.White,
                    new RectangleF(tempX, y, columnWidth, rowHeight), stringFormat);
                tempX += columnWidth;
            }

            y += rowHeight;

            
            for (int i = 0; i < dataGridViewReports.Rows.Count; i++)
            {
                tempX = x;
                Brush rowBrush = (i % 2 == 0) ? alternateRowBrush : Brushes.White;

                e.Graphics.FillRectangle(rowBrush, tempX, y, pageWidth, rowHeight);
                e.Graphics.DrawRectangle(borderPen, tempX, y, pageWidth, rowHeight);

                for (int j = 0; j < columnCount; j++)
                {
                    object cellValueObj = dataGridViewReports.Rows[i].Cells[j].Value;
                    string cellValue = cellValueObj?.ToString() ?? "0";

                 
                    if (dataGridViewReports.Columns[j].HeaderText == "Name")
                    {
                        e.Graphics.DrawString(cellValue, new Font("Arial", 10, FontStyle.Bold), projectNameBrush,
                            new RectangleF(tempX, y, columnWidth, rowHeight), stringFormat);
                    }
                    else
                    {
                        e.Graphics.DrawString(cellValue, tableFont, textBrush,
                            new RectangleF(tempX, y, columnWidth, rowHeight), stringFormat);
                    }

                    e.Graphics.DrawRectangle(borderPen, tempX, y, columnWidth, rowHeight);
                    tempX += columnWidth;
                }

                y += rowHeight;
            }
        }



    }
}
