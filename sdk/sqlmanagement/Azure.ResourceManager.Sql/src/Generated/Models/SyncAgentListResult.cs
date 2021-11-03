// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of sync agents. </summary>
    internal partial class SyncAgentListResult
    {
        /// <summary> Initializes a new instance of SyncAgentListResult. </summary>
        internal SyncAgentListResult()
        {
            Value = new ChangeTrackingList<SyncAgentData>();
        }

        /// <summary> Initializes a new instance of SyncAgentListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SyncAgentListResult(IReadOnlyList<SyncAgentData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SyncAgentData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
