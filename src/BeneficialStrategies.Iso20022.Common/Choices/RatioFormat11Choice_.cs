// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat11Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat11Choice.NotSpecifiedRate))]
    [KnownType(typeof(RatioFormat11Choice.AmountToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat11Choice.QuantityToQuantity),
        nameof(RatioFormat11Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat11Choice.NotSpecifiedRate),
        nameof(RatioFormat11Choice.NotSpecifiedRate)
    )]
    [JsonDerivedType(
        typeof(RatioFormat11Choice.AmountToAmount),
        nameof(RatioFormat11Choice.AmountToAmount)
    )]
    [IsoId("_anZPgOwOEd-sn-FiNtktcA")]
    [DisplayName("Ratio Format 11 Choice")]
    public abstract record RatioFormat11Choice_ { }
}
