﻿using System.ComponentModel.DataAnnotations;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class User
    {
        public User() { }
        public User(string? username, string? email, string? password)
        {
            Username = username;
            Email = email;
            Password = password;
        }

        [Key]
        public int Id { get; set; }
       
        [Required]
        public string? Username { get; set; } 

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

    }
}
