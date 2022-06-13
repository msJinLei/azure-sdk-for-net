// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class DateAfterModification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DaysAfterModificationGreaterThan))
            {
                writer.WritePropertyName("daysAfterModificationGreaterThan");
                writer.WriteNumberValue(DaysAfterModificationGreaterThan.Value);
            }
            if (Optional.IsDefined(DaysAfterLastAccessTimeGreaterThan))
            {
                writer.WritePropertyName("daysAfterLastAccessTimeGreaterThan");
                writer.WriteNumberValue(DaysAfterLastAccessTimeGreaterThan.Value);
            }
            if (Optional.IsDefined(DaysAfterLastTierChangeGreaterThan))
            {
                writer.WritePropertyName("daysAfterLastTierChangeGreaterThan");
                writer.WriteNumberValue(DaysAfterLastTierChangeGreaterThan.Value);
            }
            if (Optional.IsDefined(DaysAfterCreationGreaterThan))
            {
                writer.WritePropertyName("daysAfterCreationGreaterThan");
                writer.WriteNumberValue(DaysAfterCreationGreaterThan.Value);
            }
            writer.WriteEndObject();
        }

        internal static DateAfterModification DeserializeDateAfterModification(JsonElement element)
        {
            Optional<float> daysAfterModificationGreaterThan = default;
            Optional<float> daysAfterLastAccessTimeGreaterThan = default;
            Optional<float> daysAfterLastTierChangeGreaterThan = default;
            Optional<float> daysAfterCreationGreaterThan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daysAfterModificationGreaterThan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    daysAfterModificationGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("daysAfterLastAccessTimeGreaterThan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    daysAfterLastAccessTimeGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("daysAfterLastTierChangeGreaterThan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    daysAfterLastTierChangeGreaterThan = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("daysAfterCreationGreaterThan"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    daysAfterCreationGreaterThan = property.Value.GetSingle();
                    continue;
                }
            }
            return new DateAfterModification(Optional.ToNullable(daysAfterModificationGreaterThan), Optional.ToNullable(daysAfterLastAccessTimeGreaterThan), Optional.ToNullable(daysAfterLastTierChangeGreaterThan), Optional.ToNullable(daysAfterCreationGreaterThan));
        }
    }
}
