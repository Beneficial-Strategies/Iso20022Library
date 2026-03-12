// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indication whether the reconciliation is required.
    /// </summary>
    [KnownType(typeof(ReconciliationStatus8Choice.NoReconciliationRequired))]
    [KnownType(typeof(ReconciliationStatus8Choice.ReportingData))]
    [JsonDerivedType(typeof(ReconciliationStatus8Choice.NoReconciliationRequired),nameof(ReconciliationStatus8Choice.NoReconciliationRequired))]
    [JsonDerivedType(typeof(ReconciliationStatus8Choice.ReportingData),nameof(ReconciliationStatus8Choice.ReportingData))]
    [IsoId("_AuXyScK3EeuFNp8LZAnorg")]
    [DisplayName("Reconciliation Status 8 Choice")]
    public abstract partial record ReconciliationStatus8Choice_
    {
    }
}
