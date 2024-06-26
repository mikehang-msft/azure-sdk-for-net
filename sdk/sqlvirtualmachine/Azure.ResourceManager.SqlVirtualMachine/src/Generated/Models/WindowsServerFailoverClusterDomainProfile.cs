// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Active Directory account details to operate Windows Server Failover Cluster. </summary>
    public partial class WindowsServerFailoverClusterDomainProfile
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WindowsServerFailoverClusterDomainProfile"/>. </summary>
        public WindowsServerFailoverClusterDomainProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WindowsServerFailoverClusterDomainProfile"/>. </summary>
        /// <param name="domainFqdn"> Fully qualified name of the domain. </param>
        /// <param name="organizationalUnitPath"> Organizational Unit path in which the nodes and cluster will be present. </param>
        /// <param name="clusterBootstrapAccount"> Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain). </param>
        /// <param name="clusterOperatorAccount"> Account name used for operating cluster i.e. will be part of administrators group on all the participating virtual machines in the cluster. </param>
        /// <param name="sqlServiceAccount"> Account name under which SQL service will run on all participating SQL virtual machines in the cluster. </param>
        /// <param name="fileShareWitnessPath"> Optional path for fileshare witness. </param>
        /// <param name="storageAccountUri"> Fully qualified ARM resource id of the witness storage account. </param>
        /// <param name="storageAccountPrimaryKey"> Primary key of the witness storage account. </param>
        /// <param name="clusterSubnetType"> Cluster subnet type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WindowsServerFailoverClusterDomainProfile(string domainFqdn, string organizationalUnitPath, string clusterBootstrapAccount, string clusterOperatorAccount, string sqlServiceAccount, string fileShareWitnessPath, Uri storageAccountUri, string storageAccountPrimaryKey, SqlVmClusterSubnetType? clusterSubnetType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainFqdn = domainFqdn;
            OrganizationalUnitPath = organizationalUnitPath;
            ClusterBootstrapAccount = clusterBootstrapAccount;
            ClusterOperatorAccount = clusterOperatorAccount;
            SqlServiceAccount = sqlServiceAccount;
            FileShareWitnessPath = fileShareWitnessPath;
            StorageAccountUri = storageAccountUri;
            StorageAccountPrimaryKey = storageAccountPrimaryKey;
            ClusterSubnetType = clusterSubnetType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Fully qualified name of the domain. </summary>
        public string DomainFqdn { get; set; }
        /// <summary> Organizational Unit path in which the nodes and cluster will be present. </summary>
        public string OrganizationalUnitPath { get; set; }
        /// <summary> Account name used for creating cluster (at minimum needs permissions to 'Create Computer Objects' in domain). </summary>
        public string ClusterBootstrapAccount { get; set; }
        /// <summary> Account name used for operating cluster i.e. will be part of administrators group on all the participating virtual machines in the cluster. </summary>
        public string ClusterOperatorAccount { get; set; }
        /// <summary> Account name under which SQL service will run on all participating SQL virtual machines in the cluster. </summary>
        public string SqlServiceAccount { get; set; }
        /// <summary> Optional path for fileshare witness. </summary>
        public string FileShareWitnessPath { get; set; }
        /// <summary> Fully qualified ARM resource id of the witness storage account. </summary>
        public Uri StorageAccountUri { get; set; }
        /// <summary> Primary key of the witness storage account. </summary>
        public string StorageAccountPrimaryKey { get; set; }
        /// <summary> Cluster subnet type. </summary>
        public SqlVmClusterSubnetType? ClusterSubnetType { get; set; }
    }
}
