using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoadatos.Models
{
    public class NorthwindModels
    {
        public class Product
        {

            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int SupplierID { get; set; }
            public int CategoryID { get; set; }

            public Supplier Supplier { get; set; }
            public Category Category { get; set; }

        }

        public class Supplier
        {

            public int SupplierID { get; set; }
            public string CompanyName { get; set; }
            public string ContactName { get; set; }
            public string ContactTitle { get; set; }
            public int Phone { get; set; }
        }

        public class Category
        {

            public int CategoryID { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }

        }
    }
}
