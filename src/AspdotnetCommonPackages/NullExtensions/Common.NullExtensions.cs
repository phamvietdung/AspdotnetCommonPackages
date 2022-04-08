using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspdotnetCommonPackages
{
    public static partial class NullExtensions
    {
        public static Boolean IsNull<T>(this T source){
            if (source == null)
                return true;

            return false;
        }

        public static Boolean IsNotNull<T>(this T source)
        {
            return source.IsNull() ? false : true;
        }

        public static Boolean IsNotNulAndNotDefault<T>(this T source)
        {
            return source.IsNotNull() && source.IsNotDefault();
        }

        public static Boolean IsNotDefault<T>(this T source)
        {
            return !EqualityComparer<T>.Default.Equals(source, default(T));
        }

        public static Boolean IsNotNullAndHaveData<T>(this ICollection<T> sources)
        {
            if (sources.IsNull())
                return false;

            return sources.Count() > 0;
        }

        public static T GetDefaultValueIfNull<T>(this T source, T defaultValue = default(T))
        {
            if (source.IsNull())
                return defaultValue;

            return source;
        }

    }
}
