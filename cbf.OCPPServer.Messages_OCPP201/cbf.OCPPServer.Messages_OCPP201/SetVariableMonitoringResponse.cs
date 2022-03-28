//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"

namespace cbf.OCPPServer.Messages_OCPP201
{
    using System = global::System;

    




    /// <summary>
    /// Status is OK if a value could be returned. Otherwise this will indicate the reason why a value could not be returned.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum SetMonitoringStatusEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
        Accepted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"UnknownComponent")]
        UnknownComponent = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"UnknownVariable")]
        UnknownVariable = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"UnsupportedMonitorType")]
        UnsupportedMonitorType = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Rejected")]
        Rejected = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Duplicate")]
        Duplicate = 5,

    }





    /// <summary>
    /// Class to hold result of SetVariableMonitoring request.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class SetMonitoringResultType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Id given to the VariableMonitor by the Charging Station. The Id is only returned when status is accepted. Installed VariableMonitors should have unique id's but the id's of removed Installed monitors should have unique id's but the id's of removed monitors MAY be reused.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("statusInfo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public StatusInfoType StatusInfo { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetMonitoringStatusEnumType Status { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MonitorEnumType Type { get; set; }

        [Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ComponentType Component { get; set; } = new ComponentType();

        [Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public VariableType Variable { get; set; } = new VariableType();

        /// <summary>
        /// The severity that will be assigned to an event that is triggered by this monitor. The severity range is 0-9, with 0 as the highest and 9 as the lowest severity level.
        /// <br/>
        /// <br/>The severity levels have the following meaning: +
        /// <br/>*0-Danger* +
        /// <br/>Indicates lives are potentially in danger. Urgent attention is needed and action should be taken immediately. +
        /// <br/>*1-Hardware Failure* +
        /// <br/>Indicates that the Charging Station is unable to continue regular operations due to Hardware issues. Action is required. +
        /// <br/>*2-System Failure* +
        /// <br/>Indicates that the Charging Station is unable to continue regular operations due to software or minor hardware issues. Action is required. +
        /// <br/>*3-Critical* +
        /// <br/>Indicates a critical error. Action is required. +
        /// <br/>*4-Error* +
        /// <br/>Indicates a non-urgent error. Action is required. +
        /// <br/>*5-Alert* +
        /// <br/>Indicates an alert event. Default severity for any type of monitoring event.  +
        /// <br/>*6-Warning* +
        /// <br/>Indicates a warning event. Action may be required. +
        /// <br/>*7-Notice* +
        /// <br/>Indicates an unusual event. No immediate action is required. +
        /// <br/>*8-Informational* +
        /// <br/>Indicates a regular operational event. May be used for reporting, measuring throughput, etc. No action is required. +
        /// <br/>*9-Debug* +
        /// <br/>Indicates information useful to developers for debugging, not useful during operations.
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("severity", Required = Newtonsoft.Json.Required.Always)]
        public int Severity { get; set; }

    }




    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class SetVariableMonitoringResponse
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("setMonitoringResult", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<SetMonitoringResultType> SetMonitoringResult { get; set; } = new System.Collections.ObjectModel.Collection<SetMonitoringResultType>();

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603