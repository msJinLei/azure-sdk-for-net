// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Cosmos DB MongoDB collection.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class MongoDBCollectionGetResults : ARMResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionGetResults
        /// class.
        /// </summary>
        public MongoDBCollectionGetResults()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDBCollectionGetResults
        /// class.
        /// </summary>
        /// <param name="id">The unique resource identifier of the ARM
        /// resource.</param>
        /// <param name="name">The name of the ARM resource.</param>
        /// <param name="type">The type of Azure resource.</param>
        /// <param name="location">The location of the resource group to which
        /// the resource belongs.</param>
        public MongoDBCollectionGetResults(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), MongoDBCollectionGetPropertiesResource resource = default(MongoDBCollectionGetPropertiesResource), MongoDBCollectionGetPropertiesOptions options = default(MongoDBCollectionGetPropertiesOptions))
            : base(id, name, type, location, tags)
        {
            Resource = resource;
            Options = options;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.resource")]
        public MongoDBCollectionGetPropertiesResource Resource { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.options")]
        public MongoDBCollectionGetPropertiesOptions Options { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Resource != null)
            {
                Resource.Validate();
            }
        }
    }
}
