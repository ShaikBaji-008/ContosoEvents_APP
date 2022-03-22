using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_User_API.Model;
using Contoso_User_API.Data;
using Microsoft.EntityFrameworkCore;
using Contoso_User_API.Services;




namespace Contoso_User_API.Services
{
   
    public class UserService : IUserService
    {
        private readonly DataConnectionContext DataConnectionContext;

        public UserService(DataConnectionContext dataConnectionContext)
        {
            this.DataConnectionContext = dataConnectionContext;
        }
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await DataConnectionContext.Users.ToListAsync();
        }
        public async Task<User>GetUser(int id)
        {
            return await DataConnectionContext.Users.FirstOrDefaultAsync(e => e.User_Id == id);
        }
        public async Task<User> GetUserByUsername(string username)
        {
            return await DataConnectionContext.Users.FirstOrDefaultAsync(e => e.User_UserName == username);
        }
        public async Task<User> GetUserByEMail(string userEmail)
        {
            return await DataConnectionContext.Users.FirstOrDefaultAsync(e => e.User_Email == userEmail);
        }
        public async Task<User> AddUser(User addUser)
        {
            var result = await DataConnectionContext.Users.AddAsync(addUser);
            await DataConnectionContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<User> UpdateUser(User user)
        {
            var result = await DataConnectionContext.Users.FirstOrDefaultAsync(e => e.User_Id == user.User_Id);
            if (result != null)
            {
                result.User_UserName = user.User_UserName;
                result.User_FirstName = user.User_FirstName;
                result.User_LastName = user.User_LastName;
                result.User_Email = user.User_Email;
                result.User_Contact = user.User_Contact;
                result.User_Password = user.User_Password;
                result.User_Gender = user.User_Gender;
               
                result.User_Country = user.User_Country;
                result.User_Address = user.User_Address;

                await DataConnectionContext.SaveChangesAsync();
                return result;
            }
            return null;
        }


      
        public async Task DeleteUser(int UserId)
        {
            var result = await DataConnectionContext.Users.FirstOrDefaultAsync(e => e.User_Id == UserId);
            if (result != null)
            {
                DataConnectionContext.Users.Remove(result);
                await DataConnectionContext.SaveChangesAsync();
            }
        }

        public async Task<User> GetLoginIdtologin(string userLoginId, string userLoginPassword)
        {
            return await DataConnectionContext.Users.FirstOrDefaultAsync(e => e.User_UserName == userLoginId && e.User_Password == userLoginPassword);
        }

    }
}
