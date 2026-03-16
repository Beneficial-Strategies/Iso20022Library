// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a acquirer globalised card transaction or an individual card transaction.
    /// </summary>
    [KnownType(typeof(CardTransaction2Choice.Aggregated))]
    [KnownType(typeof(CardTransaction2Choice.Individual))]
    [JsonDerivedType(
        typeof(CardTransaction2Choice.Aggregated),
        nameof(CardTransaction2Choice.Aggregated)
    )]
    [JsonDerivedType(
        typeof(CardTransaction2Choice.Individual),
        nameof(CardTransaction2Choice.Individual)
    )]
    [IsoId("_0UR2gTj3EeSz-s1QOUJaOg")]
    [DisplayName("Card Transaction 2 Choice")]
    public abstract record CardTransaction2Choice_ { }
}
