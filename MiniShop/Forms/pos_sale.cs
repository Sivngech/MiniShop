using MiniShop.Models;
using MiniShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class pos_sale : Form
    {
        private List<Product> productsList = new List<Product>();
        private List<Customer> customerList = new List<Customer>();
        private Sale currentSale = new Sale();
        public pos_sale()
        {
            InitializeComponent();
            LoadCustomersFromDb();
            LoadProductsFromDb();
            InitNewSaleSession();
        }

        private void LoadProductsFromDb()
        {
            // Query products from database
            string query = "SELECT ProductID, ProductName, Price, Quantity FROM Products WHERE Quantity > 0";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            productsList.Clear();
            foreach (DataRow row in dt.Rows)
            {
                productsList.Add(new Product
                {
                    ProductID = Convert.ToInt32(row["ProductID"]),
                    ProductName = row["ProductName"].ToString() ?? string.Empty,
                    Price = Convert.ToDecimal(row["Price"]),
                    Quantity = Convert.ToInt32(row["Quantity"])
                });
            }

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productsList;
        }

        private void LoadCustomersFromDb()
        {
            string query = "SELECT CustomerID, Name, Phone, CustomerType FROM Customers";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            customerList.Clear();
            foreach (DataRow row in dt.Rows)
            {
                customerList.Add(new Customer
                {
                    CustomerID = Convert.ToInt32(row["CustomerID"]),
                    Name = row["Name"].ToString() ?? string.Empty,
                    Phone = row["Phone"]?.ToString() ?? string.Empty,
                    CustomerType = row["CustomerType"].ToString() ?? "Regular"
                });
            }

            cbCustomers.DataSource = null;
            cbCustomers.DataSource = customerList;
            cbCustomers.DisplayMember = "Name";
        }
        private void InitNewSaleSession()
        {
            if (cbCustomers.SelectedItem is Customer selectedCustomer)
            {
                if (selectedCustomer.CustomerType == "VIP")
                {
                    currentSale = new VIPSale { Customer = selectedCustomer };
                    lblVIPBadge.Visible = true;
                }
                else
                {
                    currentSale = new Sale { Customer = selectedCustomer };
                    lblVIPBadge.Visible = false;
                }
            }

            txtDiscount.Text = "0";
            UpdateCartDisplay();
        }
        private void addQtyPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void UpdateCartDisplay()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = currentSale.Details;

            lblSubtotal.Text = currentSale.CalculateSubtotal().ToString("$0.00");
            lblGrandTotal.Text = currentSale.CalculateGrandTotal().ToString("$0.00");
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            Product selectedProd = (Product)dgvProducts.CurrentRow.DataBoundItem;
            int requestedQty = (int)numQty.Value;

            if (requestedQty > selectedProd.Quantity)
            {
                MessageBox.Show($"Not enough stock! Current stock: {selectedProd.Quantity}",
                                "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingItem = currentSale.Details.FirstOrDefault(d => d.ProductID == selectedProd.ProductID);
            if (existingItem != null)
            {
                existingItem.Quantity += requestedQty;
            }
            else
            {
                currentSale.Details.Add(new SaleDetail
                {
                    ProductID = selectedProd.ProductID,
                    ProductName = selectedProd.ProductName,
                    UnitPrice = selectedProd.Price,
                    Quantity = requestedQty
                });
            }
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitNewSaleSession();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtDiscount.Text, out decimal discount))
            {
                currentSale.ManualDiscountPercent = discount;
                lblGrandTotal.Text = currentSale.CalculateGrandTotal().ToString("$0.00");
            }
        }

        private void btnCompleteSale_Click(object sender, EventArgs e)
        {
            if (currentSale.Details.Count == 0)
            {
                MessageBox.Show("Cart is empty!", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 1. Insert Sales Header into Database and get back generated SaleID
            string insertSaleQuery = @"INSERT INTO Sales (CustomerID, SaleDate, TotalAmount) 
                                       VALUES (@CustID, @SaleDate, @Total); 
                                       SELECT SCOPE_IDENTITY();";

            SqlParameter[] saleParams = new SqlParameter[]
            {
                new SqlParameter("@CustID", currentSale.Customer?.CustomerID ?? (object)DBNull.Value),
                new SqlParameter("@SaleDate", DateTime.Now),
                new SqlParameter("@Total", currentSale.CalculateGrandTotal())
            };

            object? newSaleIdObj = DatabaseHelper.ExecuteScalar(insertSaleQuery, saleParams);
            int newSaleId = Convert.ToInt32(newSaleIdObj);

            // 2. Insert Details & Update Product Inventory Stock
            foreach (var detail in currentSale.Details)
            {
                // Insert line item
                string insertDetailQuery = @"INSERT INTO SaleDetails (SaleID, ProductID, UnitPrice, Quantity) 
                                             VALUES (@SaleID, @ProductID, @UnitPrice, @Qty)";

                SqlParameter[] detailParams = new SqlParameter[]
                {
                    new SqlParameter("@SaleID", newSaleId),
                    new SqlParameter("@ProductID", detail.ProductID),
                    new SqlParameter("@UnitPrice", detail.UnitPrice),
                    new SqlParameter("@Qty", detail.Quantity)
                };
                DatabaseHelper.ExecuteNonQuery(insertDetailQuery, detailParams);

                // Deduct inventory in DB
                string updateStockQuery = "UPDATE Products SET Quantity = Quantity - @Qty WHERE ProductID = @ProductID";
                SqlParameter[] stockParams = new SqlParameter[]
                {
                    new SqlParameter("@Qty", detail.Quantity),
                    new SqlParameter("@ProductID", detail.ProductID)
                };
                DatabaseHelper.ExecuteNonQuery(updateStockQuery, stockParams);
            }
            MessageBox.Show($"Sale Completed Successfully! (Invoice #{newSaleId})",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh UI and product list
            LoadProductsFromDb();
            InitNewSaleSession();
        }
    }
}
