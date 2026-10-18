// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet Line Item5.
/// </summary>
[IsoId("_VEN0wXNXEe6Y1uOeeiF_Eg")]
[DisplayName("Fleet Line Item5")]
public record FleetLineItem5
{
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
    public required TrueFalseIndicator Fuel { get; init; }

    /// <summary>
    /// Fuel Brand Code.
    /// </summary>
    [DisplayName("Fuel Brand Code")]
    [IsoXmlTag("FuelBrndCd")]
    public Max4Text? FuelBrandCode { get; init; }

    /// <summary>
    /// Non Taxable.
    /// </summary>
    [DisplayName("Non Taxable")]
    [IsoXmlTag("NonTaxbl")]
    public TrueFalseIndicator? NonTaxable { get; init; }

    /// <summary>
    /// Other Unit Of Measure.
    /// </summary>
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    public Max35Text? OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Product Category.
    /// </summary>
    [DisplayName("Product Category")]
    [IsoXmlTag("PdctCtgy")]
    public Max35Text? ProductCategory { get; init; }

    /// <summary>
    /// Product Code.
    /// </summary>
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    public Max4Text? ProductCode { get; init; }

    /// <summary>
    /// Product Code Assigner.
    /// </summary>
    [DisplayName("Product Code Assigner")]
    [IsoXmlTag("PdctCdAssgnr")]
    public Max35Text? ProductCodeAssigner { get; init; }

    /// <summary>
    /// Product Qualifier.
    /// </summary>
    [DisplayName("Product Qualifier")]
    [IsoXmlTag("PdctQlfr")]
    public Max6Text? ProductQualifier { get; init; }

    /// <summary>
    /// Product Quantity.
    /// </summary>
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public DecimalNumber? ProductQuantity { get; init; }

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
    public TrueFalseIndicator? UnitPriceTax { get; init; }
}
