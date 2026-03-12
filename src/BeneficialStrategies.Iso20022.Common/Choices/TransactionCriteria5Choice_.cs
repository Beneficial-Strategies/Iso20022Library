// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(TransactionCriteria5Choice.QueryName))]
    [KnownType(typeof(TransactionCriteria5Choice.NewCriteria))]
    [JsonDerivedType(typeof(TransactionCriteria5Choice.QueryName),nameof(TransactionCriteria5Choice.QueryName))]
    [JsonDerivedType(typeof(TransactionCriteria5Choice.NewCriteria),nameof(TransactionCriteria5Choice.NewCriteria))]
    [IsoId("_OV995249EeiU9cctagi5ow")]
    [DisplayName("Transaction Criteria 5 Choice")]
    public abstract partial record TransactionCriteria5Choice_
    {
    }
}
