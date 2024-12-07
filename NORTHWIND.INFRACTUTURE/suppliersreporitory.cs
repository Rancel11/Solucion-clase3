using Microsoft.EntityFrameworkCore;
using NORTHWIND.APLICACTION.Abstrations;
using NorthwindContext;

namespace NORTHWIND.INFRACTUTURE
{
    public class suppliersrReporitory : Isuppliersreporitory
    {
        public readonly NorthwindContext.NorthwindContext _context;
       

        public suppliersrReporitory(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
          
            return _context.Suppliers.ToList();
        }

      

        public IEnumerable<Supplier> LoadComboboxfiltro()
        {
            return _context.Suppliers
                 .Select(s => new Supplier
                 {
                     SupplierID = s.SupplierID,
                     CompanyName = s.CompanyName
                 }).ToList();
        }
    }
}
