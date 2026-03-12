// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_HUQwMSCFEey8XKHwKquEQw")]
[DisplayName("Fleet Line Item")]
public partial record FleetLineItem4
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// True = Fuel item
    /// False = Non-fuel item
    /// </summary>
    [IsoId("_HZlVESCFEey8XKHwKquEQw")]
    [DisplayName("Fuel Indicator")]
    [IsoXmlTag("FuelInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator FuelIndicator { get; init; } 
    
    /// <summary>
    /// Type of service received at the acceptor location. 
    /// </summary>
    [IsoId("_HZlVEyCFEey8XKHwKquEQw")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public FleetServiceType1Code? ServiceType { get; init; } 
    
    /// <summary>
    /// Code that identifies the brand of the fuel purchased. 
    /// </summary>
    [IsoId("_HZlVFSCFEey8XKHwKquEQw")]
    [DisplayName("Fuel Brand Code")]
    [IsoXmlTag("FuelBrndCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? FuelBrandCode { get; init; } 
    
    /// <summary>
    /// Product code of fleet product or service being purchased.
    /// </summary>
    [IsoId("_HZlVFyCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Code")]
    [IsoXmlTag("FleetPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4Text? FleetProductCode { get; init; } 
    
    /// <summary>
    /// Contains a code that identifies a category of fleet products or services. 
    /// </summary>
    [IsoId("_HZlVGSCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Category")]
    [IsoXmlTag("FleetPdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FleetProductCategory { get; init; } 
    
    /// <summary>
    /// Contains a code that identifies the product qualifier of the fleet product or service. 
    /// </summary>
    [IsoId("_HZlVGyCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Qualifier")]
    [IsoXmlTag("FleetPdctQlfr")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    public IsoMax6Text? FleetProductQualifier { get; init; } 
    
    /// <summary>
    /// Contains a code that identifies the product code assigner.
    /// </summary>
    [IsoId("_HZlVHSCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Code Assigner")]
    [IsoXmlTag("FleetPdctCdAssgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FleetProductCodeAssigner { get; init; } 
    
    /// <summary>
    /// Indicates whether or not tax is included in unit price.
    /// True: includes tax 
    /// False: does not include tax.   
    /// </summary>
    [IsoId("_HZlVHyCFEey8XKHwKquEQw")]
    [DisplayName("Unit Price Tax Indicator")]
    [IsoXmlTag("UnitPricTaxInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? UnitPriceTaxIndicator { get; init; } 
    
    /// <summary>
    /// Unit price of the fleet line item.
    /// </summary>
    [IsoId("_HZlVISCFEey8XKHwKquEQw")]
    [DisplayName("Unit Price")]
    [IsoXmlTag("UnitPric")]
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_HZlVIyCFEey8XKHwKquEQw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_HZlVJSCFEey8XKHwKquEQw")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_HZlVJyCFEey8XKHwKquEQw")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    
    /// <summary>
    /// Contains the discount amount applied to the fleet transaction (includes coupons).
    /// </summary>
    [IsoId("_HZlVKSCFEey8XKHwKquEQw")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 
    
    /// <summary>
    /// Indicates whether or not amount of fleet purchase is taxable. 
    /// </summary>
    [IsoId("_HZlVKyCFEey8XKHwKquEQw")]
    [DisplayName("Non Taxable Indicator")]
    [IsoXmlTag("NonTaxblInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NonTaxableIndicator { get; init; } 
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_HZlVLSCFEey8XKHwKquEQw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; } 
    
    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [IsoId("_HZlVLyCFEey8XKHwKquEQw")]
    [DisplayName("Total Amount Excluding Tax")]
    [IsoXmlTag("TtlAmtExclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    
    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [IsoId("_HZlVMSCFEey8XKHwKquEQw")]
    [DisplayName("Total Amount Including Tax")]
    [IsoXmlTag("TtlAmtInclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    
    
    #nullable disable
    
}
