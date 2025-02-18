using COMPLETE_ADO_PROject.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_ADO_Project.Presentation
{
    public partial class Form2 : Form
    {
        UsersService usersService;
        public Form2()
        {
            InitializeComponent();
            usersService = new UsersService();
            cmb_Role.Items.Add("user");
            cmb_Role.Items.Add("Admin");
            cmb_Role.SelectedIndex = 0;
            chkbx_password.Checked = false;
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == "" || txt_password.Text == "" || txt_Email.Text == "")
            {
                MessageBox.Show("Please fill all fields !");
                return;
            }
            if (txt_password.Text.Length < 6)
            {
                MessageBox.Show("The Password should be 6 at least !");
                return;
            }
            if (txt_password.Text != txt_confirmPass.Text)
            {
                MessageBox.Show("The Passwords Should Match !");
                return;
            }
            int affected = usersService.AddUser(txt_name.Text, txt_password.Text, txt_Email.Text, txt_address.Text, (int)nUD_age.Value, cmb_Role.SelectedItem.ToString());
            if (affected > 0)
            {
                MessageBox.Show("Registration Completed Successfully");

            }
            else
            {
                MessageBox.Show("Please Try again");
            }

        }

        private void btn_Clearr_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_Email.Text = "";
            txt_name.Text = "";
            txt_password.Text = "";
            nUD_age.Value = nUD_age.Minimum;
            cmb_Role.SelectedIndex = 0;
        }

        private void btn_returnToLogin_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();

        }

        private void chkbx_password_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbx_password.Checked)
            {
                txt_password.UseSystemPasswordChar = true;
                txt_confirmPass.UseSystemPasswordChar = true;

            }
            else
            {
                txt_password.UseSystemPasswordChar = false;
                txt_confirmPass.UseSystemPasswordChar = false;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_address.Text = "";
            txt_confirmPass.Text = "";
            txt_Email.Text = "";
            txt_name.Text = "";
            txt_password.Text = "";
            nUD_age.Value = nUD_age.Minimum;
            cmb_Role.SelectedIndex = 0;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
