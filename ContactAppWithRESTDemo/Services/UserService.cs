using ContactAppWithRESTDemo.Models;
using ContactAppWithRESTDemo.Repository;
using ContactAppWithRESTDemo.Services.ExceptionHandler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactAppWithRESTDemo.Services
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;

        public UserService()
        {

            _userRepository = new UserRepository();
        }
        public void AddUser([FromBody] User user)
        {
            Console.WriteLine("Enter your User ID:");
            int userId = int.Parse(Console.ReadLine());

            try
            {
                User user1 = _userRepository.GetUserById(userId);


                if (user1 != null && user1.isAdmin)
                {
                    _userRepository.AddUser(user);
                    Console.WriteLine("User added successfully.");
                }

                else
                {
                    throw new UserNotAdminException("User not Admin");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }




        public void DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
        }

        public IList<User> Get()
        {

            return _userRepository.Get();
        }

        public User Get(int id)
        {
            return _userRepository.Get(id);
        }

        public void Update(int id, [FromBody] User user)
        {


            _userRepository.Update(id, user);


        }
        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }
    }
}
