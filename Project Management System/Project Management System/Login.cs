using Project_Management_System.Contexts;

namespace Project_Management_System
{
    public partial class Login : Form
    {
        PMSDbContext context = new PMSDbContext();
        public Login()
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
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var user = context.Employees.FirstOrDefault(s => s.Email == Txt_UserName.Text && s.Password == Txt_Password.Text);

            if (Txt_UserName.Text == "Admin" && Txt_Password.Text == "Password")
            {
                Employee form = new Employee();
                form.Show();
                this.Hide();
                //form.FormClosed += (s, args) => this.Close();
            }
            else if (user != null)
            {

                TaskResult taskResult = new TaskResult(user.Id);
                taskResult.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Lbl_Registration_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Txt_Password.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
           
        }
    }


}
