// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the CdnWebApplicationFirewallPolicy data model. </summary>
    public partial class CdnWebApplicationFirewallPolicyData : TrackedResource
    {
        /// <summary> Initializes a new instance of CdnWebApplicationFirewallPolicyData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sku"/> is null. </exception>
        public CdnWebApplicationFirewallPolicyData(AzureLocation location, Models.Sku sku) : base(location)
        {
            if (sku == null)
            {
                throw new ArgumentNullException(nameof(sku));
            }

            Sku = sku;
            EndpointLinks = new ChangeTrackingList<SubResource>();
        }

        /// <summary> Initializes a new instance of CdnWebApplicationFirewallPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> Gets a unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="sku"> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </param>
        /// <param name="policySettings"> Describes  policySettings for policy. </param>
        /// <param name="rateLimitRules"> Describes rate limit rules inside the policy. </param>
        /// <param name="customRules"> Describes custom rules inside the policy. </param>
        /// <param name="managedRules"> Describes managed rules inside the policy. </param>
        /// <param name="endpointLinks"> Describes Azure CDN endpoints associated with this Web Application Firewall policy. </param>
        /// <param name="provisioningState"> Provisioning state of the WebApplicationFirewallPolicy. </param>
        /// <param name="resourceState"> Resource status of the policy. </param>
        internal CdnWebApplicationFirewallPolicyData(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string etag, Models.Sku sku, PolicySettings policySettings, RateLimitRuleList rateLimitRules, CustomRuleList customRules, ManagedRuleSetList managedRules, IReadOnlyList<SubResource> endpointLinks, ProvisioningState? provisioningState, PolicyResourceState? resourceState) : base(id, name, type, systemData, tags, location)
        {
            Etag = etag;
            Sku = sku;
            PolicySettings = policySettings;
            RateLimitRules = rateLimitRules;
            CustomRules = customRules;
            ManagedRules = managedRules;
            EndpointLinks = endpointLinks;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
        }

        /// <summary> Gets a unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; set; }
        /// <summary> The pricing tier (defines a CDN provider, feature list and rate) of the CdnWebApplicationFirewallPolicy. </summary>
        public Models.Sku Sku { get; set; }
        /// <summary> Describes  policySettings for policy. </summary>
        public PolicySettings PolicySettings { get; set; }
        /// <summary> Describes rate limit rules inside the policy. </summary>
        public RateLimitRuleList RateLimitRules { get; set; }
        /// <summary> Describes custom rules inside the policy. </summary>
        public CustomRuleList CustomRules { get; set; }
        /// <summary> Describes managed rules inside the policy. </summary>
        public ManagedRuleSetList ManagedRules { get; set; }
        /// <summary> Describes Azure CDN endpoints associated with this Web Application Firewall policy. </summary>
        public IReadOnlyList<SubResource> EndpointLinks { get; }
        /// <summary> Provisioning state of the WebApplicationFirewallPolicy. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Resource status of the policy. </summary>
        public PolicyResourceState? ResourceState { get; }
    }
}
