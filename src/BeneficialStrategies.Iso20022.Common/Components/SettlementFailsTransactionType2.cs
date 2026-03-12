// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the transaction type as defined in the relevant regulation.
/// </summary>
[IsoId("_apzGIx2lEeqF2P5v-Rtejg")]
[DisplayName("Settlement Fails Transaction Type")]
public partial record SettlementFailsTransactionType2
{
    #nullable enable
    
    /// <summary>
    /// Purchase or sale of securities.
    /// </summary>
    [IsoId("_aqtFAR2lEeqF2P5v-Rtejg")]
    [DisplayName("Securities Buy Or Sell")]
    [IsoXmlTag("SctiesBuyOrSell")]
    public required SettlementTotalData1Choice_ SecuritiesBuyOrSell { get; init; } 
    
    /// <summary>
    /// Relates to securities transfers aiming to provide or to return collateral.
    /// </summary>
    [IsoId("_aqtFAx2lEeqF2P5v-Rtejg")]
    [DisplayName("Collateral Management Operation")]
    [IsoXmlTag("CollMgmtOpr")]
    public required SettlementTotalData1Choice_ CollateralManagementOperation { get; init; } 
    
    /// <summary>
    /// Relates to a securities lending or borrowing operation.
    /// </summary>
    [IsoId("_aqtFBR2lEeqF2P5v-Rtejg")]
    [DisplayName("Securities Lending Or Borrowing")]
    [IsoXmlTag("SctiesLndgOrBrrwg")]
    public required SettlementTotalData1Choice_ SecuritiesLendingOrBorrowing { get; init; } 
    
    /// <summary>
    /// Repurchase transactions.
    /// </summary>
    [IsoId("_aqtFBx2lEeqF2P5v-Rtejg")]
    [DisplayName("Repurchase Agreement")]
    [IsoXmlTag("RpAgrmt")]
    public required SettlementTotalData1Choice_ RepurchaseAgreement { get; init; } 
    
    /// <summary>
    /// Covers any securities transactions type not covered as a dedicated type.
    /// </summary>
    [IsoId("_aqtFCR2lEeqF2P5v-Rtejg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public required SettlementTotalData1Choice_ Other { get; init; } 
    
    
    #nullable disable
    
}
