// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_g1ErobPvEeelzbgsFa3sqQ")]
[DisplayName("Securities Financing Transaction Details")]
public partial record SecuritiesFinancingTransactionDetails37
{
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_hEscAbPvEeelzbgsFa3sqQ")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; } 
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_hEscCbPvEeelzbgsFa3sqQ")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ClosingLegIdentification { get; init; } 
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_hEscEbPvEeelzbgsFa3sqQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate6Choice_? TerminationDate { get; init; } 
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_hEscGbPvEeelzbgsFa3sqQ")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTime2Choice_? RateChangeDate { get; init; } 
    
    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_hEscIbPvEeelzbgsFa3sqQ")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; } 
    
    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_hEscI7PvEeelzbgsFa3sqQ")]
    [DisplayName("Commission Calculation Date")]
    [IsoXmlTag("ComssnClctnDt")]
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_hEscJbPvEeelzbgsFa3sqQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice_? RateType { get; init; } 
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_hEscLbPvEeelzbgsFa3sqQ")]
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public RevaluationIndicator3Choice_? Revaluation { get; init; } 
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_hEscNbPvEeelzbgsFa3sqQ")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework3Choice_? LegalFramework { get; init; } 
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_hEscPbPvEeelzbgsFa3sqQ")]
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethodFormat4Choice_? InterestComputationMethod { get; init; } 
    
    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_hEscRbPvEeelzbgsFa3sqQ")]
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    
    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_hEscTbPvEeelzbgsFa3sqQ")]
    [DisplayName("Interest Payment")]
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_hEscVbPvEeelzbgsFa3sqQ")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; } 
    
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_hEscXbPvEeelzbgsFa3sqQ")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; } 
    
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_hEscZbPvEeelzbgsFa3sqQ")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_hEscbbPvEeelzbgsFa3sqQ")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; } 
    
    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    [IsoId("_hEscdbPvEeelzbgsFa3sqQ")]
    [DisplayName("Charges Rate")]
    [IsoXmlTag("ChrgsRate")]
    public Rate2? ChargesRate { get; init; } 
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_hEscd7PvEeelzbgsFa3sqQ")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; } 
    
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_hEscf7PvEeelzbgsFa3sqQ")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; } 
    
    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_hEsch7PvEeelzbgsFa3sqQ")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    
    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_hEscj7PvEeelzbgsFa3sqQ")]
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    
    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_hEscl7PvEeelzbgsFa3sqQ")]
    [DisplayName("Deal Amount")]
    [IsoXmlTag("DealAmt")]
    public AmountAndDirection21? DealAmount { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_hEscn7PvEeelzbgsFa3sqQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_hEscp7PvEeelzbgsFa3sqQ")]
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection21? ForfeitAmount { get; init; } 
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_hEscr7PvEeelzbgsFa3sqQ")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection21? PremiumAmount { get; init; } 
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_hEsct7PvEeelzbgsFa3sqQ")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    public AmountAndDirection21? TerminationAmountPerPieceOfCollateral { get; init; } 
    
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_hEscv7PvEeelzbgsFa3sqQ")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection21? TerminationTransactionAmount { get; init; } 
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_hEscx7PvEeelzbgsFa3sqQ")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? SecondLegNarrative { get; init; } 
    
    
    #nullable disable
    
}
