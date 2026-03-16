// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat22Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat22Choice.AmountToAmount))]
    [KnownType(typeof(RatioFormat22Choice.AmountToQuantity))]
    [KnownType(typeof(RatioFormat22Choice.QuantityToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat22Choice.QuantityToQuantity),
        nameof(RatioFormat22Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat22Choice.AmountToAmount),
        nameof(RatioFormat22Choice.AmountToAmount)
    )]
    [JsonDerivedType(
        typeof(RatioFormat22Choice.AmountToQuantity),
        nameof(RatioFormat22Choice.AmountToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat22Choice.QuantityToAmount),
        nameof(RatioFormat22Choice.QuantityToAmount)
    )]
    [IsoId("_ckCYWJKQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 22 Choice")]
    public abstract record RatioFormat22Choice_ { }
}
