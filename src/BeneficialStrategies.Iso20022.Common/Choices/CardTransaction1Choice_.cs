// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a acquirer globalised card transaction or an individual card transaction.
    /// </summary>
    [KnownType(typeof(CardTransaction1Choice.Aggregated))]
    [KnownType(typeof(CardTransaction1Choice.Individual))]
    [JsonDerivedType(
        typeof(CardTransaction1Choice.Aggregated),
        nameof(CardTransaction1Choice.Aggregated)
    )]
    [JsonDerivedType(
        typeof(CardTransaction1Choice.Individual),
        nameof(CardTransaction1Choice.Individual)
    )]
    [IsoId("_t6ZGslkyEeGeoaLUQk__nA_-1316380729")]
    [DisplayName("Card Transaction 1 Choice")]
    public abstract record CardTransaction1Choice_ { }
}
