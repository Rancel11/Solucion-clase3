using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using NORTHWIND.APLICACTION.Abstrations;
using NorthwindContext;
using static NORTHWIND.INFRACTUTURE.Categoryrepository;

namespace NORTHWIND.INFRACTUTURE
{
    public class suppliersrReporitory : Isuppliersreporitory
    {
        public readonly NorthwindContext.NorthwindContext _context;
       

        public suppliersrReporitory(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }

        public void CreateSuppliers(Supplier request)
        {
            var supplier = new Supplier();
            supplier.CompanyName = request.CompanyName;
            supplier.ContactName = request.ContactName;
            supplier.ContactTitle = request.ContactTitle;
            supplier.Phone = request.Phone;

            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void CreateSuppliersvalidator(Supplier request)
        {
            var validator = new SupplierValidator();
            ValidationResult result = validator.Validate(request);

            if (!result.IsValid)
            {

                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"Error en la propiedad {error.PropertyName}: {error.ErrorMessage}");
                }


                throw new ValidationException(result.Errors);
            }
        }

        public void DeleteSuppliers(Supplier request)
        {
            _context.Suppliers.Remove(request);
            _context.SaveChanges();
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
          
            return _context.Suppliers.ToList();
        }

      

        public IEnumerable<Supplier> LoadComboboxfiltro()
        {
            return _context.Suppliers
                 .Select(s => new Supplier
                 {
                     SupplierID = s.SupplierID,
                     CompanyName = s.CompanyName
                 }).ToList();
        }

        public void UpdateSuppliers(Supplier request)
        {
            _context.Suppliers.Update(request);
            _context.SaveChanges();
        }

        public class SupplierValidator : AbstractValidator<Supplier>
        {
            public SupplierValidator()
            {
                RuleFor(s => s.CompanyName)
                    .NotEmpty().WithMessage("El nombre de la compañía es obligatorio.")
                    .MaximumLength(100).WithMessage("El nombre de la compañía no puede exceder los 100 caracteres.");

                RuleFor(s => s.ContactName)
                    .NotEmpty().WithMessage("El nombre del contacto es obligatorio.")
                    .MaximumLength(50).WithMessage("El nombre del contacto no puede exceder los 50 caracteres.");

                RuleFor(s => s.Phone)
                    .NotEmpty().WithMessage("El número de teléfono es obligatorio.")
                    .Matches(@"^\+?[0-9\s\-]{7,15}$").WithMessage("El formato del número de teléfono no es válido.");

                RuleFor(s => s.ContactTitle)
                    .MaximumLength(30).WithMessage("El título del contacto no puede exceder los 30 caracteres.")
                    .When(s => !string.IsNullOrEmpty(s.ContactTitle)); 
            }
        }
    }
}
