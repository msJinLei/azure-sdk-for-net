// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Communication.CallingServer
{
    /// <summary> The audio routing mode. </summary>
    public readonly partial struct AudioRoutingMode : IEquatable<AudioRoutingMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AudioRoutingMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AudioRoutingMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneToOneValue = "oneToOne";
        private const string MulticastValue = "multicast";

        /// <summary> oneToOne. </summary>
        public static AudioRoutingMode OneToOne { get; } = new AudioRoutingMode(OneToOneValue);
        /// <summary> multicast. </summary>
        public static AudioRoutingMode Multicast { get; } = new AudioRoutingMode(MulticastValue);
        /// <summary> Determines if two <see cref="AudioRoutingMode"/> values are the same. </summary>
        public static bool operator ==(AudioRoutingMode left, AudioRoutingMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AudioRoutingMode"/> values are not the same. </summary>
        public static bool operator !=(AudioRoutingMode left, AudioRoutingMode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AudioRoutingMode"/>. </summary>
        public static implicit operator AudioRoutingMode(string value) => new AudioRoutingMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AudioRoutingMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AudioRoutingMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
