// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Container App Revision.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Revision : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Revision class.
        /// </summary>
        public Revision()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Revision class.
        /// </summary>
        /// <param name="location">Resource Location.</param>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="kind">Kind of resource.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="createdTime">Timestamp describing when the revision
        /// was created
        /// by controller</param>
        /// <param name="fqdn">Fully qualified domain name of the
        /// revision</param>
        /// <param name="template">Container App Revision Template with all
        /// possible settings and the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time</param>
        /// <param name="active">Boolean describing if the Revision is
        /// Active</param>
        /// <param name="replicas">Number of pods currently running for this
        /// revision</param>
        /// <param name="trafficWeight">Traffic weight assigned to this
        /// revision</param>
        /// <param name="provisioningError">Optional Field - Platform Error
        /// Message</param>
        /// <param name="healthState">Current health State of the revision.
        /// Possible values include: 'Healthy', 'Unhealthy', 'None'</param>
        /// <param name="provisioningState">Current provisioning State of the
        /// revision. Possible values include: 'Provisioning', 'Provisioned',
        /// 'Failed', 'Deprovisioning', 'Deprovisioned'</param>
        public Revision(string location, string id = default(string), string name = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), System.DateTime? createdTime = default(System.DateTime?), string fqdn = default(string), Template template = default(Template), bool? active = default(bool?), int? replicas = default(int?), int? trafficWeight = default(int?), string provisioningError = default(string), string healthState = default(string), string provisioningState = default(string))
            : base(location, id, name, kind, type, tags)
        {
            CreatedTime = createdTime;
            Fqdn = fqdn;
            Template = template;
            Active = active;
            Replicas = replicas;
            TrafficWeight = trafficWeight;
            ProvisioningError = provisioningError;
            HealthState = healthState;
            ProvisioningState = provisioningState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets timestamp describing when the revision was created
        /// by controller
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets fully qualified domain name of the revision
        /// </summary>
        [JsonProperty(PropertyName = "properties.fqdn")]
        public string Fqdn { get; private set; }

        /// <summary>
        /// Gets container App Revision Template with all possible settings and
        /// the
        /// defaults if user did not provide them. The defaults are populated
        /// as they were at the creation time
        /// </summary>
        [JsonProperty(PropertyName = "properties.template")]
        public Template Template { get; private set; }

        /// <summary>
        /// Gets boolean describing if the Revision is Active
        /// </summary>
        [JsonProperty(PropertyName = "properties.active")]
        public bool? Active { get; private set; }

        /// <summary>
        /// Gets number of pods currently running for this revision
        /// </summary>
        [JsonProperty(PropertyName = "properties.replicas")]
        public int? Replicas { get; private set; }

        /// <summary>
        /// Gets traffic weight assigned to this revision
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficWeight")]
        public int? TrafficWeight { get; private set; }

        /// <summary>
        /// Gets optional Field - Platform Error Message
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningError")]
        public string ProvisioningError { get; private set; }

        /// <summary>
        /// Gets current health State of the revision. Possible values include:
        /// 'Healthy', 'Unhealthy', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthState")]
        public string HealthState { get; private set; }

        /// <summary>
        /// Gets current provisioning State of the revision. Possible values
        /// include: 'Provisioning', 'Provisioned', 'Failed', 'Deprovisioning',
        /// 'Deprovisioned'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
