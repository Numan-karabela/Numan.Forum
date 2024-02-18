using Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppUserC.CreateUser
{
    public class CreateUserrCommandHandler : IRequestHandler<CreateUserrCommandRequest, CreateUserrCommandResponse>
    {
         
            UserManager<AppUser> _userManager;

        public CreateUserrCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserrCommandResponse> Handle(CreateUserrCommandRequest request, CancellationToken cancellationToken)
            {
            IdentityResult result = await _userManager.CreateAsync(new()
            { Id = new int().ToString(),
                    UserName = request.UserName,
                NormalizedUserName = request.NameSurname,
                Email = request.Email,
            }, request.Password);

                if (result.Succeeded)
                {
                    return new()
                    {
                        Succeded = "Kayıt başarılı"
                    };
                }
                else
                {
                    return new()
                    {
                        Succeded = "Kayıt başarısız"
                    };
                }

            }
        }
    }
