using GraphQL;
using GraphQL.Types;
using HotelGraphQL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL.Queries
{
    public class MyHotelQuery : ObjectGraphType
    {
        public MyHotelQuery(ReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("reservations",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<IdGraphType>
                    {
                        Name = "id"
                    }
                }),
                resolve: context =>
                {
                    var query = reservationRepository.GetQuery();
                    var reservationId = context.GetArgument<int?>("id");
                    if (reservationId.HasValue)
                    {
                        return reservationRepository.GetQuery()
                            .Where(r => r.Id == reservationId.Value);
                    }
                    return query.ToList();
                }
            );
        }
    }
}
