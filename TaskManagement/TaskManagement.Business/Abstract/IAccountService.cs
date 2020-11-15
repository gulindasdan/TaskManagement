using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Core.Business;
using TaskManagement.Entities;

namespace TaskManagement.Business.Abstract
{
    public interface IAccountService 
    {
        Task<AppUser> FindByEmailAsync(string email);
        Task Login(string email, string password);
        Task Register(AppUser user);
    }
}
