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
[IsoId("_5Tn2yc3yEee5nJBZsW8MFQ")]
[DisplayName("Securities Financing Transaction Details")]
public record SecuritiesFinancingTransactionDetails39
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_5Tn2y83yEee5nJBZsW8MFQ")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? SecuritiesFinancingTradeIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_5Tn2083yEee5nJBZsW8MFQ")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_5Tn2283yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate7Choice_? TerminationDate { get; init; }

    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_5Tn2483yEee5nJBZsW8MFQ")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTime2Choice_? RateChangeDate { get; init; }

    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_5Tn2683yEee5nJBZsW8MFQ")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; }

    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_5Tn27c3yEee5nJBZsW8MFQ")]
    [DisplayName("Commission Calculation Date")]
    [IsoXmlTag("ComssnClctnDt")]
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_5Tn2783yEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType67Choice_? RateType { get; init; }

    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_5Tn2983yEee5nJBZsW8MFQ")]
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public RevaluationIndicator4Choice_? Revaluation { get; init; }

    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_5Tn2_83yEee5nJBZsW8MFQ")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework4Choice_? LegalFramework { get; init; }

    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_5Tn3B83yEee5nJBZsW8MFQ")]
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; init; }

    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_5Tn3D83yEee5nJBZsW8MFQ")]
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MaturityDateModification { get; init; }

    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_5Tn3F83yEee5nJBZsW8MFQ")]
    [DisplayName("Interest Payment")]
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InterestPayment { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_5Tn3H83yEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName2? VariableRateSupport { get; init; }

    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_5Tn3J83yEee5nJBZsW8MFQ")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_5Tn3L83yEee5nJBZsW8MFQ")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_5Tn3N83yEee5nJBZsW8MFQ")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    [IsoId("_5Tn3P83yEee5nJBZsW8MFQ")]
    [DisplayName("Charges Rate")]
    [IsoXmlTag("ChrgsRate")]
    public Rate2? ChargesRate { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_5Tn3Qc3yEee5nJBZsW8MFQ")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName2Choice_? PricingRate { get; init; }

    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_5Tn3Sc3yEee5nJBZsW8MFQ")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; }

    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_5Tn3Uc3yEee5nJBZsW8MFQ")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TransactionCallDelay { get; init; }

    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_5Tn3Wc3yEee5nJBZsW8MFQ")]
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; }

    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_5Tn3Yc3yEee5nJBZsW8MFQ")]
    [DisplayName("Deal Amount")]
    [IsoXmlTag("DealAmt")]
    public AmountAndDirection59? DealAmount { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_5Tn3ac3yEee5nJBZsW8MFQ")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection59? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_5Tn3cc3yEee5nJBZsW8MFQ")]
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection59? ForfeitAmount { get; init; }

    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_5Tn3ec3yEee5nJBZsW8MFQ")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection59? PremiumAmount { get; init; }

    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_5Tn3gc3yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; }

    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_5Tn3ic3yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection59? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_5Tn3kc3yEee5nJBZsW8MFQ")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; }
}
