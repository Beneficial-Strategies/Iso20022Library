// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the details of the underlying transaction on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction4Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction4Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction4Choice.StatementEntry))]
    [JsonDerivedType(
        typeof(UnderlyingTransaction4Choice.Initiation),
        nameof(UnderlyingTransaction4Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(UnderlyingTransaction4Choice.Interbank),
        nameof(UnderlyingTransaction4Choice.Interbank)
    )]
    [JsonDerivedType(
        typeof(UnderlyingTransaction4Choice.StatementEntry),
        nameof(UnderlyingTransaction4Choice.StatementEntry)
    )]
    [IsoId("_hRwhsYKZEee7hrXqLO3yQg")]
    [DisplayName("Underlying Transaction 4 Choice")]
    public abstract record UnderlyingTransaction4Choice_ { }
}
