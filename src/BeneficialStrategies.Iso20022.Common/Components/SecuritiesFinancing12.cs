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
[IsoId("_1ZROkY-eEeaEa8S_GI1QNA")]
[DisplayName("Securities Financing")]
public record SecuritiesFinancing12
{
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_1oSiB4-eEeaEa8S_GI1QNA")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RateChangeDate { get; init; }

    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_1oSiCY-eEeaEa8S_GI1QNA")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType35Choice_? RateType { get; init; }

    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_1oSiC4-eEeaEa8S_GI1QNA")]
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public Revaluation3Choice_? Revaluation { get; init; }

    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_1oSiDY-eEeaEa8S_GI1QNA")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework1Code? LegalFramework { get; init; }

    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_1oSiD4-eEeaEa8S_GI1QNA")]
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethod3Choice_? InterestComputationMethod { get; init; }

    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_1oSiEY-eEeaEa8S_GI1QNA")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; }

    /// <summary>
    /// Repurchase rate used to calculate the repurchase amount.
    /// </summary>
    [IsoId("_1oSiE4-eEeaEa8S_GI1QNA")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; }

    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_1oSiFY-eEeaEa8S_GI1QNA")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; }

    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_1oSiF4-eEeaEa8S_GI1QNA")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; }

    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_1oSiGY-eEeaEa8S_GI1QNA")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; }

    /// <summary>
    /// Margin over or under an index that determines the repurchase rate, expressed as a rate or an amount.
    /// </summary>
    [IsoId("_1oSiG4-eEeaEa8S_GI1QNA")]
    [DisplayName("Spread Rate")]
    [IsoXmlTag("SprdRate")]
    public SpreadRate1? SpreadRate { get; init; }

