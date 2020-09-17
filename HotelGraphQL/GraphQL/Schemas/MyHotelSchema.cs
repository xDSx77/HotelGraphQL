using GraphQL;
using GraphQL.Types;
using HotelGraphQL.GraphQL.Mutations;
using HotelGraphQL.GraphQL.Queries;
using System;

namespace HotelGraphQL.GraphQL.Schemas
{
    public class MyHotelSchema : Schema
    {
        public MyHotelSchema(IServiceProvider resolver) : base(resolver)
        {
            Query = resolver.GetService(typeof(MyHotelQuery)).As<MyHotelQuery>();
            Mutation = resolver.GetService(typeof(MyHotelMutation)).As<MyHotelMutation>();
        }
    }
}
