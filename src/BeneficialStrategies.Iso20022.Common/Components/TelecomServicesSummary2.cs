// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom services summary component carries summary level telephony billing data. 
/// </summary>
[IsoId("_7nW5oSCDEey8XKHwKquEQw")]
[DisplayName("Telecom Services Summary")]
public partial record TelecomServicesSummary2
{
    #nullable enable
    
    /// <summary>
    /// Contains the details of the customer. Also known as the user of the service.
    /// </summary>
    [IsoId("_7stTsSCDEey8XKHwKquEQw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer6? Customer { get; init; } 
    
    /// <summary>
    /// Contains the billing period start date for telecommunication or related services.
    /// </summary>
    [IsoId("_7stTsyCDEey8XKHwKquEQw")]
    [DisplayName("Billing Statement Period Start")]
    [IsoXmlTag("BllgStmtPrdStart")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BillingStatementPeriodStart { get; init; } 
    
    /// <summary>
    /// Contains the billing period end date for telecommunication or related services.
    /// </summary>
    [IsoId("_7stTtSCDEey8XKHwKquEQw")]
    [DisplayName("Billing Statement Period End")]
    [IsoXmlTag("BllgStmtPrdEnd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? BillingStatementPeriodEnd { get; init; } 
    
    /// <summary>
    /// Summary of the charges associated with the billing event. 
    /// </summary>
    [IsoId("_7stTtyCDEey8XKHwKquEQw")]
    [DisplayName("Billing Event")]
    [IsoXmlTag("BllgEvt")]
    public Amount19? BillingEvent { get; init; } 
    
    /// <summary>
    /// Total of taxes applicable to the billing amount.
    /// </summary>
    [IsoId("_7stTuSCDEey8XKHwKquEQw")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public Tax39? TotalTax { get; init; } 
    
    /// <summary>
    /// Additional user-defined data pertaining to the shipment.
    /// </summary>
    [IsoId("_7stTuyCDEey8XKHwKquEQw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
