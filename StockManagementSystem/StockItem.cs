using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem
{
    public class StockItem
    {
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        public override string ToString()
        {
            
            return $"Item Name: {ItemName}; " +
            $"Item Code: {ItemCode}; " +
            $"Quantity: {Quantity}; " +
            $"Price: ${Price:F2}";
        }


    }
}
