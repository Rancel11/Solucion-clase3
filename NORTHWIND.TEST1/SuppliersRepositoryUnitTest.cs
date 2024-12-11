

using Microsoft.Identity.Client;
using NORTHWIND.INFRACTUTURE;
using System.DirectoryServices.ActiveDirectory;
using Xunit;

namespace NORTHWIND.TEST1
{
    public class SuppliersRepositoryUnitTest
    {
        public readonly NorthwindContext.NorthwindContext _context;

        public SuppliersRepositoryUnitTest(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }


        [Fact]
        public void Test_Return_GetSuppliers()
        {

            // Arrange
            var repository = new suppliersrReporitory(_context);
            // Act
            var supplers = repository.GetSuppliers();
            // Assert
            Assert.True(supplers.Any());
        }


        [Fact]
        public void Test_Return_LoadCombobocSuppliers()
        {
            // Arrange
            var repository = new suppliersrReporitory(_context);
            // Act
            var supplers = repository.LoadComboboxfiltro();
            // Assert

            Assert.True(supplers.Any());


        }
    }
}