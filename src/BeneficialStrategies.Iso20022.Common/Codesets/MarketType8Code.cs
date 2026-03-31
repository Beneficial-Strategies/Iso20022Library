// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_90JVoDzyEeWLuazO9XdCTg")]
[Description(
    @"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed."
)]
[DerivedFrom(typeof(MarketTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketType8Code>))]
#endif
public enum MarketType8Code
{
    /// <summary>
    /// Specified type of market is counter market.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_FcGlgTzzEeWLuazO9XdCTg")]
    [Description(@"Specified type of market is counter market.")]
    Counter = MarketTypeCode.Counter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specified type of market is inter bank market.
    /// Encoded/decoded by serializers as &quot;INBA&quot;.
    /// </summary>
    [EnumMember(Value = "INBA")]
    [IsoId("_F4RkITzzEeWLuazO9XdCTg")]
    [Description(@"Specified type of market is inter bank market.")]
    InterBank = MarketTypeCode.InterBank, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is over the counter.
    /// Encoded/decoded by serializers as &quot;OTCO&quot;.
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("_GeAucTzzEeWLuazO9XdCTg")]
    [Description(@"The place is over the counter.")]
    OverTheCounter = MarketTypeCode.OverTheCounter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a primary market.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_G9KvoTzzEeWLuazO9XdCTg")]
    [Description(@"The place is a primary market.")]
    PrimaryMarket = MarketTypeCode.PrimaryMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a secondary market.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_HgWVMTzzEeWLuazO9XdCTg")]
    [Description(@"The place is a secondary market.")]
    SecondaryMarket = MarketTypeCode.SecondaryMarket, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_IEdH0TzzEeWLuazO9XdCTg")]
    [Description(@"The place is a stock exchange.")]
    StockExchange = MarketTypeCode.StockExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Various places.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_OIREYTzzEeWLuazO9XdCTg")]
    [Description(@"Various places.")]
    Various = MarketTypeCode.Various, // same ordinal as derivation source for type conversions
}
