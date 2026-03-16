// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides details of the underlying transaction, on which the investigation is processed.
    /// </summary>
    [KnownType(typeof(UnderlyingTransaction5Choice.Initiation))]
    [KnownType(typeof(UnderlyingTransaction5Choice.Interbank))]
    [KnownType(typeof(UnderlyingTransaction5Choice.StatementEntry))]
    [JsonDerivedType(
        typeof(UnderlyingTransaction5Choice.Initiation),
        nameof(UnderlyingTransaction5Choice.Initiation)
    )]
    [JsonDerivedType(
        typeof(UnderlyingTransaction5Choice.Interbank),
        nameof(UnderlyingTransaction5Choice.Interbank)
    )]
    [JsonDerivedType(
        typeof(UnderlyingTransaction5Choice.StatementEntry),
        nameof(UnderlyingTransaction5Choice.StatementEntry)
    )]
    [IsoId("_IGwpoW49EeiU9cctagi5ow")]
    [DisplayName("Underlying Transaction 5 Choice")]
    public abstract record UnderlyingTransaction5Choice_ { }
}
