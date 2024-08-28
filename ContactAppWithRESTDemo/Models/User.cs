using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace ContactAppWithRESTDemo.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserFName { get; set; }
        public string UserLName { get; set; }

        public bool isAdmin { get; set; }
        public bool isActive { get; set; }


        [JsonIgnore]
        [ValidateNever]
        public List<Contact> ContactsList { get; set; }
    }
}
