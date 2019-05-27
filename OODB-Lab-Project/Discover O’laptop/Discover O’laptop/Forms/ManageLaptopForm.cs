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
    public partial class ManageLaptopForm : Form
    {
        Database1Entities de = new Database1Entities();
        string laptopID;
        bool insert, update;
        public ManageLaptopForm()
        {
            InitializeComponent();
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String laptopSize = textBox4.Text;
            

            if (textBox2.Text == "")
            {
                MessageBox.Show("Laptop name must be filled");
                return;
            }

            if (laptopSize == "")
            {
                MessageBox.Show("Laptop size must be filled");
                return;
            }

            if (laptopSize[laptopSize.Length - 4] != 'i' || laptopSize[laptopSize.Length - 3] != 'n' || laptopSize[laptopSize.Length - 2] != 'c' || laptopSize[laptopSize.Length - 1] != 'h')
            {
                MessageBox.Show("Laptop size must ends with inch");
                return;
            }

            if (textBox5.Text == "")
            {
                MessageBox.Show("Laptop VGA field must be filled");
                return;
            }

            if (numericUpDown1.Value < 2)
            {
                MessageBox.Show("Laptop RAM must be at least 2 or more");
                return;
            }

            if (textBox7.Text == "")
            {
                MessageBox.Show("Laptop price must be filled");
                return;
            }

            if (textBox7.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Laptop price must be numeric");
                return;
            }

            if (insert)
            {
                Laptop obj = new Laptop();
                obj.LaptopID = textBox1.Text;
                obj.LaptopName = textBox2.Text;
                obj.LaptopBrandID = (from x in de.LaptopBrands
                                    where x.LaptopBrandName.Equals(comboBox1.SelectedValue.ToString())
                                    select x.LaptopBrandID).FirstOrDefault();
                obj.LaptopSize = textBox4.Text;
                obj.LaptopVGA = textBox5.Text;
                obj.LaptopRAM = numericUpDown1.Value.ToString();
                obj.LaptopPrice = int.Parse(textBox7.Text);
                de.Laptops.Add(obj);

            }
            if (update)
            {
                var obj = (from x in de.Laptops where x.LaptopID.Equals(textBox1.Text) select x).FirstOrDefault();
                obj.LaptopID = textBox1.Text;
                obj.LaptopName = textBox2.Text;
                obj.LaptopBrandID = (from x in de.LaptopBrands
                                     where x.LaptopBrandName.Equals(comboBox1.SelectedValue.ToString())
                                     select x.LaptopBrandID).FirstOrDefault();
                obj.LaptopSize = textBox4.Text;
                obj.LaptopVGA = textBox5.Text;
                obj.LaptopRAM = numericUpDown1.Value.ToString();
                obj.LaptopPrice = int.Parse(textBox7.Text);
            }
            de.SaveChanges();
            MessageBox.Show("Data has been successfully inserted/updated");
            loadData();
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
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
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
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox7.Enabled = true;
            comboBox1.Enabled = true;
            numericUpDown1.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            numericUpDown1.Value = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }
            var obj = (from x in de.Laptops where x.LaptopID.Equals(textBox1.Text) select x).FirstOrDefault();
            switch (MessageBox.Show("Are you sure want to delete this data?", "Message", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    de.Laptops.Remove(obj);
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
            laptopID = "LP";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";

            insert = false;
            update = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox7.Enabled = false;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            int cntr = de.Laptops.Count();
            if (cntr < 9) laptopID += "00";
            else if (cntr < 99) laptopID += "0";
            laptopID += (cntr + 1).ToString();
            var obj = (from x in de.Laptops
                       join y in de.LaptopBrands on x.LaptopBrandID equals y.LaptopBrandID
                       select new
                       {
                           LaptopID = x.LaptopID,
                           LaptopBrandName = y.LaptopBrandName,
                           LaptopName = x.LaptopName,
                           LaptopSize = x.LaptopSize,
                           LaptopVGA = x.LaptopVGA,
                           LaptopRAM = x.LaptopRAM,
                           LaptopPrice = x.LaptopPrice
                       }).ToList();
            dataGridView1.DataSource = obj;

            var bn = (from x in de.LaptopBrands
                      select
                          x.LaptopBrandName
                      ).ToList();
            comboBox1.DataSource = bn;

            
        }
    }
}
