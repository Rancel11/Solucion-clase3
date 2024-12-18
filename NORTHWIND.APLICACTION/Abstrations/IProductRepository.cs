using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NORTHWIND.APLICACTION.DTO;


namespace NORTHWIND.APLICACTION.Abstrations
{
    public interface IProductRepository
    {
        public IEnumerable<ProductDto> GetAllProduct();
        public IEnumerable<Supplier> LoadComboboxSupplier();
        public IEnumerable<Category> LoadCategory();
        void CreateProductValidator(Product request);
        void InsertProduct(Product request);
        void UpdateProduct(Product request);
        void DeleteProduct(Product request);
       
    }
}
