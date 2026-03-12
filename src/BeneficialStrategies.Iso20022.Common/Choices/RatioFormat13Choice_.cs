// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat13Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat13Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat13Choice.AmountToAmount))]
    [JsonDerivedType(typeof(RatioFormat13Choice.QuantityToQuantity),nameof(RatioFormat13Choice.QuantityToQuantity))]
    [JsonDerivedType(typeof(RatioFormat13Choice.NotSpecifiedRate),nameof(RatioFormat13Choice.NotSpecifiedRate))]
    [JsonDerivedType(typeof(RatioFormat13Choice.AmountToAmount),nameof(RatioFormat13Choice.AmountToAmount))]
    [IsoId("_feZYGQgYEeCVlvYcV4HKqQ")]
    [DisplayName("Ratio Format 13 Choice")]
    public abstract partial record RatioFormat13Choice_
    {
    }
}
