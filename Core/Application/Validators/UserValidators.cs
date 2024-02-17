using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class UserValidators:AbstractValidator<User>
    {
        public UserValidators()
        {
            RuleFor(User => User.UserName).NotEmpty().WithMessage("Boş geçilemez")
               .MinimumLength(5).MaximumLength(100).WithMessage("5-100 karakter arasında değer giriniz");
          
            RuleFor(User => User.Password).NotEmpty().WithMessage("Boş geçilemez")
                          .MinimumLength(8).MaximumLength(50).WithMessage("8-50 karakter arasında şifre oluşturunuz");



        }
    }
}
