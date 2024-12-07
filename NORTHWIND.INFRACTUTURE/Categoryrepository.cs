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
   
    
    public class Categoryrepository : ICategoryRepository
    {
        public readonly NorthwindContext.NorthwindContext _context;

        public Categoryrepository(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Allcaterory()
        {
            return _context.Categories.ToList();
        }

    
        public IEnumerable<Category> LoadCombobox()
        {
            return _context.Categories
              .Select(c => new Category
              {
                  CategoryID = c.CategoryID,
                  CategoryName = c.CategoryName
              }).ToList();

        }

    }
}
