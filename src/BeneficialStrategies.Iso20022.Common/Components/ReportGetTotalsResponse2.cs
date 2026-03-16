// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Report Get Totals Response2.
/// </summary>
[IsoId("_-zdYAZ9rEe-nbM0aSPcoiQ")]
[DisplayName("Report Get Totals Response2")]
public partial record ReportGetTotalsResponse2
{
    #nullable enable

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

    
    #nullable disable
    
}
