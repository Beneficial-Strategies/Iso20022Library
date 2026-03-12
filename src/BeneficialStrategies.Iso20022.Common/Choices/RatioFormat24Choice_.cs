// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to express a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat24Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat24Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat24Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat24Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat24Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat24Choice.QuantityToQuantity),nameof(RatioFormat24Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat24Choice.NotSpecifiedRate),nameof(RatioFormat24Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat24Choice.AmountToAmount),nameof(RatioFormat24Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat24Choice.AmountToQuantity),nameof(RatioFormat24Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat24Choice.QuantityToAmount),nameof(RatioFormat24Choice.QuantityToAmount))]
    [IsoId("_cti6epKQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 24 Choice")]
    public abstract partial record RatioFormat24Choice_
    {
    }
}
