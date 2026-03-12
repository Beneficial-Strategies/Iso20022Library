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
[IsoId("_SQk5gtp-Ed-ak6NoX_4Aeg_1384086328")]
[DisplayName("Interest Amount")]
public partial record InterestAmount2
{
    #nullable enable
    
    /// <summary>
    /// Amount of money representing an interest payment.
    /// </summary>
    [IsoId("_SQk5g9p-Ed-ak6NoX_4Aeg_1969327990")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public required ActiveCurrencyAndAmount AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Agreed date for the interest payment.
    /// </summary>
    [IsoId("_SQk5hNp-Ed-ak6NoX_4Aeg_1958229213")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public required DateAndDateTimeChoice_ ValueDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the interest will be settled in cash or rolled in the existing collateral balance.
    /// </summary>
    [IsoId("_SQk5hdp-Ed-ak6NoX_4Aeg_-35915493")]
    [DisplayName("Interest Method")]
    [IsoXmlTag("IntrstMtd")]
    public required InterestMethod1Code InterestMethod { get; init; } 
    
    /// <summary>
    /// Period for which the calculation has been performed.
    /// </summary>
    [IsoId("_SQk5htp-Ed-ak6NoX_4Aeg_2071212052")]
    [DisplayName("Interest Period")]
    [IsoXmlTag("IntrstPrd")]
    public required DatePeriodDetails InterestPeriod { get; init; } 
    
    /// <summary>
    /// Percentage charged for the use of an amount of money, usually expressed at an annual rate. The interest rate is the ratio of the amount of interest paid during a certain period of time compared to the principal amount of the interest bearing financial instrument.
    /// </summary>
    [IsoId("_SQk5h9p-Ed-ak6NoX_4Aeg_2013879751")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public InterestRate1Choice_? InterestRate { get; init; } 
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the security.
    /// </summary>
    [IsoId("_SQk5iNp-Ed-ak6NoX_4Aeg_-1296703788")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public InterestComputationMethod2Code? DayCountBasis { get; init; } 
    
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_SQk5idp-Ed-ak6NoX_4Aeg_1926258449")]
    [DisplayName("Applied Withholding Tax")]
    [IsoXmlTag("ApldWhldgTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AppliedWithholdingTax { get; init; } 
    
    /// <summary>
    /// Specifies whether the interest is simple or compounded.
    /// </summary>
    [IsoId("_SQuqgNp-Ed-ak6NoX_4Aeg_-67886257")]
    [DisplayName("Calculation Method")]
    [IsoXmlTag("ClctnMtd")]
    public CalculationMethod1Code? CalculationMethod { get; init; } 
    
    /// <summary>
    /// Specifies the periodicity of the calculation of the interest.
    /// </summary>
    [IsoId("_SQuqgdp-Ed-ak6NoX_4Aeg_-1817972367")]
    [DisplayName("Calculation Frequency")]
    [IsoXmlTag("ClctnFrqcy")]
    public Frequency1Code? CalculationFrequency { get; init; } 
    
    /// <summary>
    /// Specifies whether the collateral has been posted against the variation margin, the segregated independent amount or to cover any other risk defined with a proprietary code.
    /// </summary>
    [IsoId("_SQuqgtp-Ed-ak6NoX_4Aeg_-238253533")]
    [DisplayName("Collateral Purpose")]
    [IsoXmlTag("CollPurp")]
    public required CollateralPurpose1Choice_ CollateralPurpose { get; init; } 
    
    /// <summary>
    /// Provides details about the opening collateral balance.
    /// </summary>
    [IsoId("_SQuqg9p-Ed-ak6NoX_4Aeg_667059973")]
    [DisplayName("Opening Collateral Balance")]
    [IsoXmlTag("OpngCollBal")]
    public CollateralBalance1? OpeningCollateralBalance { get; init; } 
    
    /// <summary>
    /// Provides details about the closing collateral balance.
    /// </summary>
    [IsoId("_SQuqhNp-Ed-ak6NoX_4Aeg_2107004592")]
    [DisplayName("Closing Collateral Balance")]
    [IsoXmlTag("ClsgCollBal")]
    public required CollateralBalance1 ClosingCollateralBalance { get; init; } 
    
    /// <summary>
    /// Identifies the standard settlement instructions.
    /// </summary>
    [IsoId("_SQuqhdp-Ed-ak6NoX_4Aeg_2046756905")]
    [DisplayName("Standard Settlement Instructions")]
    [IsoXmlTag("StdSttlmInstrs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? StandardSettlementInstructions { get; init; } 
    
    /// <summary>
    /// Additionnal information related to interest request.
    /// </summary>
    [IsoId("_SQuqhtp-Ed-ak6NoX_4Aeg_-1308057571")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
