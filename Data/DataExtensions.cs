using System.Collections.Generic;
using System.Linq;
using System;

using GridWebApp.Models.Interfaces;

namespace GridWebApp.Data
{
    public static class DataExtensions
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> data) where T : IModel
        {
            return data.GroupBy(q => q.Id).Select(q => q.First());
        }

        public static int CountByField<T>(this IEnumerable<T> data, Func<T, int> func) where T : IData
        {
            return data.Select(func).Sum();
        }
    }
}