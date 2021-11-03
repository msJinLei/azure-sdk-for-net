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
using SqlManagementClient.Models;

namespace SqlManagementClient
{
    /// <summary> A class representing collection of GeoBackupPolicy and their operations over its parent. </summary>
    public partial class GeoBackupPolicyCollection : ArmCollection, IEnumerable<GeoBackupPolicy>, IAsyncEnumerable<GeoBackupPolicy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GeoBackupPoliciesRestOperations _geoBackupPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="GeoBackupPolicyCollection"/> class for mocking. </summary>
        protected GeoBackupPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of GeoBackupPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GeoBackupPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _geoBackupPoliciesRestClient = new GeoBackupPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Database.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_CreateOrUpdate
        /// <summary> Updates a database geo backup policy. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="parameters"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual GeoBackupPolicyCreateOrUpdateOperation CreateOrUpdate(GeoBackupPolicyName geoBackupPolicyName, GeoBackupPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _geoBackupPoliciesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, parameters, cancellationToken);
                var operation = new GeoBackupPolicyCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_CreateOrUpdate
        /// <summary> Updates a database geo backup policy. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="parameters"> The required parameters for creating or updating the geo backup policy. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<GeoBackupPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(GeoBackupPolicyName geoBackupPolicyName, GeoBackupPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _geoBackupPoliciesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new GeoBackupPolicyCreateOrUpdateOperation(Parent, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Gets a geo backup policy. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GeoBackupPolicy> Get(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _geoBackupPoliciesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GeoBackupPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies/{geoBackupPolicyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_Get
        /// <summary> Gets a geo backup policy. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<GeoBackupPolicy>> GetAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _geoBackupPoliciesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GeoBackupPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<GeoBackupPolicy> GetIfExists(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _geoBackupPoliciesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GeoBackupPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new GeoBackupPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<GeoBackupPolicy>> GetIfExistsAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _geoBackupPoliciesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GeoBackupPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new GeoBackupPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(geoBackupPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="geoBackupPolicyName"> The name of the geo backup policy. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(GeoBackupPolicyName geoBackupPolicyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(geoBackupPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_ListByDatabase
        /// <summary> Returns a list of geo backup policies. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GeoBackupPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GeoBackupPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GeoBackupPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _geoBackupPoliciesRestClient.ListByDatabase(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GeoBackupPolicy(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/geoBackupPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: GeoBackupPolicies_ListByDatabase
        /// <summary> Returns a list of geo backup policies. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GeoBackupPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GeoBackupPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GeoBackupPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GeoBackupPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _geoBackupPoliciesRestClient.ListByDatabaseAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GeoBackupPolicy(Parent, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<GeoBackupPolicy> IEnumerable<GeoBackupPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<GeoBackupPolicy> IAsyncEnumerable<GeoBackupPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, GeoBackupPolicy, GeoBackupPolicyData> Construct() { }
    }
}
