// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of an intention to pay based on purchase orders or commercial invoice.
/// </summary>
[IsoId("_PzEVSdp-Ed-ak6NoX_4Aeg_-1491388962")]
[DisplayName("Intent To Pay")]
public partial record IntentToPay1
{
    #nullable enable
    
    /// <summary>
    /// The intention to pay is based on a purchase order.
    /// </summary>
    [IsoId("_PzEVStp-Ed-ak6NoX_4Aeg_1426935583")]
    [DisplayName("By Purchase Order")]
    [IsoXmlTag("ByPurchsOrdr")]
    public required ReportLine3 ByPurchaseOrder { get; init; } 
    
    /// <summary>
    /// The intention to pay is based on a commercial invoice.
    /// </summary>
    [IsoId("_PzEVS9p-Ed-ak6NoX_4Aeg_1432476294")]
    [DisplayName("By Commercial Invoice")]
    [IsoXmlTag("ByComrclInvc")]
    public required ReportLine4 ByCommercialInvoice { get; init; } 
    
    /// <summary>
    /// Date at which the payment would be effected.
    /// </summary>
    [IsoId("_PzEVTNp-Ed-ak6NoX_4Aeg_-1088733127")]
    [DisplayName("Expected Payment Date")]
    [IsoXmlTag("XpctdPmtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ExpectedPaymentDate { get; init; } 
    
    /// <summary>
    /// Specifies the beneficiary&apos;s account information.
    /// </summary>
    [IsoId("_PzOGQNp-Ed-ak6NoX_4Aeg_-1728337681")]
    [DisplayName("Settlement Terms")]
    [IsoXmlTag("SttlmTerms")]
    public SettlementTerms2? SettlementTerms { get; init; } 
    
    
    #nullable disable
    
}
