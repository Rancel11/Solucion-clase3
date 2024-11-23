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

}
