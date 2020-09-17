﻿using HotelGraphQL.DataAccess.EfModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
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

        public DbSet<Room> GetQuery()
        {
            return _context
                .Rooms;
        }
    }
}
