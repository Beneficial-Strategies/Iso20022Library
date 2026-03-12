// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat6Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat6Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat6Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat6Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat6Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat6Choice.QuantityToQuantity),nameof(RatioFormat6Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat6Choice.NotSpecifiedRate),nameof(RatioFormat6Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat6Choice.AmountToAmount),nameof(RatioFormat6Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat6Choice.AmountToQuantity),nameof(RatioFormat6Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat6Choice.QuantityToAmount),nameof(RatioFormat6Choice.QuantityToAmount))]
    [IsoId("_Q1-jxdp-Ed-ak6NoX_4Aeg_-2128705050")]
    [DisplayName("Ratio Format 6 Choice")]
    public abstract partial record RatioFormat6Choice_
    {
    }
}
