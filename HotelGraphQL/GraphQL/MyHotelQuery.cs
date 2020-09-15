using GraphQL.Types;
using HotelGraphQL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL
{
    public class MyHotelQuery : ObjectGraphType
    {
        public MyHotelQuery(ReservationRepository reservationRepository)
        {
            Field<ListGraphType<ReservationType>>("reservations",
                resolve: context =>
                {
                    var query = reservationRepository.GetQuery();
                    return query.ToList();
                }
            );
        }
    }
}
