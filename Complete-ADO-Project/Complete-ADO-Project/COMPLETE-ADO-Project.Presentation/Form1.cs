using COMPLETE_ADO_PROject.Business;
using System.Data;

namespace COMPLETE_ADO_Project.Presentation
{
    public partial class Form1 : Form
    {
        public int userId;
        UsersService usersService;
        public Form1()
        {
            InitializeComponent();
            usersService = new UsersService();
            chkbx_password.Checked = false;

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txt_UserName.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    MessageBox.Show("Please enter a valid username and password.");
                    return;
                }

                DataTable dt = usersService.getRole(txt_UserName.Text, txt_Password.Text);

                if (dt.Rows.Count > 0)
                {
                    userId = Convert.ToInt32(dt.Rows[0]["UserId"]);
                    string role = dt.Rows[0]["Role"].ToString();
                    if (role == "user")
                    {
                        Form3 F3 = new Form3(userId);
                        this.Hide();
                        F3.Show();
                    }
                    else if (role == "Admin")
                    {
                        Form4 F4 = new Form4();
                        this.Hide();
                        F4.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role detected.");
                    }
                }
                else
                {

                    MessageBox.Show("Invalid username or password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void btn_CreateAcc_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            this.Hide();

            F2.Show();
        }

        private void chkbx_password_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_password.Checked)
            {
                txt_Password.UseSystemPasswordChar = true;
            }
            else
                txt_Password.UseSystemPasswordChar = false;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_UserName.Text = "";
            txt_Password.Text = "";
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
