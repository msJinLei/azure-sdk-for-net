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
    /// <summary> The Get VpnclientIpsecParameters operation retrieves information about the vpnclient ipsec policy for P2S client of virtual network gateway in the specified resource group through Network resource provider. </summary>
    public partial class VirtualNetworkGatewayGetVpnclientIpsecParametersOperation : Operation<VpnClientIPsecParameters>, IOperationSource<VpnClientIPsecParameters>
    {
        private readonly OperationInternals<VpnClientIPsecParameters> _operation;

        /// <summary> Initializes a new instance of VirtualNetworkGatewayGetVpnclientIpsecParametersOperation for mocking. </summary>
        protected VirtualNetworkGatewayGetVpnclientIpsecParametersOperation()
        {
        }

        internal VirtualNetworkGatewayGetVpnclientIpsecParametersOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VpnClientIPsecParameters>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "VirtualNetworkGatewayGetVpnclientIpsecParametersOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VpnClientIPsecParameters Value => _operation.Value;

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
        public override ValueTask<Response<VpnClientIPsecParameters>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VpnClientIPsecParameters>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VpnClientIPsecParameters IOperationSource<VpnClientIPsecParameters>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return VpnClientIPsecParameters.DeserializeVpnClientIPsecParameters(document.RootElement);
        }

        async ValueTask<VpnClientIPsecParameters> IOperationSource<VpnClientIPsecParameters>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return VpnClientIPsecParameters.DeserializeVpnClientIPsecParameters(document.RootElement);
        }
    }
}
