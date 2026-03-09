// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Y2IRNdp-Ed-ak6NoX_4Aeg_-2038676269")]
[Description(@"Specifies the underlying financial instrument.")]
public enum UnderlyingTypeCode
{
    /// <summary>
    /// The underlying is an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_Y2IRNtp-Ed-ak6NoX_4Aeg_-1988802884")]
    [Description(@"The underlying is an equity.")]
    Equity,
    
    /// <summary>
    /// The underlying is an index.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_Y2IRN9p-Ed-ak6NoX_4Aeg_-1987879702")]
    [Description(@"The underlying is an index.")]
    Index,
    
    /// <summary>
    /// The underlying is an interest.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_Y2IRONp-Ed-ak6NoX_4Aeg_-1986955781")]
    [Description(@"The underlying is an interest.")]
    Interest,
    
    /// <summary>
    /// The underlying is a currency.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_Y2IROdp-Ed-ak6NoX_4Aeg_-1512268250")]
    [Description(@"The underlying is a currency.")]
    Currency,
    
    /// <summary>
    /// The underlying is a precious metal.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_Y2SCMNp-Ed-ak6NoX_4Aeg_-1499340087")]
    [Description(@"The underlying is a precious metal.")]
    PreciousMetal,
    
    /// <summary>
    /// The underlying is a future.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_Y2SCMdp-Ed-ak6NoX_4Aeg_-1499336660")]
    [Description(@"The underlying is a future.")]
    Future,
    
    /// <summary>
    /// The underlying is an option.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_Y2SCMtp-Ed-ak6NoX_4Aeg_-1497492984")]
    [Description(@"The underlying is an option.")]
    Option,
    
    /// <summary>
    /// The underlying is a basket.
    /// Encoded/decoded by serializers as &quot;BASK&quot;.
    /// </summary>
    [EnumMember(Value = "BASK")]
    [IsoId("_Y2SCM9p-Ed-ak6NoX_4Aeg_-1496568515")]
    [Description(@"The underlying is a basket.")]
    Basket,
    
    /// <summary>
    /// The underlying is a swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_Y2SCNNp-Ed-ak6NoX_4Aeg_-1495643925")]
    [Description(@"The underlying is a swap.")]
    Swap,
    
    /// <summary>
    /// The underlying is a commodity.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_Y2SCNdp-Ed-ak6NoX_4Aeg_-1493796173")]
    [Description(@"The underlying is a commodity.")]
    Commodity,
    
    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as &quot;STIX&quot;.
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_o-mEQCSiEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a stock index.")]
    StockIndex,
    
    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_x_SosCSiEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a share.")]
    Share,
    
    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_1iEy8CSiEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex,
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_5O97cCSiEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend,
    
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ALdXACSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is of other type.")]
    Other,
    
    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as &quot;VOLI&quot;.
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_NHqHsCSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex,
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_Ssu50CSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_dvuGICSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a bond.")]
    Bond,
    
    /// <summary>
    /// Underlying is a future on equity.
    /// Encoded/decoded by serializers as &quot;FTEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_hM-3MCSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a future on equity.")]
    FutureOnEquity,
    
    /// <summary>
    /// Underlying is an option on equity.
    /// Encoded/decoded by serializers as &quot;OPEQ&quot;.
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_n5rYsSSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is an option on equity.")]
    OptionOnEquity,
    
    /// <summary>
    /// Underlying is a bond future.
    /// Encoded/decoded by serializers as &quot;BNDF&quot;.
    /// </summary>
    [EnumMember(Value = "BNDF")]
    [IsoId("_xqQh8CSkEeW2Xf4A_zKwwg")]
    [Description(@"Underlying is a bond future.")]
    BondFuture,
    
}
