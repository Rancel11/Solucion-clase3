using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NORTHWIND.APLICACTION.DTO;

namespace NORTHWIND.APLICACTION.Abstrations
{
    public interface IOrderRepository
    {
        public IEnumerable<Shipper> LoadShippers();
        public IEnumerable<Customer> LoadCustomer();
        public IEnumerable<Employees> LoadEnployees();
        public IEnumerable<OrderDetailDto> LoadOrdersDataGridView();
        public IEnumerable<Category> LoadComboboxCategory();
        public IEnumerable <ProductDto> LoadDatagridOrderdetails();
        void CreateOrderValidator(Order request);
    
       
    }
}
