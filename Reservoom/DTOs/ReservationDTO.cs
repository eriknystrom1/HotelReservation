using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.DTOs
{
    public class ReservationDTO
    {

        // Data Transfer Objects design patter that carries data between processes and retrieves data from db
        [Key]
        public Guid Id { get; set; }
        public int FloorNumber { get; set; }
        public int RoomNumber { get; set; }
        public string Username { get; set; }

       // public string Password { get; set; }
       // public string Extras { get; set; }
      // public string City { get; set; }
     //  public int RoomSize { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
