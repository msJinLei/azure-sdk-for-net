// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using SqlManagementClient;

namespace SqlManagementClient.Models
{
    /// <summary> Creates or updates an extended database&apos;s blob auditing policy. </summary>
    public partial class ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation : Operation<ExtendedDatabaseBlobAuditingPolicy>
    {
        private readonly OperationOrResponseInternals<ExtendedDatabaseBlobAuditingPolicy> _operation;

        /// <summary> Initializes a new instance of ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation for mocking. </summary>
        protected ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation()
        {
        }

        internal ExtendedDatabaseBlobAuditingPolicyCreateOrUpdateOperation(ArmResource operationsBase, Response<ExtendedDatabaseBlobAuditingPolicyData> response)
        {
            _operation = new OperationOrResponseInternals<ExtendedDatabaseBlobAuditingPolicy>(Response.FromValue(new ExtendedDatabaseBlobAuditingPolicy(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ExtendedDatabaseBlobAuditingPolicy Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExtendedDatabaseBlobAuditingPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ExtendedDatabaseBlobAuditingPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
