using ContactAppWithRESTDemo.Models;
using ContactAppWithRESTDemo.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Services
{
    public class ContactDetailsService : IContactDetailsServices
    {
        IContactDetailsRepository _contactDetailsRepository;
        public ContactDetailsService()
        {
            _contactDetailsRepository = new ContactDetailsRepository();
        }
        public void AddContactDetails([FromBody] ContactDetails contactDetails)
        {
            Console.WriteLine("Enter Contact ID:");
            int contactId = int.Parse(Console.ReadLine());
            contactDetails.ContactId = contactId;
            _contactDetailsRepository.AddContactDetails(contactDetails);
            Console.WriteLine("Contact details added successfully.");
        }

        public void DeleteContactDetails(int id)
        {
            _contactDetailsRepository.DeleteContactDetails(id);
        }

        public IList<ContactDetails> Get()
        {
            return _contactDetailsRepository.Get();
        }

        public ContactDetails Get(int id)
        {
            var contactDetails = _contactDetailsRepository.Get(id);
            return contactDetails;
        }

        public void UpdateContactDetails(int id, [FromBody] ContactDetails contactDetails)
        {
            throw new NotImplementedException();
        }
    }
}
