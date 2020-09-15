using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.DataAccess.EfModels
{
    public class Room
    {
        public enum RoomStatus
        {
            Undefined = 0,
            Occupied = 1,
            Available = 2,
        }

        [Key]
        public int Id { get; set; }

        public int Number { get; set; }
        public string Name { get; set; }
        public RoomStatus Status { get; set; }
        public bool AllowedSmoking { get; set; }

        [Required]
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }
    }
}
