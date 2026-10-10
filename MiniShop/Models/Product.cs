using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string ImagePath { get; set; } = string.Empty;

        // DataGridView binds this to render the image thumbnail automatically
        public Image? ProductImage { get; set; }
        public Product() { }
        public Product(int productID, string productName, int categoryID, decimal price, int quantity ,string categoryName)
        {
            ProductID = productID;
            ProductName = productName;
            CategoryID = categoryID;
            Price = price;
            Quantity = quantity;
            CategoryName= categoryName;
        }
        // Overloaded Constructor including Image Path and Image Object
        public Product(int productID, string productName, int categoryID, decimal price, int quantity, string categoryName, string imagePath, Image? productImage = null)
            : this(productID, productName, categoryID, price, quantity, categoryName)
        {
            ImagePath = imagePath;
            ProductImage = productImage;
        }
    }
}
