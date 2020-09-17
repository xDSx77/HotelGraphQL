using GraphQL.Types;
using HotelGraphQL.DataAccess.EfModels;

namespace HotelGraphQL.GraphQL
{
    public class RoomType : ObjectGraphType<Room>
    {
        public RoomType()
        {
            Name = "Room";
            Field(x => x.Id);
            Field(x => x.Number);
            Field(x => x.Name);
            Field<RoomStatusEnum>(nameof(Room.Status));
        }
    }
}
