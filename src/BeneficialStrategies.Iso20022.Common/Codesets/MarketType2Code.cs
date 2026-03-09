// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of market in which transactions take place, for example, primary.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aUdQYdp-Ed-ak6NoX_4Aeg_-922054322")]
[Description(@"Specifies the type of market in which transactions take place, for example, primary.")]
[DerivedFrom(typeof(MarketTypeCode))]
public enum MarketType2Code
{
    /// <summary>
    /// The place is a primary market.
    /// Encoded/decoded by serializers as &quot;PRIM&quot;.
    /// </summary>
    [EnumMember(Value = "PRIM")]
    [IsoId("_aUdQYtp-Ed-ak6NoX_4Aeg_-922054296")]
    [Description(@"The place is a primary market.")]
    PrimaryMarket = MarketTypeCode.PrimaryMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The place is a secondary market.
    /// Encoded/decoded by serializers as &quot;SECM&quot;.
    /// </summary>
    [EnumMember(Value = "SECM")]
    [IsoId("_aUdQY9p-Ed-ak6NoX_4Aeg_-922054280")]
    [Description(@"The place is a secondary market.")]
    SecondaryMarket = MarketTypeCode.SecondaryMarket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The place is over the counter.
    /// Encoded/decoded by serializers as &quot;OTCO&quot;.
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("_aUdQZNp-Ed-ak6NoX_4Aeg_-922054262")]
    [Description(@"The place is over the counter.")]
    OverTheCounter = MarketTypeCode.OverTheCounter, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Various places.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("_aUdQZdp-Ed-ak6NoX_4Aeg_-922054261")]
    [Description(@"Various places.")]
    Various = MarketTypeCode.Various, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The place is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aUdQZtp-Ed-ak6NoX_4Aeg_127744806")]
    [Description(@"The place is a stock exchange.")]
    StockExchange = MarketTypeCode.StockExchange, // same ordinal as derivation source for type conversions
    
}
