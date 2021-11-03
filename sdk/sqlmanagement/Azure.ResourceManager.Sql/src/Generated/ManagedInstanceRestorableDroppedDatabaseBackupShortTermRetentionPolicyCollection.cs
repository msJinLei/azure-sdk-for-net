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
    /// <summary> A class representing collection of ManagedBackupShortTermRetentionPolicy and their operations over its parent. </summary>
    public partial class ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection : ArmCollection, IEnumerable<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>, IAsyncEnumerable<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection"/> class for mocking. </summary>
        protected ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => RestorableDroppedManagedDatabase.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_CreateOrUpdate
        /// <summary> Sets a database&apos;s short term retention policy. </summary>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicyCreateOrUpdateOperation CreateOrUpdate(ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken);
                var operation = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_CreateOrUpdate
        /// <summary> Sets a database&apos;s short term retention policy. </summary>
        /// <param name="policyName"> The policy name. Should always be &quot;default&quot;. </param>
        /// <param name="parameters"> The short term retention policy info. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicyCreateOrUpdateOperation> CreateOrUpdateAsync(ManagedShortTermRetentionPolicyName policyName, ManagedBackupShortTermRetentionPolicyData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicyCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// <summary> Gets a dropped database&apos;s short term retention policy. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> Get(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies/{policyName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_Get
        /// <summary> Gets a dropped database&apos;s short term retention policy. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>> GetAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> GetIfExists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>> GetIfExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>(null, response.GetRawResponse())
                    : Response.FromValue(new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(policyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="policyName"> The policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(ManagedShortTermRetentionPolicyName policyName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(policyName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_ListByRestorableDroppedDatabase
        /// <summary> Gets a dropped database&apos;s short term retention policy list. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabase(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabaseNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}/backupShortTermRetentionPolicies
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/restorableDroppedDatabases/{restorableDroppedDatabaseId}
        /// OperationId: ManagedRestorableDroppedDatabaseBackupShortTermRetentionPolicies_ListByRestorableDroppedDatabase
        /// <summary> Gets a dropped database&apos;s short term retention policy list. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabaseAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicyCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _managedRestorableDroppedDatabaseBackupShortTermRetentionPoliciesRestClient.ListByRestorableDroppedDatabaseNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> IEnumerable<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy> IAsyncEnumerable<ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, ManagedInstanceRestorableDroppedDatabaseBackupShortTermRetentionPolicy, ManagedBackupShortTermRetentionPolicyData> Construct() { }
    }
}
