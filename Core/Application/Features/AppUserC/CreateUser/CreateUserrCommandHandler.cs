using Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppUserC.CreateUser
{
    public class CreateUserrCommandHandler : IRequestHandler<CreateUserrCommandRequest, CreateUserrCommandResponse>
    {

        private readonly UserManager<AppUser> _userManager;

        public CreateUserrCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CreateUserrCommandResponse> Handle(CreateUserrCommandRequest request, CancellationToken cancellationToken)
            {
             
            IdentityResult result = await _userManager.CreateAsync(new()
            {  Id=new(),
                UserName = request.UserName,
                Name= request.Name,
                SurName=request.SurName,
                Email = request.Email,
            }, request.Password);

                if (result.Succeeded)
                {
                    return new()
                    {
                        Succeded = "True"
                    };
                }
                else
                {
                    return new()
                    {
                        Succeded = "False"
                    };
                }

            }
        }
    }
