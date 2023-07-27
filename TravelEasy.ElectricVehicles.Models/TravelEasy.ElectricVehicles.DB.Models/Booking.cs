using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelEasy.ElectricVehicles.DB.Models;

namespace TravelEasy.EV.DB.Models.Diesel
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Required]
        [ForeignKey("ElectricVehicleId")]
        public int ElectricVehicleId { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Required]
        public DateTime EndDate { get; set; }



        // Navigation Properties
        public ElectricVehicle? ElectricVehicle { get; set; }
        public User? User { get; set; }
    }
}
