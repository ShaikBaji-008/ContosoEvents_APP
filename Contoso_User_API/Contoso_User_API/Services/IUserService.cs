using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_User_API.Model;

namespace Contoso_User_API.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User>GetUser(int User_Id);
        Task<User>GetUserByUsername(string User_UserName);

        Task<User>GetUserByEMail(string User_Email);
        Task<User>AddUser(User user);
        Task<User>UpdateUser(User user);
        Task DeleteUser(int User_Id);

        Task<User>GetLoginIdtologin(string User_Email, string User_Password);
    }
}

