﻿using AuthPractice.Models.Entities;
using System.Security.Claims;

namespace AuthPractice.Interfaces
{
    public interface IIdentityBusiness
    {
        public void CreatePasswordHashSalt(string password, out byte[] passwordHash, out byte[] passwordSalt);
        public bool AuthenticateUser(string password, byte[] passwordHash, byte[] passwordSalt);
        public string CreateToken(string userName);
        public string CreateRefreshToken();
        public ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
    }
}
