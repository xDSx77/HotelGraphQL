﻿using GraphQL.Types;
using HotelGraphQL.DataAccess.EfModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL
{
    public class RoomType : ObjectGraphType<Room>
    {
        public RoomType()
        {
            Name = "Room";
            Field(x => x.Id);
            Field(x => x.Name);
        }
    }
}
