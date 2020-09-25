using System.Collections.Generic;
using System.Linq;

using GridWebApp.Models.Interfaces;

namespace GridWebApp.Data
{
    public static class DataExtension
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> data) where T : IModel
        {
            return data.GroupBy(q => q.Id).Select(q => q.First());
        }
    }
}