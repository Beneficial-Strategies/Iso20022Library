// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-M07AW7iEeKo25nLKvGr8w_1800475441")]
[Description(
    @"Specifies the external submission or presentation channel code in the format of a character string with a maximum length of 4 characters. The list of valid codes is an external code list published separately.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalChannel1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalChannelCode>))]
#endif
public enum ExternalChannelCode
{
    /// <summary>
    /// Delivery by courier.
    /// Encoded/decoded by serializers as &quot;COUR&quot;.
    /// </summary>
    [EnumMember(Value = "COUR")]
    [IsoId("_uOZEXPRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by courier.")]
    Courier,

    /// <summary>
    /// Transmission by e-mail.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_uOi1UPRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by e-mail.")]
    Email,

    /// <summary>
    /// Transmission by fax.
    /// Encoded/decoded by serializers as &quot;FAXI&quot;.
    /// </summary>
    [EnumMember(Value = "FAXI")]
    [IsoId("_uOi1U_RYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by fax.")]
    Fax,

    /// <summary>
    /// Delivery by messenger.
    /// Encoded/decoded by serializers as &quot;MESS&quot;.
    /// </summary>
    [EnumMember(Value = "MESS")]
    [IsoId("_uOi1VvRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by messenger.")]
    Messenger,

    /// <summary>
    /// Delivery by postal service.
    /// Encoded/decoded by serializers as &quot;POST&quot;.
    /// </summary>
    [EnumMember(Value = "POST")]
    [IsoId("_uOi1WfRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by postal service.")]
    Post,

    /// <summary>
    /// Delivery by registered mail services.
    /// Encoded/decoded by serializers as &quot;REGM&quot;.
    /// </summary>
    [EnumMember(Value = "REGM")]
    [IsoId("_uOi1XPRYEeuLhpyIdtJzwg")]
    [Description(@"Delivery by registered mail services.")]
    RegisteredMail,

    /// <summary>
    /// Transfer via secure e-mail.
    /// Encoded/decoded by serializers as &quot;SEMA&quot;.
    /// </summary>
    [EnumMember(Value = "SEMA")]
    [IsoId("_uOsmUPRYEeuLhpyIdtJzwg")]
    [Description(@"Transfer via secure e-mail.")]
    SecureEmail,

    /// <summary>
    /// Transmission by SWIFTNet FileAct.
    /// Encoded/decoded by serializers as &quot;SWFA&quot;.
    /// </summary>
    [EnumMember(Value = "SWFA")]
    [IsoId("_uOsmU_RYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet FileAct.")]
    SWIFTNetFileAct,

    /// <summary>
    /// Transmission by SWIFTNet InterAct.
    /// Encoded/decoded by serializers as &quot;SWIA&quot;.
    /// </summary>
    [EnumMember(Value = "SWIA")]
    [IsoId("_uOsmVvRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet InterAct. ")]
    SWIFTNetInterAct,

    /// <summary>
    /// Transmission by SWIFT (FIN).
    /// Encoded/decoded by serializers as &quot;SWMT&quot;.
    /// </summary>
    [EnumMember(Value = "SWMT")]
    [IsoId("_uOsmWfRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFT (FIN).")]
    SWIFTMT,

    /// <summary>
    /// Transmission by SWIFTNet.
    /// Encoded/decoded by serializers as &quot;SWMX&quot;.
    /// </summary>
    [EnumMember(Value = "SWMX")]
    [IsoId("_uO1wQPRYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by SWIFTNet.")]
    SWIFTMX,

    /// <summary>
    /// Transmission by telecommunications service.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_uO1wQ_RYEeuLhpyIdtJzwg")]
    [Description(@"Transmission by telecommunications service.")]
    Telecommunication,

    /// <summary>
    /// Available via Web upload/download
    /// Encoded/decoded by serializers as &quot;WEBM&quot;.
    /// </summary>
    [EnumMember(Value = "WEBM")]
    [IsoId("_uO_hQPRYEeuLhpyIdtJzwg")]
    [Description(@"Available via Web upload/download")]
    WebUploadDownload,
}
