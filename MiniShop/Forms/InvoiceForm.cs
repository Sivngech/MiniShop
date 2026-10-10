using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniShop.Forms
{
    public partial class InvoiceForm : Form
    {
        public InvoiceForm()
        {
            InitializeComponent();
        }

        public InvoiceForm(int invoiceId, string customerName, string cashierName, DataGridView cartGrid, decimal subtotal, decimal discount, decimal grandTotal)
        {
            InitializeComponent();

            // 1. Populate metadata
            lblInvoiceId.Text = $"INV-{invoiceId:D3}";
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            lblCustomer.Text = string.IsNullOrWhiteSpace(customerName) ? "Walk-in Customer" : customerName;
            lblCashier.Text = string.IsNullOrWhiteSpace(cashierName) ? "Admin" : cashierName;

            // 2. Setup DataGridView columns if not already configured in designer
            SetupGridColumns();

            // 3. Transfer products from POS Cart DataGridView into Invoice Grid
            PopulateCartItems(cartGrid);

            // 4. Populate totals
            lblSubtotalValue.Text = $"${subtotal:F2}";
            lblDiscountValue.Text = $"{discount:F0}%";
            lblGrandtotalValue.Text = $"${grandTotal:F2}";
        }
        private void SetupGridColumns()
        {
            // Only add columns if they haven't been added in designer
            if (dgvInvoice.Columns.Count == 0)
            {
                dgvInvoice.Columns.Add("colItem", "Item");
                dgvInvoice.Columns.Add("colQty", "Qty");
                dgvInvoice.Columns.Add("colPrice", "Price");
                dgvInvoice.Columns.Add("colTotal", "SubTotal");

                // Set relative column proportions
                dgvInvoice.Columns[0].FillWeight = 140; // Item name
                dgvInvoice.Columns[1].FillWeight = 40;  // Qty
                dgvInvoice.Columns[2].FillWeight = 70;  // Unit Price
                dgvInvoice.Columns[3].FillWeight = 70;  // Total
            }
        }
        private void PopulateCartItems(DataGridView cartGrid)
        {
            dgvInvoice.Rows.Clear();

            if (cartGrid == null || cartGrid.Rows.Count == 0) return;

            foreach (DataGridViewRow row in cartGrid.Rows)
            {
                if (row.IsNewRow) continue;

                // Dynamically fetch values by column name, fallback to index if names differ
                string name = GetCellValue(row, "Product Name", 1);
                string qty = GetCellValue(row, "Qty", 3);
                string price = GetCellValue(row, "Unit Price", 2);
                string total = GetCellValue(row, "SubTotal", 4);

                dgvInvoice.Rows.Add(name, qty, price, total);
            }
        }

        private string GetCellValue(DataGridViewRow row, string columnName, int defaultIndex)
        {
            if (row.DataGridView.Columns.Contains(columnName) && row.Cells[columnName].Value != null)
            {
                return row.Cells[columnName].Value.ToString();
            }
            else if (row.Cells.Count > defaultIndex && row.Cells[defaultIndex].Value != null)
            {
                return row.Cells[defaultIndex].Value.ToString();
            }
            return "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;

            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDoc,
                Width = 600,
                Height = 700,
                StartPosition = FormStartPosition.CenterParent
            };

            previewDialog.ShowDialog(this);
        }
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Calculate capture area (Header + Content panels)
            int width = pnlHeader.Width;
            int height = pnlHeader.Height + pnlContent.Height;

            Bitmap bmp = new Bitmap(width, height);

            // Draw header and content onto image memory
            pnlHeader.DrawToBitmap(bmp, new Rectangle(0, 0, pnlHeader.Width, pnlHeader.Height));
            pnlContent.DrawToBitmap(bmp, new Rectangle(0, pnlHeader.Height, pnlContent.Width, pnlContent.Height));

            // Draw to printer graphics output
            e.Graphics.DrawImage(bmp, 50, 40);
        }
    }
}
