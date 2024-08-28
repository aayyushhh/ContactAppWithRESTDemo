using ContactAppWithRESTDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Services
{
    public interface IContactDetailsServices
    {
        public IList<ContactDetails> Get();
        public ContactDetails Get(int id);
        public void AddContactDetails([FromBody] ContactDetails contactDetails);
        public void UpdateContactDetails(int id, [FromBody] ContactDetails contactDetails);
        public void DeleteContactDetails(int id);
    }
}
