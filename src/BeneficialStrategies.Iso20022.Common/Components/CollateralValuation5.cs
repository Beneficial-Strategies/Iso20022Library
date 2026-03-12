// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details about the valuation of each piece of collateral that is posted.
/// </summary>
[IsoId("_0KFBF4FvEeWtPe6Crjmeug")]
[DisplayName("Collateral Valuation")]
public partial record CollateralValuation5
{
    #nullable enable
    
    /// <summary>
    /// Provides the identification of the valued collateral.
    /// </summary>
    [IsoId("_0f8jYYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the type of collateral used.
    /// </summary>
    [IsoId("_0f8jY4FvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public required CollateralType1Code CollateralType { get; init; } 
    
    /// <summary>
    /// Provides the status of settlement of an instruction/financial instrument movement.
    /// </summary>
    [IsoId("_0f8jZYFvEeWtPe6Crjmeug")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public required SettlementStatus2Code SettlementStatus { get; init; } 
    
    /// <summary>
    /// Specifies the number of days used for interest calculation.
    /// </summary>
    [IsoId("_0f8jZ4FvEeWtPe6Crjmeug")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_0f8jaYFvEeWtPe6Crjmeug")]
    [DisplayName("Valuation Amounts")]
    [IsoXmlTag("ValtnAmts")]
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_0f8ja4FvEeWtPe6Crjmeug")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public required InterestComputationMethod2Code DayCountBasis { get; init; } 
    
    /// <summary>
    /// Specifies the exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    [IsoId("_0f8jbYFvEeWtPe6Crjmeug")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Specifies the haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_0f8jb4FvEeWtPe6Crjmeug")]
    [DisplayName("Currency Haircut")]
    [IsoXmlTag("CcyHrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrencyHaircut { get; init; } 
    
    /// <summary>
    /// Percentage by which the collateral amount needs to be adjusted.
    /// </summary>
    [IsoId("_0f8jcYFvEeWtPe6Crjmeug")]
    [DisplayName("Adjusted Rate")]
    [IsoXmlTag("AdjstdRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? AdjustedRate { get; init; } 
    
    /// <summary>
    /// Provides details on the securities collateral.
    /// </summary>
    [IsoId("_0f8jc4FvEeWtPe6Crjmeug")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public SecuritiesCollateral6? SecuritiesCollateral { get; init; } 
    
    /// <summary>
    /// Provides details on the cash collateral valuation.
    /// </summary>
    [IsoId("_0f8jdYFvEeWtPe6Crjmeug")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public CashCollateral4? CashCollateral { get; init; } 
    
    /// <summary>
    /// Provides details on other collateral valuation.
    /// </summary>
    [IsoId("_0f8jd4FvEeWtPe6Crjmeug")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public OtherCollateral6? OtherCollateral { get; init; } 
    
    
    #nullable disable
    
}
