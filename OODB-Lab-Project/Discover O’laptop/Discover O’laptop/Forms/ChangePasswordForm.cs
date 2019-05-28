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
    public partial class ChangePasswordForm : Form
    {
        
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //old pass empty
            if (oldPassText.Text == "")
            {
                MessageBox.Show("Old Password must be filled!");
                return;
            }

            //old pass not equal
            Database1Entities de = new Database1Entities();
            var searchpass = (
               from x in de.Users
               where x.UserID.Equals(currUser.Id)
               select x.UserPassword
               ).FirstOrDefault();

            if (oldPassText.Text!=searchpass.ToString())
            {
                MessageBox.Show("Old Password doesn’t match with the current password");
                return;
            }

            //new pass empty
            else if (newPassText.Text == "")
            {
                MessageBox.Show("New Password must be filled!");
                return;
            }

            //new pass length < 5
            if (newPassText.Text.Length < 5)
            {
                MessageBox.Show("New Password length must be 5 characters or more");
                return;
            }

            //confirm pass != new pass
            if(newPass1Text.Text != newPassText.Text)
            {
                MessageBox.Show("Re-type Password doesn’t match with New Password!");
                return;
            }

            MessageBox.Show("Successfully Change Password");

            var obj = (
                from x in de.Users
                where x.UserID.Equals(currUser.Id)
                select x
                ).FirstOrDefault();

            obj.UserPassword = newPassText.Text;
            de.SaveChanges();
            this.Close();
        }
    }
}
