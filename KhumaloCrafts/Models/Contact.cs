using System.ComponentModel.DataAnnotations;

namespace KhumaloCrafts.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }


        [Required(ErrorMessage = "EmailAddress is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "ContactNumber is Required")]
        public string ContactNumber { get; set; }
    }
}

