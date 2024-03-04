using Domain.Entities.Identity;
using FluentValidation; 

namespace Application.Validators
{
    public class UserValidators:AbstractValidator<AppUser>
    {
        public UserValidators()
        {
            RuleFor(p=>p.Name).NotEmpty();
            
        }

    }
}
