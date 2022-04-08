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
    }
}
