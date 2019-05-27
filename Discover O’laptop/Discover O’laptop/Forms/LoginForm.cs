using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discover_O_laptop.Forms
{
    public partial class LoginForm : Form
    {
        RegisterForm registerform = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (registerform == null || registerform.IsDisposed == true)
            {
                registerform = new RegisterForm();
                registerform.MdiParent = this.MdiParent;
                registerform.Show();
            }
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //username empty
            if(userNameText.Text == "")
            {
                MessageBox.Show("Username must be filled!");
                return;
            }

            //password empty
            if(userPasswordText.Text == "")
            {
                MessageBox.Show("Password must be filled!");
                return;
            }

            //Invalid Username and Password
            Database1Entities de = new Database1Entities();
            var search = (
                from x in de.Users
                where x.UserName.Equals(userNameText.Text)
                select x.UserName
                ).FirstOrDefault();

            if (search != userNameText.Text)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }

            var searchpass = (
                from x in de.Users
                where x.UserName.Equals(userNameText.Text)
                select x.UserPassword
                ).FirstOrDefault();

            if (searchpass != userPasswordText.Text)
            {
                MessageBox.Show("Invalid Username or Password!");
                return;
            }

            var searchRole = (
                from x in de.Users
                where x.UserName.Equals(userNameText.Text)
                select x.UserRole
                ).FirstOrDefault();

            MessageBox.Show("You are logged in");

            MainForm parent = (MainForm)MdiParent;
            if (searchRole == "admin")
            {
                parent.loginAdmin();
            }
            if(searchRole == "member")
            {
                parent.loginMember();
            }
            this.Close();
        }
    }
}
