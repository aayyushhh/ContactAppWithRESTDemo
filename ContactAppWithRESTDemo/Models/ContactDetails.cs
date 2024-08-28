using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace ContactAppWithRESTDemo.Models
{
    public class ContactDetails
    {
        [Key]
        public int ContactDetailsId { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public int ContactId { get; set; }

        [JsonIgnore]
        [ValidateNever]
        public Contact Contact { get; set; }
    }
}
