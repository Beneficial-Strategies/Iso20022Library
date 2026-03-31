// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Element is a choice between a standard identifier and a proprietary code.
    /// </summary>
    [KnownType(typeof(UniqueTransactionIdentifier3Choice.UniqueTransactionIdentifier))]
    [KnownType(typeof(UniqueTransactionIdentifier3Choice.Proprietary))]
    [KnownType(typeof(UniqueTransactionIdentifier3Choice.NotAvailable))]
    [JsonDerivedType(
        typeof(UniqueTransactionIdentifier3Choice.UniqueTransactionIdentifier),
        nameof(UniqueTransactionIdentifier3Choice.UniqueTransactionIdentifier)
    )]
    [JsonDerivedType(
        typeof(UniqueTransactionIdentifier3Choice.Proprietary),
        nameof(UniqueTransactionIdentifier3Choice.Proprietary)
    )]
    [JsonDerivedType(
        typeof(UniqueTransactionIdentifier3Choice.NotAvailable),
        nameof(UniqueTransactionIdentifier3Choice.NotAvailable)
    )]
    [IsoId("__mtEsU7qEe2PGo0mhYCh1g")]
    [DisplayName("Unique Transaction Identifier 3 Choice")]
    public abstract record UniqueTransactionIdentifier3Choice_ { }
}
