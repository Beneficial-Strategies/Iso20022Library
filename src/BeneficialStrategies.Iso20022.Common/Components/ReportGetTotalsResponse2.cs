// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Get Totals Response2.
/// </summary>
[IsoId("_-zdYAZ9rEe-nbM0aSPcoiQ")]
[DisplayName("Report Get Totals Response2")]
public record ReportGetTotalsResponse2
{
    /// <summary>
    /// POI Reconciliation Identification.
    /// </summary>
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    public required IsoMax35Text POIReconciliationIdentification { get; init; }

    /// <summary>
    /// Transaction Totals Set.
    /// </summary>
    [DisplayName("Transaction Totals Set")]
    [IsoXmlTag("TxTtlsSet")]
    public ValueList<TransactionTotalsSet2> TransactionTotalsSet { get; init; } = [];
}
