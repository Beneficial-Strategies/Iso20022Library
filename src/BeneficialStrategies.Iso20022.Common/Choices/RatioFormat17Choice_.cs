// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat17Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat17Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat17Choice.AmountToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat17Choice.QuantityToQuantity),
        nameof(RatioFormat17Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat17Choice.NotSpecifiedRate),
        nameof(RatioFormat17Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RatioFormat17Choice.AmountToAmount),
        nameof(RatioFormat17Choice.AmountToAmount)
    )]
    [IsoId("_vQLksUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Ratio Format 17 Choice")]
    public abstract record RatioFormat17Choice_ { }
}
