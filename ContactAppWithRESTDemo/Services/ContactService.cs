using ContactAppWithRESTDemo.Data;
using ContactAppWithRESTDemo.Models;
using ContactAppWithRESTDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Services
{
    public class ContactService : IContactService
    {
        IContactRepository _contactRepository;
        

        public ContactService()
        {
            _contactRepository = new ContactRepository();
        }
        public void AddContact([FromBody] Contact contact)
        {
            {
                Console.WriteLine("Enter User ID :");
                int userId = int.Parse(Console.ReadLine());

                User user = _contactRepository.GetUserById(userId);
                if (user != null)
                {
                    contact.User = user;
                    _contactRepository.AddContact(contact);
                    Console.WriteLine("Contact added successfully.");
                }
                else
                {
                    Console.WriteLine("User ID does not exist. Contact not added.");
                }
            }
        }


        public void DeleteContact(int id)
        {
            _contactRepository.DeleteContact(id);
        }

        public IList<Contact> Get()
        {
            return _contactRepository.Get();
        }

        public Contact Get(int id)
        {
            return _contactRepository.Get(id);
        }

        public void UpdateContact(int id, [FromBody] Contact contact)
        {
            _contactRepository.UpdateContact(id, contact);
        }
    }
}
