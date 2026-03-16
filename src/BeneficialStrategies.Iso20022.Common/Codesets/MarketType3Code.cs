// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market in which transactions take place, for example, primary or secondary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUdQZ9p-Ed-ak6NoX_4Aeg_986076424")]
[Description(
    @"Specifies the type of market in which transactions take place, for example, primary or secondary."
)]
[DerivedFrom(typeof(MarketTypeCode))]
public enum MarketType3Code
{
    /// <summary>
    /// The place is a primary market.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_aUmaUNp-Ed-ak6NoX_4Aeg_1045181672")]
    [Description(@"The place is a primary market.")]
    PrimaryMarket = MarketTypeCode.PrimaryMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a secondary market.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_aUmaUdp-Ed-ak6NoX_4Aeg_1045181697")]
    [Description(@"The place is a secondary market.")]
    SecondaryMarket = MarketTypeCode.SecondaryMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is over the counter.
    /// Encoded/decoded by serializers as &quot;OTCO&quot;.
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("_aUmaUtp-Ed-ak6NoX_4Aeg_1045181733")]
    [Description(@"The place is over the counter.")]
    OverTheCounter = MarketTypeCode.OverTheCounter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aUmaU9p-Ed-ak6NoX_4Aeg_1045181750")]
    [Description(@"The place is a stock exchange.")]
    StockExchange = MarketTypeCode.StockExchange, // same ordinal as derivation source for type conversions
}
