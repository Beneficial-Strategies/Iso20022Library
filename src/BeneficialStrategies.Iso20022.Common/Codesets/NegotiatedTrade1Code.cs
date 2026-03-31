// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies whether the trade is negotiated.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aNJuhNp-Ed-ak6NoX_4Aeg_1326174786")]
[Description(@"Specifies whether the trade is negotiated.")]
[DerivedFrom(typeof(NegotiatedTradeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<NegotiatedTrade1Code>))]
#endif
public enum NegotiatedTrade1Code
{
    /// <summary>
    /// Trade is negotiated.
    /// Encoded/decoded by serializers as &quot;NEGO&quot;.
    /// </summary>
    [EnumMember(Value = "NEGO")]
    [IsoId("_aNJuhdp-Ed-ak6NoX_4Aeg_1840573471")]
    [Description(@"Trade is negotiated.")]
    Negotiated = NegotiatedTradeCode.Negotiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trade is not negotiated.
    /// Encoded/decoded by serializers as &quot;NNGO&quot;.
    /// </summary>
    [EnumMember(Value = "NNGO")]
    [IsoId("_aNJuhtp-Ed-ak6NoX_4Aeg_1840573506")]
    [Description(@"Trade is not negotiated.")]
    NotNegotiated = NegotiatedTradeCode.NotNegotiated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Whether the trade is negotiated or not is unknown.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_aNJuh9p-Ed-ak6NoX_4Aeg_1840573524")]
    [Description(@"Whether the trade is negotiated or not is unknown.")]
    Unknown = NegotiatedTradeCode.Unknown, // same ordinal as derivation source for type conversions
}
