using GraphQL.Types;
using HotelGraphQL.DataAccess.EfModels;

namespace HotelGraphQL.GraphQL
{
    public class ReservationInputType : InputObjectGraphType<Reservation>
    {
        public ReservationInputType()
        {
            Name = "ReservationInput";
            Field(x => x.RoomId);
            Field(x => x.CheckinDate);
            Field(x => x.CheckoutDate);
        }
    }
}
