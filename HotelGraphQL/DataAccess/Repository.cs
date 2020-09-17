using HotelGraphQL.DataAccess.EfModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HotelGraphQL.DataAccess
{
    public abstract class Repository<DBEntity> where DBEntity : class, new()
    {
        protected readonly DbSet<DBEntity> _set;
        protected readonly HotelDbContext _context;
        protected readonly ILogger _logger;

        public Repository(DbSet<DBEntity> set, HotelDbContext context, ILogger logger)
        {
            _set = set;
            _context = context;
            _logger = logger;
        }
    }
}
