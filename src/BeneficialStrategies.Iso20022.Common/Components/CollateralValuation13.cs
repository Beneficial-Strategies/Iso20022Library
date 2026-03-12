// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Valuation details of each piece of collateral posted.
/// </summary>
[IsoId("_eJF90SqUEeyR9JrVGfaMKw")]
[DisplayName("Collateral Valuation")]
public partial record CollateralValuation13
{
    #nullable enable
    
    /// <summary>
    /// Identification of the valued collateral.
    /// </summary>
    [IsoId("_eg72ESqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Identification")]
    [IsoXmlTag("CollId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CollateralIdentification { get; init; } 
    
    /// <summary>
    /// Type of collateral used.
    /// </summary>
    [IsoId("_eg72EyqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public required CollateralType8Code CollateralType { get; init; } 
    
    /// <summary>
    /// Direction of the collateral being reported.
    /// </summary>
    [IsoId("_eg72FSqUEeyR9JrVGfaMKw")]
    [DisplayName("Collateral Direction")]
    [IsoXmlTag("CollDrctn")]
    public CollateralDirection1Code? CollateralDirection { get; init; } 
    
    /// <summary>
    /// Settlement status of the instruction/financial instrument movement.
    /// </summary>
    [IsoId("_eg72FyqUEeyR9JrVGfaMKw")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public required SettlementStatus3Code SettlementStatus { get; init; } 
    
    /// <summary>
    /// Indicates if the collateral being reported is applied or in excess.
    /// </summary>
    [IsoId("_eg72GSqUEeyR9JrVGfaMKw")]
    [DisplayName("Applied Excess Indicator")]
    [IsoXmlTag("ApldXcssInd")]
    public CollateralAppliedExcess1Code? AppliedExcessIndicator { get; init; } 
    
    /// <summary>
    /// Number of days used for interest calculation.
    /// </summary>
    [IsoId("_eg72GyqUEeyR9JrVGfaMKw")]
    [DisplayName("Number Of Days Accrued")]
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// Details of the collateral valuation.
    /// </summary>
    [IsoId("_eg72HSqUEeyR9JrVGfaMKw")]
    [DisplayName("Valuation Amounts")]
    [IsoXmlTag("ValtnAmts")]
    public required CollateralAmount1 ValuationAmounts { get; init; } 
    
    /// <summary>
    /// Computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_eg72HyqUEeyR9JrVGfaMKw")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    
    /// <summary>
    /// Exchange rate between the currency of the collateral and the reporting currency.
    /// </summary>
    [IsoId("_eg72ISqUEeyR9JrVGfaMKw")]
    [DisplayName("Exchange Rate")]
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the currency of the collateral expressed as a percentage.
    /// </summary>
    [IsoId("_eg72IyqUEeyR9JrVGfaMKw")]
    [DisplayName("Currency Haircut")]
    [IsoXmlTag("CcyHrcut")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? CurrencyHaircut { get; init; } 
    
    /// <summary>
    /// Percentage by which the collateral amount needs to be adjusted.
    /// </summary>
    [IsoId("_eg72JSqUEeyR9JrVGfaMKw")]
    [DisplayName("Adjusted Rate")]
    [IsoXmlTag("AdjstdRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? AdjustedRate { get; init; } 
    
    /// <summary>
    /// Provides details on the securities collateral.
    /// </summary>
    [IsoId("_eg72JyqUEeyR9JrVGfaMKw")]
    [DisplayName("Securities Collateral")]
    [IsoXmlTag("SctiesColl")]
    public SecuritiesCollateral13? SecuritiesCollateral { get; init; } 
    
    /// <summary>
    /// Details of the cash collateral valuation.
    /// </summary>
    [IsoId("_eg72KSqUEeyR9JrVGfaMKw")]
    [DisplayName("Cash Collateral")]
    [IsoXmlTag("CshColl")]
    public CashCollateral4? CashCollateral { get; init; } 
    
    /// <summary>
    /// Details of other collateral.
    /// </summary>
    [IsoId("_eg72KyqUEeyR9JrVGfaMKw")]
    [DisplayName("Other Collateral")]
    [IsoXmlTag("OthrColl")]
    public OtherCollateral10? OtherCollateral { get; init; } 
    
    
    #nullable disable
    
}
