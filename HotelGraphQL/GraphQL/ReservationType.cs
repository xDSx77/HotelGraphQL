﻿using GraphQL.Types;
using HotelGraphQL.DataAccess.EfModels;

namespace HotelGraphQL.GraphQL
{
    public class ReservationType : ObjectGraphType<Reservation>
    {
        public ReservationType()
        {
            Name = "Reservation";
            Field(x => x.Id);
            Field(x => x.RoomId);
            Field(x => x.CheckinDate);
            Field(x => x.CheckoutDate);
            Field<RoomType>(nameof(Reservation.Room));
        }
    }
}
