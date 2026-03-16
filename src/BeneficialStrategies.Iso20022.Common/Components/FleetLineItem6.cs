// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Fleet Line Item6.
/// </summary>
[IsoId("_icu_sXjWEe6YlIMyoxWMJA")]
[DisplayName("Fleet Line Item6")]
public partial record FleetLineItem6
{
    #nullable enable

    /// <summary>
    /// Allowed Item.
    /// </summary>
    [DisplayName("Allowed Item")]
    [IsoXmlTag("AllwdItm")]
    public IsoTrueFalseIndicator? AllowedItem { get; init; } 

    /// <summary>
    /// Fuel.
    /// </summary>
    [DisplayName("Fuel")]
    [IsoXmlTag("Fuel")]
    public required IsoTrueFalseIndicator Fuel { get; init; } 

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
    public IsoMax15Text? ProductCode { get; init; } 

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

    
    #nullable disable
    
}
