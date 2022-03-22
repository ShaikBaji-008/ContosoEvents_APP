using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso_User_API.Data;
using Contoso_User_API.Model;
using Contoso_User_API.Services;

namespace Contoso_User_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;

        public UserController(IUserService UserService)
        {
            this.UserService = UserService;
        }
        
        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            try
            {
                return Ok(await UserService.GetUsers());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the databse");
            }
        }
        

        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            try
            {
                var result = await UserService.GetUser(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the databse");
            }
        }
        
        [HttpGet("{User_UserName}")]
        public async Task<ActionResult<User>> GetUserByUsername(string user_Username)
        {
            try
            {
                var result = await UserService.GetUserByUsername(user_Username);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the databse");
            }
        }
        
        [HttpGet("{User_Email}")]
        public async Task<ActionResult<User>> GetUserByEMail(string user_email)
        {
            try
            {
                var result = await UserService.GetUserByEMail(user_email);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the databse");
            }
        }

        [HttpPost]
        public async Task<ActionResult<User>> AddUser(User user)
        {
            try
            {
                if (User == null)
                    return BadRequest();
                //var appuser = UserService.GetUserByEMail(user.User_Email);
                //if (appuser != null)
                //{
                //    ModelState.AddModelError("Email", "User email already in use");
                //    return BadRequest(ModelState);
                //}

                var addedUser = await UserService.AddUser(user);
                return AddedAtAction(nameof(GetUsers), new { id = addedUser.User_Id }, addedUser);


            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error adding new user");
            }
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(int id, User user)
        {
            try
            {
                if (id != user.User_Id)
                    return BadRequest("User Id mismatch");

                var appusertoUpdate = await UserService.GetUser(id);
                if (appusertoUpdate == null)
                {
                    return NotFound($"User with Id={id} not found");
                }

                return await UserService.UpdateUser(user);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error updating new user");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteUser(int id)
        {
            try
            {
                var appusertoDelete = await UserService.GetUser(id);
                if (appusertoDelete == null)
                {
                    return NotFound($"User with Id={id} not found");
                }

                await UserService.DeleteUser(id);
                return Ok($"User with Id={id} deleted");
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting user");
            }
        }

        private ActionResult<User> AddedAtAction(string v, object p, User addedUser)
        {
            throw new NotImplementedException();
        }

        //For user login
        [HttpPost("{User_Username,User_Password}")]
        public async Task<ActionResult<User>> GetLoginIdtologin(string User_Username, string User_Password)
        {
            try
            {
                var result = await UserService.GetLoginIdtologin(User_Username, User_Password);
                if (result == null)
                {
                    return Ok("User with these Login credentials not found");
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error in login");
            }
        }
    }
}
//public class UserController : ControllerBase
//    {

//        private readonly IUserService UserService;

//        public UserController(IUserService UserService)
//        {
//            this.UserService = UserService;
//        }
//        private DataConnectionContext _databaseContext;

//        public UserController(DataConnectionContext _databaseContext)
//        {
//            _databaseContext = _databaseContext;
//        }

//        // GET: api/<UserController>
//        [HttpGet]
//        public IEnumerable<User> Get()
//        {
//            return _databaseContext.Users;
//        }

//        // GET api/<UserController>/
//        [HttpGet("{id}")]
//        public User Get(int id)
//        {
//            return _databaseContext.Users.FirstOrDefault(s => s.User_Id == id);
//        }

//        // POST api/<UserController>
//        [HttpPost]
//        public void Post([FromBody] User value)
//        {
//            _databaseContext.Users.Add(value);
//            _databaseContext.SaveChanges();
//        }

//        // PUT api/<UserController>/
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody] User value)
//        {
//            var UserDtls = _databaseContext.Users.FirstOrDefault(s => s.User_Id == id);
//            if (UserDtls != null)
//            {

//                _databaseContext.Entry<User>(UserDtls).CurrentValues.SetValues(value);
//                _databaseContext.SaveChanges();
//            }
//        }

//        // DELETE api/<UserController>/
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//            var UserDtls = _databaseContext.Users.FirstOrDefault(s => s.User_Id == id);
//            if (UserDtls != null)
//            {
//                _databaseContext.Users.Remove(UserDtls);
//                _databaseContext.SaveChanges();
//            }
//        }
//    }







