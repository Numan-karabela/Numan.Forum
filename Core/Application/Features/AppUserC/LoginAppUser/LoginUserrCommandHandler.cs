
using Domain.Entities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.AppUserC.LoginAppUser
{
    public class LoginUserrCommandHandler : IRequestHandler<LoginUserrCommandRequest, LoginUserrCommandResponse>
    {
         UserManager<AppUser>  _userManager;
         SignInManager<AppUser> _signInManager;

        public LoginUserrCommandHandler(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<LoginUserrCommandResponse> Handle(LoginUserrCommandRequest request, CancellationToken cancellationToken)
        {
           AppUser appUser= await _userManager.FindByNameAsync(request.UserNameOrEmail);
            if (appUser == null)
                appUser = await _userManager.FindByEmailAsync(request.UserNameOrEmail);
            if (appUser==null)
            {
                return new()
                {
                    message = "Kullanıcı Bulunamadı"
                };
            }

            SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, request.Password, false);
            if (result.Succeeded)
            {
                return new() { message = "Giriş başarılı" };
            }
            else
                return new() { message = "Giriş Başarısız" };
            


        }
    }
}
