using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore_Api.Models
{
    public class EasyStoreSchema: Schema
    {
        public EasyStoreSchema(Func<Type, GraphType> resolveType)
           : base(resolveType)
        {
            Query = (EasyStoreQuery)resolveType(typeof(EasyStoreQuery));
        }
    }
}
