// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Transaction Criteria8Choice.
    /// </summary>
    [KnownType(typeof(TransactionCriteria8Choice.NewCriteria))]
    [KnownType(typeof(TransactionCriteria8Choice.QueryName))]
    [JsonDerivedType(
        typeof(TransactionCriteria8Choice.NewCriteria),
        nameof(TransactionCriteria8Choice.NewCriteria)
    )]
    [JsonDerivedType(
        typeof(TransactionCriteria8Choice.QueryName),
        nameof(TransactionCriteria8Choice.QueryName)
    )]
    [IsoId("_3IuBQTEyEe6g-ffJsqGiSA")]
    [DisplayName("Transaction Criteria8Choice")]
    public abstract record TransactionCriteria8Choice_ { }
}
