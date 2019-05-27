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
        string userID;
        bool insert, update;

        public ManageUserForm()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("member");
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string email = textBox3.Text;
            if (textBox2.Text == "")
            {
                MessageBox.Show("Username must be filled");
                return;
            }

            if(textBox2.Text == (from User x in de.Users where x.UserName.Equals(textBox2.Text) select x.UserName).FirstOrDefault())
            {
                MessageBox.Show("Username already exists");
                return;
            }

            if (email == "")
            {
                MessageBox.Show("Email must be filled");
                return;
            }
            
            if (email.Contains('@') == false || email.Contains('.') == false)
            {
                MessageBox.Show("Email must contain '@' and '.'");
                return;
            }

            if(email[0] == '@' || email[0] == '.')
            {
                MessageBox.Show("Email cannot start with '@' and '.'");
                return;
            }

            if (email[email.Length - 1] == '@' || email[email.Length - 1] == '.')
            {
                MessageBox.Show("Email cannot end with '@' and '.'");
                return;
            }

            if (email[email.IndexOf('@') - 1] == '.' || email[email.IndexOf('@') + 1] == '.')
            {
                MessageBox.Show("'@' and '.' cannot be placed beside each other");
                return;
            }
            if (radioButton1.Checked == false  && radioButton2.Checked == false)
            {
                MessageBox.Show("Gender must be choosen!");
                return;
            }

            if (dateTimePicker1.Value.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("DOB Cannot greater than current date!");
                return;
            }

            if (textBox6.Text == "")
            {
                MessageBox.Show("Phone number must be filled");
                return;
            }

            if (textBox6.Text.All(Char.IsDigit) == false)
            {
                MessageBox.Show("Phone cannot contain alphanumeric");
                return;
            }

            if (textBox6.Text.Length != 12)
            {
                MessageBox.Show("Phone must be 12 digits");
                return;
            }

            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Address must be filled");
                return;
            }

            if (richTextBox1.Text.Contains("Street"))
            {
                MessageBox.Show("Address must contains Street");
                return;
            }

            if (textBox4.Text == "")
            {
                MessageBox.Show("Password must be filled");
                return;
            }

            if (textBox4.Text.Length < 5)
            {
                MessageBox.Show("Password length must be at least 5 characters or more");
                return;
            }

            if (insert)
            {
                User obj = new User();

                obj.UserID = userID;
                obj.UserName = textBox2.Text;
                obj.UserEmail = textBox3.Text;
                if (radioButton1.Checked == true) obj.UserGender = "Male";
                else obj.UserGender = "Female";
                obj.UserDoB = dateTimePicker1.Value;
                obj.UserPhone = textBox6.Text;
                obj.UserAddress = richTextBox1.Text;
                obj.UserPassword = textBox4.Text;
                obj.UserRole = comboBox1.SelectedItem.ToString();
                de.Users.Add(obj);
            }

            if (update)
            {
                var obj = (from x in de.Users where x.UserID.Equals(textBox1.Text) select x).FirstOrDefault();

                obj.UserName = textBox2.Text;
                obj.UserEmail = textBox3.Text;
                if (radioButton1.Checked == true) obj.UserGender = "Male";
                else obj.UserGender = "Female";
                obj.UserDoB = dateTimePicker1.Value;
                obj.UserPhone = textBox6.Text;
                obj.UserAddress = richTextBox1.Text;
                obj.UserPassword = textBox4.Text;
                obj.UserRole = comboBox1.SelectedItem.ToString();
            }

            de.SaveChanges();
            MessageBox.Show("Data has been inserted/updated successfully");
            loadData();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[1].Value.ToString() == "Male")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }

            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            richTextBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            dateTimePicker1.Enabled = true;

            richTextBox1.Enabled = true;

            comboBox1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }

            update = true;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox6.Enabled = true;

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;

            dateTimePicker1.Enabled = true;

            richTextBox1.Enabled = true;

            comboBox1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }

            var obj = (from x in de.Users where x.UserID.Equals(textBox1.Text) select x).FirstOrDefault();
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
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox6.Enabled = false;

            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            dateTimePicker1.Enabled = false;

            richTextBox1.Enabled = false;

            comboBox1.Enabled = false;

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
