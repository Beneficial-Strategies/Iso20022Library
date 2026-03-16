// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat21Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat21Choice.AmountToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat21Choice.QuantityToQuantity),
        nameof(RatioFormat21Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat21Choice.AmountToAmount),
        nameof(RatioFormat21Choice.AmountToAmount)
    )]
    [IsoId("_ckBxt5KQEeWHWpTQn1FFVg")]
    [DisplayName("Ratio Format 21 Choice")]
    public abstract record RatioFormat21Choice_ { }
}
