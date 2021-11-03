// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> Replication state (PENDING, SEEDING, CATCHUP, SUSPENDED). </summary>
    public readonly partial struct ReplicationState : IEquatable<ReplicationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ReplicationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ReplicationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "PENDING";
        private const string SeedingValue = "SEEDING";
        private const string CatchUPValue = "CATCH_UP";
        private const string SuspendedValue = "SUSPENDED";

        /// <summary> PENDING. </summary>
        public static ReplicationState Pending { get; } = new ReplicationState(PendingValue);
        /// <summary> SEEDING. </summary>
        public static ReplicationState Seeding { get; } = new ReplicationState(SeedingValue);
        /// <summary> CATCH_UP. </summary>
        public static ReplicationState CatchUP { get; } = new ReplicationState(CatchUPValue);
        /// <summary> SUSPENDED. </summary>
        public static ReplicationState Suspended { get; } = new ReplicationState(SuspendedValue);
        /// <summary> Determines if two <see cref="ReplicationState"/> values are the same. </summary>
        public static bool operator ==(ReplicationState left, ReplicationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ReplicationState"/> values are not the same. </summary>
        public static bool operator !=(ReplicationState left, ReplicationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ReplicationState"/>. </summary>
        public static implicit operator ReplicationState(string value) => new ReplicationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ReplicationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ReplicationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
