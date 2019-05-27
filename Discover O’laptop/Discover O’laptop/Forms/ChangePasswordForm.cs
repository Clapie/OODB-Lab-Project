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
            if(oldPassText.Text == "")
            {
                MessageBox.Show("Old Password must be filled!");
            }

            // else if(oldPassText) not equal

            else if(newPassText.Text == "")
            {
                MessageBox.Show("New Password must be filled!");
            }

            else if (newPassText.Text.Length < 5)
            {
                MessageBox.Show("New Password length must be 5 characters or more");
            }

            else if(newPass1Text.Text != newPassText.Text)
            {
                MessageBox.Show("Re-type Password doesn’t match with New Password!");
            }

            else
            {
                MessageBox.Show("Successfully Change Password");
                this.Close();
            }
        }
    }
}
