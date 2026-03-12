// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a new or a cancellation transaction.
    /// </summary>
    [KnownType(typeof(ReportingTransactionType3Choice.New))]
    [KnownType(typeof(ReportingTransactionType3Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType3Choice.SupplementaryData))]
    [JsonDerivedType(typeof(ReportingTransactionType3Choice.New),nameof(ReportingTransactionType3Choice.New))]
    [JsonDerivedType(typeof(ReportingTransactionType3Choice.Cancellation),nameof(ReportingTransactionType3Choice.Cancellation))]
    [JsonDerivedType(typeof(ReportingTransactionType3Choice.SupplementaryData),nameof(ReportingTransactionType3Choice.SupplementaryData))]
    [IsoId("_6c12MZicEe2f7NHvXATP5g")]
    [DisplayName("Reporting Transaction Type 3 Choice")]
    public abstract partial record ReportingTransactionType3Choice_
    {
    }
}
