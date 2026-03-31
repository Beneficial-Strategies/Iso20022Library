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
[IsoId("_AOZLsIHCEeaalK9UbuVGFw")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<UnderlyingEquityType6Code>))]
#endif
public enum UnderlyingEquityType6Code
{
    /// <summary>
    /// Underlying is a basket.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_kVvNUYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a basket.")]
    Basket = UnderlyingTypeV3Code.Basket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_khfKUYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex = UnderlyingTypeV3Code.DividendIndex, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as &quot;ETFS&quot;.
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_k8RB0YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund = UnderlyingTypeV3Code.ExchangeTradedFund, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_lhw7kYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is of other type.")]
    Other = UnderlyingTypeV3Code.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as &quot;SHRS&quot;.
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_l3es4YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a share.")]
    Share = UnderlyingTypeV3Code.Share, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_mUMeEYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend = UnderlyingTypeV3Code.StockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as &quot;STIX&quot;.
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_mnPV4YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a stock index.")]
    StockIndex = UnderlyingTypeV3Code.StockIndex, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as &quot;VOLI&quot;.
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_mysX8YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex = UnderlyingTypeV3Code.VolatilityIndex, // same ordinal as derivation source for type conversions
}
