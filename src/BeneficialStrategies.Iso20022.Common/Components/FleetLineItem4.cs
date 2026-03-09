// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for fleet transactions.
/// </summary>
[IsoId("_HUQwMSCFEey8XKHwKquEQw")]
[DisplayName("Fleet Line Item")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FleetLineItem4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FleetLineItem4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FleetLineItem4( System.String reqFuelIndicator )
    {
        FuelIndicator = reqFuelIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// True = Fuel item
    /// False = Non-fuel item
    /// </summary>
    [IsoId("_HZlVESCFEey8XKHwKquEQw")]
    [DisplayName("Fuel Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelInd")]
    #endif
    [IsoXmlTag("FuelInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator FuelIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String FuelIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String FuelIndicator { get; init; } 
    #else
    public System.String FuelIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of service received at the acceptor location. 
    /// </summary>
    [IsoId("_HZlVEyCFEey8XKHwKquEQw")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetServiceType1Code? ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetServiceType1Code? ServiceType { get; init; } 
    #else
    public FleetServiceType1Code? ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Code that identifies the brand of the fuel purchased. 
    /// </summary>
    [IsoId("_HZlVFSCFEey8XKHwKquEQw")]
    [DisplayName("Fuel Brand Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FuelBrndCd")]
    #endif
    [IsoXmlTag("FuelBrndCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? FuelBrandCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FuelBrandCode { get; init; } 
    #else
    public System.String? FuelBrandCode { get; set; } 
    #endif
    
    /// <summary>
    /// Product code of fleet product or service being purchased.
    /// </summary>
    [IsoId("_HZlVFyCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetPdctCd")]
    #endif
    [IsoXmlTag("FleetPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? FleetProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetProductCode { get; init; } 
    #else
    public System.String? FleetProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a code that identifies a category of fleet products or services. 
    /// </summary>
    [IsoId("_HZlVGSCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Category")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetPdctCtgy")]
    #endif
    [IsoXmlTag("FleetPdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FleetProductCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetProductCategory { get; init; } 
    #else
    public System.String? FleetProductCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a code that identifies the product qualifier of the fleet product or service. 
    /// </summary>
    [IsoId("_HZlVGyCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Qualifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetPdctQlfr")]
    #endif
    [IsoXmlTag("FleetPdctQlfr")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6Text? FleetProductQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetProductQualifier { get; init; } 
    #else
    public System.String? FleetProductQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a code that identifies the product code assigner.
    /// </summary>
    [IsoId("_HZlVHSCFEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Code Assigner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FleetPdctCdAssgnr")]
    #endif
    [IsoXmlTag("FleetPdctCdAssgnr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FleetProductCodeAssigner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FleetProductCodeAssigner { get; init; } 
    #else
    public System.String? FleetProductCodeAssigner { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not tax is included in unit price.
    /// True: includes tax 
    /// False: does not include tax.   
    /// </summary>
    [IsoId("_HZlVHyCFEey8XKHwKquEQw")]
    [DisplayName("Unit Price Tax Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPricTaxInd")]
    #endif
    [IsoXmlTag("UnitPricTaxInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? UnitPriceTaxIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnitPriceTaxIndicator { get; init; } 
    #else
    public System.String? UnitPriceTaxIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Unit price of the fleet line item.
    /// </summary>
    [IsoId("_HZlVISCFEey8XKHwKquEQw")]
    [DisplayName("Unit Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitPric")]
    #endif
    [IsoXmlTag("UnitPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? UnitPrice { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_HZlVIyCFEey8XKHwKquEQw")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    #else
    public UnitOfMeasure1Code? UnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Other unit of measure.
    /// </summary>
    [IsoId("_HZlVJSCFEey8XKHwKquEQw")]
    [DisplayName("Other Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrUnitOfMeasr")]
    #endif
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherUnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherUnitOfMeasure { get; init; } 
    #else
    public System.String? OtherUnitOfMeasure { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_HZlVJyCFEey8XKHwKquEQw")]
    [DisplayName("Product Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PdctQty")]
    #endif
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ProductQuantity { get; init; } 
    #else
    public System.UInt64? ProductQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the discount amount applied to the fleet transaction (includes coupons).
    /// </summary>
    [IsoId("_HZlVKSCFEey8XKHwKquEQw")]
    [DisplayName("Discount Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DscntAmt")]
    #endif
    [IsoXmlTag("DscntAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? DiscountAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not amount of fleet purchase is taxable. 
    /// </summary>
    [IsoId("_HZlVKyCFEey8XKHwKquEQw")]
    [DisplayName("Non Taxable Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonTaxblInd")]
    #endif
    [IsoXmlTag("NonTaxblInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NonTaxableIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonTaxableIndicator { get; init; } 
    #else
    public System.String? NonTaxableIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_HZlVLSCFEey8XKHwKquEQw")]
    [DisplayName("Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tax")]
    #endif
    [IsoXmlTag("Tax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Tax39? Tax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Tax39? Tax { get; init; } 
    #else
    public Tax39? Tax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [IsoId("_HZlVLyCFEey8XKHwKquEQw")]
    [DisplayName("Total Amount Excluding Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtExclgTax")]
    #endif
    [IsoXmlTag("TtlAmtExclgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [IsoId("_HZlVMSCFEey8XKHwKquEQw")]
    [DisplayName("Total Amount Including Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlAmtInclgTax")]
    #endif
    [IsoXmlTag("TtlAmtInclgTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    #else
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
