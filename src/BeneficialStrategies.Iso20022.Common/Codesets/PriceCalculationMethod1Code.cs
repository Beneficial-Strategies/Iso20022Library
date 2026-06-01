// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Standard code to specify the method applied for the calculation of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Qv5VcIDNEe-eGe8fbP3Zug")]
[Description(@"Standard code to specify the method applied for the calculation of the price.")]
[DerivedFrom(typeof(PriceCalculationMethodCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<PriceCalculationMethod1Code>))]
public enum PriceCalculationMethod1Code
{
    /// <summary>
    /// Price of the asset at close of a given day.
    /// Encoded/decoded by serializers as &quot;AVCL&quot;.
    /// </summary>
    [EnumMember(Value = "AVCL")]
    [IsoId("_24oAAYDNEe-eGe8fbP3Zug")]
    [Description(@"Price of the asset at close of a given day.")]
    AverageClosingPrice = PriceCalculationMethodCode.AverageClosingPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price at a certain amount of time prior to the date it is announced.
    /// Encoded/decoded by serializers as &quot;MIMP&quot;.
    /// </summary>
    [EnumMember(Value = "MIMP")]
    [IsoId("_2pKAoYDNEe-eGe8fbP3Zug")]
    [Description(@"Price at a certain amount of time prior to the date it is announced.")]
    MidMarketPrice = PriceCalculationMethodCode.MidMarketPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Net value of an investment fund's assets less its liabilities, divided by the number of shares outstanding.
    /// Encoded/decoded by serializers as &quot;NAVA&quot;.
    /// </summary>
    [EnumMember(Value = "NAVA")]
    [IsoId("_2wPgEYDNEe-eGe8fbP3Zug")]
    [Description(
        @"Net value of an investment fund's assets less its liabilities, divided by the number of shares outstanding."
    )]
    NetAssetValue = PriceCalculationMethodCode.NetAssetValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final asset value at the liquidation of the fund.
    /// Encoded/decoded by serializers as &quot;NAVF&quot;.
    /// </summary>
    [EnumMember(Value = "NAVF")]
    [IsoId("_2gYfIYDNEe-eGe8fbP3Zug")]
    [Description(@"Final asset value at the liquidation of the fund.")]
    FinalAssetValue = PriceCalculationMethodCode.FinalAssetValue, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The price is based on a volume-weighted average price which is a ratio of the cumulative share price to the cumulative volume traded over a given time period.
    /// Encoded/decoded by serializers as &quot;VWAP&quot;.
    /// </summary>
    [EnumMember(Value = "VWAP")]
    [IsoId("_2ch54YDNEe-eGe8fbP3Zug")]
    [Description(
        @"The price is based on a volume-weighted average price which is a ratio of the cumulative share price to the cumulative volume traded over a given time period."
    )]
    VolumeWeightedAveragePrice = PriceCalculationMethodCode.VolumeWeightedAveragePrice, // same ordinal as derivation source for type conversions
}
