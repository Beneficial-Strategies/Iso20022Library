// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Get Totals Response message.
/// </summary>
[IsoId("_k6DnIN6REeiwsev40qZGEQ")]
[DisplayName("Report Get Totals Response")]
public partial record ReportGetTotalsResponse1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the reconciliation period between Sale and POI.
    /// </summary>
    [IsoId("_t9D4sN6REeiwsev40qZGEQ")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text POIReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Result of the Sale to POI Totals processing.
    /// </summary>
    [IsoId("_wvXBMN6REeiwsev40qZGEQ")]
    [DisplayName("Transaction Totals Set")]
    [IsoXmlTag("TxTtlsSet")]
    public TransactionTotalsSet1? TransactionTotalsSet { get; init; } 
    
    
    #nullable disable
    
}
