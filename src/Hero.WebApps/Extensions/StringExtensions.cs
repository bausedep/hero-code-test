using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hero.WebApps.Extensions
{
    public static class StringExtensions
    {

        public static string ToJsonDateTime(this string CheckInDate, string CheckInTime) => $"{CheckInDate}T{CheckInTime}:00";
    }
}
