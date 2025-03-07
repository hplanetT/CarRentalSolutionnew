using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty().WithMessage("Müşteri adı boş olamaz.");
            RuleFor(c => c.LastName).NotEmpty().WithMessage("Müşteri soyadı boş olamaz.");
            RuleFor(c => c.TCNo).Length(11).WithMessage("TC Kimlik Numarası 11 haneli olmalıdır.");
            RuleFor(c => c.PhoneNumber).Matches(@"^\d{10,11}$").WithMessage("Telefon numarası 10 veya 11 haneli olmalıdır.");
            RuleFor(c => c.Email).EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz.");
        }
    }
}
