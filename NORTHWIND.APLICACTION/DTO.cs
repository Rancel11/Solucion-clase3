using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWIND.APLICACTION
{
    public class DTO
    {
        public class ProductDto
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal? UnitPrice { get; set; }
            public string CompanyName { get; set; } 
            public string CategoryName { get; set; } 
            public int? CategoryID { get; set; }
            public int? SupplierID { get; set; }
        }

        public class SupplierDto
        {

            public int SupplierID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public string Phone { get; set; }
        }
        public class CategoryDto
        {

            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }

        }
        public class OrderDetailDto
        {
            public int OrderID { get; set; }
            public string CustomerID { get; set; }
            public int ProductID { get; set; }
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public float Discount { get; set; }
            public string ProductName { get; set; }
            public string CompanyName { get; set; }
            public string CategoryName { get; set; }
            public decimal ExtendedPrice { get; set; }
        }



    }
}
