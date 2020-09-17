using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelGraphQL.DataAccess.EfModels
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }
        public int RoomId { get; set; }

        [Required]
        public DateTime CheckinDate { get; set; }
        public DateTime CheckoutDate { get; set; }

        public Reservation()
        {
        }

        public Reservation(int id, int roomId, DateTime checkinDate, DateTime checkoutDate)
        {
            Id = id;
            RoomId = roomId;
            CheckinDate = checkinDate;
            CheckoutDate = checkoutDate;
        }
    }
}
