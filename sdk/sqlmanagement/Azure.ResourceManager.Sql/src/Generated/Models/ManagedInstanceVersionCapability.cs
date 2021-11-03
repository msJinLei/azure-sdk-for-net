// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace SqlManagementClient.Models
{
    /// <summary> The managed instance capability. </summary>
    public partial class ManagedInstanceVersionCapability
    {
        /// <summary> Initializes a new instance of ManagedInstanceVersionCapability. </summary>
        internal ManagedInstanceVersionCapability()
        {
            SupportedEditions = new ChangeTrackingList<ManagedInstanceEditionCapability>();
            SupportedInstancePoolEditions = new ChangeTrackingList<InstancePoolEditionCapability>();
        }

        /// <summary> Initializes a new instance of ManagedInstanceVersionCapability. </summary>
        /// <param name="name"> The server version name. </param>
        /// <param name="supportedEditions"> The list of supported managed instance editions. </param>
        /// <param name="supportedInstancePoolEditions"> The list of supported instance pool editions. </param>
        /// <param name="status"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        internal ManagedInstanceVersionCapability(string name, IReadOnlyList<ManagedInstanceEditionCapability> supportedEditions, IReadOnlyList<InstancePoolEditionCapability> supportedInstancePoolEditions, CapabilityStatus? status, string reason)
        {
            Name = name;
            SupportedEditions = supportedEditions;
            SupportedInstancePoolEditions = supportedInstancePoolEditions;
            Status = status;
            Reason = reason;
        }

        /// <summary> The server version name. </summary>
        public string Name { get; }
        /// <summary> The list of supported managed instance editions. </summary>
        public IReadOnlyList<ManagedInstanceEditionCapability> SupportedEditions { get; }
        /// <summary> The list of supported instance pool editions. </summary>
        public IReadOnlyList<InstancePoolEditionCapability> SupportedInstancePoolEditions { get; }
        /// <summary> The status of the capability. </summary>
        public CapabilityStatus? Status { get; }
        /// <summary> The reason for the capability not being available. </summary>
        public string Reason { get; }
    }
}
