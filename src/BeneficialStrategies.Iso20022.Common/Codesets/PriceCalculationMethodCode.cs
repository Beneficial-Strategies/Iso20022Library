// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the method applied for the calculation of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_9FlG8IDMEe-eGe8fbP3Zug")]
[Description(@"Specifies the method applied for the calculation of the price.")]
[Derivations(typeof(PriceCalculationMethod1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PriceCalculationMethodCode>))]
public enum PriceCalculationMethodCode
{
    /// <summary>
    /// Price of the asset at close of a given day.
    /// Encoded/decoded by serializers as &quot;AVCL&quot;.
    /// </summary>
    [EnumMember(Value = "AVCL")]
    [IsoId("_b7jVkIDNEe-eGe8fbP3Zug")]
    [Description(@"Price of the asset at close of a given day.")]
    AverageClosingPrice,

    /// <summary>
    /// Price at a certain amount of time prior to the date it is announced.
    /// Encoded/decoded by serializers as &quot;MIMP&quot;.
    /// </summary>
    [EnumMember(Value = "MIMP")]
    [IsoId("_gEDcAIDNEe-eGe8fbP3Zug")]
    [Description(@"Price at a certain amount of time prior to the date it is announced.")]
    MidMarketPrice,

    /// <summary>
    /// Net value of an investment fund's assets less its liabilities, divided by the number of shares outstanding.
    /// Encoded/decoded by serializers as &quot;NAVA&quot;.
    /// </summary>
    [EnumMember(Value = "NAVA")]
    [IsoId("_i5WOIIDNEe-eGe8fbP3Zug")]
    [Description(
        @"Net value of an investment fund's assets less its liabilities, divided by the number of shares outstanding."
    )]
    NetAssetValue,

    /// <summary>
    /// Final asset value at the liquidation of the fund.
    /// Encoded/decoded by serializers as &quot;NAVF&quot;.
    /// </summary>
    [EnumMember(Value = "NAVF")]
    [IsoId("_mK76sIDNEe-eGe8fbP3Zug")]
    [Description(@"Final asset value at the liquidation of the fund.")]
    FinalAssetValue,

    /// <summary>
    /// The price is based on a volume-weighted average price which is a ratio of the cumulative share price to the cumulative volume traded over a given time period.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_patCUIDNEe-eGe8fbP3Zug")]
    [Description(
        @"The price is based on a volume-weighted average price which is a ratio of the cumulative share price to the cumulative volume traded over a given time period."
    )]
    VolumeWeightedAveragePrice,
}
