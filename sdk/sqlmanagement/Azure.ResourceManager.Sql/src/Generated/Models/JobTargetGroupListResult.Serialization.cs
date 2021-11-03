// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    internal partial class JobTargetGroupListResult
    {
        internal static JobTargetGroupListResult DeserializeJobTargetGroupListResult(JsonElement element)
        {
            Optional<IReadOnlyList<JobTargetGroupData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<JobTargetGroupData> array = new List<JobTargetGroupData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JobTargetGroupData.DeserializeJobTargetGroupData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new JobTargetGroupListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
