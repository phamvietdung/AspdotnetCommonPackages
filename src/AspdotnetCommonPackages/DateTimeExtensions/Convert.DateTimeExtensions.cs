using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AspdotnetCommonPackages
{
    /// <summary>
    /// Every thing you need when convert to DateTime
    /// </summary>
    public static partial class DatetimeExtensions
    {

        /// <summary>
        /// https://lonewolfonline.net/list-net-culture-country-codes/
        /// If cultureInfo is not set, we'll use CultureInfo.CurrentCulture as default
        /// </summary>
        /// <param name="source"></param>
        /// <param name="cultureInfo">Use CultureInfo.CurrentCulture as default</param>
        /// <returns></returns>
        public static KeyValuePair<string, DateTime> GetParseableToDateTimeFormat(this string source, CultureInfo cultureInfo = null)
        {
            Dictionary<string, DateTime> parseable = new Dictionary<string, DateTime>();

            cultureInfo = cultureInfo.GetDefaultValueIfNull(CultureInfo.CurrentCulture);

            DateTimeFormatInfo dtfi = CultureInfo.GetCultureInfo(cultureInfo.Name).DateTimeFormat;

            Type typ = dtfi.GetType();

            PropertyInfo[] props = typ.GetProperties();

            foreach (var prop in props)
            {
                // Is this a format pattern-related property?
                if (prop.Name.Contains("Pattern"))
                {
                    string fmt = prop.GetValue(dtfi, null).ToString();

                    DateTime tp = new DateTime();

                    if (DateTime.TryParseExact(source, fmt, cultureInfo, DateTimeStyles.None, out tp))
                        parseable.Add(fmt, tp);
 
                }
            }

            return parseable.FirstOrDefaultNull();

        }
        public static DateTime FromString(this string source)
        {
            throw new NotImplementedException();
        }
    }
}
