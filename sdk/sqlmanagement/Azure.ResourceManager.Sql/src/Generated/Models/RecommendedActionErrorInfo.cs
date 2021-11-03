// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SqlManagementClient.Models
{
    /// <summary> Contains error information for an Azure SQL Database, Server or Elastic Pool Recommended Action. </summary>
    public partial class RecommendedActionErrorInfo
    {
        /// <summary> Initializes a new instance of RecommendedActionErrorInfo. </summary>
        internal RecommendedActionErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of RecommendedActionErrorInfo. </summary>
        /// <param name="errorCode"> Gets the reason why the recommended action was put to error state. e.g., DatabaseHasQdsOff, IndexAlreadyExists. </param>
        /// <param name="isRetryable"> Gets whether the error could be ignored and recommended action could be retried. Possible values are: Yes/No. </param>
        internal RecommendedActionErrorInfo(string errorCode, IsRetryable? isRetryable)
        {
            ErrorCode = errorCode;
            IsRetryable = isRetryable;
        }

        /// <summary> Gets the reason why the recommended action was put to error state. e.g., DatabaseHasQdsOff, IndexAlreadyExists. </summary>
        public string ErrorCode { get; }
        /// <summary> Gets whether the error could be ignored and recommended action could be retried. Possible values are: Yes/No. </summary>
        public IsRetryable? IsRetryable { get; }
    }
}
