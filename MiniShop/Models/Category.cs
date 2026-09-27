using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; } = true;
        public Category() { }
        public Category(int categoryId, string categoryName, string? description = null, bool isActive = true)
        {
            CategoryID = categoryId;
            CategoryName = categoryName;
            Description = description;
            IsActive = isActive;
        }

        public override string ToString()
        {
            return CategoryName;
        }
    }
}

