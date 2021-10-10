using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.PhoneNumber).NotEmpty();
            RuleFor(p => p.Surname).NotEmpty();
            RuleFor(p => p.PhoneNumber).MaximumLength(15);
        }
    }
}
