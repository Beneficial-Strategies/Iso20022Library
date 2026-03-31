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
[IsoId("_aUwLUNp-Ed-ak6NoX_4Aeg_270418666")]
[Description(
    @"Specifies the type of place where a trade was executed, a price was sourced from, an instrument is listed."
)]
[DerivedFrom(typeof(MarketTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<MarketType5Code>))]
#endif
public enum MarketType5Code
{
    /// <summary>
    /// The place is over the counter.
    /// Encoded/decoded by serializers as &quot;OTCO&quot;.
    /// </summary>
    [EnumMember(Value = "OTCO")]
    [IsoId("_aUwLUdp-Ed-ak6NoX_4Aeg_1589066038")]
    [Description(@"The place is over the counter.")]
    OverTheCounter = MarketTypeCode.OverTheCounter, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The place is a stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aUwLUtp-Ed-ak6NoX_4Aeg_-1956234882")]
    [Description(@"The place is a stock exchange.")]
    StockExchange = MarketTypeCode.StockExchange, // same ordinal as derivation source for type conversions
}
