using NORTHWIND.INFRACTUTURE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWIND.TEST1
{
    public class OrderRepositoryUnitTest
    {
        public readonly NorthwindContext.NorthwindContext _context;

        public OrderRepositoryUnitTest(NorthwindContext.NorthwindContext context)
        {
            _context = context;

        }


       

     


        [Fact]
        public void Test_return_LoadCustomer()
        {
            // Arrange
            var repository = new OrderRepository(_context);
            // Act
            var order = repository.LoadCustomer();
            //Assert

            Assert.True(order.Any());

        }

        [Fact]
        public void Test_return_LoadEmployees()
        {
            // Arrange
            var repository = new OrderRepository(_context);
            // Act
            var order = repository.LoadEnployees();
            //Assert

            Assert.True(order.Any());

        }
        [Fact]
        public void Test_return_Allorderdetails()
        {
            // Arrange
            var repository = new OrderRepository(_context);
            // Act
            var order = repository.LoadOrdersDataGridView();
            //Assert

            Assert.True(order.Any());

        }
        [Fact]
        public void Test_return_LoadDatagridOrderdetails()
        {
            //Arrange
            var repository = new OrderRepository(_context);
            // Act
            var order = repository.LoadDatagridOrderdetails();
            //Assert

            Assert.True(order.Any());
        }
    }
}
