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
[IsoId("_Tw694R1TEey8XKHwKquEQw")]
[DisplayName("Fleet Line Item")]
public partial record FleetLineItem3
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether or not the requested product or service is allowed.
    /// True = Allowed
    /// False = Not allowed
    /// </summary>
    [IsoId("_T46cQR1TEey8XKHwKquEQw")]
    [DisplayName("Allowed Item Indicator")]
    [IsoXmlTag("AllwdItmInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AllowedItemIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the line item represents a fuel or non-fuel product or service.
    /// </summary>
    [IsoId("_T46cQx1TEey8XKHwKquEQw")]
    [DisplayName("Fuel Indicator")]
    [IsoXmlTag("FuelInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator FuelIndicator { get; init; } 
    
    /// <summary>
    /// Type of service received at the acceptor location. 
    /// </summary>
    [IsoId("_T46cRR1TEey8XKHwKquEQw")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public FleetServiceType1Code? ServiceType { get; init; } 
    
    /// <summary>
    /// Contains a code that identifies a category of fleet products or services. 
    /// </summary>
    [IsoId("_T46cRx1TEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Category")]
    [IsoXmlTag("FleetPdctCtgy")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? FleetProductCategory { get; init; } 
    
    /// <summary>
    /// Code that identifies the type of fuel or non-fuel product or service being purchased. 
    /// </summary>
    [IsoId("_T46cSR1TEey8XKHwKquEQw")]
    [DisplayName("Fleet Product Code")]
    [IsoXmlTag("FleetPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoMax15Text? FleetProductCode { get; init; } 
    
    /// <summary>
    /// Unit of measure of the item purchased.
    /// </summary>
    [IsoId("_T46cSx1TEey8XKHwKquEQw")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public UnitOfMeasure1Code? UnitOfMeasure { get; init; } 
    
    /// <summary>
    /// Quantity of product or item.
    /// </summary>
    [IsoId("_T46cTR1TEey8XKHwKquEQw")]
    [DisplayName("Product Quantity")]
    [IsoXmlTag("PdctQty")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ProductQuantity { get; init; } 
    
    /// <summary>
    /// Total amount excluding tax.
    /// </summary>
    [IsoId("_T47DUR1TEey8XKHwKquEQw")]
    [DisplayName("Total Amount Excluding Tax")]
    [IsoXmlTag("TtlAmtExclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountExcludingTax { get; init; } 
    
    /// <summary>
    /// Total amount including tax.
    /// </summary>
    [IsoId("_T47DUx1TEey8XKHwKquEQw")]
    [DisplayName("Total Amount Including Tax")]
    [IsoXmlTag("TtlAmtInclgTax")]
    public ImpliedCurrencyAndAmount? TotalAmountIncludingTax { get; init; } 
    
    
    #nullable disable
    
}
