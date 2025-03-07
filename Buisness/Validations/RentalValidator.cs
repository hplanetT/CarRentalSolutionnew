using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Validations
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("Kiralama tarihi boş olamaz.");
            RuleFor(r => r.ReturnDate).GreaterThan(r => r.RentDate)
                .When(r => r.ReturnDate.HasValue)
                .WithMessage("Teslim tarihi, kiralama tarihinden sonra olmalıdır.");
        }
    }
}
