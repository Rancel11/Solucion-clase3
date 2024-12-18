using Microsoft.EntityFrameworkCore;
using Xunit;
using NORTHWIND.INFRACTUTURE;
using NorthwindContext;

namespace NORTHWIND.TEST1
{
    public class CategoryRepositoryUnitTest
    {
        public readonly NorthwindContext.NorthwindContext _context;
         
        public CategoryRepositoryUnitTest()
        {
            
            var options = new DbContextOptionsBuilder<NorthwindContext.NorthwindContext>()
                .UseInMemoryDatabase(databaseName: "Northwind")
                .Options;

            
            _context = new NorthwindContext.NorthwindContext(options);
        }

        [Fact]
        public void Test_return_AllCategory()
        {
            // Arrange
            var repository = new Categoryrepository(_context);

           
            _context.Categories.Add(new Category { CategoryName = "Beverages" });
            _context.SaveChanges();

            // Act
            var categories = repository.Allcaterory();

            // Assert
            Assert.True(categories.Any(), "No categories were returned.");
        }
    }
}
