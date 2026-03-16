// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Telecom Services3.
/// </summary>
[IsoId("_05CBYXTwEe6h-4AZRg9sVg")]
[DisplayName("Telecom Services3")]
public partial record TelecomServices3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Billing End.
    /// </summary>
    [DisplayName("Billing End")]
    [IsoXmlTag("BllgEnd")]
    public IsoISODate? BillingEnd { get; init; } 

    /// <summary>
    /// Billing Event.
    /// </summary>
    [DisplayName("Billing Event")]
    [IsoXmlTag("BllgEvt")]
    public ValueList<Amount22> BillingEvent { get; init; } = [];

    /// <summary>
    /// Billing Start.
    /// </summary>
    [DisplayName("Billing Start")]
    [IsoXmlTag("BllgStart")]
    public IsoISODate? BillingStart { get; init; } 

    /// <summary>
    /// Customer Account Number.
    /// </summary>
    [DisplayName("Customer Account Number")]
    [IsoXmlTag("CstmrAcctNb")]
    public IsoMax35Text? CustomerAccountNumber { get; init; } 

    /// <summary>
    /// Customer Name.
    /// </summary>
    [DisplayName("Customer Name")]
    [IsoXmlTag("CstmrNm")]
    public IsoMax70Text? CustomerName { get; init; } 

    /// <summary>
    /// Customer Phone.
    /// </summary>
    [DisplayName("Customer Phone")]
    [IsoXmlTag("CstmrPhne")]
    public IsoPhoneNumber? CustomerPhone { get; init; } 

    /// <summary>
    /// Line Item.
    /// </summary>
    [DisplayName("Line Item")]
    [IsoXmlTag("LineItm")]
    public ValueList<TelecomServicesLineItem3> LineItem { get; init; } = [];

    /// <summary>
    /// Total Tax.
    /// </summary>
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax41> TotalTax { get; init; } = [];

    
    #nullable disable
    
}
