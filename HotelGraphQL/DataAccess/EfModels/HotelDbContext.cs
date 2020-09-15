using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.DataAccess.EfModels
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext()
        {
        }

        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Rooms
            modelBuilder.Entity<Room>().HasData(new Room { Id = 1, Number = 100, Name = "Room 100", Status = RoomStatus.Available, AllowedSmoking = false });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 2, Number = 101, Name = "Room 101", Status = RoomStatus.Available, AllowedSmoking = true });
            modelBuilder.Entity<Room>().HasData(new Room { Id = 3, Number = 102, Name = "Room 102", Status = RoomStatus.Occupied, AllowedSmoking = false });

            // Reservations
            modelBuilder.Entity<Reservation>().HasData(new Reservation { Id = 1, RoomId = 1, CheckinDate = DateTime.Now.AddDays(-2), CheckoutDate = DateTime.Now.AddDays(4) });
            modelBuilder.Entity<Reservation>().HasData(new Reservation { Id = 2, RoomId = 2, CheckinDate = DateTime.Now.AddDays(-4), CheckoutDate = DateTime.Now.AddDays(1) });

            base.OnModelCreating(modelBuilder);
        }
    }
}
