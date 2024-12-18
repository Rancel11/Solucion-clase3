using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWIND.APLICACTION.Abstrations
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> Allcaterory();
        public IEnumerable<Category> LoadCombobox();
        void CreateCategoryValidator(Category request);
        void CreateCategory(Category request);
        void DeleteCategory(Category request);
        void UpdateCategory(Category request);
        
    }
}
