using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Validations
{
    public class PaymentValidator : AbstractValidator<Payment>
    {
        public PaymentValidator()
        {
            RuleFor(p => p.Amount).GreaterThan(0).WithMessage("Ödeme miktarı 0'dan büyük olmalıdır.");
            RuleFor(p => p.PaymentMethod).NotEmpty().WithMessage("Ödeme yöntemi boş olamaz.");
        }
    }
}
