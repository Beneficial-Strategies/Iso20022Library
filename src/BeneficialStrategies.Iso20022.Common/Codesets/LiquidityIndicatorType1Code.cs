// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the market and statistic conditions upon which a liquidity indicator has been computed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afCItNp-Ed-ak6NoX_4Aeg_1937966255")]
[Description(
    @"Specifies the market and statistic conditions upon which a liquidity indicator has been computed."
)]
[DerivedFrom(typeof(LiquidityIndicatorTypeCode))]
public enum LiquidityIndicatorType1Code
{
    /// <summary>
    /// Computation is on the average value of the price of a security over a period of five days.
    /// Encoded/decoded by serializers as &quot;FIVE&quot;.
    /// </summary>
    [EnumMember(Value = "FIVE")]
    [IsoId("_afCItdp-Ed-ak6NoX_4Aeg_1985065189")]
    [Description(
        @"Computation is on the average value of the price of a security over a period of five days."
    )]
    FiveDayMovingAverage = LiquidityIndicatorTypeCode.FiveDayMovingAverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Computation is on the average value of the price of a security over a period of 20 days.
    /// Encoded/decoded by serializers as &quot;TWEN&quot;.
    /// </summary>
    [EnumMember(Value = "TWEN")]
    [IsoId("_afCIttp-Ed-ak6NoX_4Aeg_1985065206")]
    [Description(
        @"Computation is on the average value of the price of a security over a period of 20 days."
    )]
    TwentyDayMovingAverage = LiquidityIndicatorTypeCode.TwentyDayMovingAverage, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Computation is on the standard market conditions and volume.
    /// Encoded/decoded by serializers as &quot;NORM&quot;.
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_afCIt9p-Ed-ak6NoX_4Aeg_1985065379")]
    [Description(@"Computation is on the standard market conditions and volume.")]
    NormalMarketSize = LiquidityIndicatorTypeCode.NormalMarketSize, // same ordinal as derivation source for type conversions
}
