// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Containers.ContainerRegistry;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry.Specialized
{
    [JsonConverter(typeof(OciManifestConverter))]
    public partial class OciManifest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config");
                writer.WriteObjectValue(Config);
            }
            if (Optional.IsCollectionDefined(Layers))
            {
                writer.WritePropertyName("layers");
                writer.WriteStartArray();
                foreach (var item in Layers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Annotations))
            {
                if (Annotations != null)
                {
                    writer.WritePropertyName("annotations");
                    writer.WriteObjectValue(Annotations);
                }
                else
                {
                    writer.WriteNull("annotations");
                }
            }
            writer.WriteEndObject();
        }

        internal static OciManifest DeserializeOciManifest(JsonElement element)
        {
            Optional<ArtifactBlobDescriptor> config = default;
            Optional<IList<ArtifactBlobDescriptor>> layers = default;
            Optional<Annotations> annotations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("config"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    config = ArtifactBlobDescriptor.DeserializeArtifactBlobDescriptor(property.Value);
                    continue;
                }
                if (property.NameEquals("layers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ArtifactBlobDescriptor> array = new List<ArtifactBlobDescriptor>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArtifactBlobDescriptor.DeserializeArtifactBlobDescriptor(item));
                    }
                    layers = array;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = ContainerRegistry.Annotations.DeserializeAnnotations(property.Value);
                    continue;
                }
            }
            return new OciManifest(config.Value, Optional.ToList(layers), annotations.Value);
        }

        internal partial class OciManifestConverter : JsonConverter<OciManifest>
        {
            public override void Write(Utf8JsonWriter writer, OciManifest model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override OciManifest Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeOciManifest(document.RootElement);
            }
        }
    }
}
