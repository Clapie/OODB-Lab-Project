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
        bool insert = false, update = false;
        public ManageLaptopForm()
        {
            InitializeComponent();
            loadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String laptopSize = laptopSizeText.Text;

            //empty laptop name
            if (laptopNameText.Text == "")
            {
                MessageBox.Show("Laptop name must be filled");
                return;
            }

            //laptop brand not chosen
            if (laptopBrandBox.SelectedIndex == -1)
            {
                MessageBox.Show("Laptop Brand must be chosen!");
                return;
            }

            //empty laptop size
            if (laptopSize == "")
            {
                MessageBox.Show("Laptop size must be filled");
                return;
            }

            //laptop size does not ends with inch
            if (laptopSize[laptopSize.Length - 4] != 'i' || laptopSize[laptopSize.Length - 3] != 'n' || laptopSize[laptopSize.Length - 2] != 'c' || laptopSize[laptopSize.Length - 1] != 'h')
            {
                MessageBox.Show("Laptop size must ends with inch");
                return;
            }

            //empty laptop VGA 
            if (laptopVGAText.Text == "")
            {
                MessageBox.Show("Laptop VGA field must be filled");
                return;
            }

            //laptop RAM less than 2
            if (laptopRAM.Value < 2)
            {
                MessageBox.Show("Laptop RAM must be at least 2 or more");
                return;
            }

            //empty laptop price
            if (laptopPriceText.Text == "")
            {
                MessageBox.Show("Laptop price must be filled");
                return;
            }

            //laptop price not numeric
            if (!laptopPriceText.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Laptop price must be numeric");
                return;
            }

            if (insert)
            {
                Laptop obj = new Laptop();
                obj.LaptopID = laptopIdText.Text;
                obj.LaptopName = laptopNameText.Text;

                obj.LaptopBrandID = (
                    from x in de.LaptopBrands
                    where x.LaptopBrandName.Equals(laptopBrandBox.SelectedValue.ToString())
                    select x.LaptopBrandID
                    ).FirstOrDefault();

                obj.LaptopSize = this.laptopSizeText.Text;
                obj.LaptopVGA = laptopVGAText.Text;
                obj.LaptopRAM = laptopRAM.Value.ToString();
                obj.LaptopPrice = int.Parse(laptopPriceText.Text);
                de.Laptops.Add(obj);
                insert = false;

            }
            if (update)
            {
                var obj = (
                    from x in de.Laptops
                    where x.LaptopID.Equals(laptopIdText.Text)
                    select x
                    ).FirstOrDefault();

                obj.LaptopID = laptopIdText.Text;
                obj.LaptopName = laptopNameText.Text;
                obj.LaptopBrandID = (
                    from x in de.LaptopBrands
                    where x.LaptopBrandName.Equals(laptopBrandBox.SelectedValue.ToString())
                    select x.LaptopBrandID
                    ).FirstOrDefault();

                obj.LaptopSize = this.laptopSizeText.Text;
                obj.LaptopVGA = laptopVGAText.Text;
                obj.LaptopRAM = laptopRAM.Value.ToString();
                obj.LaptopPrice = int.Parse(laptopPriceText.Text);
                update = false;
            }
            de.SaveChanges();
            MessageBox.Show("Data has been successfully inserted/updated");
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insert = true;
            laptopIdText.Text = laptopID;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;

            laptopIdText.Enabled = false;
            laptopNameText.Enabled = true;
            laptopSizeText.Enabled = true;
            laptopVGAText.Enabled = true;
            laptopPriceText.Enabled = true;
            laptopBrandBox.Enabled = true;
            laptopRAM.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (laptopIdText.Text == "")
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

            laptopIdText.Enabled = true;
            laptopNameText.Enabled = true;
            laptopSizeText.Enabled = true;
            laptopVGAText.Enabled = true;
            laptopPriceText.Enabled = true;
            laptopBrandBox.Enabled = true;
            laptopRAM.Enabled = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            laptopIdText.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            laptopBrandBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            laptopNameText.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            laptopSizeText.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            laptopVGAText.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            laptopRAM.Value = int.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            laptopPriceText.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (laptopIdText.Text == "")
            {
                MessageBox.Show("Please select data first");
                return;
            }
            var obj = (from x in de.Laptops where x.LaptopID.Equals(laptopIdText.Text) select x).FirstOrDefault();
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
            laptopIdText.Text = "";
            laptopNameText.Text = "";
            laptopSizeText.Text = "";
            laptopVGAText.Text = "";
            laptopPriceText.Text = "";

            insert = false;
            update = false;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;

            laptopIdText.Enabled = false;
            laptopNameText.Enabled = false;
            laptopSizeText.Enabled = false;
            laptopVGAText.Enabled = false;
            laptopPriceText.Enabled = false;
            laptopBrandBox.Enabled = false;
            laptopRAM.Enabled = false;
            int cntr = de.Laptops.Count();
            if (cntr < 9) laptopID += "00";
            else if (cntr < 99) laptopID += "0";
            laptopID += (cntr + 1).ToString();

            var obj = (
                from x in de.Laptops
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

            var bn = (
                from x in de.LaptopBrands
                select x.LaptopBrandName
                ).ToList();
            laptopBrandBox.DataSource = bn;
        }
    }
}
