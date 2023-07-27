using System.ComponentModel.DataAnnotations;

namespace TravelEasy.EV.DB.Models.Diesel
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
