using Microsoft.IdentityModel.Tokens;
using Models;
using System;

namespace WebApi.Authentication
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);
        TokenValidationParameters GetValdiationParameters();
        
    }
}
