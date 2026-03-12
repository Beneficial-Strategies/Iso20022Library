// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the information that is searched either implicitly by recalling a previous query or explicitly by defining the criteria.
    /// </summary>
    [KnownType(typeof(TransactionCriteria4Choice.QueryName))]
    [KnownType(typeof(TransactionCriteria4Choice.NewCriteria))]
    [JsonDerivedType(typeof(TransactionCriteria4Choice.QueryName),nameof(TransactionCriteria4Choice.QueryName))]
    [JsonDerivedType(typeof(TransactionCriteria4Choice.NewCriteria),nameof(TransactionCriteria4Choice.NewCriteria))]
    [IsoId("_Uxo3t5lQEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Criteria 4 Choice")]
    public abstract partial record TransactionCriteria4Choice_
    {
    }
}
