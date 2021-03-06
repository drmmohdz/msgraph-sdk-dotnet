// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Windows10Team General Configuration.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class Windows10TeamGeneralConfiguration : DeviceConfiguration
    {
    
        /// <summary>
        /// Gets or sets azure operational insights block telemetry.
        /// Indicates whether or not to Block Azure Operational Insights.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureOperationalInsightsBlockTelemetry", Required = Newtonsoft.Json.Required.Default)]
        public bool? AzureOperationalInsightsBlockTelemetry { get; set; }
    
        /// <summary>
        /// Gets or sets azure operational insights workspace id.
        /// The Azure Operational Insights workspace id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureOperationalInsightsWorkspaceId", Required = Newtonsoft.Json.Required.Default)]
        public string AzureOperationalInsightsWorkspaceId { get; set; }
    
        /// <summary>
        /// Gets or sets azure operational insights workspace key.
        /// The Azure Operational Insights Workspace key.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "azureOperationalInsightsWorkspaceKey", Required = Newtonsoft.Json.Required.Default)]
        public string AzureOperationalInsightsWorkspaceKey { get; set; }
    
        /// <summary>
        /// Gets or sets connect app block auto launch.
        /// Specifies whether to automatically launch the Connect app whenever a projection is initiated.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "connectAppBlockAutoLaunch", Required = Newtonsoft.Json.Required.Default)]
        public bool? ConnectAppBlockAutoLaunch { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window blocked.
        /// Indicates whether or not to Block setting a maintenance window for device updates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceWindowBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? MaintenanceWindowBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window duration in hours.
        /// Maintenance window duration for device updates. Valid values 0 to 5
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceWindowDurationInHours", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaintenanceWindowDurationInHours { get; set; }
    
        /// <summary>
        /// Gets or sets maintenance window start time.
        /// Maintenance window start time for device updates.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maintenanceWindowStartTime", Required = Newtonsoft.Json.Required.Default)]
        public TimeOfDay MaintenanceWindowStartTime { get; set; }
    
        /// <summary>
        /// Gets or sets miracast channel.
        /// The channel. Possible values are: userDefined, one, two, three, four, five, six, seven, eight, nine, ten, eleven, thirtySix, forty, fortyFour, fortyEight, oneHundredFortyNine, oneHundredFiftyThree, oneHundredFiftySeven, oneHundredSixtyOne, oneHundredSixtyFive.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "miracastChannel", Required = Newtonsoft.Json.Required.Default)]
        public MiracastChannel? MiracastChannel { get; set; }
    
        /// <summary>
        /// Gets or sets miracast blocked.
        /// Indicates whether or not to Block wireless projection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "miracastBlocked", Required = Newtonsoft.Json.Required.Default)]
        public bool? MiracastBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets miracast require pin.
        /// Indicates whether or not to require a pin for wireless projection.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "miracastRequirePin", Required = Newtonsoft.Json.Required.Default)]
        public bool? MiracastRequirePin { get; set; }
    
        /// <summary>
        /// Gets or sets settings block my meetings and files.
        /// Specifies whether to disable the 'My meetings and files' feature in the Start menu, which shows the signed-in user's meetings and files from Office 365.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsBlockMyMeetingsAndFiles", Required = Newtonsoft.Json.Required.Default)]
        public bool? SettingsBlockMyMeetingsAndFiles { get; set; }
    
        /// <summary>
        /// Gets or sets settings block session resume.
        /// Specifies whether to allow the ability to resume a session when the session times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsBlockSessionResume", Required = Newtonsoft.Json.Required.Default)]
        public bool? SettingsBlockSessionResume { get; set; }
    
        /// <summary>
        /// Gets or sets settings block signin suggestions.
        /// Specifies whether to disable auto-populating of the sign-in dialog with invitees from scheduled meetings.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsBlockSigninSuggestions", Required = Newtonsoft.Json.Required.Default)]
        public bool? SettingsBlockSigninSuggestions { get; set; }
    
        /// <summary>
        /// Gets or sets settings default volume.
        /// Specifies the default volume value for a new session. Permitted values are 0-100. The default is 45. Valid values 0 to 100
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsDefaultVolume", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SettingsDefaultVolume { get; set; }
    
        /// <summary>
        /// Gets or sets settings screen timeout in minutes.
        /// Specifies the number of minutes until the Hub screen turns off.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsScreenTimeoutInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SettingsScreenTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets settings session timeout in minutes.
        /// Specifies the number of minutes until the session times out.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsSessionTimeoutInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SettingsSessionTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets settings sleep timeout in minutes.
        /// Specifies the number of minutes until the Hub enters sleep mode.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingsSleepTimeoutInMinutes", Required = Newtonsoft.Json.Required.Default)]
        public Int32? SettingsSleepTimeoutInMinutes { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen block automatic wake up.
        /// Indicates whether or not to Block the welcome screen from waking up automatically when someone enters the room.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "welcomeScreenBlockAutomaticWakeUp", Required = Newtonsoft.Json.Required.Default)]
        public bool? WelcomeScreenBlockAutomaticWakeUp { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen background image url.
        /// The welcome screen background image URL. The URL must use the HTTPS protocol and return a PNG image.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "welcomeScreenBackgroundImageUrl", Required = Newtonsoft.Json.Required.Default)]
        public string WelcomeScreenBackgroundImageUrl { get; set; }
    
        /// <summary>
        /// Gets or sets welcome screen meeting information.
        /// The welcome screen meeting information shown. Possible values are: userDefined, showOrganizerAndTimeOnly, showOrganizerAndTimeAndSubject.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "welcomeScreenMeetingInformation", Required = Newtonsoft.Json.Required.Default)]
        public WelcomeScreenMeetingInformation? WelcomeScreenMeetingInformation { get; set; }
    
    }
}

