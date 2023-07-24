using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelEasy.EV.DB.Models.Diesel
{
    [Keyless]
    public class Booking
    {
        public int UserId { get; set; }
        public int CarId { get; set; }
    }
}
