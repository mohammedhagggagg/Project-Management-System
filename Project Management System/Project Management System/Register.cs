using Project_Management_System.Contexts;
using Project_Management_System.Models;

namespace Project_Management_System
{
    public partial class Register : Form
    {
        PMSDbContext context = new PMSDbContext();
        public Register()
        {
            InitializeComponent();
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

            //panel1.Visible = false;  
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label4_Click_1(object sender, EventArgs e)
        {
            Txt_UserName.Text = "";
            Txt_Password.Text = "";
            Txt_Email.Text = "";
            CB_Gender.Text = "";
            Txt_Phone.Text = "";
            CB_Gender.SelectedIndex = -1;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(Txt_UserName.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Email.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Password.Text) ||
                    string.IsNullOrWhiteSpace(Txt_Phone.Text) ||
                    CB_Gender.SelectedItem == null ||
                     CB_Gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Information");
                    return;
                }
                else
                {
                    Models.Employee employee = new Models.Employee()
                    {
                        Name = Txt_UserName.Text,
                        Email = Txt_Email.Text,
                        Phone = Txt_Phone.Text,
                        Password = Txt_Password.Text,
                        Gender = (Gender)Enum.Parse(typeof(Gender), CB_Gender.SelectedItem.ToString())
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

        private void RefreshData()
        {
            Txt_UserName.Text = "";
            Txt_Password.Text = "";
            Txt_Email.Text = "";
            CB_Gender.Text = "";
            Txt_Phone.Text = "";
            CB_Gender.SelectedIndex = -1;

            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Lbl_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Password.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
    }


}
