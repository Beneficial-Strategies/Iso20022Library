// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat18Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat18Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat18Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat18Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat18Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat18Choice.QuantityToQuantity),nameof(RatioFormat18Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat18Choice.NotSpecifiedRate),nameof(RatioFormat18Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat18Choice.AmountToAmount),nameof(RatioFormat18Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat18Choice.AmountToQuantity),nameof(RatioFormat18Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat18Choice.QuantityToAmount),nameof(RatioFormat18Choice.QuantityToAmount))]
    [IsoId("_7Z03EUEKEeWVgfuHGaKtRQ")]
    [DisplayName("Ratio Format 18 Choice")]
    public abstract partial record RatioFormat18Choice_
    {
    }
}
