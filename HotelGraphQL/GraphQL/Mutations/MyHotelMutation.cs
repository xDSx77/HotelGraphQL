using GraphQL;
using GraphQL.Types;
using HotelGraphQL.DataAccess;
using HotelGraphQL.DataAccess.EfModels;

namespace HotelGraphQL.GraphQL.Mutations
{
    public class MyHotelMutation : ObjectGraphType
    {
        public MyHotelMutation(ReservationRepository reservationRepository)
        {
            Field<ReservationType>("createReservation",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ReservationInputType>>
                    {
                        Name = "reservation"
                    }
                ),
                resolve: context =>
                {
                    var reservation = context.GetArgument<Reservation>("reservation");
                    return reservationRepository.CreateReservation(reservation);
                }
            );
        }
    }
}
