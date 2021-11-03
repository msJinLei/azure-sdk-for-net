// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace SqlManagementClient.Models
{
    public partial class ImportNewDatabaseDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName");
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(Edition))
            {
                writer.WritePropertyName("edition");
                writer.WriteStringValue(Edition);
            }
            if (Optional.IsDefined(ServiceObjectiveName))
            {
                writer.WritePropertyName("serviceObjectiveName");
                writer.WriteStringValue(ServiceObjectiveName);
            }
            if (Optional.IsDefined(MaxSizeBytes))
            {
                writer.WritePropertyName("maxSizeBytes");
                writer.WriteStringValue(MaxSizeBytes);
            }
            writer.WritePropertyName("storageKeyType");
            writer.WriteStringValue(StorageKeyType.ToString());
            writer.WritePropertyName("storageKey");
            writer.WriteStringValue(StorageKey);
            writer.WritePropertyName("storageUri");
            writer.WriteStringValue(StorageUri);
            writer.WritePropertyName("administratorLogin");
            writer.WriteStringValue(AdministratorLogin);
            writer.WritePropertyName("administratorLoginPassword");
            writer.WriteStringValue(AdministratorLoginPassword);
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType");
                writer.WriteStringValue(AuthenticationType);
            }
            if (Optional.IsDefined(NetworkIsolation))
            {
                writer.WritePropertyName("networkIsolation");
                writer.WriteObjectValue(NetworkIsolation);
            }
            writer.WriteEndObject();
        }
    }
}
