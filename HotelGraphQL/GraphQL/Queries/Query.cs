using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL.Queries
{
    public class Query : ObjectGraphType
    {
        public Query()
        {
            Name = "Query";
            Field<ListRoomsQuery>("rooms", resolve: context => new { });
            Field<ListReservationsQuery>("reservations", resolve: context => new { });
        }
    }
}
