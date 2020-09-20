using HotelGraphQL.DataAccess.EfModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace HotelGraphQL.DataAccess
{
    public class RoomRepository : Repository<Room>
    {
        public RoomRepository(HotelDbContext context, ILogger<RoomRepository> logger) : base(context.Rooms, context, logger)
        {
        }

        public DbSet<Room> GetQuery()
        {
            return _context
                .Rooms;
        }
    }
}
