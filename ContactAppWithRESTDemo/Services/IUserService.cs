﻿using ContactAppWithRESTDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactAppWithRESTDemo.Services
{
    public interface IUserService
    {
        public IList<User> Get();
        public User Get(int id);
        public void AddUser([FromBody] User user);
        public void Update(int id, [FromBody] User user);
        public void DeleteUser(int id);
        public User GetUserById(int userId);
 
    }
}