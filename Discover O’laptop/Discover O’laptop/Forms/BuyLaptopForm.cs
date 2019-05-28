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
    public partial class BuyLaptopForm : Form
    {
        Database1Entities de = new Database1Entities();
        public BuyLaptopForm()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            laptopIdText.Enabled = false;
            laptopNameText.Enabled = false;
            laptopPriceText.Enabled = false;
            laptopQty.Enabled = true;
            selectedLaptopId.Enabled = false;

            var obj = (
                from x in de.Laptops
                join y in de.LaptopBrands 
                on x.LaptopBrandID equals y.LaptopBrandID
                select new
                {
                    ID = x.LaptopID,
                    Brand = y.LaptopBrandName,
                    Name = x.LaptopName,
                    Size = x.LaptopSize,
                    VGA = x.LaptopVGA,
                    RAM = x.LaptopRAM,
                    Price = x.LaptopPrice
                }).ToList();
            dataGridView1.DataSource = obj;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            laptopIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            laptopNameText.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            laptopPriceText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //user has not select
            if(laptopIdText.Text == "")
            {
                MessageBox.Show("Please select data first!");
                return;
            }
               
            //laptop quantity < 1
            if (laptopQty.Value < 1)
            {
                MessageBox.Show("Quantity must be more than or equals to 1!");
                return;
            }

            var obj = (
                from x in de.Laptops
                select new {
                    ID = laptopIdText.Text,
                    Name = laptopNameText.Text,
                    Quantity = laptopQty.Value,
                    Price = laptopPriceText.Text.to
                }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(selectedLaptopId.Text == "")
            {
                MessageBox.Show("Please select data first!");
                return;
            }


        }
    }
}
