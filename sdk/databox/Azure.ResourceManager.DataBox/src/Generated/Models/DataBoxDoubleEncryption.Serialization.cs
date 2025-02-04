// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    internal static partial class DataBoxDoubleEncryptionExtensions
    {
        public static string ToSerialString(this DataBoxDoubleEncryption value) => value switch
        {
            DataBoxDoubleEncryption.Enabled => "Enabled",
            DataBoxDoubleEncryption.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataBoxDoubleEncryption value.")
        };

        public static DataBoxDoubleEncryption ToDataBoxDoubleEncryption(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return DataBoxDoubleEncryption.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return DataBoxDoubleEncryption.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataBoxDoubleEncryption value.");
        }
    }
}
