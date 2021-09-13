// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Checks whether the subscription is visible to private link service. </summary>
    public partial class PrivateLinkServiceCheckPrivateLinkServiceVisibilityOperation : Operation<PrivateLinkServiceVisibility>, IOperationSource<PrivateLinkServiceVisibility>
    {
        private readonly OperationInternals<PrivateLinkServiceVisibility> _operation;

        /// <summary> Initializes a new instance of PrivateLinkServiceCheckPrivateLinkServiceVisibilityOperation for mocking. </summary>
        protected PrivateLinkServiceCheckPrivateLinkServiceVisibilityOperation()
        {
        }

        internal PrivateLinkServiceCheckPrivateLinkServiceVisibilityOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<PrivateLinkServiceVisibility>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "PrivateLinkServiceCheckPrivateLinkServiceVisibilityOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override PrivateLinkServiceVisibility Value => _operation.Value;

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
        public override ValueTask<Response<PrivateLinkServiceVisibility>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<PrivateLinkServiceVisibility>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        PrivateLinkServiceVisibility IOperationSource<PrivateLinkServiceVisibility>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return PrivateLinkServiceVisibility.DeserializePrivateLinkServiceVisibility(document.RootElement);
        }

        async ValueTask<PrivateLinkServiceVisibility> IOperationSource<PrivateLinkServiceVisibility>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return PrivateLinkServiceVisibility.DeserializePrivateLinkServiceVisibility(document.RootElement);
        }
    }
}
