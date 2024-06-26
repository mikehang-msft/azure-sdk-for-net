// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Automation
{
    /// <summary>
    /// A class representing the AutomationJobSchedule data model.
    /// Definition of the job schedule.
    /// </summary>
    public partial class AutomationJobScheduleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="AutomationJobScheduleData"/>. </summary>
        internal AutomationJobScheduleData()
        {
            Parameters = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationJobScheduleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="jobScheduleId"> Gets or sets the id of job schedule. </param>
        /// <param name="schedule"> Gets or sets the schedule. </param>
        /// <param name="runbook"> Gets or sets the runbook. </param>
        /// <param name="runOn"> Gets or sets the hybrid worker group that the scheduled job should run on. </param>
        /// <param name="parameters"> Gets or sets the parameters of the job schedule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationJobScheduleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? jobScheduleId, ScheduleAssociationProperty schedule, RunbookAssociationProperty runbook, string runOn, IReadOnlyDictionary<string, string> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            JobScheduleId = jobScheduleId;
            Schedule = schedule;
            Runbook = runbook;
            RunOn = runOn;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the id of job schedule. </summary>
        public Guid? JobScheduleId { get; }
        /// <summary> Gets or sets the schedule. </summary>
        internal ScheduleAssociationProperty Schedule { get; }
        /// <summary> Gets or sets the name of the Schedule. </summary>
        public string ScheduleName
        {
            get => Schedule?.Name;
        }

        /// <summary> Gets or sets the runbook. </summary>
        internal RunbookAssociationProperty Runbook { get; }
        /// <summary> Gets or sets the name of the runbook. </summary>
        public string RunbookName
        {
            get => Runbook?.Name;
        }

        /// <summary> Gets or sets the hybrid worker group that the scheduled job should run on. </summary>
        public string RunOn { get; }
        /// <summary> Gets or sets the parameters of the job schedule. </summary>
        public IReadOnlyDictionary<string, string> Parameters { get; }
    }
}
