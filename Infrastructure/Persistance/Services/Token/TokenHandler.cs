using Application.Abstractions.Token;
using Application.Dtos;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services.Token
{
    public class TokenHandler : ITokenHandler
    {
        readonly IConfiguration _configuration;

        public TokenHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TokenResponse CreateAccessToken(int minute)
        {
            TokenResponse token = new();

            //security key'in simacriğini alıyoruz
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(_configuration["Token:SecurityKey"])); 

            //şifrelenmiş key'i oluşturduğumuz yer
            SigningCredentials credentials=new(securityKey,SecurityAlgorithms.HmacSha256);

            //Token ayarları veriyoruz
            token.Expiration = DateTime.UtcNow.AddMinutes(minute);

            JwtSecurityToken securityToken = new(
                audience: _configuration["Token:Audience"],
                issuer: _configuration["Token:Issuer"],
                expires: token.Expiration,
                notBefore:DateTime.UtcNow,
                signingCredentials:credentials 
                );
            JwtSecurityTokenHandler tokenHandler = new();

            token.AccessToken=  tokenHandler.WriteToken(securityToken);


            return token;

        }
    }
}
