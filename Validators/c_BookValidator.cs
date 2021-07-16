using BookShop.Data;
using BookShop.Logic;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Validators
{
    public class CBookValidator: AbstractValidator<CBooks>
    {
        public CBookValidator() //constructor where the validator lives
        {
            //rule for the validation
            RuleFor(e => e.AuthorName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid");

            RuleFor(e => e.Title)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid");

            RuleFor(e => e.ISBN)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} is Empty.")
               .Length(8, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
               .Must(BeAValid).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(e => e.Publisher)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} is Empty.")
               .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
               .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");


            RuleFor(e => e.PublicationYear)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .InclusiveBetween(1700, 2021).WithMessage("{PropertyName} Invalid Year");
               

            RuleFor(e => e.Price)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .InclusiveBetween(3, 1000).WithMessage("{PropertyName} Price Outside Range");
        }

        protected bool BeAValidName(String name) //self-composed validation rule that does not allow special characters in the name
        {
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeAValid(String name) //self-composed validation rule that does not allow special characters in the name
        {
            name = name.Replace("-", "");
            return name.All(Char.IsLetterOrDigit);
        }
    }
}

