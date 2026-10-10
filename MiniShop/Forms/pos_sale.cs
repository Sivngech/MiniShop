using MiniShop.Models;
using MiniShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class pos_sale : Form
    {
        private List<Product> productsList = new List<Product>();
        private List<Customer> customerList = new List<Customer>();
        private Sale currentSale = new Sale();
        private bool isLoadingCustomers = false; // Prevents recursive event triggers

        public pos_sale()
        {
            InitializeComponent();
            ApplyModernDataGridStyle(dgvProducts);
            ApplyModernDataGridStyle(dgvCart);

            // Wire up cell click event for cart remove button
            dgvCart.CellClick += dgvCart_CellClick;

            LoadCustomersFromDb();
            LoadProductsFromDb();
            InitNewSaleSession();
        }

        private void ApplyModernDataGridStyle(DataGridView dgv)
        {
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.BackgroundColor = Color.White;
            dgv.EnableHeadersVisualStyles = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(245, 230, 238);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(50, 50, 50);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 36;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dgv.RowsDefaultCellStyle.BackColor = Color.White;
            dgv.RowsDefaultCellStyle.ForeColor = Color.FromArgb(60, 60, 60);
            dgv.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(248, 200, 215);
            dgv.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(30, 30, 30);
            dgv.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(253, 248, 250);
            dgv.RowTemplate.Height = 32;
        }

        private void LoadProductsFromDb()
        {
            // 1. Include ImagePath in SQL query
            string query = "SELECT ProductID, ProductName, Price, Quantity, ImagePath FROM Products WHERE Quantity > 0";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);

            productsList.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string path = row["ImagePath"]?.ToString() ?? string.Empty;
                Image? loadedImg = null;

                // Load image from path if file exists
                if (!string.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                {
                    try
                    {
                        using (var tempImg = Image.FromFile(path))
                        {
                            loadedImg = new Bitmap(tempImg);
                        }
                    }
                    catch
                    {
                        loadedImg = null;
                    }
                }

                productsList.Add(new Product
                {
                    ProductID = Convert.ToInt32(row["ProductID"]),
                    ProductName = row["ProductName"].ToString() ?? string.Empty,
                    Price = Convert.ToDecimal(row["Price"]),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    ImagePath = path,
                    ProductImage = loadedImg
                });
            }

            // Increase row height template so images fit cleanly
            dgvProducts.RowTemplate.Height = 55;

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productsList;

            // Hide unused/raw properties
            if (dgvProducts.Columns["CategoryID"] != null) dgvProducts.Columns["CategoryID"].Visible = false;
            if (dgvProducts.Columns["CategoryName"] != null) dgvProducts.Columns["CategoryName"].Visible = false;
            if (dgvProducts.Columns["ImagePath"] != null) dgvProducts.Columns["ImagePath"].Visible = false;

            // Configure and position the Image column
            if (dgvProducts.Columns["ProductImage"] is DataGridViewImageColumn imgCol)
            {
                imgCol.HeaderText = "Image";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.FillWeight = 20;
                imgCol.DisplayIndex = 0; // Display as first column on the left
            }

            // Format remaining display columns
            if (dgvProducts.Columns["ProductID"] != null)
            {
                dgvProducts.Columns["ProductID"].HeaderText = "ID";
                dgvProducts.Columns["ProductID"].FillWeight = 15;
            }
            if (dgvProducts.Columns["ProductName"] != null)
            {
                dgvProducts.Columns["ProductName"].HeaderText = "Product Name";
                dgvProducts.Columns["ProductName"].FillWeight = 40;
            }
            if (dgvProducts.Columns["Price"] != null)
            {
                dgvProducts.Columns["Price"].HeaderText = "Price";
                dgvProducts.Columns["Price"].DefaultCellStyle.Format = "$0.00";
                dgvProducts.Columns["Price"].FillWeight = 20;
            }
            if (dgvProducts.Columns["Quantity"] != null)
            {
                dgvProducts.Columns["Quantity"].HeaderText = "Stock";
                dgvProducts.Columns["Quantity"].FillWeight = 15;
            }
        }

        private void LoadCustomersFromDb()
        {
            isLoadingCustomers = true; // Lock event listener

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

            // 1. Create projection list from DB customers
            var displayList = customerList.Select(c => new
            {
                CustomerID = (int?)c.CustomerID,
                DisplayText = $"{c.Name} ({c.CustomerType})",
                OriginalCustomer = (Customer?)c
            }).ToList();

            // 2. Add Walk-in Customer as the default first option
            displayList.Insert(0, new
            {
                CustomerID = (int?)null,
                DisplayText = "Walk-in Customer",
                OriginalCustomer = (Customer?)null
            });

            cbCustomers.DataSource = null;
            cbCustomers.DataSource = displayList;
            cbCustomers.DisplayMember = "DisplayText";
            cbCustomers.ValueMember = "CustomerID";

            cbCustomers.SelectedIndex = 0; // Default to Walk-in Customer

            isLoadingCustomers = false; // Unlock event listener
        }

        private void InitNewSaleSession()
        {
            List<SaleDetail> existingDetails = currentSale?.Details ?? new List<SaleDetail>();

            if (cbCustomers.SelectedItem != null)
            {
                // Extract original customer safely
                dynamic selectedObj = cbCustomers.SelectedItem;
                Customer? selectedCustomer = selectedObj.OriginalCustomer;

                if (selectedCustomer != null && selectedCustomer.CustomerType == "VIP")
                {
                    currentSale = new VIPSale { Customer = selectedCustomer };
                    if (lblVIPBadge != null) lblVIPBadge.Visible = true;
                }
                else
                {
                    currentSale = new Sale { Customer = selectedCustomer };
                    if (lblVIPBadge != null) lblVIPBadge.Visible = false;
                }
            }
            else
            {
                currentSale = new Sale();
                if (lblVIPBadge != null) lblVIPBadge.Visible = false;
            }

            currentSale.Details = existingDetails;
            txtDiscount.Text = "0";
            UpdateCartDisplay();
        }

        private void UpdateCartDisplay()
        {
            dgvCart.DataSource = null;
            dgvCart.Columns.Clear(); // Reset columns to ensure remove button stays properly ordered

            dgvCart.DataSource = new BindingList<SaleDetail>(currentSale.Details);

            if (dgvCart.Columns["ProductID"] != null)
            {
                dgvCart.Columns["ProductID"].HeaderText = "ID";
                dgvCart.Columns["ProductID"].FillWeight = 15;
            }
            if (dgvCart.Columns["ProductName"] != null)
            {
                dgvCart.Columns["ProductName"].HeaderText = "Product Name";
                dgvCart.Columns["ProductName"].FillWeight = 40;
            }
            if (dgvCart.Columns["UnitPrice"] != null)
            {
                dgvCart.Columns["UnitPrice"].HeaderText = "Unit Price";
                dgvCart.Columns["UnitPrice"].DefaultCellStyle.Format = "$0.00";
                dgvCart.Columns["UnitPrice"].FillWeight = 20;
            }
            if (dgvCart.Columns["Quantity"] != null)
            {
                dgvCart.Columns["Quantity"].HeaderText = "Qty";
                dgvCart.Columns["Quantity"].FillWeight = 15;
            }
            if (dgvCart.Columns["SubTotal"] != null)
            {
                dgvCart.Columns["SubTotal"].HeaderText = "SubTotal";
                dgvCart.Columns["SubTotal"].DefaultCellStyle.Format = "$0.00";
                dgvCart.Columns["SubTotal"].FillWeight = 20;
            }

            // Add dynamic Remove Button column
            DataGridViewButtonColumn btnRemoveCol = new DataGridViewButtonColumn
            {
                Name = "btnRemove",
                HeaderText = "",
                Text = "✕",
                UseColumnTextForButtonValue = true,
                FillWeight = 12,
                FlatStyle = FlatStyle.Flat
            };
            btnRemoveCol.DefaultCellStyle.ForeColor = Color.Red;
            btnRemoveCol.DefaultCellStyle.SelectionForeColor = Color.DarkRed;

            dgvCart.Columns.Add(btnRemoveCol);

            lblSubtotal.Text = currentSale.CalculateSubtotal().ToString("$0.00");
            lblGrandTotal.Text = currentSale.CalculateGrandTotal().ToString("$0.00");
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verify click is valid and was on the Remove button column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && dgvCart.Columns[e.ColumnIndex].Name == "btnRemove")
            {
                // Remove selected item from sale cart
                currentSale.Details.RemoveAt(e.RowIndex);

                // Refresh cart view
                UpdateCartDisplay();
            }
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Do not run session init while setting up DataSource
            if (isLoadingCustomers) return;

            InitNewSaleSession();
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow == null) return;

            Product selectedProd = (Product)dgvProducts.CurrentRow.DataBoundItem;
            int requestedQty = (int)numQty.Value;

            if (requestedQty <= 0)
            {
                MessageBox.Show("Please select a valid quantity.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (requestedQty > selectedProd.Quantity)
            {
                MessageBox.Show($"Not enough stock! Current stock: {selectedProd.Quantity}",
                                "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existingItem = currentSale.Details.FirstOrDefault(d => d.ProductID == selectedProd.ProductID);
            if (existingItem != null)
            {
                if (existingItem.Quantity + requestedQty > selectedProd.Quantity)
                {
                    MessageBox.Show($"Cannot add more than total available stock ({selectedProd.Quantity}).",
                                    "Stock Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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

            UpdateCartDisplay();
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

            // 1. Insert Sale record into Database
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

            // 2. Insert SaleDetails and Update Stock
            foreach (var detail in currentSale.Details)
            {
                string insertDetailQuery = @"INSERT INTO SaleDetails (SaleID, ProductID, UnitPrice, Quantity, SubTotal) 
                                             VALUES (@SaleID, @ProductID, @UnitPrice, @Qty, @SubTotal)";

                SqlParameter[] detailParams = new SqlParameter[]
                {
                    new SqlParameter("@SaleID", newSaleId),
                    new SqlParameter("@ProductID", detail.ProductID),
                    new SqlParameter("@UnitPrice", detail.UnitPrice),
                    new SqlParameter("@Qty", detail.Quantity),
                    new SqlParameter("@SubTotal", detail.UnitPrice * detail.Quantity)
                };
                DatabaseHelper.ExecuteNonQuery(insertDetailQuery, detailParams);

                string updateStockQuery = "UPDATE Products SET Quantity = Quantity - @Qty WHERE ProductID = @ProductID";
                SqlParameter[] stockParams = new SqlParameter[]
                {
                    new SqlParameter("@Qty", detail.Quantity),
                    new SqlParameter("@ProductID", detail.ProductID)
                };
                DatabaseHelper.ExecuteNonQuery(updateStockQuery, stockParams);
            }

            // 3. Collect receipt details for Invoice Form
            string customerName = currentSale.Customer?.Name ?? "Walk-in Customer";
            string cashierName = "Admin"; // Replace with logged-in user variable if available
            decimal subtotal = currentSale.CalculateSubtotal();
            decimal discount = currentSale.ManualDiscountPercent;
            decimal grandTotal = currentSale.CalculateGrandTotal();

            // 4. Open Invoice Preview Dialog
            using (InvoiceForm invoiceForm = new InvoiceForm(newSaleId, customerName, cashierName, dgvCart, subtotal, discount, grandTotal))
            {
                invoiceForm.ShowDialog(this);
            }

            // 5. Reset POS Cart and reload product stock
            currentSale.Details.Clear();
            LoadProductsFromDb();
            InitNewSaleSession();
        }

        private void addQtyPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblCartTitle_Click(object sender, EventArgs e)
        {
        }
    }
}