using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Validations
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz.");
            RuleFor(u => u.PasswordHash).NotEmpty().WithMessage("Şifre boş olamaz.");
            RuleFor(u => u.Role).NotEmpty().WithMessage("Rol bilgisi boş olamaz.");
        }
    }
}
