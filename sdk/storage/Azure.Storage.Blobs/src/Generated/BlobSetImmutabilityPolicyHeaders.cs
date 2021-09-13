// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;
using Azure.Storage.Blobs.Models;

namespace Azure.Storage.Blobs
{
    internal partial class BlobSetImmutabilityPolicyHeaders
    {
        private readonly Response _response;
        public BlobSetImmutabilityPolicyHeaders(Response response)
        {
            _response = response;
        }
        /// <summary> Indicates the version of the Blob service used to execute the request. This header is returned for requests made against version 2009-09-19 and above. </summary>
        public string Version => _response.Headers.TryGetValue("x-ms-version", out string value) ? value : null;
        /// <summary> Indicates the time the immutability policy will expire. </summary>
        public DateTimeOffset? ImmutabilityPolicyExpiry => _response.Headers.TryGetValue("x-ms-immutability-policy-until-date", out DateTimeOffset? value) ? value : null;
        /// <summary> Indicates immutability policy mode. </summary>
        public BlobImmutabilityPolicyMode? ImmutabilityPolicyMode => _response.Headers.TryGetValue("x-ms-immutability-policy-mode", out string value) ? value.ToBlobImmutabilityPolicyMode() : null;
    }
}
