// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> The response to a list firewall rules request. </summary>
    internal partial class FirewallRuleListResult
    {
        /// <summary> Initializes a new instance of FirewallRuleListResult. </summary>
        internal FirewallRuleListResult()
        {
            Value = new ChangeTrackingList<FirewallRuleData>();
        }

        /// <summary> Initializes a new instance of FirewallRuleListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal FirewallRuleListResult(IReadOnlyList<FirewallRuleData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<FirewallRuleData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
