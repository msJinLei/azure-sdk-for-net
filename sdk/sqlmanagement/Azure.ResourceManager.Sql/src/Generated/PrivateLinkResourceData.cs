// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager;
using Azure.ResourceManager.Models;
using SqlManagementClient.Models;

namespace SqlManagementClient
{
    /// <summary> A class representing the PrivateLinkResource data model. </summary>
    public partial class PrivateLinkResourceData : Resource
    {
        /// <summary> Initializes a new instance of PrivateLinkResourceData. </summary>
        public PrivateLinkResourceData()
        {
        }

        /// <summary> Initializes a new instance of PrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="properties"> The private link resource group id. </param>
        internal PrivateLinkResourceData(ResourceIdentifier id, string name, ResourceType type, PrivateLinkResourceProperties properties) : base(id, name, type)
        {
            Properties = properties;
        }

        /// <summary> The private link resource group id. </summary>
        public PrivateLinkResourceProperties Properties { get; }
    }
}
