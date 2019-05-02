// From https://github.com/dotnet/corefxlab
// https://github.com/dotnet/corefxlab/commit/e075d78df60452b68d212e3333fd3f37cd28d4f0
// Until they add this to .NET

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Boring
{
    /// <summary>
    /// Extension methods for <see cref="DateTime"/>.
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Gets a <see cref="Date"/> value that represents the date component of the current
        /// <see cref="DateTime"/> object.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> instance.</param>
        /// <returns>The <see cref="Date"/> value.</returns>
        public static Date GetDate(this DateTime dateTime)
        {
            return new Date((int)(dateTime.Ticks / TimeSpan.TicksPerDay));
        }

        /// <summary>
        /// Gets a <see cref="Time"/> value that represents the time component of the current
        /// <see cref="DateTime"/> object.
        /// </summary>
        /// <param name="dateTime">The <see cref="DateTime"/> instance.</param>
        /// <returns>The <see cref="Time"/> value.</returns>
        public static Time GetTime(this DateTime dateTime)
        {
            return new Time(dateTime.TimeOfDay.Ticks);
        }
    }
}
