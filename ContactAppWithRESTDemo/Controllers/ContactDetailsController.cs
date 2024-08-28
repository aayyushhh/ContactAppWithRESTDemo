using ContactAppWithRESTDemo.Models;
using ContactAppWithRESTDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailsController : ControllerBase
    {
        IContactDetailsServices _contactDetailsServices;

        public ContactDetailsController()
        {
            _contactDetailsServices = new ContactDetailsService();
        }
        [HttpGet]
        public IList<ContactDetails> Get()
        {
            return _contactDetailsServices.Get();
        }


        [HttpGet("{id}")]
        public ContactDetails Get(int id)
        {
            return _contactDetailsServices.Get(id);
        }

        [HttpPost]
        public void AddContactDetails([FromBody] ContactDetails contact)
        {
            _contactDetailsServices.AddContactDetails(contact);
        }

        [HttpPut("{id}")]
        public void UpdateContactDeatils(int id, [FromBody] ContactDetails contact)
        {

            _contactDetailsServices.UpdateContactDetails(id, contact);

        }


        [HttpDelete("{id}")]
        public void DeleteContactDetails(int id)
        {
            _contactDetailsServices.DeleteContactDetails(id);
        }
    }
}

