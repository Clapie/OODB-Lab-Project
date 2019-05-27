using Discover_O_laptop.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discover_O_laptop
{
    public partial class Form1 : Form
    {
        LoginForm loginForm = null;
        User user = new User();

        public Form1()
        {
            InitializeComponent();
            logout();
        }

        public void loginAdmin()
        {
            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;
            changePasswordToolStripMenuItem.Visible = true;
            buyToolStripMenuItem.Visible = false;
            manageToolStripMenuItem.Visible = true;
            viewToolStripMenuItem.Visible = true;
            transactionToolStripMenuItem.Visible = true;
            historyToolStripMenuItem.Visible = false;
        }

        public void loginMember()
        {
            loginToolStripMenuItem.Visible = false;
            logoutToolStripMenuItem.Visible = true;
            changePasswordToolStripMenuItem.Visible = true;
            buyToolStripMenuItem.Visible = true;
            manageToolStripMenuItem.Visible = false;
            viewToolStripMenuItem.Visible = true;
            transactionToolStripMenuItem.Visible = false;
            historyToolStripMenuItem.Visible = true;
        }

        public void logout()
        {
            loginToolStripMenuItem.Visible = true;
            logoutToolStripMenuItem.Visible = false;
            changePasswordToolStripMenuItem.Visible = false;
            buyToolStripMenuItem.Visible = false;
            manageToolStripMenuItem.Visible = false;
            viewToolStripMenuItem.Visible = false;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (loginForm == null || loginForm.IsDisposed == true)
            {
                loginForm = new LoginForm();
                loginForm.MdiParent = this;
                loginForm.Show();
            }
        }
    }
}
