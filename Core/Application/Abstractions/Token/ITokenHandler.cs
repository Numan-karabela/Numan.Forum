using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions.Token
{
    public interface ITokenHandler
    {
       TokenResponse CreateAccessToken(int minute);
    }
}
