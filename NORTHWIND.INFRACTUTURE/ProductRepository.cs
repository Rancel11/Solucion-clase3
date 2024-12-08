using Microsoft.EntityFrameworkCore;
using NORTHWIND.APLICACTION;
using NORTHWIND.APLICACTION.Abstrations;
using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NORTHWIND.INFRACTUTURE
{
    public class ProductRepository : IProductRepository
    {
        public readonly NorthwindContext.NorthwindContext _context;
        
     

        public ProductRepository(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<DTO.ProductDto> GetAllProduct()
        {

            return _context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .Select(p => new DTO.ProductDto
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice,
                    CompanyName = p.Supplier.CompanyName,
                    CategoryName = p.Category.CategoryName,
                    CategoryID = p.CategoryID,
                    SupplierID = p.SupplierID
                }).ToList();
        }

     

        public IEnumerable<Category> LoadCategory()
        
        {
            return _context.Categories
                .Select(c => new Category
                {
                   CategoryID = c.CategoryID,
                   CategoryName = c.CategoryName
                }).ToList();
        }

        public IEnumerable<Supplier> LoadComboboxSupplier()
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
