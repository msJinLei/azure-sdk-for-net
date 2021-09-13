// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class Availability
    {
        internal static Availability DeserializeAvailability(JsonElement element)
        {
            Optional<DateTimeRange> range = default;
            Optional<TimeSpan> intervalSize = default;
            Optional<IReadOnlyDictionary<string, int>> distribution = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("range"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    range = DateTimeRange.DeserializeDateTimeRange(property.Value);
                    continue;
                }
                if (property.NameEquals("intervalSize"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    intervalSize = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("distribution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    distribution = dictionary;
                    continue;
                }
            }
            return new Availability(range.Value, Optional.ToNullable(intervalSize), Optional.ToDictionary(distribution));
        }
    }
}
