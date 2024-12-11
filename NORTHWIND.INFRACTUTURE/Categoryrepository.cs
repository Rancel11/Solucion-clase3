using FluentValidation;
using FluentValidation.Results;
using Microsoft.Identity.Client;
using NORTHWIND.APLICACTION;
using NORTHWIND.APLICACTION.Abstrations;
using NorthwindContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORTHWIND.INFRACTUTURE
{
   
    
    public class Categoryrepository : ICategoryRepository
    {
        public readonly NorthwindContext.NorthwindContext _context;

        public Categoryrepository(NorthwindContext.NorthwindContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Allcaterory()
        {
            return _context.Categories.ToList();
        }

    
        public IEnumerable<Category> LoadCombobox()
        {
            return _context.Categories
              .Select(c => new Category
              {
                  CategoryID = c.CategoryID,
                  CategoryName = c.CategoryName
              }).ToList();

        }

        public void CreateCategoryValidator(Category request)
        {
            var validator = new CategoryValidator();
            ValidationResult result = validator.Validate(request);

            if (!result.IsValid)
            {
                
                foreach (var error in result.Errors)
                {
                    Console.WriteLine($"Error en la propiedad {error.PropertyName}: {error.ErrorMessage}");
                }

                
                throw new ValidationException(result.Errors);
            }

            
            Console.WriteLine("La categoría es válida.");
        }

        public class CategoryValidator : AbstractValidator<Category>
        {
            public CategoryValidator()
            {
              

                RuleFor(c => c.CategoryName)
                    .NotEmpty().WithMessage("El nombre de la categoría no puede estar vacío.")
                    .MaximumLength(50).WithMessage("El nombre de la categoría no puede exceder los 50 caracteres.");

                RuleFor(c => c.Description).NotEmpty().WithMessage("La descripcion no puede estar vacia");
            }
        }

    }
}
