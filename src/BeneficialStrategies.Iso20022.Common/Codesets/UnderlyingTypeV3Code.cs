// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the underlying financial instrument.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_JuMQeH50EeasY4u9QTizPQ")]
[Description(@"Specifies the underlying financial instrument.")]
[Derivations(
    typeof(UnderlyingInterestRateType3Code),
    typeof(UnderlyingContractForDifferenceType3Code),
    typeof(UnderlyingEquityType6Code),
    typeof(UnderlyingEquityType5Code)
)]
public enum UnderlyingTypeV3Code
{
    /// <summary>
    /// Underlying is a basket.
    /// Encoded/decoded by serializers as &quot;BSKT&quot;.
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_JuMQjn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a basket.")]
    Basket,

    /// <summary>
    /// Underlying is a bond.
    /// Encoded/decoded by serializers as &quot;BOND&quot;.
    /// </summary>
    [EnumMember(Value = "BOND")]
    [IsoId("_JuMQin50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a bond.")]
    Bond,

    /// <summary>
    /// Underlying is a bond future.
    /// Encoded/decoded by serializers as &quot;BNDF&quot;.
    /// </summary>
    [EnumMember(Value = "BNDF")]
    [IsoId("_JuMQgH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a bond future.")]
    BondFuture,

    /// <summary>
    /// Underlying is a commodity.
    /// Encoded/decoded by serializers as &quot;COMM&quot;.
    /// </summary>
    [EnumMember(Value = "COMM")]
    [IsoId("_JuMQiH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a commodity.")]
    Commodity,

    /// <summary>
    /// Underlying is a currency.
    /// Encoded/decoded by serializers as &quot;CURR&quot;.
    /// </summary>
    [EnumMember(Value = "CURR")]
    [IsoId("_JuMQiX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a currency.")]
    Currency,

    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_JuMQhX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex,

    /// <summary>
    /// Underlying is an equity.
    /// Encoded/decoded by serializers as &quot;EQUI&quot;.
    /// </summary>
    [EnumMember(Value = "EQUI")]
    [IsoId("_JuMQhH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an equity.")]
    Equity,

    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as &quot;ETFS&quot;.
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_JuMQeX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund,

    /// <summary>
    /// Underlying is a future.
    /// Encoded/decoded by serializers as &quot;FUTR&quot;.
    /// </summary>
    [EnumMember(Value = "FUTR")]
    [IsoId("_JuMQe350EeasY4u9QTizPQ")]
    [Description(@"Underlying is a future.")]
    Future,

    /// <summary>
    /// Underlying is a future on equity.
    /// Encoded/decoded by serializers as &quot;FTEQ&quot;.
    /// </summary>
    [EnumMember(Value = "FTEQ")]
    [IsoId("_JuMQfH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a future on equity.")]
    FutureOnEquity,

    /// <summary>
    /// Underlying is an index.
    /// Encoded/decoded by serializers as &quot;INDX&quot;.
    /// </summary>
    [EnumMember(Value = "INDX")]
    [IsoId("_JuMQf350EeasY4u9QTizPQ")]
    [Description(@"Underlying is an index.")]
    Index,

    /// <summary>
    /// Underlying is interest rate.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_JuMQfn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is interest rate.")]
    InterestRate,

    /// <summary>
    /// Underlying is an option.
    /// Encoded/decoded by serializers as &quot;OPTN&quot;.
    /// </summary>
    [EnumMember(Value = "OPTN")]
    [IsoId("_JuMQgX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an option.")]
    Option,

    /// <summary>
    /// Underlying is an option on equity.
    /// Encoded/decoded by serializers as &quot;OPEQ&quot;.
    /// </summary>
    [EnumMember(Value = "OPEQ")]
    [IsoId("_JuMQjH50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an option on equity.")]
    OptionOnEquity,

    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_JuMQen50EeasY4u9QTizPQ")]
    [Description(@"Underlying is of other type.")]
    Other,

    /// <summary>
    /// Underlying is precious metal.
    /// Encoded/decoded by serializers as &quot;PRME&quot;.
    /// </summary>
    [EnumMember(Value = "PRME")]
    [IsoId("_JuMQg350EeasY4u9QTizPQ")]
    [Description(@"Underlying is precious metal.")]
    PreciousMetal,

    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as &quot;SHRS&quot;.
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_JuMQjX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a share.")]
    Share,

    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_JuMQgn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend,

    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as &quot;STIX&quot;.
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_JuMQi350EeasY4u9QTizPQ")]
    [Description(@"Underlying is a stock index.")]
    StockIndex,

    /// <summary>
    /// Underlying is a swap.
    /// Encoded/decoded by serializers as &quot;SWAP&quot;.
    /// </summary>
    [EnumMember(Value = "SWAP")]
    [IsoId("_JuMQhn50EeasY4u9QTizPQ")]
    [Description(@"Underlying is a swap.")]
    Swap,

    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as &quot;VOLI&quot;.
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_JuMQh350EeasY4u9QTizPQ")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex,

    /// <summary>
    /// Underlying is an interest rate future or a forward rate agreement (FRA).
    /// Encoded/decoded by serializers as &quot;IFUT&quot;.
    /// </summary>
    [EnumMember(Value = "IFUT")]
    [IsoId("_JuMQj350EeasY4u9QTizPQ")]
    [Description(@"Underlying is an interest rate future or a forward rate agreement (FRA).")]
    InterestRateFutureFRA,

    /// <summary>
    /// Underlying is an emission allowance.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_JuMQfX50EeasY4u9QTizPQ")]
    [Description(@"Underlying is an emission allowance.")]
    EmissionAllowance,
}
