using ContactAppWithRESTDemo.Data;
using ContactAppWithRESTDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactAppWithRESTDemo.Repository
{
    public class UserRepository : IUserRepository
    {
        ContactDbContext contextdb = new ContactDbContext();
        public void AddUser([FromBody] User user)
        {

            contextdb.Users.Add(user);
            contextdb.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = contextdb.Users.Find(id);
            user.isActive = false;
            
            contextdb.SaveChanges();
        }

        public IList<User> Get()
        {
            return contextdb.Users.ToList();
        }

        public User Get(int id)
        {
            var users = contextdb.Users.Find(id);

            return users;
        }

        public void Update(int id, [FromBody] User user)
        {
            var user1 = contextdb.Users.Find(id);
            user1.UserFName = user.UserFName;
            user1.UserLName = user.UserLName;
            contextdb.SaveChanges();



        }
        public User GetUserById(int userId)
        {
            return contextdb.Users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
