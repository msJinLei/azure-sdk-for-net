// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SqlManagementClient.Models
{
    /// <summary> The PrivateLinkServiceConnectionStateProperty. </summary>
    public partial class PrivateLinkServiceConnectionStateProperty
    {
        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="description"/> is null. </exception>
        public PrivateLinkServiceConnectionStateProperty(PrivateLinkServiceConnectionStateStatus status, string description)
        {
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            Status = status;
            Description = description;
        }

        /// <summary> Initializes a new instance of PrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        internal PrivateLinkServiceConnectionStateProperty(PrivateLinkServiceConnectionStateStatus status, string description, PrivateLinkServiceConnectionStateActionsRequire? actionsRequired)
        {
            Status = status;
            Description = description;
            ActionsRequired = actionsRequired;
        }

        /// <summary> The private link service connection status. </summary>
        public PrivateLinkServiceConnectionStateStatus Status { get; set; }
        /// <summary> The private link service connection description. </summary>
        public string Description { get; set; }
        /// <summary> The actions required for private link service connection. </summary>
        public PrivateLinkServiceConnectionStateActionsRequire? ActionsRequired { get; }
    }
}
