using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace NORTHWIND.APLICACTION.Abstrations
{
    public interface Isuppliersreporitory
    {
        public IEnumerable<Supplier> GetSuppliers();
        public IEnumerable<Supplier> LoadComboboxfiltro();
        
    }

 

}
