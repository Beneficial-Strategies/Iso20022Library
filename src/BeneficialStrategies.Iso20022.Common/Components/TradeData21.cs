// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the reported trade transactions.
/// </summary>
[IsoId("_CpO6Zf_oEemm3skPVSMJQg")]
[DisplayName("Trade Data")]
public partial record TradeData21
{
    #nullable enable
    
    /// <summary>
    /// Status of the required transactions reconciliation or pairing.
    /// </summary>
    [IsoId("_CtHU0f_oEemm3skPVSMJQg")]
    [DisplayName("Pairing Reconciliation Status")]
    [IsoXmlTag("PairgRcncltnSts")]
    public NumberOfReportsPerStatus2? PairingReconciliationStatus { get; init; } 
    
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    [IsoId("_CtHU0__oEemm3skPVSMJQg")]
    [DisplayName("Reconciliation Report")]
    [IsoXmlTag("RcncltnRpt")]
    public ValueList<ReconciliationReport5> ReconciliationReport { get; init; } = new ValueList<ReconciliationReport5>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _CtHU0__oEemm3skPVSMJQg
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_CtHU1f_oEemm3skPVSMJQg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
