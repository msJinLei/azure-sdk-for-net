// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace SqlManagementClient.Models
{
    /// <summary> A job target, for example a specific database or a container of databases that is evaluated during job execution. </summary>
    public partial class JobTarget
    {
        /// <summary> Initializes a new instance of JobTarget. </summary>
        /// <param name="type"> The target type. </param>
        public JobTarget(JobTargetType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of JobTarget. </summary>
        /// <param name="membershipType"> Whether the target is included or excluded from the group. </param>
        /// <param name="type"> The target type. </param>
        /// <param name="serverName"> The target server name. </param>
        /// <param name="databaseName"> The target database name. </param>
        /// <param name="elasticPoolName"> The target elastic pool name. </param>
        /// <param name="shardMapName"> The target shard map. </param>
        /// <param name="refreshCredential"> The resource ID of the credential that is used during job execution to connect to the target and determine the list of databases inside the target. </param>
        internal JobTarget(JobTargetGroupMembershipType? membershipType, JobTargetType type, string serverName, string databaseName, string elasticPoolName, string shardMapName, string refreshCredential)
        {
            MembershipType = membershipType;
            Type = type;
            ServerName = serverName;
            DatabaseName = databaseName;
            ElasticPoolName = elasticPoolName;
            ShardMapName = shardMapName;
            RefreshCredential = refreshCredential;
        }

        /// <summary> Whether the target is included or excluded from the group. </summary>
        public JobTargetGroupMembershipType? MembershipType { get; set; }
        /// <summary> The target type. </summary>
        public JobTargetType Type { get; set; }
        /// <summary> The target server name. </summary>
        public string ServerName { get; set; }
        /// <summary> The target database name. </summary>
        public string DatabaseName { get; set; }
        /// <summary> The target elastic pool name. </summary>
        public string ElasticPoolName { get; set; }
        /// <summary> The target shard map. </summary>
        public string ShardMapName { get; set; }
        /// <summary> The resource ID of the credential that is used during job execution to connect to the target and determine the list of databases inside the target. </summary>
        public string RefreshCredential { get; set; }
    }
}
