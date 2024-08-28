using ContactAppWithRESTDemo.Data;
using ContactAppWithRESTDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactAppWithRESTDemo.Repository
{
    public class ContactRepository : IContactRepository
    {
        ContactDbContext contactDbContext = new ContactDbContext();
        public void AddContact([FromBody] Contact contact)
        {
            contactDbContext.Contacts.Add(contact);
            contactDbContext.SaveChanges();
        }

        public void DeleteContact(int id)
        {
            var contact = contactDbContext.Contacts.Find(id);
            contactDbContext.Contacts.Remove(contact);
            contactDbContext.SaveChanges();
        }

        public IList<Contact> Get()
        {
            return contactDbContext.Contacts.ToList();
        }

        public Contact Get(int id)
        {
            var contact = contactDbContext.Contacts.Find(id);
            return contact;
        }

        public void UpdateContact(int id, [FromBody] Contact contact)
        {
            var contact1 = contactDbContext.Contacts.Find(id);
            contact1.ContactFName = contact.ContactFName;
            contact1.ContactLName = contact.ContactLName;
            contactDbContext.SaveChanges();
        }
        public User GetUserById(int userId)
        {
            return contactDbContext.Users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
