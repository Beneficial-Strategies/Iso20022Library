// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice Line Item3.
/// </summary>
[IsoId("_KXZxEXQ5Ee6Y1uOeeiF_Eg")]
[DisplayName("Invoice Line Item3")]
public partial record InvoiceLineItem3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Adjustment Amount.
    /// </summary>
    [DisplayName("Adjustment Amount")]
    [IsoXmlTag("AdjstmntAmt")]
    public ImpliedCurrencyAndAmount? AdjustmentAmount { get; init; } 

    /// <summary>
    /// Adjustment Credit Debit.
    /// </summary>
    [DisplayName("Adjustment Credit Debit")]
    [IsoXmlTag("AdjstmntCdtDbt")]
    public CreditDebit3Code? AdjustmentCreditDebit { get; init; } 

    /// <summary>
    /// Adjustment Reason.
    /// </summary>
    [DisplayName("Adjustment Reason")]
    [IsoXmlTag("AdjstmntRsn")]
    public IsoMax35Text? AdjustmentReason { get; init; } 

    /// <summary>
    /// Contract Number.
    /// </summary>
    [DisplayName("Contract Number")]
    [IsoXmlTag("CtrctNb")]
    public IsoMax70Text? ContractNumber { get; init; } 

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Description.
    /// </summary>
    [DisplayName("Description")]
    [IsoXmlTag("Desc")]
    public IsoMax256Text? Description { get; init; } 

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; } 

    /// <summary>
    /// Insurance Amount.
    /// </summary>
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 

    /// <summary>
    /// Medical Services.
    /// </summary>
    [DisplayName("Medical Services")]
    [IsoXmlTag("MdclSvcs")]
    public IsoTrueFalseIndicator? MedicalServices { get; init; } 

    /// <summary>
    /// Order Date.
    /// </summary>
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    public IsoISODate? OrderDate { get; init; } 

    /// <summary>
    /// Other Unit Of Measure.
    /// </summary>
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 

    /// <summary>
    /// Product Code.
    /// </summary>
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax70Text? ProductCode { get; init; } 

    /// <summary>
    /// Product Qualifier.
    /// </summary>
    [DisplayName("Product Qualifier")]
    [IsoXmlTag("PdctQlfr")]
    public IsoMax35Text? ProductQualifier { get; init; } 

    /// <summary>
    /// Product Quantity.
    /// </summary>
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public IsoDecimalNumber? ProductQuantity { get; init; } 

    /// <summary>
    /// Rebilling.
    /// </summary>
    [DisplayName("Rebilling")]
    [IsoXmlTag("Rbllg")]
    public IsoTrueFalseIndicator? Rebilling { get; init; } 

    /// <summary>
    /// Shipping Date.
    /// </summary>
    [DisplayName("Shipping Date")]
    [IsoXmlTag("ShppgDt")]
    public IsoISODate? ShippingDate { get; init; } 

    /// <summary>
    /// Ship To Industry Code.
    /// </summary>
    [DisplayName("Ship To Industry Code")]
    [IsoXmlTag("ShipToIndstryCd")]
    public IsoMax50Text? ShipToIndustryCode { get; init; } 

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 

    /// <summary>
    /// Type Of Supply.
    /// </summary>
    [DisplayName("Type Of Supply")]
    [IsoXmlTag("TpOfSpply")]
    public IsoMax10Text? TypeOfSupply { get; init; } 

    /// <summary>
    /// Unit Of Measure.
    /// </summary>
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 

    /// <summary>
    /// Unit Price.
    /// </summary>
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 

    /// <summary>
    /// VAT Invoice Reference.
    /// </summary>
    [DisplayName("VAT Invoice Reference")]
    [IsoXmlTag("VATInvcRef")]
    public IsoMax35Text? VATInvoiceReference { get; init; } 

    /// <summary>
    /// Zero Cost To Customer.
    /// </summary>
    [DisplayName("Zero Cost To Customer")]
    [IsoXmlTag("ZeroCostToCstmr")]
    public IsoTrueFalseIndicator? ZeroCostToCustomer { get; init; } 

    
    #nullable disable
    
}
