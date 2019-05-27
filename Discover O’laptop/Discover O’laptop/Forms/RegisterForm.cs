using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Discover_O_laptop;

namespace Discover_O_laptop.Forms
{
    public partial class RegisterForm : Form
    {
        LoginForm loginForm = null;
        DateTimePicker temp = new DateTimePicker();

        public RegisterForm()
        {
            InitializeComponent();
            temp.Value = DateTime.Now;
        }

        public void tologinform()
        {
            if (loginForm == null || loginForm.IsDisposed == true)
            {
                loginForm = new LoginForm();
                loginForm.MdiParent = this.MdiParent;
                loginForm.Show();
            }
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tologinform();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Empty Username
            if (userNameText.Text == "")
            {
                MessageBox.Show("Username must be filled!");
                return;
            }

            //Existing Username
            Database1Entities de = new Database1Entities();
            var search = (
                from x in de.Users
                where x.UserName.Equals(userNameText.Text)
                select x.UserName
                ).FirstOrDefault();

            if(search == userNameText.Text)
            {
                MessageBox.Show("Username already exists");
                return;
            }

            //Empty Email
            if(userEmailText.Text == "")
            {
                MessageBox.Show("Email must be filled!");
                return;
            }

            //Email does not contain @ && .
            int fl = userEmailText.Text.IndexOf("@");
            int fl1 = userEmailText.Text.IndexOf(".");
            int len = userEmailText.Text.Length;

            if (fl < 0 || fl1 < 0)
            {
                MessageBox.Show("Email must contain \'@\' and \'.\'");
                return;
            }

            //Email start with @ or .
            if (fl == 0 || fl1 == 0)
            {
                MessageBox.Show("Email cannot start with \'@\' or \'.\'");
                return;
            }

            //Email end with @ or .
            if (fl == len - 1 || fl1 == len - 1)
            {
                MessageBox.Show("Email cannot end with \'@\' or \'.\'");
                return;
            }

            //Email contain @ and . but placed with each other
            if (Math.Abs(fl-fl1)==1)
            {
                MessageBox.Show("\'@\' and \'.\' cannot be placed beside each other");
                return;
            }

            //Gender not chosen
            if(!maleButton.Checked && !femaleButton.Checked)
            {
                MessageBox.Show("Gender must be chosen!");
                return;
            }

            //DoB is greater than current date
            if (userDoB.Value.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("DOB Cannot greater than current date!");
                return;
            }

            //Phone is empty
            if (userPhoneText.Text == "")
            {
                MessageBox.Show("Phone number must be filled!");
                return;
            }

            //phone is not digit
            if (!userPhoneText.Text.All(char.IsDigit))
            {
                MessageBox.Show("Phone must be numeric!");
                return;
            }

            //phone length != 12 digits
            if(userPhoneText.Text.Length != 12)
            {
                MessageBox.Show("Phone must be 12 digits");
                return;
            }

            //address is empty
            if(userAddressText.Text == "")
            {
                MessageBox.Show("Address must be filled!");
                return;
            }

            //address does not contain street
            if (!userAddressText.Text.Contains("Street"))
            {
                MessageBox.Show("Address must contain \'Street\'");
                return;
            }

            //password is empty
            if(userPasswordText.Text == "")
            {
                MessageBox.Show("Password must be filled!");
                return;
            }

            //password length < 5
            if (userPasswordText.Text.Length < 5)
            {
                MessageBox.Show("Password length must be 5 characters or more");
                return;
            }

            //confirm password != password
            if(userPasswordText.Text != userPassword1Text.Text)
            {
                MessageBox.Show("Confirm Password must be the same with Password!");
                return;
            }

            User obj = new User();

            string userID = null;
            userID += "US";
            int cntr = de.Users.Count();
            if (cntr < 9) userID += "00";
            else if (cntr < 99) userID += "0";
            userID += (cntr + 1).ToString();

            obj.UserID = userID;
            obj.UserName = userNameText.Text;
            obj.UserEmail = userEmailText.Text;
            if (maleButton.Checked == true) obj.UserGender = "Male";
            else obj.UserGender = "Female";
            obj.UserDoB = userDoB.Value;
            obj.UserPhone = userPhoneText.Text;
            obj.UserAddress = userAddressText.Text;
            obj.UserPassword = userPasswordText.Text;
            obj.UserRole = "member";
            de.Users.Add(obj);
            de.SaveChanges();

            MessageBox.Show("You are Registered");
            tologinform();
        }
    }
}