    /// <summary>
    /// Indicates whether or not the trade is callable.
    /// </summary>
    [IsoId("_1oSiHY-eEeaEa8S_GI1QNA")]
    [DisplayName("Callable Trade Indicator")]
    [IsoXmlTag("CllblTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableTradeIndicator { get; init; }

    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_1oSiH4-eEeaEa8S_GI1QNA")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionCallDelay { get; init; }

    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    [IsoId("_1oSiIY-eEeaEa8S_GI1QNA")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection5? AccruedInterestAmount { get; init; }

    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_1oSiI4-eEeaEa8S_GI1QNA")]
    [DisplayName("Accrued Interest Percentage")]
    [IsoXmlTag("AcrdIntrstPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AccruedInterestPercentage { get; init; }

    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_1oSiJY-eEeaEa8S_GI1QNA")]
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection5? ForfeitAmount { get; init; }

    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_1oSiJ4-eEeaEa8S_GI1QNA")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection5? PremiumAmount { get; init; }

    /// <summary>
    /// Amount of money to be settled per piece of collateral to close the transaction.
    /// </summary>
    [IsoId("_1oSiKY-eEeaEa8S_GI1QNA")]
    [DisplayName("Closing Amount Per Pieces Of Collateral")]
    [IsoXmlTag("ClsgAmtPerPcsOfColl")]
    public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; init; }

    /// <summary>
    /// Indicates the total Number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_1oSiK4-eEeaEa8S_GI1QNA")]
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TotalNumberOfCollateralInstructions { get; init; }

    /// <summary>
    /// Provides details for the securities financing transaction.
    /// </summary>
    [IsoId("_1oSiLY-eEeaEa8S_GI1QNA")]
    [DisplayName("Financing Agreement")]
    [IsoXmlTag("FincgAgrmt")]
    public Agreement5? FinancingAgreement { get; init; }

    /// <summary>
    /// Method applied to a lending transaction.
    /// </summary>
    [IsoId("_1oSiL4-eEeaEa8S_GI1QNA")]
    [DisplayName("Lending Transaction Method")]
    [IsoXmlTag("LndgTxMtd")]
    public LendingTransactionMethod2Choice_? LendingTransactionMethod { get; init; }

    /// <summary>
    /// Indicates if the contract is with or without an exchange of collateral.
    /// </summary>
    [IsoId("_1oSiMY-eEeaEa8S_GI1QNA")]
    [DisplayName("Lending With Collateral")]
    [IsoXmlTag("LndgWthColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LendingWithCollateral { get; init; }

    /// <summary>
    /// Identifies the underlying reason for the borrowing, for instance, sale on my behalf or on behalf of a third party.
    /// </summary>
    [IsoId("_1oSiM4-eEeaEa8S_GI1QNA")]
    [DisplayName("Borrowing Reason")]
    [IsoXmlTag("BrrwgRsn")]
    public BorrowingReason2Choice_? BorrowingReason { get; init; }

    /// <summary>
    /// Indicates the type of collateral, for insatnce, security, bond, etc.
    /// </summary>
    [IsoId("_1oSiNY-eEeaEa8S_GI1QNA")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public CollateralType4Choice_? CollateralType { get; init; }

    /// <summary>
    /// Indicates whether or not the contract terms changed.
    /// </summary>
    [IsoId("_1oSiN4-eEeaEa8S_GI1QNA")]
    [DisplayName("Contract Terms Modification Changed")]
    [IsoXmlTag("CtrctTermsModChngd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ContractTermsModificationChanged { get; init; }

    /// <summary>
    /// Interest rate to be paid as agreed between the counterparties.
    /// </summary>
    [IsoId("_1oSiOY-eEeaEa8S_GI1QNA")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public Rate2? InterestRate { get; init; }

    /// <summary>
    /// Rate to be paid by the Borrower to the Lender for the securities borrowed.
    /// </summary>
    [IsoId("_1oSiO4-eEeaEa8S_GI1QNA")]
    [DisplayName("Borrowing Rate")]
    [IsoXmlTag("BrrwgRate")]
    public Rate2? BorrowingRate { get; init; }

    /// <summary>
    /// Method used to calculate the standard collateral amount.
    /// </summary>
    [IsoId("_1oSiPY-eEeaEa8S_GI1QNA")]
    [DisplayName("Standard Collateral Ratio")]
    [IsoXmlTag("StdCollRatio")]
    public Rate2? StandardCollateralRatio { get; init; }

    /// <summary>
    /// Percentage of earnings paid to shareholders in dividends.
    /// </summary>
    [IsoId("_1oSiP4-eEeaEa8S_GI1QNA")]
    [DisplayName("Dividend Ratio")]
    [IsoXmlTag("DvddRatio")]
    public Rate2? DividendRatio { get; init; }

    /// <summary>
    /// Number of days the securities are lent or borrowed where the contract has an agreed closing date.
    /// </summary>
    [IsoId("_1oSiQY-eEeaEa8S_GI1QNA")]
    [DisplayName("Number Of Days Lending Borrowing")]
    [IsoXmlTag("NbOfDaysLndgBrrwg")]
    public Number24Choice_? NumberOfDaysLendingBorrowing { get; init; }

    /// <summary>
    /// Specifies the standard collateral amount.
    /// </summary>
    [IsoId("_1oSiQ4-eEeaEa8S_GI1QNA")]
    [DisplayName("Standard Collateral Amount")]
    [IsoXmlTag("StdCollAmt")]
    public AmountAndDirection5? StandardCollateralAmount { get; init; }

    /// <summary>
    /// Interest rate tax that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_1oSiRY-eEeaEa8S_GI1QNA")]
    [DisplayName("Accrued Interest Tax")]
    [IsoXmlTag("AcrdIntrstTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestTax { get; init; }

    /// <summary>
    /// Number of days accrued at the instant of closing trade.
    /// </summary>
    [IsoId("_1oSiR4-eEeaEa8S_GI1QNA")]
    [DisplayName("End Number Of Days Accrued")]
    [IsoXmlTag("EndNbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? EndNumberOfDaysAccrued { get; init; }

    /// <summary>
    /// End ratio of principal outstanding to the original balance.
    /// </summary>
    [IsoId("_1oSiSY-eEeaEa8S_GI1QNA")]
    [DisplayName("End Factor")]
    [IsoXmlTag("EndFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? EndFactor { get; init; }

    /// <summary>
    /// Type of securities lending.
    /// </summary>
    [IsoId("_1oSiS4-eEeaEa8S_GI1QNA")]
    [DisplayName("Securities Lending Type")]
    [IsoXmlTag("SctiesLndgTp")]
    public SecuritiesLendingType2Choice_? SecuritiesLendingType { get; init; }

    /// <summary>
    /// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
    /// </summary>
    [IsoId("_1oSiTY-eEeaEa8S_GI1QNA")]
    [DisplayName("Reversible")]
    [IsoXmlTag("Rvsbl")]
    public Reversible2Choice_? Reversible { get; init; }

    /// <summary>
    /// This is the minimum date at which the Borrower is allowed to give back the securities.
    /// </summary>
    [IsoId("_1oSiT4-eEeaEa8S_GI1QNA")]
    [DisplayName("Minimum Date For Call Back")]
    [IsoXmlTag("MinDtForCallBck")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MinimumDateForCallBack { get; init; }

    /// <summary>
    /// Indicates that the contract can be rolled over.
    /// </summary>
    [IsoId("_1oSiUY-eEeaEa8S_GI1QNA")]
    [DisplayName("Roll Over")]
    [IsoXmlTag("RollOver")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RollOver { get; init; }

    /// <summary>
    /// Indicates whether the securities lending fees can be paid periodically or at the end of the contract.
    /// </summary>
    [IsoId("_1oSiU4-eEeaEa8S_GI1QNA")]
    [DisplayName("Periodic Payment")]
    [IsoXmlTag("PrdcPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PeriodicPayment { get; init; }

    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// </summary>
    [IsoId("_1oSiVY-eEeaEa8S_GI1QNA")]
    [DisplayName("Ex Coupon")]
    [IsoXmlTag("ExCpn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExCoupon { get; init; }
}
