// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type for a contract for equity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U38OIGlOEeaLAKoEUNsD9g")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV2Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnderlyingEquityType4Code>))]
#endif
public enum UnderlyingEquityType4Code
{
    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as &quot;STIX&quot;.
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_u5AjUWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a stock index.")]
    StockIndex = UnderlyingTypeV2Code.StockIndex, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_vggBIWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex = UnderlyingTypeV2Code.DividendIndex, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_v6xiUWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is of other type.")]
    Other = UnderlyingTypeV2Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as &quot;VOLI&quot;.
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_wUg4AWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex = UnderlyingTypeV2Code.VolatilityIndex, // same ordinal as derivation source for type conversions
}
