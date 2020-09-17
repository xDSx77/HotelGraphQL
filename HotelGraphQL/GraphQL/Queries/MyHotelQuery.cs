using GraphQL;
using GraphQL.Types;
using HotelGraphQL.DataAccess;
using System.Collections.Generic;
using System.Linq;

namespace HotelGraphQL.GraphQL.Queries
{
    public class MyHotelQuery : ObjectGraphType
    {
        public MyHotelQuery(RoomRepository roomRepository, ReservationRepository reservationRepository)
        {
            Field<ListGraphType<RoomType>>("rooms",
                arguments: new QueryArguments(new List<QueryArgument>
                {
                    new QueryArgument<BooleanGraphType>
                    {
                        Name = "allowedSmoking"
                    }
                }),
                resolve: context =>
                {
                    var query = roomRepository.GetQuery();
                    var roomAllowedSmoking = context.GetArgument<bool?>("allowedSmoking");
                    if (roomAllowedSmoking.HasValue)
                    {
                        return roomRepository.GetQuery()
                            .Where(room => room.AllowedSmoking == roomAllowedSmoking.Value);
                    }
                    return query.ToList();
                }
            );

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
                            .Where(reservation => reservation.Id == reservationId.Value);
                    }
                    return query.ToList();
                }
            );
        }
    }
}
