using BookShop.Logic;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Validators
{
    public class CEmployeeValidator: AbstractValidator<CEmployee> //validating registation info through FluentValidation lib
    {
        public CEmployeeValidator() //constructor where the validator lives
        {
            //rule for the validation
            RuleFor(e => e.FirstName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
                .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(e => e.LastName)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
                .Must(BeAValidName).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(e => e.Username)
               .Cascade(CascadeMode.StopOnFirstFailure)
               .NotEmpty().WithMessage("{PropertyName} is Empty.")
               .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
               .Must(BeAValidUsername).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(e => e.Email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .Length(2, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
                .EmailAddress().WithMessage("A valid {PropertyName} is required");

            RuleFor(e => e.Phone)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .Length(8, 12).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid")
                .Must(BeAValidPhone).WithMessage("{PropertyName} Contains Invalid Characters");

            RuleFor(e => e.Password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty().WithMessage("{PropertyName} is Empty.")
                .Length(5, 64).WithMessage("Length ({TotalLength}) of {PropertyName} is Invalid");

        }

        protected bool BeAValidName(String name) //self-composed validation rule that does not allow special characters in the name
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetter);
        }

        protected bool BeAValidPhone(String phone) //self-composed validation rule that does not allow the user to enter strings for phone
        {
            phone = phone.Replace(" ", "");
            phone = phone.Replace("+", "");
            return phone.All(Char.IsDigit);
        }

        protected bool BeAValidUsername(String name) //self-composed validation rule that does not allow special characters in the name
        {
            name = name.Replace(" ", "");
            name = name.Replace("-", "");
            return name.All(Char.IsLetterOrDigit);
        }
    }
}
