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
        bool insert = false, update = false;
        public ManageLaptopBrandForm()
        {
            InitializeComponent();
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(brandNameText.Text.Length<2 || brandNameText.Text.Length > 15)
            {
                MessageBox.Show("Brand name must between 2-15 characters");
                return;
            }
            
            var search = (
                from x in de.LaptopBrands
                where x.LaptopBrandName.Equals(brandNameText.Text)
                select x.LaptopBrandName
                ).FirstOrDefault();

            if (search == brandNameText.Text)
            {
                MessageBox.Show("Username already exist!");
                return;
            }

            if (insert)
            {
                LaptopBrand obj = new LaptopBrand();
                obj.LaptopBrandID = brandID;
                obj.LaptopBrandName = brandNameText.Text;
                de.LaptopBrands.Add(obj);
                insert = false;
            }

            if (update)
            {
                var temp = (
                    from x in de.LaptopBrands
                    where x.LaptopBrandID.Equals(brandIdText.Text)
                    select x
                    ).FirstOrDefault();
                temp.LaptopBrandID = brandIdText.Text;
                temp.LaptopBrandName = brandNameText.Text;
                update = false;
            }

            de.SaveChanges();
            MessageBox.Show("Data has been successfully inserted/updated");
            loadData();
        }

        private void LaptopBrandGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            brandIdText.Text = LaptopBrandGrid.CurrentRow.Cells[0].Value.ToString();
            brandNameText.Text = LaptopBrandGrid.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert = true;
            brandIdText.Text = brandID;
            brandNameText.Enabled = true;
            insertButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (brandIdText.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }
            update = true;
            brandNameText.Enabled = true;
            insertButton.Enabled = false;
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            saveButton.Enabled = true;
            cancelButton.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (brandIdText.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }

            var obj = (
                from x in de.LaptopBrands
                where x.LaptopBrandID == brandIdText.Text
                select x
                ).FirstOrDefault();


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
            insertButton.Enabled = true;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            saveButton.Enabled = false;
            cancelButton.Enabled = false;
            brandIdText.Enabled = false;
            brandNameText.Enabled = false;
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
