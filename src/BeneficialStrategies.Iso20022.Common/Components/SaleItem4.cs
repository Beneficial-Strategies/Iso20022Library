// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sale Item4.
/// </summary>
[IsoId("_fRnPIXNSEe6Y1uOeeiF_Eg")]
[DisplayName("Sale Item4")]
public partial record SaleItem4
{
    #nullable enable

    /// <summary>
    /// Additional Product Code.
    /// </summary>
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    public IsoMax70Text? AdditionalProductCode { get; init; } 

    /// <summary>
    /// Additional Product Code Type.
    /// </summary>
    [DisplayName("Additional Product Code Type")]
    [IsoXmlTag("AddtlPdctCdTp")]
    public IsoMax35Text? AdditionalProductCodeType { get; init; } 

    /// <summary>
    /// Adjusted Amount.
    /// </summary>
    [DisplayName("Adjusted Amount")]
    [IsoXmlTag("AdjstdAmt")]
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; init; } 

    /// <summary>
    /// Adjustment.
    /// </summary>
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public ValueList<Adjustment14> Adjustment { get; init; } = [];

    /// <summary>
    /// Insurance Amount.
    /// </summary>
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 

    /// <summary>
    /// Insurance Indicator.
    /// </summary>
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 

    /// <summary>
    /// Non Adjusted Total Amount.
    /// </summary>
    [DisplayName("Non Adjusted Total Amount")]
    [IsoXmlTag("NonAdjstdTtlAmt")]
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; } 

    /// <summary>
    /// Non Adjusted Unit Price.
    /// </summary>
    [DisplayName("Non Adjusted Unit Price")]
    [IsoXmlTag("NonAdjstdUnitPric")]
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; } 

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
    /// Product Code Modifier.
    /// </summary>
    [DisplayName("Product Code Modifier")]
    [IsoXmlTag("PdctCdModfr")]
    public IsoDecimalNumber? ProductCodeModifier { get; init; } 

    /// <summary>
    /// Product Code Type.
    /// </summary>
    [DisplayName("Product Code Type")]
    [IsoXmlTag("PdctCdTp")]
    public ProductCodeType1Code? ProductCodeType { get; init; } 

    /// <summary>
    /// Product Description.
    /// </summary>
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    public IsoMax140Text? ProductDescription { get; init; } 

    /// <summary>
    /// Product Quantity.
    /// </summary>
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    public IsoDecimalNumber? ProductQuantity { get; init; } 

    /// <summary>
    /// Product Type.
    /// </summary>
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    public IsoMax35Text? ProductType { get; init; } 

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
    /// Unit Of Measure.
    /// </summary>
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 

    
    #nullable disable
    
}
