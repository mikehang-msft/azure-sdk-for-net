// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The DataCollectionRulePrivateLinkScopedResourceInfo. </summary>
    public partial class DataCollectionRulePrivateLinkScopedResourceInfo
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

        /// <summary> Initializes a new instance of <see cref="DataCollectionRulePrivateLinkScopedResourceInfo"/>. </summary>
        internal DataCollectionRulePrivateLinkScopedResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataCollectionRulePrivateLinkScopedResourceInfo"/>. </summary>
        /// <param name="resourceId"> The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure Monitor Private Link Scope. </param>
        /// <param name="scopeId"> The immutableId of the Azure Monitor Private Link Scope Resource to which the association is. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataCollectionRulePrivateLinkScopedResourceInfo(ResourceIdentifier resourceId, string scopeId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            ScopeId = scopeId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resourceId of the Azure Monitor Private Link Scope Scoped Resource through which this DCE is associated with a Azure Monitor Private Link Scope. </summary>
        public ResourceIdentifier ResourceId { get; }
        /// <summary> The immutableId of the Azure Monitor Private Link Scope Resource to which the association is. </summary>
        public string ScopeId { get; }
    }
}
