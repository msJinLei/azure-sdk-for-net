// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of target groups. </summary>
    internal partial class JobTargetGroupListResult
    {
        /// <summary> Initializes a new instance of JobTargetGroupListResult. </summary>
        internal JobTargetGroupListResult()
        {
            Value = new ChangeTrackingList<JobTargetGroupData>();
        }

        /// <summary> Initializes a new instance of JobTargetGroupListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobTargetGroupListResult(IReadOnlyList<JobTargetGroupData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<JobTargetGroupData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
