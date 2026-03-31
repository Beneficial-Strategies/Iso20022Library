// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_cI8Gyzm6EeWV5sr121Fc8A")]
[DisplayName("Securities Financing Transaction Details")]
public record SecuritiesFinancingTransactionDetails27
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_cm_UpTm6EeWV5sr121Fc8A")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_cm_UrTm6EeWV5sr121Fc8A")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_cm_UtTm6EeWV5sr121Fc8A")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate4Choice_? TerminationDate { get; init; }

    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_cm_UvTm6EeWV5sr121Fc8A")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTimeChoice_? RateChangeDate { get; init; }

    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_cm_UxTm6EeWV5sr121Fc8A")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public DateAndDateTimeChoice_? EarliestCallBackDate { get; init; }

    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_cm_Uxzm6EeWV5sr121Fc8A")]
    [DisplayName("Commission Calculation Date")]
    [IsoXmlTag("ComssnClctnDt")]
    public DateAndDateTimeChoice_? CommissionCalculationDate { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_cm_UyTm6EeWV5sr121Fc8A")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice_? RateType { get; init; }

    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_cm_U0Tm6EeWV5sr121Fc8A")]
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public RevaluationIndicator3Choice_? Revaluation { get; init; }

    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_cm_U2Tm6EeWV5sr121Fc8A")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework3Choice_? LegalFramework { get; init; }

    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_cm_U4Tm6EeWV5sr121Fc8A")]
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethodFormat4Choice_? InterestComputationMethod { get; init; }

    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_cm_U6Tm6EeWV5sr121Fc8A")]
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MaturityDateModification { get; init; }

    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_cm_U8Tm6EeWV5sr121Fc8A")]
    [DisplayName("Interest Payment")]
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InterestPayment { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_cm_U-Tm6EeWV5sr121Fc8A")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; }

    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_cm_VATm6EeWV5sr121Fc8A")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_cm_VCTm6EeWV5sr121Fc8A")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_cm_VETm6EeWV5sr121Fc8A")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    [IsoId("_cm_VGTm6EeWV5sr121Fc8A")]
    [DisplayName("Charges Rate")]
    [IsoXmlTag("ChrgsRate")]
    public Rate2? ChargesRate { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_cm_VGzm6EeWV5sr121Fc8A")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; }

    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_cm_VIzm6EeWV5sr121Fc8A")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; }

    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_cm_VKzm6EeWV5sr121Fc8A")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TransactionCallDelay { get; init; }

    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_cm_VMzm6EeWV5sr121Fc8A")]
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; }

    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_cm_VOzm6EeWV5sr121Fc8A")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection21? LocalBrokerCommission { get; init; }

    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_cm_VPTm6EeWV5sr121Fc8A")]
    [DisplayName("Deal Amount")]
    [IsoXmlTag("DealAmt")]
    public AmountAndDirection21? DealAmount { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_cm_VRTm6EeWV5sr121Fc8A")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection21? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_cm_VTTm6EeWV5sr121Fc8A")]
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection21? ForfeitAmount { get; init; }

    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_cm_VVTm6EeWV5sr121Fc8A")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection21? PremiumAmount { get; init; }

    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_cm_VXTm6EeWV5sr121Fc8A")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    public AmountAndDirection21? TerminationAmountPerPieceOfCollateral { get; init; }

    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_cm_VZTm6EeWV5sr121Fc8A")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection21? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_cm_VbTm6EeWV5sr121Fc8A")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SecondLegNarrative { get; init; }
}
