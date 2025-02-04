// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class OrdinalResolution
    {
        internal static OrdinalResolution DeserializeOrdinalResolution(JsonElement element)
        {
            string offset = default;
            RelativeTo relativeTo = default;
            string value = default;
            ResolutionKind resolutionKind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offset"))
                {
                    offset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("relativeTo"))
                {
                    relativeTo = new RelativeTo(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resolutionKind"))
                {
                    resolutionKind = new ResolutionKind(property.Value.GetString());
                    continue;
                }
            }
            return new OrdinalResolution(resolutionKind, offset, relativeTo, value);
        }
    }
}
