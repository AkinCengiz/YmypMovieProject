using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using YmypMovieProject.Entity.Dtos.Categories;

namespace YmypMovieProject.Business.Validators;
public class CategoryValidator : AbstractValidator<CategoryAddRequestDto>
{
    public CategoryValidator()
    {
        RuleFor(c => c.Name).NotEmpty().WithMessage("Category name cannot be empty.")
            .Length(2, 50).WithMessage("Category name must be between 2 and 50 characters long.");
        RuleFor(c => c.Description)
            .NotEmpty().WithMessage("Category description cannot be empty.")
            .Length(10, 200).WithMessage("Category description must be between 10 and 200 characters long.");
    }
}
