// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(TransactionCriteria7Choice.QueryName))]
    [KnownType(typeof(TransactionCriteria7Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(TransactionCriteria7Choice.QueryName),
        nameof(TransactionCriteria7Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(TransactionCriteria7Choice.NewCriteria),
        nameof(TransactionCriteria7Choice.NewCriteria)
    )]
    [IsoId("_9lnxdQKxEe2rHs6fbn9-0A")]
    [DisplayName("Transaction Criteria 7 Choice")]
    public abstract record TransactionCriteria7Choice_ { }
}
