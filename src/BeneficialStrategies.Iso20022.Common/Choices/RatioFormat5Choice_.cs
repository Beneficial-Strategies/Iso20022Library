// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat5Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat5Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat5Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat5Choice.QuantityToQuantity),nameof(RatioFormat5Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat5Choice.NotSpecifiedRate),nameof(RatioFormat5Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat5Choice.AmountToAmount),nameof(RatioFormat5Choice.AmountToAmount))]
    [IsoId("_Q2IUxdp-Ed-ak6NoX_4Aeg_1134486617")]
    [DisplayName("Ratio Format 5 Choice")]
    public abstract partial record RatioFormat5Choice_
    {
    }
}
