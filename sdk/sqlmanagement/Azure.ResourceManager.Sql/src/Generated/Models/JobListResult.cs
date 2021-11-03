// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> A list of jobs. </summary>
    internal partial class JobListResult
    {
        /// <summary> Initializes a new instance of JobListResult. </summary>
        internal JobListResult()
        {
            Value = new ChangeTrackingList<JobData>();
        }

        /// <summary> Initializes a new instance of JobListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobListResult(IReadOnlyList<JobData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<JobData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
