// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for Teradata data source. </summary>
    public partial class TeradataLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of TeradataLinkedService. </summary>
        public TeradataLinkedService()
        {
            Type = "Teradata";
        }

        /// <summary> Initializes a new instance of TeradataLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="connectionString"> Teradata ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="server"> Server name for connection. Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> AuthenticationType to be used for connection. </param>
        /// <param name="username"> Username for authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password"> Password for authentication. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </param>
        internal TeradataLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object connectionString, object server, TeradataAuthenticationType? authenticationType, object username, SecretBase password, object encryptedCredential) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            ConnectionString = connectionString;
            Server = server;
            AuthenticationType = authenticationType;
            Username = username;
            Password = password;
            EncryptedCredential = encryptedCredential;
            Type = type ?? "Teradata";
        }

        /// <summary> Teradata ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public object ConnectionString { get; set; }
        /// <summary> Server name for connection. Type: string (or Expression with resultType string). </summary>
        public object Server { get; set; }
        /// <summary> AuthenticationType to be used for connection. </summary>
        public TeradataAuthenticationType? AuthenticationType { get; set; }
        /// <summary> Username for authentication. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary> Password for authentication. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string (or Expression with resultType string). </summary>
        public object EncryptedCredential { get; set; }
    }
}
