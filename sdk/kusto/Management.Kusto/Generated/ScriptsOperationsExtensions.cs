// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ScriptsOperations.
    /// </summary>
    public static partial class ScriptsOperationsExtensions
    {
            /// <summary>
            /// Returns the list of database scripts for given database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            public static IEnumerable<Script> ListByDatabase(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName)
            {
                return operations.ListByDatabaseAsync(resourceGroupName, clusterName, databaseName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the list of database scripts for given database.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Script>> ListByDatabaseAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDatabaseWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a Kusto cluster database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            public static Script Get(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName)
            {
                return operations.GetAsync(resourceGroupName, clusterName, databaseName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a Kusto cluster database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Script> GetAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a Kusto database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains the KQL to run.
            /// </param>
            public static Script CreateOrUpdate(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a Kusto database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains the KQL to run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Script> CreateOrUpdateAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains to the KQL to run.
            /// </param>
            public static Script Update(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters)
            {
                return operations.UpdateAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains to the KQL to run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Script> UpdateAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Kusto principalAssignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            public static void Delete(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName)
            {
                operations.DeleteAsync(resourceGroupName, clusterName, databaseName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Kusto principalAssignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Checks that the script name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the script.
            /// </param>
            public static CheckNameResult CheckNameAvailability(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, ScriptCheckNameRequest scriptName)
            {
                return operations.CheckNameAvailabilityAsync(resourceGroupName, clusterName, databaseName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks that the script name is valid and is not already in use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CheckNameResult> CheckNameAvailabilityAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, ScriptCheckNameRequest scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a Kusto database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains the KQL to run.
            /// </param>
            public static Script BeginCreateOrUpdate(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a Kusto database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains the KQL to run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Script> BeginCreateOrUpdateAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains to the KQL to run.
            /// </param>
            public static Script BeginUpdate(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a database script.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='parameters'>
            /// The Kusto Script parameters contains to the KQL to run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Script> BeginUpdateAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, Script parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a Kusto principalAssignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            public static void BeginDelete(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName)
            {
                operations.BeginDeleteAsync(resourceGroupName, clusterName, databaseName, scriptName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a Kusto principalAssignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group containing the Kusto cluster.
            /// </param>
            /// <param name='clusterName'>
            /// The name of the Kusto cluster.
            /// </param>
            /// <param name='databaseName'>
            /// The name of the database in the Kusto cluster.
            /// </param>
            /// <param name='scriptName'>
            /// The name of the Kusto database script.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IScriptsOperations operations, string resourceGroupName, string clusterName, string databaseName, string scriptName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, clusterName, databaseName, scriptName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
