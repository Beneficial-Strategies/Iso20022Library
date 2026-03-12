// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat14Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat14Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat14Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat14Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat14Choice.QuantityToAmount))]
    [JsonDerivedType(typeof(RatioFormat14Choice.QuantityToQuantity),nameof(RatioFormat14Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat14Choice.NotSpecifiedRate),nameof(RatioFormat14Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat14Choice.AmountToAmount),nameof(RatioFormat14Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat14Choice.AmountToQuantity),nameof(RatioFormat14Choice.AmountToQuantity))]
    [JsonDerivedType(typeof(RatioFormat14Choice.QuantityToAmount),nameof(RatioFormat14Choice.QuantityToAmount))]
    [IsoId("_fflq5ggYEeCVlvYcV4HKqQ")]
    [DisplayName("Ratio Format 14 Choice")]
    public abstract partial record RatioFormat14Choice_
    {
    }
}
