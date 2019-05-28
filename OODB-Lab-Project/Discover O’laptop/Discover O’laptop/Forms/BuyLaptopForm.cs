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
        DataTable dt = new DataTable();
        string transactionID="", currentUser;
        public BuyLaptopForm(string user)
        {
            InitializeComponent();
            currentUser = user;
            loadData();
        }

        public void loadData()
        {
            laptopIdText.Enabled = false;
            laptopNameText.Enabled = false;
            laptopPriceText.Enabled = false;
            laptopQty.Enabled = true;
            selectedLaptopId.Enabled = false;
            totalPrice.Enabled = false;

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

        public void loadCart()
        {
            selectedLaptopId.Text = "";
            totalPrice.Text = "";
            int cntr = (from x in de.HeaderTransactions select x).Count();
            transactionID = "TR";
            if (cntr < 9) transactionID += "00";
            else if (cntr < 99) transactionID += "0";

            transactionID += (cntr + 1).ToString();
            dataGridView2.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            laptopIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            laptopNameText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            laptopPriceText.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
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

            DataRow tempDr = dt.NewRow();
            dt.Rows.Add(laptopIdText.Text, laptopNameText.Text,laptopQty.Value,laptopPriceText.Text,(laptopQty.Value * int.Parse(laptopPriceText.Text.ToString())));
            dataGridView2.DataSource = dt;
            loadCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No laptop in cart!");
                return;
            }

            for(int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                HeaderTransaction ht = new HeaderTransaction();
                DetailTransaction dtn = new DetailTransaction();

                ht.TransactionID = transactionID;
                ht.UserID = currentUser;
                ht.TransactionDate = DateTime.Now.ToString();
                dtn.TransactionID = transactionID;
                dtn.LaptopID = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                DataGridViewRow row = dataGridView2.Rows[0];
                dtn.Quantity = Convert.ToInt32(row.Cells[2].Value.ToString());
                de.HeaderTransactions.Add(ht);
                de.DetailTransactions.Add(dtn);
                de.SaveChanges();
                dataGridView2.Rows.RemoveAt(0);
            }

            MessageBox.Show("Checkout Success");
            loadCart();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedLaptopId.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            totalPrice.Text = (int.Parse(dataGridView2.CurrentRow.Cells[1].Value.ToString()) * int.Parse(dataGridView2.CurrentRow.Cells[2].Value.ToString())).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0) MessageBox.Show("Please select a row");
            else dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            loadCart();
        }
    }
}
