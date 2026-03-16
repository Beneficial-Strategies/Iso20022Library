// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet Line Item5.
/// </summary>
[IsoId("_VEN0wXNXEe6Y1uOeeiF_Eg")]
[DisplayName("Fleet Line Item5")]
public partial record FleetLineItem5
{
    #nullable enable

    /// <summary>
    /// Discount Amount.
    /// </summary>
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 

    /// <summary>
    /// Fuel.
    /// </summary>
    [DisplayName("Fuel")]
    [IsoXmlTag("Fuel")]
    public required IsoTrueFalseIndicator Fuel { get; init; } 

    /// <summary>
    /// Fuel Brand Code.
    /// </summary>
    [DisplayName("Fuel Brand Code")]
    [IsoXmlTag("FuelBrndCd")]
    public IsoMax4Text? FuelBrandCode { get; init; } 

    /// <summary>
    /// Non Taxable.
    /// </summary>
    [DisplayName("Non Taxable")]
    [IsoXmlTag("NonTaxbl")]
    public IsoTrueFalseIndicator? NonTaxable { get; init; } 

    /// <summary>
    /// Other Unit Of Measure.
    /// </summary>
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 

    /// <summary>
    /// Product Category.
    /// </summary>
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public IsoMax35Text? ProductCategory { get; init; } 

    /// <summary>
    /// Product Code.
    /// </summary>
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public IsoMax4Text? ProductCode { get; init; } 

    /// <summary>
    /// Product Code Assigner.
    /// </summary>
    [DisplayName("Product Code Assigner")]
    [IsoXmlTag("PdctCdAssgnr")]
    public IsoMax35Text? ProductCodeAssigner { get; init; } 

    /// <summary>
    /// Product Qualifier.
    /// </summary>
    [DisplayName("Product Qualifier")]
    [IsoXmlTag("PdctQlfr")]
    public IsoMax6Text? ProductQualifier { get; init; } 

    /// <summary>
    /// Product Quantity.
    /// </summary>
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public IsoDecimalNumber? ProductQuantity { get; init; } 

    /// <summary>
    /// Service Type.
    /// </summary>
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public FleetServiceType1Code? ServiceType { get; init; } 

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    /// <summary>
    /// Total Amount Excluding Tax.
    /// </summary>
    [DisplayName("Total Amount Excluding Tax")]
    [IsoXmlTag("TtlAmtExclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 

    /// <summary>
    /// Total Amount Including Tax.
    /// </summary>
    [DisplayName("Total Amount Including Tax")]
    [IsoXmlTag("TtlAmtInclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 

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
    /// Unit Price Tax.
    /// </summary>
    [DisplayName("Unit Price Tax")]
    [IsoXmlTag("UnitPricTax")]
    public IsoTrueFalseIndicator? UnitPriceTax { get; init; } 

    
    #nullable disable
    
}
