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
    /// Data type of this variable.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum DataEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"string")]
        String = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"decimal")]
        Decimal = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"integer")]
        Integer = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"dateTime")]
        DateTime = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"boolean")]
        Boolean = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"OptionList")]
        OptionList = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"SequenceList")]
        SequenceList = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"MemberList")]
        MemberList = 7,

    }

    /// <summary>
    /// Defines the mutability of this attribute. Default is ReadWrite when omitted.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum MutabilityEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"ReadOnly")]
        ReadOnly = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"WriteOnly")]
        WriteOnly = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ReadWrite")]
        ReadWrite = 2,

    }





    /// <summary>
    /// Class to report components, variables and variable attributes and characteristics.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ReportDataType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("component", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ComponentType Component { get; set; } = new ComponentType();

        [Newtonsoft.Json.JsonProperty("variable", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public VariableType Variable { get; set; } = new VariableType();

        [Newtonsoft.Json.JsonProperty("variableAttribute", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(4)]
        public System.Collections.Generic.ICollection<VariableAttributeType> VariableAttribute { get; set; } = new System.Collections.ObjectModel.Collection<VariableAttributeType>();

        [Newtonsoft.Json.JsonProperty("variableCharacteristics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public VariableCharacteristicsType VariableCharacteristics { get; set; }

    }

    /// <summary>
    /// Attribute data of a variable.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class VariableAttributeType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AttributeEnumType? Type { get; set; }

        /// <summary>
        /// Value of the attribute. May only be omitted when mutability is set to 'WriteOnly'.
        /// <br/>
        /// <br/>The Configuration Variable &amp;lt;&amp;lt;configkey-reporting-value-size,ReportingValueSize&amp;gt;&amp;gt; can be used to limit GetVariableResult.attributeValue, VariableAttribute.value and EventData.actualValue. The max size of these values will always remain equal. 
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2500)]
        public string Value { get; set; }

        [Newtonsoft.Json.JsonProperty("mutability", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MutabilityEnumType? Mutability { get; set; }

        /// <summary>
        /// If true, value will be persistent across system reboots or power down. Default when omitted is false.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("persistent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Persistent { get; set; } = false;

        /// <summary>
        /// If true, value that will never be changed by the Charging Station at runtime. Default when omitted is false.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("constant", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Constant { get; set; } = false;

    }

    /// <summary>
    /// Fixed read-only parameters of a variable.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class VariableCharacteristicsType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Unit of the variable. When the transmitted value has a unit, this field SHALL be included.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(16)]
        public string Unit { get; set; }

        [Newtonsoft.Json.JsonProperty("dataType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DataEnumType DataType { get; set; }

        /// <summary>
        /// Minimum possible value of this variable.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinLimit { get; set; }

        /// <summary>
        /// Maximum possible value of this variable. When the datatype of this Variable is String, OptionList, SequenceList or MemberList, this field defines the maximum length of the (CSV) string.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxLimit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxLimit { get; set; }

        /// <summary>
        /// Allowed values when variable is Option/Member/SequenceList. 
        /// <br/>
        /// <br/>* OptionList: The (Actual) Variable value must be a single value from the reported (CSV) enumeration list.
        /// <br/>
        /// <br/>* MemberList: The (Actual) Variable value  may be an (unordered) (sub-)set of the reported (CSV) valid values list.
        /// <br/>
        /// <br/>* SequenceList: The (Actual) Variable value  may be an ordered (priority, etc)  (sub-)set of the reported (CSV) valid values.
        /// <br/>
        /// <br/>This is a comma separated list.
        /// <br/>
        /// <br/>The Configuration Variable &amp;lt;&amp;lt;configkey-configuration-value-size,ConfigurationValueSize&amp;gt;&amp;gt; can be used to limit SetVariableData.attributeValue and VariableCharacteristics.valueList. The max size of these values will always remain equal. 
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("valuesList", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(1000)]
        public string ValuesList { get; set; }

        /// <summary>
        /// Flag indicating if this variable supports monitoring. 
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supportsMonitoring", Required = Newtonsoft.Json.Required.Always)]
        public bool SupportsMonitoring { get; set; }

    }



    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class NotifyReportRequest
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// The id of the GetReportRequest  or GetBaseReportRequest that requested this report
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.Always)]
        public int RequestId { get; set; }

        /// <summary>
        /// Timestamp of the moment this message was generated at the Charging Station.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generatedAt", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset GeneratedAt { get; set; }

        [Newtonsoft.Json.JsonProperty("reportData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<ReportDataType> ReportData { get; set; }

        /// <summary>
        /// ???to be continued??? indicator. Indicates whether another part of the report follows in an upcoming notifyReportRequest message. Default value when omitted is false.
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tbc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Tbc { get; set; } = false;

        /// <summary>
        /// Sequence number of this message. First message starts at 0.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seqNo", Required = Newtonsoft.Json.Required.Always)]
        public int SeqNo { get; set; }

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603