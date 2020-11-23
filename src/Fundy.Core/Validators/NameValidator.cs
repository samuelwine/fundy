using FluentValidation;
using Fundy.Core.Records;

namespace Fundy.Core.Validators
{
    class NameValidator : AbstractValidator<Name>
    {
        public NameValidator()
        {
            RuleFor(name => name.FirstName).NotEmpty();
            RuleFor(name => name.LastName).NotEmpty();
        }
    }
}
