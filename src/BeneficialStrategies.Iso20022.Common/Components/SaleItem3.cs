// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Item purchased with the transaction
/// </summary>
[IsoId("_tJtrsSCAEey8XKHwKquEQw")]
[DisplayName("Sale Item")]
public partial record SaleItem3
{
    #nullable enable
    
    /// <summary>
    /// Contains the product type of the sale line item.
    /// </summary>
    [IsoId("_tQC9MSCAEey8XKHwKquEQw")]
    [DisplayName("Product Type")]
    [IsoXmlTag("PdctTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProductType { get; init; } 
    
    /// <summary>
    /// Product code of the item.
    /// </summary>
    [IsoId("_tQC9MyCAEey8XKHwKquEQw")]
    [DisplayName("Product Code")]
    [IsoXmlTag("PdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ProductCode { get; init; } 
    
    /// <summary>
    /// Contains a list of codes used to identify a product.
    /// </summary>
    [IsoId("_tQC9NSCAEey8XKHwKquEQw")]
    [DisplayName("Product Code Type")]
    [IsoXmlTag("PdctCdTp")]
    public ProductCodeType1Code? ProductCodeType { get; init; } 
    
    /// <summary>
    /// Additional code related to the product.
    /// </summary>
    [IsoId("_tQC9NyCAEey8XKHwKquEQw")]
    [DisplayName("Additional Product Code")]
    [IsoXmlTag("AddtlPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? AdditionalProductCode { get; init; } 
    
    /// <summary>
    /// Additional type of codification  used to identify a product.
    /// </summary>
    [IsoId("_tQC9OSCAEey8XKHwKquEQw")]
    [DisplayName("Additional Product Code Type")]
    [IsoXmlTag("AddtlPdctCdTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AdditionalProductCodeType { get; init; } 
    
    /// <summary>
    /// Code discriminator between a product code and its format to uniquely identify a specific product (for example, Item or pack of same items).
    /// </summary>
    [IsoId("_tQC9OyCAEey8XKHwKquEQw")]
    [DisplayName("Product Code Modifier")]
    [IsoXmlTag("PdctCdModfr")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductCodeModifier { get; init; } 
    
    /// <summary>
    /// Description of the product or item.
    /// </summary>
    [IsoId("_tQC9PSCAEey8XKHwKquEQw")]
    [DisplayName("Product Description")]
    [IsoXmlTag("PdctDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? ProductDescription { get; init; } 
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_tQC9PyCAEey8XKHwKquEQw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_tQC9QSCAEey8XKHwKquEQw")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_tQC9QyCAEey8XKHwKquEQw")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    
    /// <summary>
    /// Original, non-adjusted cost of one unit of the product or service before discounts and taxes.
    /// </summary>
    [IsoId("_tQC9RSCAEey8XKHwKquEQw")]
    [DisplayName("Non Adjusted Unit Price")]
    [IsoXmlTag("NonAdjstdUnitPric")]
    public ImpliedCurrencyAndAmount? NonAdjustedUnitPrice { get; init; } 
    
    /// <summary>
    /// Original, non-adjusted total cost of a product or service before discounts and taxes.
    /// </summary>
    [IsoId("_tQC9RyCAEey8XKHwKquEQw")]
    [DisplayName("Non Adjusted Total Amount")]
    [IsoXmlTag("NonAdjstdTtlAmt")]
    public ImpliedCurrencyAndAmount? NonAdjustedTotalAmount { get; init; } 
    
    /// <summary>
    /// Adjustment made to the original price.
    /// </summary>
    [IsoId("_tQC9SSCAEey8XKHwKquEQw")]
    [DisplayName("Adjustment")]
    [IsoXmlTag("Adjstmnt")]
    public Adjustment10? Adjustment { get; init; } 
    
    /// <summary>
    /// Total cost of the line item amount, inclusive adjustments and exclusive of taxes.
    /// </summary>
    [IsoId("_tQC9SyCAEey8XKHwKquEQw")]
    [DisplayName("Adjusted Amount")]
    [IsoXmlTag("AdjstdAmt")]
    public ImpliedCurrencyAndAmount? AdjustedAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_tQC9TSCAEey8XKHwKquEQw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    
    /// <summary>
    /// Cost of the insurance purchased.
    /// </summary>
    [IsoId("_tQC9TyCAEey8XKHwKquEQw")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; } 
    
    /// <summary>
    /// Taxes applying to the good or item.
    /// </summary>
    [IsoId("_tQC9USCAEey8XKHwKquEQw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; } 
    
    /// <summary>
    /// Total cost of the line item, inclusive of all applicable adjustments and taxes.
    /// </summary>
    [IsoId("_tQC9UyCAEey8XKHwKquEQw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; } 
    
    
    #nullable disable
    
}
