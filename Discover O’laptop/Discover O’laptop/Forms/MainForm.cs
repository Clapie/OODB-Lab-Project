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
    public partial class MainForm : Form
    {
        LoginForm loginForm = null;
        ChangePasswordForm changepassForm = null;
        User user = new User();
        
        public MainForm()
        {
            InitializeComponent();
            addcustomadmin();
            logout();
        }

        public void addcustomadmin()
        {
            Database1Entities de = new Database1Entities();
            User obj = new User();
            string userID = null;
            userID += "US";
            int cntr = de.Users.Count();
            if (cntr < 9) userID += "00";
            else if (cntr < 99) userID += "0";
            userID += (cntr + 1).ToString();
            obj.UserID = userID;
            obj.UserName = "admin";
            obj.UserEmail = "admin@bunis.com";
            obj.UserGender = "Male";
            obj.UserDoB = DateTime.Now;
            obj.UserPhone = "081234567890";
            obj.UserAddress = "bunis Street";
            obj.UserPassword =  "admin";
            obj.UserRole = "admin";
            de.Users.Add(obj);
            de.SaveChanges();
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

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(currUser.Id);
            if (changepassForm == null || changepassForm.IsDisposed == true)
            {
                changepassForm = new ChangePasswordForm();
                changepassForm.MdiParent = this;
                changepassForm.Show();
            }
        }
    }
}
