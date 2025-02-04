// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualApplianceSite and their operations over a NetworkVirtualAppliance. </summary>
    public partial class VirtualApplianceSiteCollection : ArmCollection, IEnumerable<VirtualApplianceSite>, IAsyncEnumerable<VirtualApplianceSite>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly VirtualApplianceSitesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualApplianceSiteCollection"/> class for mocking. </summary>
        protected VirtualApplianceSiteCollection()
        {
        }

        /// <summary> Initializes a new instance of VirtualApplianceSiteCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualApplianceSiteCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualApplianceSitesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        IEnumerator<VirtualApplianceSite> IEnumerable<VirtualApplianceSite>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualApplianceSite> IAsyncEnumerable<VirtualApplianceSite>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => NetworkVirtualAppliance.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates the specified Network Virtual Appliance Site. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Site operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual VirtualApplianceSiteCreateOrUpdateOperation CreateOrUpdate(string siteName, VirtualApplianceSiteData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (siteName == null)
            {
                throw new ArgumentNullException(nameof(siteName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, siteName, parameters, cancellationToken);
                var operation = new VirtualApplianceSiteCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, siteName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified Network Virtual Appliance Site. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="parameters"> Parameters supplied to the create or update Network Virtual Appliance Site operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="siteName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<VirtualApplianceSiteCreateOrUpdateOperation> CreateOrUpdateAsync(string siteName, VirtualApplianceSiteData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (siteName == null)
            {
                throw new ArgumentNullException(nameof(siteName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, siteName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new VirtualApplianceSiteCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, siteName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualApplianceSite> Get(string siteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Get");
            scope.Start();
            try
            {
                if (siteName == null)
                {
                    throw new ArgumentNullException(nameof(siteName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualApplianceSite(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualApplianceSite>> GetAsync(string siteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.Get");
            scope.Start();
            try
            {
                if (siteName == null)
                {
                    throw new ArgumentNullException(nameof(siteName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualApplianceSite(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualApplianceSite> GetIfExists(string siteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                if (siteName == null)
                {
                    throw new ArgumentNullException(nameof(siteName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualApplianceSite>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualApplianceSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualApplianceSite>> GetIfExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetIfExists");
            scope.Start();
            try
            {
                if (siteName == null)
                {
                    throw new ArgumentNullException(nameof(siteName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualApplianceSite>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualApplianceSite(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string siteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (siteName == null)
                {
                    throw new ArgumentNullException(nameof(siteName));
                }

                var response = GetIfExists(siteName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteName"> The name of the site. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string siteName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.CheckIfExists");
            scope.Start();
            try
            {
                if (siteName == null)
                {
                    throw new ArgumentNullException(nameof(siteName));
                }

                var response = await GetIfExistsAsync(siteName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all Network Virtual Appliance Sites in a Network Virtual Appliance resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualApplianceSite" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualApplianceSite> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualApplianceSite> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualApplianceSite> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all Network Virtual Appliance Sites in a Network Virtual Appliance resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualApplianceSite" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualApplianceSite> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualApplianceSite>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualApplianceSite>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualApplianceSiteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualApplianceSite(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VirtualApplianceSite, VirtualApplianceSiteData> Construct() { }
    }
}
