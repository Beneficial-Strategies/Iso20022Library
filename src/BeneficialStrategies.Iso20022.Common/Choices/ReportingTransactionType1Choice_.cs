// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a new or a cancellation transaction.
    /// </summary>
    [KnownType(typeof(ReportingTransactionType1Choice.New))]
    [KnownType(typeof(ReportingTransactionType1Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType1Choice.SupplementaryData))]
    [JsonDerivedType(typeof(ReportingTransactionType1Choice.New),nameof(ReportingTransactionType1Choice.New))]
    [JsonDerivedType(typeof(ReportingTransactionType1Choice.Cancellation),nameof(ReportingTransactionType1Choice.Cancellation))]
    [JsonDerivedType(typeof(ReportingTransactionType1Choice.SupplementaryData),nameof(ReportingTransactionType1Choice.SupplementaryData))]
    [IsoId("_JzZ68YG-EeaalK9UbuVGFw")]
    [DisplayName("Reporting Transaction Type 1 Choice")]
    public abstract partial record ReportingTransactionType1Choice_
    {
    }
}
