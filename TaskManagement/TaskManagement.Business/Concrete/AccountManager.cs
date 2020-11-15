using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TaskManagement.Business.Abstract;
using TaskManagement.Entities;

namespace TaskManagement.Business.Concrete
{
    public class AccountManager : IAccountService
    {
        private readonly IConfiguration _config;
        private readonly UserManager<AppUser> _userManager;

        public AccountManager(UserManager<AppUser> userManager, IConfiguration config)
        {
            _userManager = userManager;
            _config = config;
        }

        public async Task Login(string email, string password)
        {
            var user = await CheckUserCredentialAsync(email, password);
            if(user != null)
            {
                var token = GenerateJwtToken(user);
            }
        }

        public async Task Register(AppUser user)
        {
            using TransactionScope transactionScope = new TransactionScope();
            try
            {
                await _userManager.CreateAsync(user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<AppUser> FindByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }

        #region Helper Methods
        private async Task<AppUser> CheckUserCredentialAsync(string email, string password)
        {
            var user = await FindByEmailAsync(email);
            if(user != null)
            {
               await _userManager.CheckPasswordAsync(user, password);
            }
            return user;
        }

        private string GenerateJwtToken(AppUser user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
        #endregion
    }
}
