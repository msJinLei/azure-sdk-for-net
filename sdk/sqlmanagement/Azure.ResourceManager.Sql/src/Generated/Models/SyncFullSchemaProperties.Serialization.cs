// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace SqlManagementClient.Models
{
    public partial class SyncFullSchemaProperties
    {
        internal static SyncFullSchemaProperties DeserializeSyncFullSchemaProperties(JsonElement element)
        {
            Optional<IReadOnlyList<SyncFullSchemaTable>> tables = default;
            Optional<DateTimeOffset> lastUpdateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SyncFullSchemaTable> array = new List<SyncFullSchemaTable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SyncFullSchemaTable.DeserializeSyncFullSchemaTable(item));
                    }
                    tables = array;
                    continue;
                }
                if (property.NameEquals("lastUpdateTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new SyncFullSchemaProperties(Optional.ToList(tables), Optional.ToNullable(lastUpdateTime));
        }
    }
}
