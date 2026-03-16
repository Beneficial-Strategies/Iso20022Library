// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format to expressed a ratio.
    /// </summary>
    [KnownType(typeof(RatioFormat3Choice.QuantityToQuantity))]
    [KnownType(typeof(RatioFormat3Choice.AmountToAmount))]
    [JsonDerivedType(
        typeof(RatioFormat3Choice.QuantityToQuantity),
        nameof(RatioFormat3Choice.QuantityToQuantity)
    )]
    [JsonDerivedType(
        typeof(RatioFormat3Choice.AmountToAmount),
        nameof(RatioFormat3Choice.AmountToAmount)
    )]
    [IsoId("_Q1ro09p-Ed-ak6NoX_4Aeg_-828617665")]
    [DisplayName("Ratio Format 3 Choice")]
    public abstract record RatioFormat3Choice_ { }
}
