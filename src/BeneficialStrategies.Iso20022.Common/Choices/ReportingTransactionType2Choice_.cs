// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a new or a cancellation transaction.
    /// </summary>
    [KnownType(typeof(ReportingTransactionType2Choice.New))]
    [KnownType(typeof(ReportingTransactionType2Choice.Cancellation))]
    [KnownType(typeof(ReportingTransactionType2Choice.SupplementaryData))]
    [JsonDerivedType(
        typeof(ReportingTransactionType2Choice.New),
        nameof(ReportingTransactionType2Choice.New)
    )]
    [JsonDerivedType(
        typeof(ReportingTransactionType2Choice.Cancellation),
        nameof(ReportingTransactionType2Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(ReportingTransactionType2Choice.SupplementaryData),
        nameof(ReportingTransactionType2Choice.SupplementaryData)
    )]
    [IsoId("_W2U3kZ26Eeuwmdq0KtnICg")]
    [DisplayName("Reporting Transaction Type 2 Choice")]
    public abstract record ReportingTransactionType2Choice_ { }
}
