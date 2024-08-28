using ContactAppWithRESTDemo.Data;
using ContactAppWithRESTDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContactAppWithRESTDemo.Repository
{
    public class ContactDetailsRepository : IContactDetailsRepository
    {
        ContactDbContext contactdetailsdb = new ContactDbContext();
        public void AddContactDetails([FromBody] ContactDetails contactDetails)
        {
            contactdetailsdb.ContactDetails.Add(contactDetails);
            contactdetailsdb.SaveChanges();
        }

        public void DeleteContactDetails(int id)
        {
            var contactdetails = contactdetailsdb.ContactDetails.Find(id);
            contactdetailsdb.ContactDetails.Remove(contactdetails);
            contactdetailsdb.SaveChanges(true);


        }

        public IList<ContactDetails> Get()
        {
            return contactdetailsdb.ContactDetails.ToList();
        }

        public ContactDetails Get(int id)
        {
            var contactdetail = contactdetailsdb.ContactDetails.Find(id);
            return contactdetail;
        }

        public void UpdateContactDetails(int id, [FromBody] ContactDetails contactDetails)
        {
            var contactdetails1 = contactdetailsdb.ContactDetails.Find(id);
            contactdetails1.Value = contactDetails.Value;
            contactdetails1.Value = contactDetails.Value;
            contactdetailsdb.SaveChanges();
        }
    }
}
