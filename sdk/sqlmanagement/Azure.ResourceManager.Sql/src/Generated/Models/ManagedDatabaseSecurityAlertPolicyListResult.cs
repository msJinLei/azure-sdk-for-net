// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of the managed database&apos;s security alert policies. </summary>
    internal partial class ManagedDatabaseSecurityAlertPolicyListResult
    {
        /// <summary> Initializes a new instance of ManagedDatabaseSecurityAlertPolicyListResult. </summary>
        internal ManagedDatabaseSecurityAlertPolicyListResult()
        {
            Value = new ChangeTrackingList<ManagedDatabaseSecurityAlertPolicyData>();
        }

        /// <summary> Initializes a new instance of ManagedDatabaseSecurityAlertPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal ManagedDatabaseSecurityAlertPolicyListResult(IReadOnlyList<ManagedDatabaseSecurityAlertPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedDatabaseSecurityAlertPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
