// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the market and statistic conditions upon which a liquidity indicator has been computed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afCIuNp-Ed-ak6NoX_4Aeg_336256712")]
[Description(@"Specifies the market and statistic conditions upon which a liquidity indicator has been computed.")]
[Derivations(typeof(LiquidityIndicatorType1Code))]
public enum LiquidityIndicatorTypeCode
{
    /// <summary>
    /// Computation is on the average value of the price of a security over a period of five days.
    /// Encoded/decoded by serializers as &quot;FIVE&quot;.
    /// </summary>
    [EnumMember(Value = "FIVE")]
    [IsoId("_afL5sNp-Ed-ak6NoX_4Aeg_336256713")]
    [Description(@"Computation is on the average value of the price of a security over a period of five days.")]
    FiveDayMovingAverage,
    
    /// <summary>
    /// Computation is on the average value of the price of a security over a period of 20 days.
    /// Encoded/decoded by serializers as &quot;TWEN&quot;.
    /// </summary>
    [EnumMember(Value = "TWEN")]
    [IsoId("_afL5sdp-Ed-ak6NoX_4Aeg_336256721")]
    [Description(@"Computation is on the average value of the price of a security over a period of 20 days.")]
    TwentyDayMovingAverage,
    
    /// <summary>
    /// Computation is on the standard market conditions and volume.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_afL5stp-Ed-ak6NoX_4Aeg_336256722")]
    [Description(@"Computation is on the standard market conditions and volume.")]
    NormalMarketSize,
    
    /// <summary>
    /// Computation is on another price computation method.
    /// Encoded/decoded by serializers as &quot;OTHE&quot;.
    /// </summary>
    [EnumMember(Value = "OTHE")]
    [IsoId("_afL5s9p-Ed-ak6NoX_4Aeg_336256723")]
    [Description(@"Computation is on another price computation method.")]
    Other,
    
}
