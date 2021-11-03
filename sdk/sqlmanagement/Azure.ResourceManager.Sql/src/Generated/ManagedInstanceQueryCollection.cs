// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;

namespace SqlManagementClient
{
    /// <summary> A class representing collection of ManagedInstanceQuery and their operations over its parent. </summary>
    public partial class ManagedInstanceQueryCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseQueriesRestOperations _managedDatabaseQueriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceQueryCollection"/> class for mocking. </summary>
        protected ManagedInstanceQueryCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceQueryCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceQueryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseQueriesRestClient = new ManagedDatabaseQueriesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedDatabase.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/queries/{queryId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseQueries_Get
        /// <summary> Get query by query id. </summary>
        /// <param name="queryId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/> is null. </exception>
        public virtual Response<ManagedInstanceQuery> Get(string queryId, CancellationToken cancellationToken = default)
        {
            if (queryId == null)
            {
                throw new ArgumentNullException(nameof(queryId));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceQueryCollection.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseQueriesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, queryId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceQuery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/queries/{queryId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}
        /// OperationId: ManagedDatabaseQueries_Get
        /// <summary> Get query by query id. </summary>
        /// <param name="queryId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceQuery>> GetAsync(string queryId, CancellationToken cancellationToken = default)
        {
            if (queryId == null)
            {
                throw new ArgumentNullException(nameof(queryId));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceQueryCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseQueriesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, queryId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceQuery(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queryId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/> is null. </exception>
        public virtual Response<ManagedInstanceQuery> GetIfExists(string queryId, CancellationToken cancellationToken = default)
        {
            if (queryId == null)
            {
                throw new ArgumentNullException(nameof(queryId));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceQueryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedDatabaseQueriesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, queryId, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceQuery>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceQuery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queryId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/> is null. </exception>
        public async virtual Task<Response<ManagedInstanceQuery>> GetIfExistsAsync(string queryId, CancellationToken cancellationToken = default)
        {
            if (queryId == null)
            {
                throw new ArgumentNullException(nameof(queryId));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceQueryCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedDatabaseQueriesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, queryId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceQuery>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceQuery(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queryId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string queryId, CancellationToken cancellationToken = default)
        {
            if (queryId == null)
            {
                throw new ArgumentNullException(nameof(queryId));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceQueryCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(queryId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="queryId"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="queryId"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string queryId, CancellationToken cancellationToken = default)
        {
            if (queryId == null)
            {
                throw new ArgumentNullException(nameof(queryId));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceQueryCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(queryId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagedInstanceQuery, ManagedInstanceQueryData> Construct() { }
    }
}
