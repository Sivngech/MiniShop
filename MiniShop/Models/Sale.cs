using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniShop.Models
{
    public class SaleDetail
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal SubTotal => UnitPrice * Quantity;
    }

    public class Sale
    {
        public int SaleID { get; set; }
        public Customer? Customer { get; set; }
        public DateTime SaleDate { get; set; } = DateTime.Now;
        public List<SaleDetail> Details { get; set; } = new List<SaleDetail>();
        public decimal ManualDiscountPercent { get; set; }

        public decimal CalculateSubtotal()
        {
            return Details.Sum(d => d.SubTotal);
        }

        // Virtual method for Polymorphism
        public virtual decimal CalculateGrandTotal()
        {
            decimal subtotal = CalculateSubtotal();
            decimal discountAmount = subtotal * (ManualDiscountPercent / 100m);
            return subtotal - discountAmount;
        }
    }

    // Un-nested VIPSale for cleaner instantiation
    public class VIPSale : Sale
    {
        public decimal VIPExtraDiscountPercent { get; set; } = 5.0m; // Extra 5% OFF for VIPs

        public override decimal CalculateGrandTotal()
        {
            decimal baseTotal = base.CalculateGrandTotal();
            return baseTotal - (baseTotal * (VIPExtraDiscountPercent / 100m));
        }
    }
}