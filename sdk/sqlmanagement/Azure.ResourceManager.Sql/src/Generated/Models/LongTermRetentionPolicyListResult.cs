// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of long term retention policies. </summary>
    internal partial class LongTermRetentionPolicyListResult
    {
        /// <summary> Initializes a new instance of LongTermRetentionPolicyListResult. </summary>
        internal LongTermRetentionPolicyListResult()
        {
            Value = new ChangeTrackingList<LongTermRetentionPolicyData>();
        }

        /// <summary> Initializes a new instance of LongTermRetentionPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal LongTermRetentionPolicyListResult(IReadOnlyList<LongTermRetentionPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<LongTermRetentionPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
