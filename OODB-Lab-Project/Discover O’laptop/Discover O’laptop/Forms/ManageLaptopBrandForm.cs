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
    public partial class ManageLaptopBrandForm : Form
    {
        Database1Entities de = new Database1Entities();
        string brandID;
        bool insert, update;
        public ManageLaptopBrandForm()
        {
            InitializeComponent();
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length<2 || textBox2.Text.Length > 15)
            {
                MessageBox.Show("Brand name must between 2-15 characters");
                return;
            }
            
            if((from x in de.LaptopBrands where x.LaptopBrandName.Equals(textBox2.Text) select x).Count()!=0)
            {
                MessageBox.Show("Username already exist!");
                return;
            }

            if (insert)
            {
                LaptopBrand obj = new LaptopBrand();
                obj.LaptopBrandID = brandID;
                obj.LaptopBrandName = textBox2.Text;
                de.LaptopBrands.Add(obj);
            }

            if (update)
            {
                var obj = (from x in de.LaptopBrands where x.LaptopBrandID == textBox2.Text select x).FirstOrDefault();
                obj.LaptopBrandID = textBox1.Text;
                obj.LaptopBrandName = textBox2.Text;
            }

            de.SaveChanges();
            MessageBox.Show("Data has been successfully inserted/updated");
            loadData();
        }

        private void LaptopBrandGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = LaptopBrandGrid.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = LaptopBrandGrid.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert = true;
            textBox1.Text = brandID;
            textBox2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }
            update = true;
            textBox2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }

            var obj = (from x in de.LaptopBrands where x.LaptopBrandID == textBox1.Text select x).FirstOrDefault();
            switch (MessageBox.Show("Are you sure want to delete this data?", "Message", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    de.LaptopBrands.Remove(obj);
                    break;
                case DialogResult.No:
                    MessageBox.Show("No");
                    break;
            }
            de.SaveChanges();
            loadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadData();
        }

        void loadData()
        {
            brandID = "BN";
            insert = false;
            update = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            int cntr = de.LaptopBrands.Count();
            if (cntr < 9) brandID += "00";
            else if (cntr < 99) brandID += "0";
            brandID += (cntr + 1).ToString();

            var obj = (from x in de.LaptopBrands
                       select new
                       {
                           LaptopBrandID = x.LaptopBrandID,
                           laptopBrandName = x.LaptopBrandName
                       }).ToList();
            LaptopBrandGrid.DataSource = obj;
        }




        
    }
}
