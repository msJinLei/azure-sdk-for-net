// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SqlManagementClient.Models
{
    internal static partial class AutoExecuteStatusExtensions
    {
        public static string ToSerialString(this AutoExecuteStatus value) => value switch
        {
            AutoExecuteStatus.Enabled => "Enabled",
            AutoExecuteStatus.Disabled => "Disabled",
            AutoExecuteStatus.Default => "Default",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoExecuteStatus value.")
        };

        public static AutoExecuteStatus ToAutoExecuteStatus(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return AutoExecuteStatus.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return AutoExecuteStatus.Disabled;
            if (string.Equals(value, "Default", StringComparison.InvariantCultureIgnoreCase)) return AutoExecuteStatus.Default;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutoExecuteStatus value.");
        }
    }
}
