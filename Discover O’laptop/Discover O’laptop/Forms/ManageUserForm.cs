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
    public partial class ManageUserForm : Form
    {
        Database1Entities de = new Database1Entities();
        string userID = null;
        bool insert = false, update = false;
        DateTimePicker temp = new DateTimePicker();

        public ManageUserForm()
        {
            InitializeComponent();
            userRole.Items.Add("admin");
            userRole.Items.Add("member");
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
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

            if (search == userNameText.Text)
            {
                MessageBox.Show("Username already exists");
                return;
            }

            //Empty Email
            if (userEmailText.Text == "")
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
            if (Math.Abs(fl - fl1) == 1)
            {
                MessageBox.Show("\'@\' and \'.\' cannot be placed beside each other");
                return;
            }

            //Gender not chosen
            if (!maleButton.Checked && !femaleButton.Checked)
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
            if (userPhoneText.Text.Length != 12)
            {
                MessageBox.Show("Phone must be 12 digits");
                return;
            }

            //address is empty
            if (userAddressText.Text == "")
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
            if (userPasswordText.Text == "")
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

            if (insert)
            {
                User obj = new User();

                obj.UserID = userID;
                obj.UserName = userNameText.Text;
                obj.UserEmail = userEmailText.Text;
                if (maleButton.Checked == true) obj.UserGender = "Male";
                else obj.UserGender = "Female";
                obj.UserDoB = userDoB.Value;
                obj.UserPhone = userPhoneText.Text;
                obj.UserAddress = userAddressText.Text;
                obj.UserPassword = userPasswordText.Text;
                obj.UserRole = userRole.SelectedItem.ToString();
                de.Users.Add(obj);
                insert = false;
            }

            if (update)
            {
                var obj = (
                    from x in de.Users
                    where x.UserID.Equals(userIdText.Text)
                    select x
                    ).FirstOrDefault();

                obj.UserName = userNameText.Text;
                obj.UserEmail = userEmailText.Text;
                if (maleButton.Checked == true) obj.UserGender = "Male";
                else obj.UserGender = "Female";
                obj.UserDoB = userDoB.Value;
                obj.UserPhone = userPhoneText.Text;
                obj.UserAddress = userAddressText.Text;
                obj.UserPassword = userPasswordText.Text;
                obj.UserRole = userRole.SelectedItem.ToString();
                
                update = false;
            }
            de.SaveChanges();
            MessageBox.Show("Data has been inserted/updated successfully");
            loadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "Male")
            {
                maleButton.Checked = true;
                femaleButton.Checked = false;
            }

            else
            {
                maleButton.Checked = false;
                femaleButton.Checked = true;
            }
            userNameText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            userEmailText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            userDoB.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            userPhoneText.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            userAddressText.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            userPasswordText.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            userRole.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert = true;

            insertButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;

            userIdText.Enabled = false;
            userIdText.Text = userID;
            userNameText.Enabled = true;
            userEmailText.Enabled = true;
            userPasswordText.Enabled = true;
            userPhoneText.Enabled = true;

            maleButton.Enabled = true;
            femaleButton.Enabled = true;

            userDoB.Enabled = true;

            userAddressText.Enabled = true;

            userRole.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (userRole.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }

            update = true;

            insertButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;

            userIdText.Enabled = true;
            userNameText.Enabled = true;
            userEmailText.Enabled = true;
            userPasswordText.Enabled = true;
            userPhoneText.Enabled = true;

            maleButton.Enabled = true;
            femaleButton.Enabled = true;

            userDoB.Enabled = true;

            userAddressText.Enabled = true;

            userRole.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (userIdText.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }

            var obj = (
                from x in de.Users
                where x.UserID.Equals(userIdText.Text)
                select x
                ).FirstOrDefault();
            switch (MessageBox.Show("Are you sure want to delete this data?", "Message", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    de.Users.Remove(obj);
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
            }
            de.SaveChanges();
            loadData();
        }

        public void loadData()
        {
            userID = "US";
            insert = false;
            update = false;
            insertButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;

            userIdText.Enabled = false;
            userNameText.Enabled = false;
            userEmailText.Enabled = false;
            userPasswordText.Enabled = false;
            userPhoneText.Enabled = false;

            maleButton.Enabled = false;
            femaleButton.Enabled = false;

            userDoB.Enabled = false;

            userAddressText.Enabled = false;

            userRole.Enabled = false;

            int cntr = de.Users.Count();
            if (cntr < 9) userID += "00";
            else if (cntr < 99) userID += "0";
            userID += (cntr + 1).ToString();

            var obj = (from x in de.Users
                       select new
                       {
                           UserID = x.UserID,
                           UserName = x.UserName,
                           UserGender = x.UserGender,
                           UserEmail = x.UserEmail,
                           UserDOB = x.UserDoB,
                           UserPhone = x.UserPhone,
                           UserAddress = x.UserAddress,
                           UserPassword = x.UserPassword,
                           UserRole = x.UserRole

                       }).ToList();
            dataGridView1.DataSource = obj;
        }


    }
}
