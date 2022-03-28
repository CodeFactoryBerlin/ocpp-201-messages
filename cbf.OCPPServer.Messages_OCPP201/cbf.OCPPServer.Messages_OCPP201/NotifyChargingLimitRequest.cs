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
    /// Cost. Cost_ Kind. Cost_ Kind_ Code
    /// <br/>urn:x-oca:ocpp:uid:1:569243
    /// <br/>The kind of cost referred to in the message element amount
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum CostKindEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"CarbonDioxideEmission")]
        CarbonDioxideEmission = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"RelativePricePercentage")]
        RelativePricePercentage = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"RenewableGenerationPercentage")]
        RenewableGenerationPercentage = 2,

    }

    /// <summary>
    /// Charging_ Limit
    /// <br/>urn:x-enexis:ecdm:uid:2:234489
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ChargingLimitType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("chargingLimitSource", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingLimitSourceEnumType ChargingLimitSource { get; set; }

        /// <summary>
        /// Charging_ Limit. Is_ Grid_ Critical. Indicator
        /// <br/>urn:x-enexis:ecdm:uid:1:570847
        /// <br/>Indicates whether the charging limit is critical for the grid.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("isGridCritical", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsGridCritical { get; set; }

    }


    /// <summary>
    /// Charging_ Schedule
    /// <br/>urn:x-oca:ocpp:uid:2:233256
    /// <br/>Charging schedule structure defines a list of charging periods, as used in: GetCompositeSchedule.conf and ChargingProfile. 
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ChargingScheduleType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Identifies the ChargingSchedule.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }

        /// <summary>
        /// Charging_ Schedule. Start_ Schedule. Date_ Time
        /// <br/>urn:x-oca:ocpp:uid:1:569237
        /// <br/>Starting point of an absolute schedule. If absent the schedule will be relative to start of charging.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startSchedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartSchedule { get; set; }

        /// <summary>
        /// Charging_ Schedule. Duration. Elapsed_ Time
        /// <br/>urn:x-oca:ocpp:uid:1:569236
        /// <br/>Duration of the charging schedule in seconds. If the duration is left empty, the last period will continue indefinitely or until end of the transaction if chargingProfilePurpose = TxProfile.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Duration { get; set; }

        [Newtonsoft.Json.JsonProperty("chargingRateUnit", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ChargingRateUnitEnumType ChargingRateUnit { get; set; }

        [Newtonsoft.Json.JsonProperty("chargingSchedulePeriod", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(1024)]
        public System.Collections.Generic.ICollection<ChargingSchedulePeriodType> ChargingSchedulePeriod { get; set; } = new System.Collections.ObjectModel.Collection<ChargingSchedulePeriodType>();

        /// <summary>
        /// Charging_ Schedule. Min_ Charging_ Rate. Numeric
        /// <br/>urn:x-oca:ocpp:uid:1:569239
        /// <br/>Minimum charging rate supported by the EV. The unit of measure is defined by the chargingRateUnit. This parameter is intended to be used by a local smart charging algorithm to optimize the power allocation for in the case a charging process is inefficient at lower charging rates. Accepts at most one digit fraction (e.g. 8.1)
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minChargingRate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinChargingRate { get; set; }

        [Newtonsoft.Json.JsonProperty("salesTariff", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SalesTariffType SalesTariff { get; set; }

    }

    /// <summary>
    /// Consumption_ Cost
    /// <br/>urn:x-oca:ocpp:uid:2:233259
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class ConsumptionCostType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Consumption_ Cost. Start_ Value. Numeric
        /// <br/>urn:x-oca:ocpp:uid:1:569246
        /// <br/>The lowest level of consumption that defines the starting point of this consumption block. The block interval extends to the start of the next interval.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startValue", Required = Newtonsoft.Json.Required.Always)]
        public double StartValue { get; set; }

        [Newtonsoft.Json.JsonProperty("cost", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<CostType> Cost { get; set; } = new System.Collections.ObjectModel.Collection<CostType>();

    }

    /// <summary>
    /// Cost
    /// <br/>urn:x-oca:ocpp:uid:2:233258
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class CostType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("costKind", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public CostKindEnumType CostKind { get; set; }

        /// <summary>
        /// Cost. Amount. Amount
        /// <br/>urn:x-oca:ocpp:uid:1:569244
        /// <br/>The estimated or actual cost per kWh
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public int Amount { get; set; }

        /// <summary>
        /// Cost. Amount_ Multiplier. Integer
        /// <br/>urn:x-oca:ocpp:uid:1:569245
        /// <br/>Values: -3..3, The amountMultiplier defines the exponent to base 10 (dec). The final value is determined by: amount * 10 ^ amountMultiplier
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountMultiplier", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? AmountMultiplier { get; set; }

    }

    /// <summary>
    /// Relative_ Timer_ Interval
    /// <br/>urn:x-oca:ocpp:uid:2:233270
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class RelativeTimeIntervalType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Relative_ Timer_ Interval. Start. Elapsed_ Time
        /// <br/>urn:x-oca:ocpp:uid:1:569279
        /// <br/>Start of the interval, in seconds from NOW.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start", Required = Newtonsoft.Json.Required.Always)]
        public int Start { get; set; }

        /// <summary>
        /// Relative_ Timer_ Interval. Duration. Elapsed_ Time
        /// <br/>urn:x-oca:ocpp:uid:1:569280
        /// <br/>Duration of the interval, in seconds.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("duration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Duration { get; set; }

    }

    /// <summary>
    /// Sales_ Tariff_ Entry
    /// <br/>urn:x-oca:ocpp:uid:2:233271
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class SalesTariffEntryType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("relativeTimeInterval", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public RelativeTimeIntervalType RelativeTimeInterval { get; set; } = new RelativeTimeIntervalType();

        /// <summary>
        /// Sales_ Tariff_ Entry. E_ Price_ Level. Unsigned_ Integer
        /// <br/>urn:x-oca:ocpp:uid:1:569281
        /// <br/>Defines the price level of this SalesTariffEntry (referring to NumEPriceLevels). Small values for the EPriceLevel represent a cheaper TariffEntry. Large values for the EPriceLevel represent a more expensive TariffEntry.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ePriceLevel", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int? EPriceLevel { get; set; }

        [Newtonsoft.Json.JsonProperty("consumptionCost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(3)]
        public System.Collections.Generic.ICollection<ConsumptionCostType> ConsumptionCost { get; set; }

    }

    /// <summary>
    /// Sales_ Tariff
    /// <br/>urn:x-oca:ocpp:uid:2:233272
    /// <br/>NOTE: This dataType is based on dataTypes from &amp;lt;&amp;lt;ref-ISOIEC15118-2,ISO 15118-2&amp;gt;&amp;gt;.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class SalesTariffType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        /// <summary>
        /// Identified_ Object. MRID. Numeric_ Identifier
        /// <br/>urn:x-enexis:ecdm:uid:1:569198
        /// <br/>SalesTariff identifier used to identify one sales tariff. An SAID remains a unique identifier for one schedule throughout a charging session.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        public int Id { get; set; }

        /// <summary>
        /// Sales_ Tariff. Sales. Tariff_ Description
        /// <br/>urn:x-oca:ocpp:uid:1:569283
        /// <br/>A human readable title/short description of the sales tariff e.g. for HMI display purposes.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("salesTariffDescription", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(32)]
        public string SalesTariffDescription { get; set; }

        /// <summary>
        /// Sales_ Tariff. Num_ E_ Price_ Levels. Counter
        /// <br/>urn:x-oca:ocpp:uid:1:569284
        /// <br/>Defines the overall number of distinct price levels used across all provided SalesTariff elements.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("numEPriceLevels", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? NumEPriceLevels { get; set; }

        [Newtonsoft.Json.JsonProperty("salesTariffEntry", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(1024)]
        public System.Collections.Generic.ICollection<SalesTariffEntryType> SalesTariffEntry { get; set; } = new System.Collections.ObjectModel.Collection<SalesTariffEntryType>();

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class NotifyChargingLimitRequest
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("chargingSchedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<ChargingScheduleType> ChargingSchedule { get; set; }

        /// <summary>
        /// The charging schedule contained in this notification applies to an EVSE. evseId must be &amp;gt; 0.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? EvseId { get; set; }

        [Newtonsoft.Json.JsonProperty("chargingLimit", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ChargingLimitType ChargingLimit { get; set; } = new ChargingLimitType();

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603