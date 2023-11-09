using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspdotnetCommonPackages
{
    public static partial class CollectionExtensions
    {
        public static T FirstOrDefaultNull<T>(this ICollection<T> source)
        {
            if (source == null || source.Count == 0)
                return default;

            return source.First();
        }

        public static List<TValue> ToList<TId, TValue>(this Dictionary<TId, List<TValue>> input)
        {
            var result = new List<TValue>();

            foreach(var item in input)
            {
                result.AddRange(item.Value);
            }

            return result;
        }
    }
}
