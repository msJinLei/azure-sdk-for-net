// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace SqlManagementClient.Models
{
    public partial class RecommendedActionMetricInfo
    {
        internal static RecommendedActionMetricInfo DeserializeRecommendedActionMetricInfo(JsonElement element)
        {
            Optional<string> metricName = default;
            Optional<string> unit = default;
            Optional<string> timeGrain = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<double> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricName"))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("unit"))
                {
                    unit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeGrain"))
                {
                    timeGrain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetDouble();
                    continue;
                }
            }
            return new RecommendedActionMetricInfo(metricName.Value, unit.Value, timeGrain.Value, Optional.ToNullable(startTime), Optional.ToNullable(value));
        }
    }
}
