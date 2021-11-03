// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SqlManagementClient.Models
{
    public partial class PrivateLinkServiceConnectionStateProperty : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("description");
            writer.WriteStringValue(Description);
            writer.WriteEndObject();
        }

        internal static PrivateLinkServiceConnectionStateProperty DeserializePrivateLinkServiceConnectionStateProperty(JsonElement element)
        {
            PrivateLinkServiceConnectionStateStatus status = default;
            string description = default;
            Optional<PrivateLinkServiceConnectionStateActionsRequire> actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = new PrivateLinkServiceConnectionStateStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    actionsRequired = new PrivateLinkServiceConnectionStateActionsRequire(property.Value.GetString());
                    continue;
                }
            }
            return new PrivateLinkServiceConnectionStateProperty(status, description, Optional.ToNullable(actionsRequired));
        }
    }
}
