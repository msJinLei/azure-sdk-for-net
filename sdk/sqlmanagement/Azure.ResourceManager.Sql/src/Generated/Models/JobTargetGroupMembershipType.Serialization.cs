// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SqlManagementClient.Models
{
    internal static partial class JobTargetGroupMembershipTypeExtensions
    {
        public static string ToSerialString(this JobTargetGroupMembershipType value) => value switch
        {
            JobTargetGroupMembershipType.Include => "Include",
            JobTargetGroupMembershipType.Exclude => "Exclude",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobTargetGroupMembershipType value.")
        };

        public static JobTargetGroupMembershipType ToJobTargetGroupMembershipType(this string value)
        {
            if (string.Equals(value, "Include", StringComparison.InvariantCultureIgnoreCase)) return JobTargetGroupMembershipType.Include;
            if (string.Equals(value, "Exclude", StringComparison.InvariantCultureIgnoreCase)) return JobTargetGroupMembershipType.Exclude;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown JobTargetGroupMembershipType value.");
        }
    }
}
