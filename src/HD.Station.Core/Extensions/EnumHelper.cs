using HD.Station.Faults;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace HD.Station
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class EnumHelper
    {
        /// <summary>
        /// Convert and ErrorCode to ToFault
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static Fault ToFault(this ErrorCode error)
        {
            return new Fault
            {
                Code = error,
                Description = error.GetAttribute<DescriptionAttribute>()?.Description,
                HttpStatusCode = error.GetAttribute<HttpStatusCodeAttribute>()?.Code
            };
        }

        public static int ToEventId(this ErrorCode error)
        {
            var attribute = error.GetAttribute<ErrorCodeAttribute>();
            return attribute?.ToEventId() ?? 0;
        }

        /// <summary>
        /// Retrieve the attribute apply to an enum value
        /// </summary>
        /// <typeparam name="TAttribute">The attribute type need to retrieve</typeparam>
        /// <param name="value">The enum value</param>
        /// <returns></returns>
        public static TAttribute GetAttribute<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            return value.GetType()
                .GetTypeInfo()
                .GetField(value.ToString())
                .GetCustomAttribute<TAttribute>();
        }

        /// <summary>
        /// Retrieve the all attributes of special type apply to an enum value
        /// </summary>
        /// <typeparam name="TAttribute">The attribute type need to retrieve</typeparam>
        /// <param name="value">The enum value</param>
        /// <returns>The list attributes of special type apply to enum value</returns>
        public static IEnumerable<TAttribute> GetAttributes<TAttribute>(this Enum value) where TAttribute : Attribute
        {
            return value.GetType()
                .GetTypeInfo()
                .GetField(value.ToString())
                .GetCustomAttributes<TAttribute>();
        }
    }
}