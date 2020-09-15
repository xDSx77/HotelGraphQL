using HotelGraphQL.DataAccess.EfModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.DataAccess
{
    public class RoomRepository : Repository<Room>
    {
        public RoomRepository(HotelDbContext context, ILogger<RoomRepository> logger) : base(context.Rooms, context, logger)
        {
        }

        public async Task<IEnumerable<Room>> GetAll()
        {
            return await _context
                .Rooms
                .ToListAsync();
        }
    }
}
