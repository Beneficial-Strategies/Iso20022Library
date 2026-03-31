// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that identifies an administrative type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_H-bSIDNKEeylu6lH-gut-A")]
[Description(@"Code that identifies an administrative type.")]
[Derivations(typeof(AdministrativeType1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AdministrativeTypeCode>))]
#endif
public enum AdministrativeTypeCode
{
    /// <summary>
    /// Text message.
    /// Encoded/decoded by serializers as &quot;TEXT&quot;.
    /// </summary>
    [EnumMember(Value = "TEXT")]
    [IsoId("_N79nkDNKEeylu6lH-gut-A")]
    [Description(@"Text message.")]
    TextMessage,

    /// <summary>
    /// Other administrative type defined at private level.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_TckJYDNKEeylu6lH-gut-A")]
    [Description(@"Other administrative type defined at private level.")]
    OtherPrivate,

    /// <summary>
    /// Other administrative type defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_fkWakDNKEeylu6lH-gut-A")]
    [Description(@"Other administrative type defined at national level.")]
    OtherNational,

    /// <summary>
    /// Currency conversion rate data.
    /// Encoded/decoded by serializers as &quot;CCRD&quot;.
    /// </summary>
    [EnumMember(Value = "CCRD")]
    [IsoId("_kBf7UDNKEeylu6lH-gut-A")]
    [Description(@"Currency conversion rate data.")]
    CurrencyConversionRateData,
}
