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
    /// Sampled_ Value. Location. Location_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569265
    /// <br/>Indicates where the measured value has been sampled. Default =  "Outlet"
    /// <br/>
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum LocationEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Body")]
        Body = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Cable")]
        Cable = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"EV")]
        EV = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Inlet")]
        Inlet = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Outlet")]
        Outlet = 4,

    }

    /// <summary>
    /// Sampled_ Value. Measurand. Measurand_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569263
    /// <br/>Type of measurement. Default = "Energy.Active.Import.Register"
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum MeasurandEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Current.Export")]
        Current_Export = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Current.Import")]
        Current_Import = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Current.Offered")]
        Current_Offered = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Export.Register")]
        Energy_Active_Export_Register = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Import.Register")]
        Energy_Active_Import_Register = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Export.Register")]
        Energy_Reactive_Export_Register = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Import.Register")]
        Energy_Reactive_Import_Register = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Export.Interval")]
        Energy_Active_Export_Interval = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Import.Interval")]
        Energy_Active_Import_Interval = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Active.Net")]
        Energy_Active_Net = 9,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Export.Interval")]
        Energy_Reactive_Export_Interval = 10,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Import.Interval")]
        Energy_Reactive_Import_Interval = 11,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Reactive.Net")]
        Energy_Reactive_Net = 12,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Apparent.Net")]
        Energy_Apparent_Net = 13,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Apparent.Import")]
        Energy_Apparent_Import = 14,

        [System.Runtime.Serialization.EnumMember(Value = @"Energy.Apparent.Export")]
        Energy_Apparent_Export = 15,

        [System.Runtime.Serialization.EnumMember(Value = @"Frequency")]
        Frequency = 16,

        [System.Runtime.Serialization.EnumMember(Value = @"Power.Active.Export")]
        Power_Active_Export = 17,

        [System.Runtime.Serialization.EnumMember(Value = @"Power.Active.Import")]
        Power_Active_Import = 18,

        [System.Runtime.Serialization.EnumMember(Value = @"Power.Factor")]
        Power_Factor = 19,

        [System.Runtime.Serialization.EnumMember(Value = @"Power.Offered")]
        Power_Offered = 20,

        [System.Runtime.Serialization.EnumMember(Value = @"Power.Reactive.Export")]
        Power_Reactive_Export = 21,

        [System.Runtime.Serialization.EnumMember(Value = @"Power.Reactive.Import")]
        Power_Reactive_Import = 22,

        [System.Runtime.Serialization.EnumMember(Value = @"SoC")]
        SoC = 23,

        [System.Runtime.Serialization.EnumMember(Value = @"Voltage")]
        Voltage = 24,

    }

    /// <summary>
    /// Sampled_ Value. Phase. Phase_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569264
    /// <br/>Indicates how the measured value is to be interpreted. For instance between L1 and neutral (L1-N) Please note that not all values of phase are applicable to all Measurands. When phase is absent, the measured value is interpreted as an overall value.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum PhaseEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"L1")]
        L1 = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"L2")]
        L2 = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"L3")]
        L3 = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"N")]
        N = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"L1-N")]
        L1N = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"L2-N")]
        L2N = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"L3-N")]
        L3N = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"L1-L2")]
        L1L2 = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"L2-L3")]
        L2L3 = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"L3-L1")]
        L3L1 = 9,

    }

    /// <summary>
    /// Sampled_ Value. Context. Reading_ Context_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569261
    /// <br/>Type of detail value: start, end or sample. Default = "Sample.Periodic"
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum ReadingContextEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Interruption.Begin")]
        Interruption_Begin = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Interruption.End")]
        Interruption_End = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"Other")]
        Other = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Sample.Clock")]
        Sample_Clock = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Sample.Periodic")]
        Sample_Periodic = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"Transaction.Begin")]
        Transaction_Begin = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"Transaction.End")]
        Transaction_End = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"Trigger")]
        Trigger = 7,

    }

    /// <summary>
    /// Meter_ Value
    /// <br/>urn:x-oca:ocpp:uid:2:233265
    /// <br/>Collection of one or more sampled values in MeterValuesRequest and TransactionEvent. All sampled values in a MeterValue are sampled at the same point in time.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class MeterValueType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("sampledValue", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<SampledValueType> SampledValue { get; set; } = new System.Collections.ObjectModel.Collection<SampledValueType>();

        /// <summary>
        /// Meter_ Value. Timestamp. Date_ Time
        /// <br/>urn:x-oca:ocpp:uid:1:569259
        /// <br/>Timestamp for measured value(s).
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Timestamp { get; set; }

    }

    /// <summary>
    /// Sampled_ Value
    /// <br/>urn:x-oca:ocpp:uid:2:233266
    /// <br/>Single sampled value in MeterValues. Each value can be accompanied by optional fields.
    /// <br/>
    /// <br/>To save on mobile data usage, default values of all of the optional fields are such that. The value without any additional fields will be interpreted, as a register reading of active import energy in Wh (Watt-hour) units.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class SampledValueType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Sampled_ Value. Value. Measure
        /// <br/>urn:x-oca:ocpp:uid:1:569260
        /// <br/>Indicates the measured value.
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }

        [Newtonsoft.Json.JsonProperty("context", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ReadingContextEnumType? Context { get; set; }

        [Newtonsoft.Json.JsonProperty("measurand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MeasurandEnumType? Measurand { get; set; }

        [Newtonsoft.Json.JsonProperty("phase", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PhaseEnumType? Phase { get; set; }

        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public LocationEnumType? Location { get; set; }

        [Newtonsoft.Json.JsonProperty("signedMeterValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignedMeterValueType SignedMeterValue { get; set; }

        [Newtonsoft.Json.JsonProperty("unitOfMeasure", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public UnitOfMeasureType UnitOfMeasure { get; set; }

    }

    /// <summary>
    /// Represent a signed version of the meter value.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class SignedMeterValueType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Base64 encoded, contains the signed data which might contain more then just the meter value. It can contain information like timestamps, reference to a customer etc.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signedMeterData", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(2500)]
        public string SignedMeterData { get; set; }

        /// <summary>
        /// Method used to create the digital signature.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("signingMethod", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string SigningMethod { get; set; }

        /// <summary>
        /// Method used to encode the meter values before applying the digital signature algorithm.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("encodingMethod", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string EncodingMethod { get; set; }

        /// <summary>
        /// Base64 encoded, sending depends on configuration variable _PublicKeyWithSignedMeterValue_.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publicKey", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(2500)]
        public string PublicKey { get; set; }

    }

    /// <summary>
    /// Represents a UnitOfMeasure with a multiplier
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class UnitOfMeasureType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Unit of the value. Default = "Wh" if the (default) measurand is an "Energy" type.
        /// <br/>This field SHALL use a value from the list Standardized Units of Measurements in Part 2 Appendices. 
        /// <br/>If an applicable unit is available in that list, otherwise a "custom" unit might be used.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(20)]
        public string Unit { get; set; } = "Wh";

        /// <summary>
        /// Multiplier, this value represents the exponent to base 10. I.e. multiplier 3 means 10 raised to the 3rd power. Default is 0.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("multiplier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Multiplier { get; set; } = 0;

    }

    /// <summary>
    /// Request_ Body
    /// <br/>urn:x-enexis:ecdm:uid:2:234744
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class MeterValuesRequest
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Request_ Body. EVSEID. Numeric_ Identifier
        /// <br/>urn:x-enexis:ecdm:uid:1:571101
        /// <br/>This contains a number (&amp;gt;0) designating an EVSE of the Charging Station. ‘0’ (zero) is used to designate the main power meter.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Always)]
        public int EvseId { get; set; }

        [Newtonsoft.Json.JsonProperty("meterValue", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<MeterValueType> MeterValue { get; set; } = new System.Collections.ObjectModel.Collection<MeterValueType>();

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603