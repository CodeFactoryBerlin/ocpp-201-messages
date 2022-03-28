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
    /// ID_ Token. Status. Authorization_ Status
    /// <br/>urn:x-oca:ocpp:uid:1:569372
    /// <br/>Current status of the ID Token.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum AuthorizationStatusEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
        Accepted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"Blocked")]
        Blocked = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"ConcurrentTx")]
        ConcurrentTx = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"Expired")]
        Expired = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"Invalid")]
        Invalid = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"NoCredit")]
        NoCredit = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"NotAllowedTypeEVSE")]
        NotAllowedTypeEVSE = 6,

        [System.Runtime.Serialization.EnumMember(Value = @"NotAtThisLocation")]
        NotAtThisLocation = 7,

        [System.Runtime.Serialization.EnumMember(Value = @"NotAtThisTime")]
        NotAtThisTime = 8,

        [System.Runtime.Serialization.EnumMember(Value = @"Unknown")]
        Unknown = 9,

    }

    /// <summary>
    /// Certificate status information. 
    /// <br/>- if all certificates are valid: return 'Accepted'.
    /// <br/>- if one of the certificates was revoked, return 'CertificateRevoked'.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public enum AuthorizeCertificateStatusEnumType
    {

        [System.Runtime.Serialization.EnumMember(Value = @"Accepted")]
        Accepted = 0,

        [System.Runtime.Serialization.EnumMember(Value = @"SignatureError")]
        SignatureError = 1,

        [System.Runtime.Serialization.EnumMember(Value = @"CertificateExpired")]
        CertificateExpired = 2,

        [System.Runtime.Serialization.EnumMember(Value = @"CertificateRevoked")]
        CertificateRevoked = 3,

        [System.Runtime.Serialization.EnumMember(Value = @"NoCertificateAvailable")]
        NoCertificateAvailable = 4,

        [System.Runtime.Serialization.EnumMember(Value = @"CertChainError")]
        CertChainError = 5,

        [System.Runtime.Serialization.EnumMember(Value = @"ContractCancelled")]
        ContractCancelled = 6,

    }







    /// <summary>
    /// ID_ Token
    /// <br/>urn:x-oca:ocpp:uid:2:233247
    /// <br/>Contains status information about an identifier.
    /// <br/>It is advised to not stop charging for a token that expires during charging, as ExpiryDate is only used for caching purposes. If ExpiryDate is not given, the status has no end date.
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class IdTokenInfoType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizationStatusEnumType Status { get; set; }

        /// <summary>
        /// ID_ Token. Expiry. Date_ Time
        /// <br/>urn:x-oca:ocpp:uid:1:569373
        /// <br/>Date and Time after which the token must be considered invalid.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cacheExpiryDateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CacheExpiryDateTime { get; set; }

        /// <summary>
        /// Priority from a business point of view. Default priority is 0, The range is from -9 to 9. Higher values indicate a higher priority. The chargingPriority in &amp;lt;&amp;lt;transactioneventresponse,TransactionEventResponse&amp;gt;&amp;gt; overrules this one. 
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("chargingPriority", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ChargingPriority { get; set; }

        /// <summary>
        /// ID_ Token. Language1. Language_ Code
        /// <br/>urn:x-oca:ocpp:uid:1:569374
        /// <br/>Preferred user interface language of identifier user. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public string Language1 { get; set; }

        /// <summary>
        /// Only used when the IdToken is only valid for one or more specific EVSEs, not for the entire Charging Station.
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("evseId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.Generic.ICollection<int> EvseId { get; set; }

        [Newtonsoft.Json.JsonProperty("groupIdToken", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IdTokenType GroupIdToken { get; set; }

        /// <summary>
        /// ID_ Token. Language2. Language_ Code
        /// <br/>urn:x-oca:ocpp:uid:1:569375
        /// <br/>Second preferred user interface language of identifier user. Don’t use when language1 is omitted, has to be different from language1. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public string Language2 { get; set; }

        [Newtonsoft.Json.JsonProperty("personalMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public MessageContentType PersonalMessage { get; set; }

    }



    /// <summary>
    /// Message_ Content
    /// <br/>urn:x-enexis:ecdm:uid:2:234490
    /// <br/>Contains message details, for a message to be displayed on a Charging Station.
    /// <br/>
    /// <br/>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class MessageContentType
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("format", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public MessageFormatEnumType Format { get; set; }

        /// <summary>
        /// Message_ Content. Language. Language_ Code
        /// <br/>urn:x-enexis:ecdm:uid:1:570849
        /// <br/>Message language identifier. Contains a language code as defined in &amp;lt;&amp;lt;ref-RFC5646,[RFC5646]&amp;gt;&amp;gt;.
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(8)]
        public string Language { get; set; }

        /// <summary>
        /// Message_ Content. Content. Message
        /// <br/>urn:x-enexis:ecdm:uid:1:570852
        /// <br/>Message contents.
        /// <br/>
        /// <br/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [System.ComponentModel.DataAnnotations.StringLength(512)]
        public string Content { get; set; }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.15.10.0 (NJsonSchema v10.6.10.0 (Newtonsoft.Json v12.0.0.0))")]
    public partial class AuthorizeResponse
    {
        [Newtonsoft.Json.JsonProperty("customData", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomDataType CustomData { get; set; }

        [Newtonsoft.Json.JsonProperty("idTokenInfo", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public IdTokenInfoType IdTokenInfo { get; set; } = new IdTokenInfoType();

        [Newtonsoft.Json.JsonProperty("certificateStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AuthorizeCertificateStatusEnumType? CertificateStatus { get; set; }

    }


}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108
#pragma warning restore 3016
#pragma warning restore 8603