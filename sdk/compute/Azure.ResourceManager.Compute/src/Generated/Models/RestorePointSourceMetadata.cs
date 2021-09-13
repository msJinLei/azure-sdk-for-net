// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of the Virtual Machine for which the restore point was created. The properties provided are a subset and the snapshot of the overall Virtual Machine properties captured at the time of the restore point creation. </summary>
    public partial class RestorePointSourceMetadata
    {
        /// <summary> Initializes a new instance of RestorePointSourceMetadata. </summary>
        internal RestorePointSourceMetadata()
        {
        }

        /// <summary> Initializes a new instance of RestorePointSourceMetadata. </summary>
        /// <param name="hardwareProfile"> Gets the hardware profile. </param>
        /// <param name="storageProfile"> Gets the storage profile. </param>
        /// <param name="osProfile"> Gets the OS profile. </param>
        /// <param name="diagnosticsProfile"> Gets the diagnostics profile. </param>
        /// <param name="licenseType"> Gets the license type, which is for bring your own license scenario. </param>
        /// <param name="vmId"> Gets the virtual machine unique id. </param>
        /// <param name="securityProfile"> Gets the security profile. </param>
        /// <param name="location"> Location of the VM from which the restore point was created. </param>
        internal RestorePointSourceMetadata(HardwareProfile hardwareProfile, RestorePointSourceVMStorageProfile storageProfile, OSProfile osProfile, DiagnosticsProfile diagnosticsProfile, string licenseType, string vmId, SecurityProfile securityProfile, string location)
        {
            HardwareProfile = hardwareProfile;
            StorageProfile = storageProfile;
            OsProfile = osProfile;
            DiagnosticsProfile = diagnosticsProfile;
            LicenseType = licenseType;
            VmId = vmId;
            SecurityProfile = securityProfile;
            Location = location;
        }

        /// <summary> Gets the hardware profile. </summary>
        public HardwareProfile HardwareProfile { get; }
        /// <summary> Gets the storage profile. </summary>
        public RestorePointSourceVMStorageProfile StorageProfile { get; }
        /// <summary> Gets the OS profile. </summary>
        public OSProfile OsProfile { get; }
        /// <summary> Gets the diagnostics profile. </summary>
        public DiagnosticsProfile DiagnosticsProfile { get; }
        /// <summary> Gets the license type, which is for bring your own license scenario. </summary>
        public string LicenseType { get; }
        /// <summary> Gets the virtual machine unique id. </summary>
        public string VmId { get; }
        /// <summary> Gets the security profile. </summary>
        public SecurityProfile SecurityProfile { get; }
        /// <summary> Location of the VM from which the restore point was created. </summary>
        public string Location { get; }
    }
}
