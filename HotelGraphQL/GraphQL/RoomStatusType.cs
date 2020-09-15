using GraphQL.Types;
using HotelGraphQL.DataAccess.EfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL
{
    public class RoomStatusType : ObjectGraphType<RoomStatus>
    {
        public RoomStatusType()
        {
            Field(x => x.ToString());
        }
    }
}
