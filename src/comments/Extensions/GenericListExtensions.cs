using System.Collections.Generic;
using System.Linq;

namespace TimeSavers.VS.Comments.GenericListExtensions
{
    public static class GenericListExtensions
    {
        public static List<T> AsList<T>(this IEnumerable<T> source)
        {
            var list = source as List<T>;
            if (list == null)
                return source.ToList();

            return list;
        }
    }
}