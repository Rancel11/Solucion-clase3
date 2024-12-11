using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NORTHWIND.INFRACTUTURE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWIND.TEST1
{
    public class CategoryRepositoryUnitTest
    {
        public readonly NorthwindContext.NorthwindContext _context;

        public CategoryRepositoryUnitTest(NorthwindContext.NorthwindContext context)
        {
            _context = context;

        }

       
        [Fact]
        public void Test_return_Allcategory()
        {
            // Arrange
            var repository = new Categoryrepository(_context);
            // Act
            var category = repository.Allcaterory();
            //Assert

            Assert.True(category.Any());

        }

        [Fact]
        public void Test_return_LoadComboboxcategory()
        {
             var repository = new Categoryrepository(_context);
            // Act
            var category = repository.Allcaterory();
            //Assert

            Assert.True(category.Any());
        }
    }
}
