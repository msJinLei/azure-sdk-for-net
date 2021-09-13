// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// OperationJobExtendedInfo
    /// </summary>
    /// <remarks>
    /// Operation Job Extended Info
    /// </remarks>
    public partial class OperationJobExtendedInfo : OperationExtendedInfo
    {
        /// <summary>
        /// Initializes a new instance of the OperationJobExtendedInfo class.
        /// </summary>
        public OperationJobExtendedInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationJobExtendedInfo class.
        /// </summary>
        /// <param name="objectType">This property will be used as the
        /// discriminator for deciding the specific types in the polymorphic
        /// chain of types.</param>
        /// <param name="jobId">Arm Id of the job created for this
        /// operation.</param>
        public OperationJobExtendedInfo(string objectType = default(string), string jobId = default(string))
            : base(objectType)
        {
            JobId = jobId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets arm Id of the job created for this operation.
        /// </summary>
        [JsonProperty(PropertyName = "jobId")]
        public string JobId { get; set; }

    }
}
