using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using NORTHWIND.APLICACTION.Abstrations;
using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NORTHWIND.APLICACTION.DTO;
using static NORTHWIND.INFRACTUTURE.Categoryrepository;

namespace NORTHWIND.INFRACTUTURE
{
    public class OrderRepository : IOrderRepository
    {
        private readonly NorthwindContext.NorthwindContext _context;

        public OrderRepository(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer> LoadCustomer()
        {
            return _context.customers
          .Select(c => new Customer
          {
              CustomerID = c.CustomerID,
              CompanyName = c.CompanyName

          }).ToList();
        }

        public IEnumerable<Employees> LoadEnployees()
        {
            return _context.Employees
               .Select(e => new Employees
               {
                  EmployeeID = e.EmployeeID,
                  FirstName = e.FirstName
               }).ToArray();
        }
       

        public IEnumerable<Shipper> LoadShippers()
        {
            return _context.shippers
                .Select(s => new Shipper
                {
                   ShipperID = s.ShipperID,
                   CompanyName = s.CompanyName
                }).ToList();
        }

        public IEnumerable<OrderDetailDto> LoadOrdersDataGridView()
        {
            return _context.orderDetails
               .Include(o => o.Order)
               .Include(o => o.Product)
               .ThenInclude(p => p.Supplier)
               .Include(o => o.Product.Category)
               .Select(o => new OrderDetailDto
               {
                   OrderID = o.OrderID,
                   CustomerID = o.Order.CustomerID,
                   ProductID = o.ProductID,
                   UnitPrice = o.Product.UnitPrice,
                   Quantity = o.Quantity,
                   Discount = o.Discount,
                   ProductName = o.Product.ProductName,
                   CompanyName = o.Product.Supplier.CompanyName,
                   CategoryName = o.Product.Category.CategoryName,
                   ExtendedPrice = o.Product.UnitPrice * o.Quantity * (1 - (decimal)o.Discount)
               }).ToList();
        }

        public IEnumerable<Category> LoadComboboxCategory()
        {
            return _context.Categories
               .Select(c => new Category
               {
                   CategoryID=c.CategoryID,
                   CategoryName=c.CategoryName
               }).ToList();
        }

        public IEnumerable<ProductDto> LoadDatagridOrderdetails()
        {
            return _context.Products
           .Include(p => p.Supplier)
           .Include(p => p.Category)
           .Select(p => new ProductDto
            {
                 ProductID = p.ProductID,
                 ProductName = p.ProductName,
                 CompanyName = p.Supplier.CompanyName,
                 CategoryName = p.Category.CategoryName,
                 UnitPrice = p.UnitPrice
            }).Distinct() 
             .ToList();
        }

        public void CreateOrderValidator(Order request)
        {
            var validator = new OrderValidator();
            ValidationResult result = validator.Validate(request);

            if (!result.IsValid)
            {

                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"Error en la propiedad {error.PropertyName}: {error.ErrorMessage}");
                }


                throw new ValidationException(result.Errors);
            }


            Console.WriteLine("La orden es válida.");
        }

        public class OrderValidator : AbstractValidator<Order>
        {
            public OrderValidator()
            {
                

           

                RuleFor(x => x.ShipName)
                    .NotEmpty().WithMessage("El nombre del destinatario es obligatorio.")
                    .MaximumLength(100).WithMessage("El nombre del destinatario no puede exceder los 100 caracteres.");

                RuleFor(x => x.ShipAddress)
                    .NotEmpty().WithMessage("La dirección de envío es obligatoria.")
                    .MaximumLength(200).WithMessage("La dirección de envío no puede exceder los 200 caracteres.");

                RuleFor(x => x.ShipCity)
                    .NotEmpty().WithMessage("La ciudad de envío es obligatoria.")
                    .MaximumLength(50).WithMessage("El nombre de la ciudad no puede exceder los 50 caracteres.");

                RuleFor(x => x.ShipPostalCode)
                    .NotEmpty().WithMessage("El código postal es obligatorio.")
                    .Matches(@"^\d{5}$").WithMessage("El código postal debe tener 5 dígitos.");

                RuleFor(x => x.ShipCountry)
                    .NotEmpty().WithMessage("El país de envío es obligatorio.")
                    .MaximumLength(50).WithMessage("El nombre del país no puede exceder los 50 caracteres.");



                RuleFor(x => x.Freight).NotEmpty().WithMessage("No Puede estar vacio");
                    
            }
        }

    }
}
