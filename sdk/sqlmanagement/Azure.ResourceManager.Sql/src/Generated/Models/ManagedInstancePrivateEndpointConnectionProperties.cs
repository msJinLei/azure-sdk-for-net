// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Resources.Models;

namespace SqlManagementClient.Models
{
    /// <summary> Properties of a private endpoint connection. </summary>
    public partial class ManagedInstancePrivateEndpointConnectionProperties
    {
        /// <summary> Initializes a new instance of ManagedInstancePrivateEndpointConnectionProperties. </summary>
        internal ManagedInstancePrivateEndpointConnectionProperties()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstancePrivateEndpointConnectionProperties. </summary>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="privateLinkServiceConnectionState"> Connection State of the Private Endpoint Connection. </param>
        /// <param name="provisioningState"> State of the Private Endpoint Connection. </param>
        internal ManagedInstancePrivateEndpointConnectionProperties(WritableSubResource privateEndpoint, ManagedInstancePrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState, string provisioningState)
        {
            PrivateEndpoint = privateEndpoint;
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        public WritableSubResource PrivateEndpoint { get; }
        /// <summary> Connection State of the Private Endpoint Connection. </summary>
        public ManagedInstancePrivateLinkServiceConnectionStateProperty PrivateLinkServiceConnectionState { get; }
        /// <summary> State of the Private Endpoint Connection. </summary>
        public string ProvisioningState { get; }
    }
}
