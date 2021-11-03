// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> The state of read-only routing. If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica in the same region. </summary>
    public readonly partial struct DatabaseReadScale : IEquatable<DatabaseReadScale>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseReadScale"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseReadScale(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static DatabaseReadScale Enabled { get; } = new DatabaseReadScale(EnabledValue);
        /// <summary> Disabled. </summary>
        public static DatabaseReadScale Disabled { get; } = new DatabaseReadScale(DisabledValue);
        /// <summary> Determines if two <see cref="DatabaseReadScale"/> values are the same. </summary>
        public static bool operator ==(DatabaseReadScale left, DatabaseReadScale right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseReadScale"/> values are not the same. </summary>
        public static bool operator !=(DatabaseReadScale left, DatabaseReadScale right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DatabaseReadScale"/>. </summary>
        public static implicit operator DatabaseReadScale(string value) => new DatabaseReadScale(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseReadScale other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseReadScale other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
