using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register_Products
{
    public partial class Products : Form
    {

        List<Products> AllProducts = new List<Products>();
        public Products()
        {
            InitializeComponent();
        }
        Regex onlyletters = new Regex(@"^[a-zA-Z]+$");
        Regex price = new Regex(@"^[0-9]*(?:\.[0-9]*)?$");
        Regex onlynumbers = new Regex(@"^[0-9]+$");



        private void Save_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                //Adding Rows
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = NameBox.Text;
                row.Cells[1].Value = PriceBox.Text;
                row.Cells[2].Value = CategoryBox.Text;
                row.Cells[3].Value = BrandBox.Text;
                row.Cells[4].Value = ColorBox.Text;
                row.Cells[5].Value = BarcodeBox.Text;
                row.Cells[6].Value = StockBox.Text;
                row.Cells[7].Value = AdBox.Text;
                dataGridView1.Rows.Add(row);

                NameBox.Clear();
                PriceBox.Clear();
                ColorBox.Clear();
                StockBox.Clear();
                BarcodeBox.Clear();
                AdBox.Clear();
            }
            else
            {
                MessageBox.Show("Please fill form correctly,then save!");
            }
        }

        private void NameBox_Validating(object sender, CancelEventArgs e)
        {
            if (NameBox.Text.Length == 0)
            {
                MessageBox.Show("FIll the name");
                e.Cancel = true;
            }
        }

        private void PriceBox_Validating(object sender, CancelEventArgs e)
        {
            if (PriceBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(PriceBox.Text, price.ToString()))
            {
                MessageBox.Show("Insert Product price correctly");
                e.Cancel = true;
            }

        }

        private void CategoryBox_Validating(object sender, CancelEventArgs e)
        {
            if (CategoryBox.Text.Length == 0)
            {
                MessageBox.Show("Please select category from List");
                e.Cancel = true;
            }
        }

        private void BrandBox_Validating(object sender, CancelEventArgs e)
        {
            if (BrandBox.Text.Length == 0)
            {
                MessageBox.Show("Please select brand from list");
                e.Cancel = true;
            }
        }

        private void ColorBox_Validating(object sender, CancelEventArgs e)
        {
            if (ColorBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(ColorBox.Text,onlyletters.ToString()))
            {
                MessageBox.Show("Insert Product color correctly");
                e.Cancel = true;
            }

        }

        private void BarcodeBox_Validating(object sender, CancelEventArgs e)
        {
            if (BarcodeBox.Text.Length == 0)
            {
                MessageBox.Show("Dont miss barcode part");
                e.Cancel = true;
            }
        }

        private void StockBox_Validating(object sender, CancelEventArgs e)
        {
            if (StockBox.Text.Length == 0)
            {
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(StockBox.Text, onlynumbers.ToString()))
            {
                MessageBox.Show("Insert stock size correctly");
                e.Cancel = true;
            }

        }

        private void AdBox_Validating(object sender, CancelEventArgs e)
        {
            if (AdBox.Text.Length == 0)
            {
                MessageBox.Show("Dont miss AD");
                e.Cancel = true;
            }
        }
        
    }
}

