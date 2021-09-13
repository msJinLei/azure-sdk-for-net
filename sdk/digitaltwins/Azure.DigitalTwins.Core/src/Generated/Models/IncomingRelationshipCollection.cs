// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A collection of incoming relationships which relate digital twins together. </summary>
    internal partial class IncomingRelationshipCollection
    {
        /// <summary> Initializes a new instance of IncomingRelationshipCollection. </summary>
        internal IncomingRelationshipCollection()
        {
            Value = new ChangeTrackingList<IncomingRelationship>();
        }

        /// <summary> Initializes a new instance of IncomingRelationshipCollection. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> A URI to retrieve the next page of objects. </param>
        internal IncomingRelationshipCollection(IReadOnlyList<IncomingRelationship> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        public IReadOnlyList<IncomingRelationship> Value { get; }
        /// <summary> A URI to retrieve the next page of objects. </summary>
        public string NextLink { get; }
    }
}
