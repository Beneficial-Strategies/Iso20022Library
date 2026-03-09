// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the type of quote. Can be either an indicative, a tradeable or a restricted tradeable quote.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ZY2jx9p-Ed-ak6NoX_4Aeg_336258538")]
[Description(@"Identifies the type of quote. Can be either an indicative, a tradeable or a restricted tradeable quote.")]
[Derivations(typeof(QuoteType1Code))]
public enum QuoteTypeCode
{
    /// <summary>
    /// Indicates the type of quote is an indicative quote. ||An indicative quote is used to inform a counterparty of a market. An indicative quote does not result directly in a trade.
    /// Encoded/decoded by serializers as &quot;INDI&quot;.
    /// </summary>
    [EnumMember(Value = "INDI")]
    [IsoId("_ZY2jyNp-Ed-ak6NoX_4Aeg_336258555")]
    [Description(@"Indicates the type of quote is an indicative quote. ||An indicative quote is used to inform a counterparty of a market. An indicative quote does not result directly in a trade.")]
    Indicative,
    
    /// <summary>
    /// Indicates the type of quote is a tradeable quote. |A tradeable quote is submitted to a market and will result directly in a trade against other orders and quotes in a market.
    /// Encoded/decoded by serializers as &quot;TRAD&quot;.
    /// </summary>
    [EnumMember(Value = "TRAD")]
    [IsoId("_ZY_tsNp-Ed-ak6NoX_4Aeg_336258564")]
    [Description(@"Indicates the type of quote is a tradeable quote. |A tradeable quote is submitted to a market and will result directly in a trade against other orders and quotes in a market.")]
    Tradeable,
    
    /// <summary>
    /// Indicates the type of quote is a restricted tradeable quote. |A restricted tradeable quote is submitted to a market and within a certain restriction (possibly based upon price or quantity) will automatically trade against orders. Order that do not comply with restrictions are sent to the quote issuer who can choose to accept or decline the order.
    /// Encoded/decoded by serializers as &quot;REST&quot;.
    /// </summary>
    [EnumMember(Value = "REST")]
    [IsoId("_ZY_tsdp-Ed-ak6NoX_4Aeg_336258565")]
    [Description(@"Indicates the type of quote is a restricted tradeable quote. |A restricted tradeable quote is submitted to a market and within a certain restriction (possibly based upon price or quantity) will automatically trade against orders. Order that do not comply with restrictions are sent to the quote issuer who can choose to accept or decline the order.")]
    RestrictedTradeable,
    
    /// <summary>
    /// Indicates the type of quote is a counter quote.
    /// Encoded/decoded by serializers as &quot;COUN&quot;.
    /// </summary>
    [EnumMember(Value = "COUN")]
    [IsoId("_ZY_tstp-Ed-ak6NoX_4Aeg_336258566")]
    [Description(@"Indicates the type of quote is a counter quote.")]
    Counter,
    
}
