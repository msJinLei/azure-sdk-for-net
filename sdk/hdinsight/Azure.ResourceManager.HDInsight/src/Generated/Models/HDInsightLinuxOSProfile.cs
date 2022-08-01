// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The ssh username, password, and ssh public key.
    /// Serialized Name: LinuxOperatingSystemProfile
    /// </summary>
    public partial class HDInsightLinuxOSProfile
    {
        /// <summary> Initializes a new instance of HDInsightLinuxOSProfile. </summary>
        public HDInsightLinuxOSProfile()
        {
        }

        /// <summary> Initializes a new instance of HDInsightLinuxOSProfile. </summary>
        /// <param name="username">
        /// The username.
        /// Serialized Name: LinuxOperatingSystemProfile.username
        /// </param>
        /// <param name="password">
        /// The password.
        /// Serialized Name: LinuxOperatingSystemProfile.password
        /// </param>
        /// <param name="sshProfile">
        /// The SSH profile.
        /// Serialized Name: LinuxOperatingSystemProfile.sshProfile
        /// </param>
        internal HDInsightLinuxOSProfile(string username, string password, SshProfile sshProfile)
        {
            Username = username;
            Password = password;
            SshProfile = sshProfile;
        }

        /// <summary>
        /// The username.
        /// Serialized Name: LinuxOperatingSystemProfile.username
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// The password.
        /// Serialized Name: LinuxOperatingSystemProfile.password
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// The SSH profile.
        /// Serialized Name: LinuxOperatingSystemProfile.sshProfile
        /// </summary>
        internal SshProfile SshProfile { get; set; }
        /// <summary>
        /// The list of SSH public keys.
        /// Serialized Name: SshProfile.publicKeys
        /// </summary>
        public IList<HDInsightSshPublicKey> SshPublicKeys
        {
            get
            {
                if (SshProfile is null)
                    SshProfile = new SshProfile();
                return SshProfile.PublicKeys;
            }
        }
    }
}
