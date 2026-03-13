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
[IsoId("_ArgEdcK3EeuFNp8LZAnorg")]
[DisplayName("Trade Data")]
public partial record TradeData28
{
    #nullable enable
    
    /// <summary>
    /// Status of the required transactions reconciliation or pairing.
    /// </summary>
    [IsoId("_AtBHYcK3EeuFNp8LZAnorg")]
    [DisplayName("Pairing Reconciliation Status")]
    [IsoXmlTag("PairgRcncltnSts")]
    public NumberOfReportsPerStatus4? PairingReconciliationStatus { get; init; } 
    
    /// <summary>
    /// Data on transaction requiring reconciliation or pairing. 
    /// </summary>
    [IsoId("_AtBHY8K3EeuFNp8LZAnorg")]
    [DisplayName("Reconciliation Report")]
    [IsoXmlTag("RcncltnRpt")]
    public ValueList<ReconciliationReport8> ReconciliationReport { get; init; } = [];
    // ID for the above is _AtBHY8K3EeuFNp8LZAnorg
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_AtBHZcK3EeuFNp8LZAnorg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
