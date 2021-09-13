// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties of a rule.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FirewallPolicyRule")]
    public partial class FirewallPolicyRule
    {
        /// <summary>
        /// Initializes a new instance of the FirewallPolicyRule class.
        /// </summary>
        public FirewallPolicyRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FirewallPolicyRule class.
        /// </summary>
        /// <param name="name">Name of the rule.</param>
        /// <param name="description">Description of the rule.</param>
        public FirewallPolicyRule(string name = default(string), string description = default(string))
        {
            Name = name;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets description of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
