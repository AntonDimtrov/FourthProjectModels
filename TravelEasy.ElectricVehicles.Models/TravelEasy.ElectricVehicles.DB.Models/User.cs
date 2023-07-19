using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    internal class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Username { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 8)]
        public string? Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 10)]
        public string? PhoneNumber { get; set; }

        //[StringLength(number, MinimumLength = number)] 
    }
}
