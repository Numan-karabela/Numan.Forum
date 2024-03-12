using Domain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validators
{
    public class PostValidator:AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x=>x.Title).NotNull().WithMessage("Başlık boş olamaz"); 
            RuleFor(x=>x.Content).NotNull().WithMessage("Boş değer girilemez");
            RuleFor(x => x.UserId).NotNull().WithMessage("Hata");


        }
    }
}
