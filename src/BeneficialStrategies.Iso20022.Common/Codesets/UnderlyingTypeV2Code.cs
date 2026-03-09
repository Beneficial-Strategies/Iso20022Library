// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_01GtYOJOEeWKDJcMqE1cSA")]
[Description(@"Specifies the underlying financial instrument.")]
[Derivations(typeof(UnderlyingEquityType3Code),typeof(UnderlyingEquityType4Code))]
public enum UnderlyingTypeV2Code
{
    /// <summary>
    /// Underlying is a basket.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_Bv_2gOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a basket.")]
    Basket,
    
    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_DCjDgOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a bond.")]
    Bond,
    
    /// <summary>
    /// Underlying is a bond future.
    /// Encoded/decoded by serializers as &quot;BNDF&quot;.
    /// </summary>
    [EnumMember(Value = "BNDF")]
    [IsoId("_El5FkOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a bond future.")]
    BondFuture,
    
    /// <summary>
    /// Underlying is a commodity.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_GewEoOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a commodity.")]
    Commodity,
    
    /// <summary>
    /// Underlying is a currency.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_IJ9CMOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a currency.")]
    Currency,
    
    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_KLIPwOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex,
    
    /// <summary>
    /// Underlying is an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_MapbUOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an equity.")]
    Equity,
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as &quot;ETFT&quot;.
    /// </summary>
    [EnumMember(Value = "ETFT")]
    [IsoId("_ODfBYOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund,
    
    /// <summary>
    /// Underlying is a future.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_dMyi0OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a future.")]
    Future,
    
    /// <summary>
    /// Underlying is a future on equity.
    /// Encoded/decoded by serializers as &quot;FTEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_gEvnYOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a future on equity.")]
    FutureOnEquity,
    
    /// <summary>
    /// Underlying is an index.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_iIhdAOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an index.")]
    Index,
    
    /// <summary>
    /// Underlying is interest.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_jmvugOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is interest.")]
    Interest,
    
    /// <summary>
    /// Underlying is an option.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_lnYwkOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an option.")]
    Option,
    
    /// <summary>
    /// Underlying is an option on equity.
    /// Encoded/decoded by serializers as &quot;OPEQ&quot;.
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_m9iEIOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is an option on equity.")]
    OptionOnEquity,
    
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_olTTMOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is of other type.")]
    Other,
    
    /// <summary>
    /// Underlying is precious metal.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_pvdZMOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is precious metal.")]
    PreciousMetal,
    
    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as &quot;SHAR&quot;.
    /// </summary>
    [EnumMember(Value = "SHAR")]
    [IsoId("_rj0SwOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a share.")]
    Share,
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_strd0OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend,
    
    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as &quot;STIX&quot;.
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_vALE4OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a stock index.")]
    StockIndex,
    
    /// <summary>
    /// Underlying is a swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_w5PfUOJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a swap.")]
    Swap,
    
    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as &quot;VOLI&quot;.
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_yJSK4OJPEeWKDJcMqE1cSA")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex,
    
    /// <summary>
    /// Underlying is an interest rate future or a forward rate agreement (FRA).
    /// Encoded/decoded by serializers as &quot;IFUT&quot;.
    /// </summary>
    [EnumMember(Value = "IFUT")]
    [IsoId("_UQtCgDfLEeaXwbucHIjFhw")]
    [Description(@"Underlying is an interest rate future or a forward rate agreement (FRA).")]
    InterestRateFutureFRA,
    
}
