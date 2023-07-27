using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TravelEasy.EV.DB.Models.Diesel;

namespace TravelEasy.ElectricVehicles.DB.Models
{
    public class ElectricVehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("BrandId")]
        public int BrandId { get; set; }

        [Required]
        public string? Model { get; set; }

        [Required]
        public int HorsePowers { get; set; }

        [Required]
        public int Range { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        [Required]
        public string? ImageURL { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Brand Brand {  get; set; }
    }
}