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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Updates a local network gateway tags. </summary>
    public partial class LocalNetworkGatewayUpdateTagsOperation : Operation<LocalNetworkGateway>
    {
        private readonly OperationOrResponseInternals<LocalNetworkGateway> _operation;

        /// <summary> Initializes a new instance of LocalNetworkGatewayUpdateTagsOperation for mocking. </summary>
        protected LocalNetworkGatewayUpdateTagsOperation()
        {
        }

        internal LocalNetworkGatewayUpdateTagsOperation(ArmResource operationsBase, Response<LocalNetworkGatewayData> response)
        {
            _operation = new OperationOrResponseInternals<LocalNetworkGateway>(Response.FromValue(new LocalNetworkGateway(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override LocalNetworkGateway Value => _operation.Value;

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
        public override ValueTask<Response<LocalNetworkGateway>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<LocalNetworkGateway>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
