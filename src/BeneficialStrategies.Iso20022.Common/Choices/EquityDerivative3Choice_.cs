// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element to define an equity instrument underlying code types.
    /// </summary>
    [KnownType(typeof(EquityDerivative3Choice.Basket))]
    [KnownType(typeof(EquityDerivative3Choice.Index))]
    [KnownType(typeof(EquityDerivative3Choice.SingleName))]
    [KnownType(typeof(EquityDerivative3Choice.Other))]
    [JsonDerivedType(
        typeof(EquityDerivative3Choice.Basket),
        nameof(EquityDerivative3Choice.Basket)
    )]
    [JsonDerivedType(typeof(EquityDerivative3Choice.Index), nameof(EquityDerivative3Choice.Index))]
    [JsonDerivedType(
        typeof(EquityDerivative3Choice.SingleName),
        nameof(EquityDerivative3Choice.SingleName)
    )]
    [JsonDerivedType(typeof(EquityDerivative3Choice.Other), nameof(EquityDerivative3Choice.Other))]
    [IsoId("_hW-FN2lPEeaLAKoEUNsD9g")]
    [DisplayName("Equity Derivative 3 Choice")]
    public abstract record EquityDerivative3Choice_ { }
}
