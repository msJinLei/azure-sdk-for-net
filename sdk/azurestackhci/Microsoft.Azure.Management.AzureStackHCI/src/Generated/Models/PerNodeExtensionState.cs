// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStackHCI.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Status of Arc Extension for a particular node in HCI Cluster.
    /// </summary>
    public partial class PerNodeExtensionState
    {
        /// <summary>
        /// Initializes a new instance of the PerNodeExtensionState class.
        /// </summary>
        public PerNodeExtensionState()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PerNodeExtensionState class.
        /// </summary>
        /// <param name="name">Name of the node in HCI Cluster.</param>
        /// <param name="extension">Fully qualified resource ID for the
        /// particular Arc Extension on this node.</param>
        /// <param name="state">State of Arc Extension in this node. Possible
        /// values include: 'NotSpecified', 'Error', 'Succeeded', 'Canceled',
        /// 'Failed', 'Connected', 'Disconnected', 'Deleted', 'Creating',
        /// 'Updating', 'Deleting', 'Moving'</param>
        public PerNodeExtensionState(string name = default(string), string extension = default(string), string state = default(string))
        {
            Name = name;
            Extension = extension;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the node in HCI Cluster.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets fully qualified resource ID for the particular Arc Extension
        /// on this node.
        /// </summary>
        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; private set; }

        /// <summary>
        /// Gets state of Arc Extension in this node. Possible values include:
        /// 'NotSpecified', 'Error', 'Succeeded', 'Canceled', 'Failed',
        /// 'Connected', 'Disconnected', 'Deleted', 'Creating', 'Updating',
        /// 'Deleting', 'Moving'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

    }
}
