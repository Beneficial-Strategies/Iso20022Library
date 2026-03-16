// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an equity derivative return parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_E3W44QneEeWa7rBfPECYsw")]
[Description(@"Specifies an equity derivative return parameter.")]
[Derivations(typeof(EquityReturnParameter1Code))]
public enum EquityReturnParameterCode
{
    /// <summary>
    /// Equity derivative parameter Price Return Basis Performance.
    /// Encoded/decoded by serializers as &quot;PRBP&quot;.
    /// </summary>
    [EnumMember(Value = "PRBP")]
    [IsoId("_HwuSsAneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Price Return Basis Performance.")]
    PriceReturnBasicPerformanceParameter,

    /// <summary>
    /// Equity derivative parameter Return Variance.
    /// Encoded/decoded by serializers as &quot;PRVA&quot;.
    /// </summary>
    [EnumMember(Value = "PRVA")]
    [IsoId("_LKYWIAneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Return Variance.")]
    ParameterReturnVariance,

    /// <summary>
    /// Equity derivative parameter Return Volatility.
    /// Encoded/decoded by serializers as &quot;PRVO&quot;.
    /// </summary>
    [EnumMember(Value = "PRVO")]
    [IsoId("_XgXbYQneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Return Volatility.")]
    ParameterReturnVolatility,

    /// <summary>
    /// Equity derivative parameter Return Dividend.
    /// Encoded/decoded by serializers as &quot;PRDV&quot;.
    /// </summary>
    [EnumMember(Value = "PRDV")]
    [IsoId("_YKeIUQneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Return Dividend.")]
    ParameterReturnDividend,
}
