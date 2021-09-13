// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Input for add disk(s) operation.
    /// </summary>
    public partial class AddDisksInput
    {
        /// <summary>
        /// Initializes a new instance of the AddDisksInput class.
        /// </summary>
        public AddDisksInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AddDisksInput class.
        /// </summary>
        /// <param name="properties">Add disks input properties.</param>
        public AddDisksInput(AddDisksInputProperties properties = default(AddDisksInputProperties))
        {
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets add disks input properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public AddDisksInputProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
