// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an equity derivative return parameter.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_drgvAAneEeWa7rBfPECYsw")]
[Description(@"Specifies an equity derivative return parameter.")]
[DerivedFrom(typeof(EquityReturnParameterCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<EquityReturnParameter1Code>))]
#endif
public enum EquityReturnParameter1Code
{
    /// <summary>
    /// Equity derivative parameter Return Dividend.
    /// Encoded/decoded by serializers as &quot;PRDV&quot;.
    /// </summary>
    [EnumMember(Value = "PRDV")]
    [IsoId("_eyxSAQneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Return Dividend.")]
    ParameterReturnDividend = EquityReturnParameterCode.ParameterReturnDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity derivative parameter Return Variance.
    /// Encoded/decoded by serializers as &quot;PRVA&quot;.
    /// </summary>
    [EnumMember(Value = "PRVA")]
    [IsoId("_e3rnMQneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Return Variance.")]
    ParameterReturnVariance = EquityReturnParameterCode.ParameterReturnVariance, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity derivative parameter Return Volatility.
    /// Encoded/decoded by serializers as &quot;PRVO&quot;.
    /// </summary>
    [EnumMember(Value = "PRVO")]
    [IsoId("_e_kX4QneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Return Volatility.")]
    ParameterReturnVolatility = EquityReturnParameterCode.ParameterReturnVolatility, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Equity derivative parameter Price Return Basis Performance.
    /// Encoded/decoded by serializers as &quot;PRBP&quot;.
    /// </summary>
    [EnumMember(Value = "PRBP")]
    [IsoId("_fD4QIQneEeWa7rBfPECYsw")]
    [Description(@"Equity derivative parameter Price Return Basis Performance.")]
    PriceReturnBasicPerformanceParameter =
        EquityReturnParameterCode.PriceReturnBasicPerformanceParameter, // same ordinal as derivation source for type conversions
}
