using GraphQL;
using GraphQL.Types;
using HotelGraphQL.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL.Queries
{
    public class ListRoomsQuery : ObjectGraphType
    {
        public ListRoomsQuery(RoomRepository roomRepository)
        {
            Name = "Rooms";
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
        }
    }
}
