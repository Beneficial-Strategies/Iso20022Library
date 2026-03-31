// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Indication whether the reconciliation is required.
    /// </summary>
    [KnownType(typeof(ReconciliationStatus5Choice.NoReconciliationRequired))]
    [KnownType(typeof(ReconciliationStatus5Choice.ReportingData))]
    [JsonDerivedType(
        typeof(ReconciliationStatus5Choice.NoReconciliationRequired),
        nameof(ReconciliationStatus5Choice.NoReconciliationRequired)
    )]
    [JsonDerivedType(
        typeof(ReconciliationStatus5Choice.ReportingData),
        nameof(ReconciliationStatus5Choice.ReportingData)
    )]
    [IsoId("_CxSDKf_oEemm3skPVSMJQg")]
    [DisplayName("Reconciliation Status 5 Choice")]
    public abstract record ReconciliationStatus5Choice_ { }
}
