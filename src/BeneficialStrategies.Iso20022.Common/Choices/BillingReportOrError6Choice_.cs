// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between report on billing data, billing cancellation request details or operational error.
    /// </summary>
    [KnownType(typeof(BillingReportOrError6Choice.BillingReport))]
    [KnownType(typeof(BillingReportOrError6Choice.CancellationReport))]
    [KnownType(typeof(BillingReportOrError6Choice.OperationalError))]
    [JsonDerivedType(typeof(BillingReportOrError6Choice.BillingReport), nameof(BillingReportOrError6Choice.BillingReport))]
    [JsonDerivedType(typeof(BillingReportOrError6Choice.CancellationReport), nameof(BillingReportOrError6Choice.CancellationReport))]
    [JsonDerivedType(typeof(BillingReportOrError6Choice.OperationalError), nameof(BillingReportOrError6Choice.OperationalError))]
    [IsoId("_2hOjcTEyEe6g-ffJsqGiSA")]
    [DisplayName("BillingReportOrError6Choice")]
    public abstract record BillingReportOrError6Choice_ { }
}
