// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal transaction results after a Reversal request.
/// </summary>
[IsoId("_ENNZoQ1REeqjM-rxn3HuXQ")]
[DisplayName("Retailer Reversal Result")]
public partial record RetailerReversalResult2
{
    #nullable enable
    
    /// <summary>
    /// POI reconciliation identification.
    /// </summary>
    [IsoId("_EZPDcQ1REeqjM-rxn3HuXQ")]
    [DisplayName("POI Reconciliation Identification")]
    [IsoXmlTag("POIRcncltnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    
    /// <summary>
    /// Original Transaction if any linked to this reversal.
    /// </summary>
    [IsoId("_EZPDcw1REeqjM-rxn3HuXQ")]
    [DisplayName("Original Payment Transaction")]
    [IsoXmlTag("OrgnlPmtTx")]
    public CardPaymentTransaction100? OriginalPaymentTransaction { get; init; } 
    
    /// <summary>
    /// Updated Customer order list after reversal.
    /// </summary>
    [IsoId("_EZPDdQ1REeqjM-rxn3HuXQ")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    
    #nullable disable
    
}
