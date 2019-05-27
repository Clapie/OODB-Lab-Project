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
    public partial class RegisterForm : Form
    {
        LoginForm loginForm = null;

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed == true)
            {
                loginForm = new LoginForm();
                loginForm.MdiParent = this.MdiParent;
                loginForm.Show();
            }
            this.Close();
        }
    }
}
