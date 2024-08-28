using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ContactAppWithRESTDemo.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactFName { get; set; }
        public string ContactLName { get; set; }
        public bool isActive { get; set; }

        public int UserId { get; set; }


        [ValidateNever]
        [JsonIgnore]
        public User User { get; set; }
        public List<ContactDetails> ContactDetailsList { get; set; }

    }
}
