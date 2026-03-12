// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the elements related to the interest amount calculation.
/// </summary>
[IsoId("_Oz1hcStMEeyOa655cLd-DQ")]
[DisplayName("Interest Amount")]
public partial record InterestAmount3
{
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_PN61YStMEeyOa655cLd-DQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    [IsoId("_PN61YytMEeyOa655cLd-DQ")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public required DateAndDateTime2Choice_ ValueDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    [IsoId("_PN61ZStMEeyOa655cLd-DQ")]
    [DisplayName("Interest Method")]
    [IsoXmlTag("IntrstMtd")]
    public required InterestMethod1Code InterestMethod { get; init; } 
    
    /// <summary>
    /// Period for which the calculation has been performed.
    /// </summary>
    [IsoId("_PN61ZytMEeyOa655cLd-DQ")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public required DatePeriod2 InterestPeriod { get; init; } 
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_PN61aStMEeyOa655cLd-DQ")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate1Choice_? InterestRate { get; init; } 
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_PN61aytMEeyOa655cLd-DQ")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_PN61bStMEeyOa655cLd-DQ")]
    [DisplayName("Applied Withholding Tax")]
    [IsoXmlTag("ApldWhldgTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AppliedWithholdingTax { get; init; } 
    
    /// <summary>
    /// Specifies whether the interest is simple or compounded.
    /// </summary>
    [IsoId("_PN61bytMEeyOa655cLd-DQ")]
    [DisplayName("Calculation Method")]
    [IsoXmlTag("ClctnMtd")]
    public CalculationMethod1Code? CalculationMethod { get; init; } 
    
    /// <summary>
    /// Specifies the periodicity of the calculation of the interest.
    /// </summary>
    [IsoId("_PN61cStMEeyOa655cLd-DQ")]
    [DisplayName("Calculation Frequency")]
    [IsoXmlTag("ClctnFrqcy")]
    public Frequency1Code? CalculationFrequency { get; init; } 
    
    /// <summary>
    /// Specifies whether the collateral has been posted against the variation margin, the segregated independent amount or to cover any other risk defined with a proprietary code.
    /// </summary>
    [IsoId("_PN61cytMEeyOa655cLd-DQ")]
    [DisplayName("Collateral Purpose")]
    [IsoXmlTag("CollPurp")]
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    [IsoId("_PN61dStMEeyOa655cLd-DQ")]
    [DisplayName("Opening Collateral Balance")]
    [IsoXmlTag("OpngCollBal")]
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    [IsoId("_PN61dytMEeyOa655cLd-DQ")]
    [DisplayName("Closing Collateral Balance")]
    [IsoXmlTag("ClsgCollBal")]
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_PN61eStMEeyOa655cLd-DQ")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    
    /// <summary>
    /// Additionnal information related to interest request.
    /// </summary>
    [IsoId("_PN61eytMEeyOa655cLd-DQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
