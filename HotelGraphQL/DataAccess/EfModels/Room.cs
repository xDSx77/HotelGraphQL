using System.ComponentModel.DataAnnotations;

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

        public Room()
        {
        }

        public Room(int id, int number, string name, RoomStatus status, bool allowedSmoking)
        {
            Id = id;
            Number = number;
            Name = name;
            Status = status;
            AllowedSmoking = allowedSmoking;
        }
    }
}
