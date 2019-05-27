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
    public partial class ViewTransactionForm : Form
    {
        Database1Entities de = new Database1Entities();
        string transactionID;
        int month = 0;
        string userID;
        public ViewTransactionForm()
        {
            InitializeComponent();
            for (int i = 1; i <= 12; i++)
            {
                comboBox1.Items.Add(i);
            }
            loadData();
        }
        public void loadData()
        {
            if (month != 0)
            {
                var obj = (from x in de.HeaderTransactions
                           join y in de.Users on x.UserID equals y.UserID
                           where (x.TransactionDate.Substring(3, 2).Equals(month.ToString()) || x.TransactionDate.Substring(4, 1).Equals(month.ToString()))
                           select new
                           {
                               TransactionID = x.TransactionID,
                               UserID = x.UserID,
                               UserName = y.UserName,
                               TransactionDate = x.TransactionDate
                           }).ToList();
                dataGridView1.DataSource = obj;
            }
            else
            {
                var obj = (from x in de.HeaderTransactions
                           join y in de.Users on x.UserID equals y.UserID
                           select new
                           {
                               TransactionID = x.TransactionID,
                               UserID = x.UserID,
                               UserName = y.UserName,
                               TransactionDate = x.TransactionDate
                           }).ToList();
                dataGridView1.DataSource = obj;
            }

            if (transactionID != "")
            {
                var obj = (from x in de.DetailTransactions
                           where x.TransactionID.Equals(transactionID)
                           select new
                           {
                               LaptopID = x.LaptopID,
                               Quantity = x.Quantity

                           }).ToList();
                dataGridView2.DataSource = obj;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            month = 0;
            comboBox1.Text = "";
            loadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            month = int.Parse(comboBox1.SelectedItem.ToString());
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transactionID = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            loadData();
        }

    }
}
