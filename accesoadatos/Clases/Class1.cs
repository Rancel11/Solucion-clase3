using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accesoadatos.Clases
{
    public class Productos
    {

        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public float Discount { get; set; }
        public string CategoryName { get; set; }
        public string CompanyName { get; set; }
        public decimal ExtendedPrice { get; set; }


    }
    public class Supplier
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
    }

    public class OrderValidator
    {
        public string CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ShipVia { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public string ShipRegion { get; set; }
        public string ShipName { get; set; }
        public string FreightText { get; set; }

    }
}