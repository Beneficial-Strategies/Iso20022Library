// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__3I0YNojEeC60axPepSq7g_-47982085")]
[Description(
    @"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed."
)]
[DerivedFrom(typeof(MarketTypeCode))]
public enum MarketType6Code
{
    /// <summary>
    /// The place is over the counter.
    /// Encoded/decoded by serializers as &quot;OTCO&quot;.
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("__3I0YdojEeC60axPepSq7g_-615099029")]
    [Description(@"The place is over the counter.")]
    OverTheCounter = MarketTypeCode.OverTheCounter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Various places.
    /// Encoded/decoded by serializers as &quot;VARI&quot;.
    /// </summary>
    [EnumMember(Value = "VARI")]
    [IsoId("__3I0YtojEeC60axPepSq7g_852049734")]
    [Description(@"Various places.")]
    Various = MarketTypeCode.Various, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("__3I0Y9ojEeC60axPepSq7g_858735869")]
    [Description(@"The place is a stock exchange.")]
    StockExchange = MarketTypeCode.StockExchange, // same ordinal as derivation source for type conversions
}
