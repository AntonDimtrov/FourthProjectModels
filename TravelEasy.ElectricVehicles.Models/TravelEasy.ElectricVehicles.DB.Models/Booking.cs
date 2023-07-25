using System.ComponentModel.DataAnnotations;

namespace TravelEasy.EV.DB.Models.Diesel
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int CarId { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Today;

        [Required]
        public DateTime EndDate { get; set; }
    }
}
