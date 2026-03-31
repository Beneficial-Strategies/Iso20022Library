// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of quote. Can be either an indicative, a tradeable or a restricted tradeable quote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZY2jwtp-Ed-ak6NoX_4Aeg_2060710435")]
[Description(
    @"Identifies the type of quote. Can be either an indicative, a tradeable or a restricted tradeable quote."
)]
[DerivedFrom(typeof(QuoteTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<QuoteType1Code>))]
#endif
public enum QuoteType1Code
{
    /// <summary>
    /// Indicates the type of quote is an indicative quote. ||An indicative quote is used to inform a counterparty of a market. An indicative quote does not result directly in a trade.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_ZY2jw9p-Ed-ak6NoX_4Aeg_2117046401")]
    [Description(
        @"Indicates the type of quote is an indicative quote. ||An indicative quote is used to inform a counterparty of a market. An indicative quote does not result directly in a trade."
    )]
    Indicative = QuoteTypeCode.Indicative, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the type of quote is a tradeable quote. |A tradeable quote is submitted to a market and will result directly in a trade against other orders and quotes in a market.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZY2jxNp-Ed-ak6NoX_4Aeg_2117046443")]
    [Description(
        @"Indicates the type of quote is a tradeable quote. |A tradeable quote is submitted to a market and will result directly in a trade against other orders and quotes in a market."
    )]
    Tradeable = QuoteTypeCode.Tradeable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the type of quote is a restricted tradeable quote. |A restricted tradeable quote is submitted to a market and within a certain restriction (possibly based upon price or quantity) will automatically trade against orders. Order that do not comply with restrictions are sent to the quote issuer who can choose to accept or decline the order.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ZY2jxdp-Ed-ak6NoX_4Aeg_2117046678")]
    [Description(
        @"Indicates the type of quote is a restricted tradeable quote. |A restricted tradeable quote is submitted to a market and within a certain restriction (possibly based upon price or quantity) will automatically trade against orders. Order that do not comply with restrictions are sent to the quote issuer who can choose to accept or decline the order."
    )]
    RestrictedTradeable = QuoteTypeCode.RestrictedTradeable, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Indicates the type of quote is a counter quote.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_ZY2jxtp-Ed-ak6NoX_4Aeg_2117046713")]
    [Description(@"Indicates the type of quote is a counter quote.")]
    Counter = QuoteTypeCode.Counter, // same ordinal as derivation source for type conversions
}
