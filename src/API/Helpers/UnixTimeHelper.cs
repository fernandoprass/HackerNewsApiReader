using System;

namespace API.Helpers
{
    /// <summary> The Unit Time helper </summary>
    public static class UnixTimeHelper
    {
        /// <summary> Convert Unix Time to Datetime
        /// </summary>
        /// <param name="unixTimeStamp">The unix timestamp</param>
        /// <returns>A datetime</returns>
        public static DateTime ToDatetime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp);
            return dateTime;
        }
    }
}
