// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class EventHubCompatibleEndpointProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionTimeInDays))
            {
                writer.WritePropertyName("retentionTimeInDays"u8);
                writer.WriteNumberValue(RetentionTimeInDays.Value);
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            writer.WriteEndObject();
        }

        internal static EventHubCompatibleEndpointProperties DeserializeEventHubCompatibleEndpointProperties(JsonElement element)
        {
            Optional<long> retentionTimeInDays = default;
            Optional<int> partitionCount = default;
            Optional<IReadOnlyList<string>> partitionIds = default;
            Optional<string> path = default;
            Optional<string> endpoint = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    retentionTimeInDays = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("partitionCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    partitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("partitionIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    partitionIds = array;
                    continue;
                }
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
            }
            return new EventHubCompatibleEndpointProperties(Optional.ToNullable(retentionTimeInDays), Optional.ToNullable(partitionCount), Optional.ToList(partitionIds), path.Value, endpoint.Value);
        }
    }
}
