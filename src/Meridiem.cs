// From https://github.com/dotnet/corefxlab
// https://github.com/dotnet/corefxlab/commit/e075d78df60452b68d212e3333fd3f37cd28d4f0
// Until they add this to .NET

// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace Boring
{
    /// <summary>
    /// Provides an enumeration of AM or PM to support 12-hour clock values in the <see cref="Time"/> type.
    /// </summary>
    /// <remarks>
    /// Though commonly used in English, these abbreviations derive from Latin.
    /// AM is an abbreviation for "Ante Meridiem", meaning "before mid-day".
    /// PM is an abbreviation for "Post Meridiem", meaning "after mid-day".
    /// </remarks>
    public enum Meridiem
    {
        AM,
        PM
    }
}