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
[IsoId("_At1L1NokEeC60axPepSq7g_-198376474")]
[DisplayName("Securities Financing")]
public partial record SecuritiesFinancing10
{
    #nullable enable
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_At1L1dokEeC60axPepSq7g_-695932125")]
    [DisplayName("Rate Change Date")]
    [IsoXmlTag("RateChngDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? RateChangeDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_At-VwNokEeC60axPepSq7g_-312215540")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public RateType19Choice_? RateType { get; init; } 
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_At-VwdokEeC60axPepSq7g_1988607050")]
    [DisplayName("Revaluation")]
    [IsoXmlTag("Rvaltn")]
    public Revaluation2Choice_? Revaluation { get; init; } 
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_At-VwtokEeC60axPepSq7g_1106850683")]
    [DisplayName("Legal Framework")]
    [IsoXmlTag("LglFrmwk")]
    public LegalFramework1Code? LegalFramework { get; init; } 
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_At-Vw9okEeC60axPepSq7g_-1309287893")]
    [DisplayName("Interest Computation Method")]
    [IsoXmlTag("IntrstCmptnMtd")]
    public InterestComputationMethod2Choice_? InterestComputationMethod { get; init; } 
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_At-VxNokEeC60axPepSq7g_-1002610009")]
    [DisplayName("Variable Rate Support")]
    [IsoXmlTag("VarblRateSpprt")]
    public RateName1? VariableRateSupport { get; init; } 
    
    /// <summary>
    /// Repurchase rate used to calculate the repurchase amount.
    /// </summary>
    [IsoId("_At-VxdokEeC60axPepSq7g_-275415175")]
    [DisplayName("Repurchase Rate")]
    [IsoXmlTag("RpRate")]
    public Rate2? RepurchaseRate { get; init; } 
    
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_At-VxtokEeC60axPepSq7g_721657178")]
    [DisplayName("Stock Loan Margin")]
    [IsoXmlTag("StockLnMrgn")]
    public Rate2? StockLoanMargin { get; init; } 
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_AuIGwNokEeC60axPepSq7g_1718729531")]
    [DisplayName("Securities Haircut")]
    [IsoXmlTag("SctiesHrcut")]
    public Rate2? SecuritiesHaircut { get; init; } 
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_AuIGwdokEeC60axPepSq7g_-1272487528")]
    [DisplayName("Pricing Rate")]
    [IsoXmlTag("PricgRate")]
    public RateOrName1Choice_? PricingRate { get; init; } 
    
    /// <summary>
    /// Margin over or under an index that determines the repurchase rate, expressed as a rate or an amount.
    /// </summary>
    [IsoId("_AuIGwtokEeC60axPepSq7g_2025407415")]
    [DisplayName("Spread Rate")]
    [IsoXmlTag("SprdRate")]
    public SpreadRate1? SpreadRate { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the trade is callable.
    /// </summary>
    [IsoId("_AuIGw9okEeC60axPepSq7g_-1267193902")]
    [DisplayName("Callable Trade Indicator")]
    [IsoXmlTag("CllblTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CallableTradeIndicator { get; init; } 
    
    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_AuIGxNokEeC60axPepSq7g_-1999682362")]
    [DisplayName("Transaction Call Delay")]
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionCallDelay { get; init; } 
    
    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    [IsoId("_AuIGxdokEeC60axPepSq7g_-965809644")]
    [DisplayName("Accrued Interest Amount")]
    [IsoXmlTag("AcrdIntrstAmt")]
    public AmountAndDirection5? AccruedInterestAmount { get; init; } 
    
    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_AuIGxtokEeC60axPepSq7g_-933857720")]
    [DisplayName("Accrued Interest Percentage")]
    [IsoXmlTag("AcrdIntrstPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? AccruedInterestPercentage { get; init; } 
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_AuRQsNokEeC60axPepSq7g_1028335062")]
    [DisplayName("Forfeit Amount")]
    [IsoXmlTag("FrftAmt")]
    public AmountAndDirection5? ForfeitAmount { get; init; } 
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_AuRQsdokEeC60axPepSq7g_-1193971907")]
    [DisplayName("Premium Amount")]
    [IsoXmlTag("PrmAmt")]
    public AmountAndDirection5? PremiumAmount { get; init; } 
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to close the transaction.
    /// </summary>
    [IsoId("_AuRQstokEeC60axPepSq7g_-1962881997")]
    [DisplayName("Closing Amount Per Pieces Of Collateral")]
    [IsoXmlTag("ClsgAmtPerPcsOfColl")]
    public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; init; } 
    
    /// <summary>
    /// Indicates the total Number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_AuRQs9okEeC60axPepSq7g_1298212581")]
    [DisplayName("Total Number Of Collateral Instructions")]
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    
    /// <summary>
    /// Provides details for the securities financing transaction.
    /// </summary>
    [IsoId("_AuRQtNokEeC60axPepSq7g_2103923036")]
    [DisplayName("Financing Agreement")]
    [IsoXmlTag("FincgAgrmt")]
    public Agreement3? FinancingAgreement { get; init; } 
    
    /// <summary>
    /// Method applied to a lending transaction.
    /// </summary>
    [IsoId("_AuRQtdokEeC60axPepSq7g_414120520")]
    [DisplayName("Lending Transaction Method")]
    [IsoXmlTag("LndgTxMtd")]
    public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; init; } 
    
    /// <summary>
    /// Indicates if the contract is with or without an exchange of collateral.
    /// </summary>
    [IsoId("_AuRQttokEeC60axPepSq7g_-232941151")]
    [DisplayName("Lending With Collateral")]
    [IsoXmlTag("LndgWthColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LendingWithCollateral { get; init; } 
    
    /// <summary>
    /// Identifies the underlying reason for the borrowing, for instance, sale on my behalf or on behalf of a third party.
    /// </summary>
    [IsoId("_AubBsNokEeC60axPepSq7g_-1443291770")]
    [DisplayName("Borrowing Reason")]
    [IsoXmlTag("BrrwgRsn")]
    public BorrowingReason1Choice_? BorrowingReason { get; init; } 
    
    /// <summary>
    /// Indicates the type of collateral, for insatnce, security, bond, etc.
    /// </summary>
    [IsoId("_AubBsdokEeC60axPepSq7g_-412210548")]
    [DisplayName("Collateral Type")]
    [IsoXmlTag("CollTp")]
    public CollateralType1Choice_? CollateralType { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the contract terms changed.
    /// </summary>
    [IsoId("_AubBstokEeC60axPepSq7g_-1017643701")]
    [DisplayName("Contract Terms Modification Changed")]
    [IsoXmlTag("CtrctTermsModChngd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ContractTermsModificationChanged { get; init; } 
    
    /// <summary>
    /// Interest rate to be paid as agreed between the counterparties.
    /// </summary>
    [IsoId("_AubBs9okEeC60axPepSq7g_1287973967")]
    [DisplayName("Interest Rate")]
    [IsoXmlTag("IntrstRate")]
    public Rate2? InterestRate { get; init; } 
    
    /// <summary>
    /// Rate to be paid by the Borrower to the Lender for the securities borrowed.
    /// </summary>
    [IsoId("_AubBtNokEeC60axPepSq7g_-228030791")]
    [DisplayName("Borrowing Rate")]
    [IsoXmlTag("BrrwgRate")]
    public Rate2? BorrowingRate { get; init; } 
    
    /// <summary>
    /// Method used to calculate the standard collateral amount.
    /// </summary>
    [IsoId("_AubBtdokEeC60axPepSq7g_367898826")]
    [DisplayName("Standard Collateral Ratio")]
    [IsoXmlTag("StdCollRatio")]
    public Rate2? StandardCollateralRatio { get; init; } 
    
    /// <summary>
    /// Percentage of earnings paid to shareholders in dividends.
    /// </summary>
    [IsoId("_AukysNokEeC60axPepSq7g_641828188")]
    [DisplayName("Dividend Ratio")]
    [IsoXmlTag("DvddRatio")]
    public Rate2? DividendRatio { get; init; } 
    
    /// <summary>
    /// Number of days the securities are lent or borrowed where the contract has an agreed closing date.
    /// </summary>
    [IsoId("_AukysdokEeC60axPepSq7g_-1206770256")]
    [DisplayName("Number Of Days Lending Borrowing")]
    [IsoXmlTag("NbOfDaysLndgBrrwg")]
    public Number21Choice_? NumberOfDaysLendingBorrowing { get; init; } 
    
    /// <summary>
    /// Specifies the standard collateral amount.
    /// </summary>
    [IsoId("_AukystokEeC60axPepSq7g_1937742031")]
    [DisplayName("Standard Collateral Amount")]
    [IsoXmlTag("StdCollAmt")]
    public AmountAndDirection5? StandardCollateralAmount { get; init; } 
    
    /// <summary>
    /// Interest rate tax that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_Aukys9okEeC60axPepSq7g_-1335503795")]
    [DisplayName("Accrued Interest Tax")]
    [IsoXmlTag("AcrdIntrstTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestTax { get; init; } 
    
    /// <summary>
    /// Number of days accrued at the instant of closing trade.
    /// </summary>
    [IsoId("_AukytNokEeC60axPepSq7g_460885409")]
    [DisplayName("End Number Of Days Accrued")]
    [IsoXmlTag("EndNbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? EndNumberOfDaysAccrued { get; init; } 
    
    /// <summary>
    /// End ratio of principal outstanding to the original balance.
    /// </summary>
    [IsoId("_AukytdokEeC60axPepSq7g_1286453782")]
    [DisplayName("End Factor")]
    [IsoXmlTag("EndFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    public IsoBaseOneRate? EndFactor { get; init; } 
    
    /// <summary>
    /// Type of securities lending.
    /// </summary>
    [IsoId("_AukyttokEeC60axPepSq7g_702451242")]
    [DisplayName("Securities Lending Type")]
    [IsoXmlTag("SctiesLndgTp")]
    public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; init; } 
    
    /// <summary>
    /// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
    /// </summary>
    [IsoId("_Aut8oNokEeC60axPepSq7g_-1062983843")]
    [DisplayName("Reversible")]
    [IsoXmlTag("Rvsbl")]
    public Reversible1Choice_? Reversible { get; init; } 
    
    /// <summary>
    /// This is the minimum date at which the Borrower is allowed to give back the securities.
    /// </summary>
    [IsoId("_Aut8odokEeC60axPepSq7g_1976821560")]
    [DisplayName("Minimum Date For Call Back")]
    [IsoXmlTag("MinDtForCallBck")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MinimumDateForCallBack { get; init; } 
    
    /// <summary>
    /// Indicates that the contract can be rolled over.
    /// </summary>
    [IsoId("_Aut8otokEeC60axPepSq7g_446006542")]
    [DisplayName("Roll Over")]
    [IsoXmlTag("RollOver")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RollOver { get; init; } 
    
    /// <summary>
    /// Indicates whether the securities lending fees can be paid periodically or at the end of the contract.
    /// </summary>
    [IsoId("_Aut8o9okEeC60axPepSq7g_788130492")]
    [DisplayName("Periodic Payment")]
    [IsoXmlTag("PrdcPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PeriodicPayment { get; init; } 
    
    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// </summary>
    [IsoId("_Aut8pNokEeC60axPepSq7g_1099234723")]
    [DisplayName("Ex Coupon")]
    [IsoXmlTag("ExCpn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExCoupon { get; init; } 
    
    
    #nullable disable
    
}
