// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace SqlManagementClient.Models
{
    /// <summary> Day of maintenance window. </summary>
    public readonly partial struct DayOfWeek : IEquatable<DayOfWeek>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DayOfWeek"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DayOfWeek(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SundayValue = "Sunday";
        private const string MondayValue = "Monday";
        private const string TuesdayValue = "Tuesday";
        private const string WednesdayValue = "Wednesday";
        private const string ThursdayValue = "Thursday";
        private const string FridayValue = "Friday";
        private const string SaturdayValue = "Saturday";

        /// <summary> Sunday. </summary>
        public static DayOfWeek Sunday { get; } = new DayOfWeek(SundayValue);
        /// <summary> Monday. </summary>
        public static DayOfWeek Monday { get; } = new DayOfWeek(MondayValue);
        /// <summary> Tuesday. </summary>
        public static DayOfWeek Tuesday { get; } = new DayOfWeek(TuesdayValue);
        /// <summary> Wednesday. </summary>
        public static DayOfWeek Wednesday { get; } = new DayOfWeek(WednesdayValue);
        /// <summary> Thursday. </summary>
        public static DayOfWeek Thursday { get; } = new DayOfWeek(ThursdayValue);
        /// <summary> Friday. </summary>
        public static DayOfWeek Friday { get; } = new DayOfWeek(FridayValue);
        /// <summary> Saturday. </summary>
        public static DayOfWeek Saturday { get; } = new DayOfWeek(SaturdayValue);
        /// <summary> Determines if two <see cref="DayOfWeek"/> values are the same. </summary>
        public static bool operator ==(DayOfWeek left, DayOfWeek right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DayOfWeek"/> values are not the same. </summary>
        public static bool operator !=(DayOfWeek left, DayOfWeek right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DayOfWeek"/>. </summary>
        public static implicit operator DayOfWeek(string value) => new DayOfWeek(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DayOfWeek other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DayOfWeek other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
