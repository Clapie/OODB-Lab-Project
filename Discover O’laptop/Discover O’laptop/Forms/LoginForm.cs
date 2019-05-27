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
    }
}
