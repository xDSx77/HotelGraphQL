using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.DataAccess.EfModels
{
    public enum RoomStatus
    {
        Undefined = 0,
        Occupied = 1,
        Available = 2,
    }

    public class Room
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        public RoomStatus Status { get; set; }

        public bool AllowedSmoking { get; set; }
    }
}
