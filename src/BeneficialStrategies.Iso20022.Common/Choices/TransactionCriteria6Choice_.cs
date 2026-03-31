// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(TransactionCriteria6Choice.QueryName))]
    [KnownType(typeof(TransactionCriteria6Choice.NewCriteria))]
    [JsonDerivedType(
        typeof(TransactionCriteria6Choice.QueryName),
        nameof(TransactionCriteria6Choice.QueryName)
    )]
    [JsonDerivedType(
        typeof(TransactionCriteria6Choice.NewCriteria),
        nameof(TransactionCriteria6Choice.NewCriteria)
    )]
    [IsoId("_gSybxdcZEeqRFcf2R4bPBw")]
    [DisplayName("Transaction Criteria 6 Choice")]
    public abstract record TransactionCriteria6Choice_ { }
}
