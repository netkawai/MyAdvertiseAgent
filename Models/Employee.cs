using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAdvertiseAgent.Models
{
    public class Employee
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PhoneNumber { get; set; }

        public Boolean HasAdmin { get; set; }

        [Required]
        public string Email { get; set; }

        // This should be hidden in UI
        [Required]
        public string Credential { get; set; }
    }
}
