using ContactAppWithRESTDemo.Models;
using ContactAppWithRESTDemo.Repository;
using ContactAppWithRESTDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;

        public UserController()
        {
            _userService = new UserService();

        }

        [HttpGet]
        public IList<User> Get()
        {
            return _userService.Get();
        }


        [HttpGet("{id}")]
        public User Get(int id)
        {
            return _userService.Get(id);
        }

        [HttpPost]
        public void AddUser([FromBody] User user)
        {
            _userService.AddUser(user);
        }

        [HttpPut("{id}")]
        public void UpdateUser(int id, [FromBody] User user)
        {

            _userService.Update(id, user);

        }


        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
    }







}

