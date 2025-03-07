using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Validations
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            int a = 4;
            RuleFor(c => c.Brand).NotEmpty().WithMessage("Araç markası boş olamaz.");
            RuleFor(c => c.Model).NotEmpty().WithMessage("Araç modeli boş olamaz.");
            RuleFor(c => c.LicensePlate).Matches(@"^[0-9A-Z]{7,8}$").WithMessage("Plaka formatı hatalı.");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Günlük ücret 0'dan büyük olmalıdır.");
        }
    }
}
