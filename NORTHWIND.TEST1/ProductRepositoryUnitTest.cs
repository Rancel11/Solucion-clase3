using Newtonsoft.Json.Bson;
using NORTHWIND.INFRACTUTURE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWIND.TEST1
{
    public class ProductRepositoryUnitTest
    {
        public readonly NorthwindContext.NorthwindContext _context;

        public ProductRepositoryUnitTest(NorthwindContext.NorthwindContext context)
        {
            _context = context;

        }


        [Fact]
        public void Test_return_GetAllProduct()
        {
            // Arrange
            var repository = new ProductRepository(_context);
            // Act
            var product = repository.GetAllProduct();
            //Assert

            Assert.True(product.Any());

        }

    }
}
