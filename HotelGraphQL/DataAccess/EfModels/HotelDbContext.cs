using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace HotelGraphQL.DataAccess.EfModels
{
    public class HotelDbContext : DbContext
    {

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
            if (Rooms.Any())
                return;
            // Rooms
            Rooms.Add(new Room(1, 100, "Room 100", RoomStatus.Occupied, false));
            Rooms.Add(new Room(2, 101, "Room 101", RoomStatus.Occupied, true));
            Rooms.Add(new Room(3, 102, "Room 102", RoomStatus.Available, false));
            SaveChanges();

            // Reservations
            Reservations.Add(new Reservation(1, 1, DateTime.Now.AddDays(-2), DateTime.Now.AddDays(4)));
            Reservations.Add(new Reservation(2, 2, DateTime.Now.AddDays(-4), DateTime.Now.AddDays(1)));
            SaveChanges();
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
