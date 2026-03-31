// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between an acquirer globalised card transaction or an individual card transaction.
    /// </summary>
    [KnownType(typeof(CardTransaction3Choice.Aggregated))]
    [KnownType(typeof(CardTransaction3Choice.Individual))]
    [JsonDerivedType(
        typeof(CardTransaction3Choice.Aggregated),
        nameof(CardTransaction3Choice.Aggregated)
    )]
    [JsonDerivedType(
        typeof(CardTransaction3Choice.Individual),
        nameof(CardTransaction3Choice.Individual)
    )]
    [IsoId("_S1q3Ka6BEeexrtTFgmVD3Q")]
    [DisplayName("Card Transaction 3 Choice")]
    public abstract record CardTransaction3Choice_ { }
}
