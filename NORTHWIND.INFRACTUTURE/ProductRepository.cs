using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using NORTHWIND.APLICACTION;
using NORTHWIND.APLICACTION.Abstrations;
using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NORTHWIND.INFRACTUTURE.Categoryrepository;


namespace NORTHWIND.INFRACTUTURE
{
    public class ProductRepository : IProductRepository
    {
        public readonly NorthwindContext.NorthwindContext _context;
        
     

        public ProductRepository(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }

        public void CreateProductValidator(Product request)
        {
            
            var validator = new ProductValidator();
            ValidationResult result = validator.Validate(request);

            if (!result.IsValid)
            {

                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"Error en la propiedad {error.PropertyName}: {error.ErrorMessage}");
                }


                throw new ValidationException(result.Errors);
            }


            Console.WriteLine("El producto es válida.");
        }

        public IEnumerable<DTO.ProductDto> GetAllProduct()
        {

            return _context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .Select(p => new DTO.ProductDto
                {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    QuantityPerUnit = p.QuantityPerUnit,
                    UnitPrice = p.UnitPrice,
                    CompanyName = p.Supplier.CompanyName,
                    CategoryName = p.Category.CategoryName,
                    CategoryID = p.CategoryID,
                    SupplierID = p.SupplierID
                }).ToList();
        }

     

        public IEnumerable<Category> LoadCategory()
        
        {
            return _context.Categories
                .Select(c => new Category
                {
                   CategoryID = c.CategoryID,
                   CategoryName = c.CategoryName
                }).ToList();
        }

        public IEnumerable<Supplier> LoadComboboxSupplier()
        {
            return _context.Suppliers
               .Select(s => new Supplier
               {
                   SupplierID = s.SupplierID,
                   CompanyName = s.CompanyName
               }).ToList();
        }

        
        
        
        public class ProductValidator : AbstractValidator<Product>
        {
            public ProductValidator()
            {
                RuleFor(product => product.ProductName)
                    .NotEmpty().WithMessage("El nombre del producto es obligatorio.")
                    .Matches(@"^[a-zA-Z\s]+$").WithMessage("El nombre del producto solo debe contener letras.");

                RuleFor(product => product.QuantityPerUnit)
                    .NotEmpty().WithMessage("La cantidad por unidad es obligatoria.");

                RuleFor(product => product.UnitPrice)
                    .NotEmpty().WithMessage("El precio único es obligatorio.")
                    .GreaterThan(0).WithMessage("El precio debe ser mayor que cero.");
            }
        }
    }
}
