// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> The license type. Possible values are &apos;LicenseIncluded&apos; (price for SQL license is included) and &apos;BasePrice&apos; (without SQL license price). </summary>
    public readonly partial struct InstancePoolLicenseType : IEquatable<InstancePoolLicenseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InstancePoolLicenseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InstancePoolLicenseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LicenseIncludedValue = "LicenseIncluded";
        private const string BasePriceValue = "BasePrice";

        /// <summary> LicenseIncluded. </summary>
        public static InstancePoolLicenseType LicenseIncluded { get; } = new InstancePoolLicenseType(LicenseIncludedValue);
        /// <summary> BasePrice. </summary>
        public static InstancePoolLicenseType BasePrice { get; } = new InstancePoolLicenseType(BasePriceValue);
        /// <summary> Determines if two <see cref="InstancePoolLicenseType"/> values are the same. </summary>
        public static bool operator ==(InstancePoolLicenseType left, InstancePoolLicenseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InstancePoolLicenseType"/> values are not the same. </summary>
        public static bool operator !=(InstancePoolLicenseType left, InstancePoolLicenseType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InstancePoolLicenseType"/>. </summary>
        public static implicit operator InstancePoolLicenseType(string value) => new InstancePoolLicenseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InstancePoolLicenseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InstancePoolLicenseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
