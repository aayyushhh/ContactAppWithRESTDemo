using ContactAppWithRESTDemo.Models;
using ContactAppWithRESTDemo.Repository;
using ContactAppWithRESTDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        IContactService _contactService;

        public ContactController()
        {
            _contactService = new ContactService();
        }
        [HttpGet]
        public IList<Contact> Get()
        {
            return _contactService.Get();
        }


        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return _contactService.Get(id);
        }

        [HttpPost]
        public void AddContact([FromBody] Contact contact)
        {
            _contactService.AddContact(contact);
        }

        [HttpPut("{id}")]
        public void UpdateContact(int id, [FromBody] Contact contact)
        {

            _contactService.UpdateContact(id, contact);

        }


        [HttpDelete("{id}")]
        public void DeleteContact(int id)
        {
            _contactService.DeleteContact(id);
        }
    }
}
