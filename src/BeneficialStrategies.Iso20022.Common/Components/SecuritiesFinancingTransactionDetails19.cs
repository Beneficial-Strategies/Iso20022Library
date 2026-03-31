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
[IsoId("_SnggcFL0EeG2M5YWM-8eJg_-1806973104")]
[DisplayName("Securities Financing Transaction Details")]
public record SecuritiesFinancingTransactionDetails19
{
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_SnggcVL0EeG2M5YWM-8eJg_-1920812170")]
    [DisplayName("Securities Financing Trade Identification")]
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_SnggclL0EeG2M5YWM-8eJg_1669040511")]
    [DisplayName("Closing Leg Identification")]
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClosingLegIdentification { get; init; }

    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_SnpqYFL0EeG2M5YWM-8eJg_493849486")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public TerminationDate2Choice_? TerminationDate { get; init; }

    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_SnpqYVL0EeG2M5YWM-8eJg_-503222867")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    public DateAndDateTimeChoice_? RateChangeDate { get; init; }

    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_SnzbYFL0EeG2M5YWM-8eJg_1142044568")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public DateAndDateTimeChoice_? EarliestCallBackDate { get; init; }

    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_SnzbYVL0EeG2M5YWM-8eJg_-1614134286")]
    [DisplayName("Commission Calculation Date")]
    [IsoXmlTag("ComssnClctnDt")]
    public DateAndDateTimeChoice_? CommissionCalculationDate { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_Sn9MYFL0EeG2M5YWM-8eJg_1975718395")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType5Choice_? RateType { get; init; }

    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_Sn9MYVL0EeG2M5YWM-8eJg_800527370")]
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public RevaluationIndicator1Choice_? Revaluation { get; init; }

    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_Sn9MYlL0EeG2M5YWM-8eJg_-1849172491")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework1Choice_? LegalFramework { get; init; }

    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_SoGWUFL0EeG2M5YWM-8eJg_-310384049")]
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethodFormat1Choice_? InterestComputationMethod { get; init; }

    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_SoGWUVL0EeG2M5YWM-8eJg_-1015498664")]
    [DisplayName("Maturity Date Modification")]
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MaturityDateModification { get; init; }

    /// <summary>
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_SoQHUFL0EeG2M5YWM-8eJg_2104277607")]
    [DisplayName("Interest Payment")]
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? InterestPayment { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_SoQHUVL0EeG2M5YWM-8eJg_-545422254")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; }

    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_SoQHUlL0EeG2M5YWM-8eJg_993366188")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_SoZRQFL0EeG2M5YWM-8eJg_288251573")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_SoZRQVL0EeG2M5YWM-8eJg_-886939452")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    /// <summary>
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    [IsoId("_SojCQFL0EeG2M5YWM-8eJg_758327983")]
    [DisplayName("Charges Rate")]
    [IsoXmlTag("ChrgsRate")]
    public Rate2? ChargesRate { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_SojCQVL0EeG2M5YWM-8eJg_-1997850871")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; }

    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_SoszQFL0EeG2M5YWM-8eJg_1592001810")]
    [DisplayName("Spread")]
    [IsoXmlTag("Sprd")]
    public Rate2? Spread { get; init; }

    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_SoszQVL0EeG2M5YWM-8eJg_416810785")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TransactionCallDelay { get; init; }

    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_SoszQlL0EeG2M5YWM-8eJg_2062078220")]
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; }

    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_So19MFL0EeG2M5YWM-8eJg_-1408540033")]
    [DisplayName("Local Broker Commission")]
    [IsoXmlTag("LclBrkrComssn")]
    public AmountAndDirection4? LocalBrokerCommission { get; init; }

    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_So19MVL0EeG2M5YWM-8eJg_-694100634")]
    [DisplayName("Deal Amount")]
    [IsoXmlTag("DealAmt")]
    public AmountAndDirection4? DealAmount { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_So_uMFL0EeG2M5YWM-8eJg_-1399215249")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection4? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_So_uMVL0EeG2M5YWM-8eJg_1720561022")]
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection4? ForfeitAmount { get; init; }

    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_SpJfMFL0EeG2M5YWM-8eJg_-929138839")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection4? PremiumAmount { get; init; }

    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_SpJfMVL0EeG2M5YWM-8eJg_609649603")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    public AmountAndDirection4? TerminationAmountPerPieceOfCollateral { get; init; }

    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_SpJfMlL0EeG2M5YWM-8eJg_-95465012")]
    [DisplayName("Termination Transaction Amount")]
    [IsoXmlTag("TermntnTxAmt")]
    public AmountAndDirection4? TerminationTransactionAmount { get; init; }

    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_SpSpIFL0EeG2M5YWM-8eJg_-1270656037")]
    [DisplayName("Second Leg Narrative")]
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SecondLegNarrative { get; init; }
}
