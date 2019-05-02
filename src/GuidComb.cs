using System;

namespace Boring
{
    public static class GuidComb
    {
        private static DateTime _msBaseDate = new DateTime(1900, 1, 1);
        private static readonly long MsBaseDateTicks = _msBaseDate.Ticks;

        /// <summary>
        /// Genera un nuevo Guid destinado a su utilización como clave primaria de tablas de bases de datos relacionales
        /// Source: http://www.ideablade.com/DevForceClassic/TechTips/techtip_improve_your_guid.htm
        /// </summary>
        /// <returns>El Guid generado</returns>
        public static Guid NewComb()
        {
            var guidArray = Guid.NewGuid().ToByteArray();
            var now = DateTime.UtcNow;

            // Texts the days and milliseconds which will be used to build the byte string
            var days = new TimeSpan(now.Ticks - MsBaseDateTicks);
            var msecs = new TimeSpan(now.Ticks - (new DateTime(now.Year, now.Month, now.Day).Ticks));

            // Convert days and msecs to byte arrays
            // SQL Server is accurate to 1/300th of a millisecond
            // .NET DateTime ticks are in milliseconds
            // so we divide .NET ticks by 3.333333
            var daysArray = BitConverter.GetBytes(days.Days);
            var msecsArray = BitConverter.GetBytes((long)(msecs.TotalMilliseconds / 3.333333));

            // Reverse the bytes to match SQL Servers ordering
            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);

            // Copy the bytes into the guid
            Array.Copy(daysArray, daysArray.Length - 2, guidArray, guidArray.Length - 6, 2);
            Array.Copy(msecsArray, msecsArray.Length - 4, guidArray, guidArray.Length - 4, 4);

            return new Guid(guidArray);
        }

        /// <summary>Extract datetime part of a Guid.Comb.</summary>
        /// <remarks>
        /// Please note: This function returns the date in Universal Time;
        /// you may want to convert back to local time with
        /// <code>GetDateFromComb(aGuidComb).ToLocalTime();</code>
        /// </remarks>
        public static DateTime GetDateFromComb(Guid guid)
        {
            var daysArray = new byte[4];
            var msecsArray = new byte[4];
            var guidArray = guid.ToByteArray();

            // Copy the date parts of the guid to the respective byte arrays.
            Array.Copy(guidArray, guidArray.Length - 6, daysArray, 2, 2);
            Array.Copy(guidArray, guidArray.Length - 4, msecsArray, 0, 4);

            // Reverse the arrays to put them into the appropriate order
            Array.Reverse(daysArray);
            Array.Reverse(msecsArray);

            // Convert the bytes to ints
            var days = BitConverter.ToInt32(daysArray, 0);
            var msecs = BitConverter.ToInt32(msecsArray, 0);

            var date = _msBaseDate.AddDays(days);
            date = date.AddMilliseconds(msecs * 3.333333);

            return date;
        }

    }
}

