// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market in which transactions take place, eg, primary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUTfZNp-Ed-ak6NoX_4Aeg_2050093734")]
[Description(@"Specifies the type of market in which transactions take place, eg, primary.")]
[DerivedFrom(typeof(MarketTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketType1Code>))]
#endif
public enum MarketType1Code
{
    /// <summary>
    /// The place is a primary market.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_aUTfZdp-Ed-ak6NoX_4Aeg_2050094305")]
    [Description(@"The place is a primary market.")]
    PrimaryMarket = MarketTypeCode.PrimaryMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a secondary market.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_aUTfZtp-Ed-ak6NoX_4Aeg_2051015336")]
    [Description(@"The place is a secondary market.")]
    SecondaryMarket = MarketTypeCode.SecondaryMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a third market.
    /// Encoded/decoded by serializers as &quot;THIM&quot;.
    /// </summary>
    [EnumMember(Value = "THIM")]
    [IsoId("_aUTfZ9p-Ed-ak6NoX_4Aeg_-1860687416")]
    [Description(@"The place is a third market.")]
    ThirdMarket = MarketTypeCode.ThirdMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a fourth market.
    /// Encoded/decoded by serializers as &quot;FOUM&quot;.
    /// </summary>
    [EnumMember(Value = "FOUM")]
    [IsoId("_aUdQYNp-Ed-ak6NoX_4Aeg_-1831136197")]
    [Description(@"The place is a fourth market.")]
    FourthMarket = MarketTypeCode.FourthMarket, // same ordinal as derivation source for type conversions
}
