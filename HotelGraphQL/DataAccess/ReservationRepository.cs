using HotelGraphQL.DataAccess.EfModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.DataAccess
{
    public class ReservationRepository : Repository<Reservation>
    {
        public ReservationRepository(HotelDbContext context, ILogger<ReservationRepository> logger) : base(context.Reservations, context, logger)
        {
        }

        public async Task<IEnumerable<Reservation>> GetAll()
        {
            return await _context
                .Reservations
                .Include(x => x.Room)
                .ToListAsync();
        }

        public async Task<Reservation> CreateReservation(Reservation reservation)
        {
            try
            {
                _context.Reservations.Add(reservation);
                await _context.SaveChangesAsync();
                return _context.Reservations.Where(x => x.Id == reservation.Id).Include(x => x.Room).FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError("cannot create reservation", ex);
                return null;
            }
        }

        public IIncludableQueryable<Reservation, Room> GetQuery()
        {
            return _context
                .Reservations
                .Include(x => x.Room);
        }
    }
}
