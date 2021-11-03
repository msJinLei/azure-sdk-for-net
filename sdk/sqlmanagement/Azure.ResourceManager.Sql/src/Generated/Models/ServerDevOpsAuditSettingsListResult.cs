// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of server DevOps audit settings. </summary>
    internal partial class ServerDevOpsAuditSettingsListResult
    {
        /// <summary> Initializes a new instance of ServerDevOpsAuditSettingsListResult. </summary>
        internal ServerDevOpsAuditSettingsListResult()
        {
            Value = new ChangeTrackingList<ServerDevOpsAuditingSettingsData>();
        }

        /// <summary> Initializes a new instance of ServerDevOpsAuditSettingsListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ServerDevOpsAuditSettingsListResult(IReadOnlyList<ServerDevOpsAuditingSettingsData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ServerDevOpsAuditingSettingsData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
