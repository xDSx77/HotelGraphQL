using GraphQL;
using GraphQL.Types;
using HotelGraphQL.GraphQL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelGraphQL.GraphQL.Schemas
{
    public class MyHotelSchema : Schema
    {
        public MyHotelSchema(IServiceProvider resolver) : base(resolver)
        {
            Query = resolver.GetService(typeof(Query)).As<Query>();

        }
    }
}
