using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _10_Laboratory_Exercise_1
{
    public partial class frmAddProduct : Form
    {
        private List<ProductClass> showProductList = new List<ProductClass>();

        public frmAddProduct()
        {
            InitializeComponent();
        }

        public class ProductClass
        {
            private int _Quantity;
            private double _SellingPrice;
            private string _ProductName, _Category, _ManufacturingDate, _ExpirationDate, _Description;

            public ProductClass(string productName, string category, string mfgDate, string expDate, double price, int quantity, string description)
            {
                _ProductName = productName;
                _Category = category;
                _ManufacturingDate = mfgDate;
                _ExpirationDate = expDate;
                _SellingPrice = price;
                _Quantity = quantity;
                _Description = description;
            }

            public string ProductName
            {
                get { return _ProductName; }
                set { _ProductName = value; }
            }

            public string Category
            {
                get { return _Category; }
                set { _Category = value; }
            }

            public string ManufacturingDate
            {
                get { return _ManufacturingDate; }
                set { _ManufacturingDate = value; }
            }

            public string ExpirationDate
            {
                get { return _ExpirationDate; }
                set { _ExpirationDate = value; }
            }

            public string Description
            {
                get { return _Description; }
                set { _Description = value; }
            }

            public int Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; }
            }

            public double SellingPrice
            {
                get { return _SellingPrice; }
                set { _SellingPrice = value; }
            }
        }

        public string Product_Name(string name)
        {
            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                throw new Exception("Product name must contain only letters and spaces.");
            return name;
        }

        public int Quantity(string qty)
        {
            if (!Regex.IsMatch(qty, @"^\d+$"))
                throw new Exception("Quantity must be a valid integer.");
            return Convert.ToInt32(qty);
        }

        public double SellingPrice(string price)
        {
            if (!Regex.IsMatch(price, @"^(\d*\.)?\d+$"))
                throw new Exception("Selling price must be a valid number.");
            return Convert.ToDouble(price);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = Product_Name(txtProductName.Text);
                string category = cbCategory.Text;
                string manufacturingDate = dtPickerMfgDate.Value.ToString("yyyy-MM-dd");
                string expirationDate = dtPickerExpDate.Value.ToString("yyyy-MM-dd");
                string description = richTxtDescription.Text;
                int quantity = Quantity(txtQuantity.Text);
                double sellingPrice = SellingPrice(txtSellPrice.Text);

                showProductList.Add(new ProductClass(productName, category, manufacturingDate, expirationDate, sellingPrice, quantity, description));

                gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridViewProductList.DataSource = null; 
                gridViewProductList.DataSource = showProductList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

