using ContactAppWithRESTDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Repository
{
    public interface IContactRepository
    {
        public IList<Contact> Get();
        public Contact Get(int id);
        public void AddContact([FromBody] Contact contact);
        public void UpdateContact(int id, [FromBody] Contact contact);
        public void DeleteContact(int id);
        User GetUserById(int userId);
    }
}
