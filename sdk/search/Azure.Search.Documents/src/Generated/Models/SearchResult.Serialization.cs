// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchResult
    {
        internal static SearchResult DeserializeSearchResult(JsonElement element)
        {
            double searchScore = default;
            Optional<double?> searchRerankerScore = default;
            Optional<IReadOnlyDictionary<string, IList<string>>> searchHighlights = default;
            Optional<IReadOnlyList<CaptionResult>> searchCaptions = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"))
                {
                    searchScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.rerankerScore"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchRerankerScore = null;
                        continue;
                    }
                    searchRerankerScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.highlights"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<string> array = new List<string>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(item.GetString());
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    searchHighlights = dictionary;
                    continue;
                }
                if (property.NameEquals("@search.captions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        searchCaptions = null;
                        continue;
                    }
                    List<CaptionResult> array = new List<CaptionResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CaptionResult.DeserializeCaptionResult(item));
                    }
                    searchCaptions = array;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SearchResult(searchScore, Optional.ToNullable(searchRerankerScore), Optional.ToDictionary(searchHighlights), Optional.ToList(searchCaptions), additionalProperties);
        }
    }
}
