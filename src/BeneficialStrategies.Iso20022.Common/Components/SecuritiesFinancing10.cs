// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the closing of the securities financing transaction.
/// </summary>
[IsoId("_At1L1NokEeC60axPepSq7g_-198376474")]
[DisplayName("Securities Financing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancing10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_At1L1dokEeC60axPepSq7g_-695932125")]
    [DisplayName("Rate Change Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateChngDt")]
    #endif
    [IsoXmlTag("RateChngDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RateChangeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RateChangeDate { get; init; } 
    #else
    public System.DateTime? RateChangeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_At-VwNokEeC60axPepSq7g_-312215540")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateType19Choice_? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType19Choice_? RateType { get; init; } 
    #else
    public RateType19Choice_? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_At-VwdokEeC60axPepSq7g_1988607050")]
    [DisplayName("Revaluation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvaltn")]
    #endif
    [IsoXmlTag("Rvaltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Revaluation2Choice_? Revaluation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Revaluation2Choice_? Revaluation { get; init; } 
    #else
    public Revaluation2Choice_? Revaluation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_At-VwtokEeC60axPepSq7g_1106850683")]
    [DisplayName("Legal Framework")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglFrmwk")]
    #endif
    [IsoXmlTag("LglFrmwk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalFramework1Code? LegalFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalFramework1Code? LegalFramework { get; init; } 
    #else
    public LegalFramework1Code? LegalFramework { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_At-Vw9okEeC60axPepSq7g_-1309287893")]
    [DisplayName("Interest Computation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstCmptnMtd")]
    #endif
    [IsoXmlTag("IntrstCmptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethod2Choice_? InterestComputationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod2Choice_? InterestComputationMethod { get; init; } 
    #else
    public InterestComputationMethod2Choice_? InterestComputationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_At-VxNokEeC60axPepSq7g_-1002610009")]
    [DisplayName("Variable Rate Support")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateSpprt")]
    #endif
    [IsoXmlTag("VarblRateSpprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateName1? VariableRateSupport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateName1? VariableRateSupport { get; init; } 
    #else
    public RateName1? VariableRateSupport { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase rate used to calculate the repurchase amount.
    /// </summary>
    [IsoId("_At-VxdokEeC60axPepSq7g_-275415175")]
    [DisplayName("Repurchase Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RpRate")]
    #endif
    [IsoXmlTag("RpRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? RepurchaseRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? RepurchaseRate { get; init; } 
    #else
    public Rate2? RepurchaseRate { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage mark-up on a loan consideration used to reflect the lender&apos;s risk.
    /// </summary>
    [IsoId("_At-VxtokEeC60axPepSq7g_721657178")]
    [DisplayName("Stock Loan Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StockLnMrgn")]
    #endif
    [IsoXmlTag("StockLnMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? StockLoanMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? StockLoanMargin { get; init; } 
    #else
    public Rate2? StockLoanMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Haircut or valuation factor on the security expressed as a percentage.
    /// </summary>
    [IsoId("_AuIGwNokEeC60axPepSq7g_1718729531")]
    [DisplayName("Securities Haircut")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesHrcut")]
    #endif
    [IsoXmlTag("SctiesHrcut")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? SecuritiesHaircut { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? SecuritiesHaircut { get; init; } 
    #else
    public Rate2? SecuritiesHaircut { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_AuIGwdokEeC60axPepSq7g_-1272487528")]
    [DisplayName("Pricing Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgRate")]
    #endif
    [IsoXmlTag("PricgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateOrName1Choice_? PricingRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrName1Choice_? PricingRate { get; init; } 
    #else
    public RateOrName1Choice_? PricingRate { get; set; } 
    #endif
    
    /// <summary>
    /// Margin over or under an index that determines the repurchase rate, expressed as a rate or an amount.
    /// </summary>
    [IsoId("_AuIGwtokEeC60axPepSq7g_2025407415")]
    [DisplayName("Spread Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SprdRate")]
    #endif
    [IsoXmlTag("SprdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpreadRate1? SpreadRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpreadRate1? SpreadRate { get; init; } 
    #else
    public SpreadRate1? SpreadRate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the trade is callable.
    /// </summary>
    [IsoId("_AuIGw9okEeC60axPepSq7g_-1267193902")]
    [DisplayName("Callable Trade Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CllblTradInd")]
    #endif
    [IsoXmlTag("CllblTradInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CallableTradeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CallableTradeIndicator { get; init; } 
    #else
    public System.String? CallableTradeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_AuIGxNokEeC60axPepSq7g_-1999682362")]
    [DisplayName("Transaction Call Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCallDely")]
    #endif
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? TransactionCallDelay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionCallDelay { get; init; } 
    #else
    public System.String? TransactionCallDelay { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    [IsoId("_AuIGxdokEeC60axPepSq7g_-965809644")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection5? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_AuIGxtokEeC60axPepSq7g_-933857720")]
    [DisplayName("Accrued Interest Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstPctg")]
    #endif
    [IsoXmlTag("AcrdIntrstPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AccruedInterestPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AccruedInterestPercentage { get; init; } 
    #else
    public System.Decimal? AccruedInterestPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_AuRQsNokEeC60axPepSq7g_1028335062")]
    [DisplayName("Forfeit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrftAmt")]
    #endif
    [IsoXmlTag("FrftAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? ForfeitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? ForfeitAmount { get; init; } 
    #else
    public AmountAndDirection5? ForfeitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_AuRQsdokEeC60axPepSq7g_-1193971907")]
    [DisplayName("Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmAmt")]
    #endif
    [IsoXmlTag("PrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? PremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? PremiumAmount { get; init; } 
    #else
    public AmountAndDirection5? PremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to close the transaction.
    /// </summary>
    [IsoId("_AuRQstokEeC60axPepSq7g_-1962881997")]
    [DisplayName("Closing Amount Per Pieces Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgAmtPerPcsOfColl")]
    #endif
    [IsoXmlTag("ClsgAmtPerPcsOfColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; init; } 
    #else
    public AmountAndDirection5? ClosingAmountPerPiecesOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the total Number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_AuRQs9okEeC60axPepSq7g_1298212581")]
    [DisplayName("Total Number Of Collateral Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfCollInstrs")]
    #endif
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalNumberOfCollateralInstructions { get; init; } 
    #else
    public System.String? TotalNumberOfCollateralInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details for the securities financing transaction.
    /// </summary>
    [IsoId("_AuRQtNokEeC60axPepSq7g_2103923036")]
    [DisplayName("Financing Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgAgrmt")]
    #endif
    [IsoXmlTag("FincgAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement3? FinancingAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement3? FinancingAgreement { get; init; } 
    #else
    public Agreement3? FinancingAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Method applied to a lending transaction.
    /// </summary>
    [IsoId("_AuRQtdokEeC60axPepSq7g_414120520")]
    [DisplayName("Lending Transaction Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgTxMtd")]
    #endif
    [IsoXmlTag("LndgTxMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; init; } 
    #else
    public LendingTransactionMethod1Choice_? LendingTransactionMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the contract is with or without an exchange of collateral.
    /// </summary>
    [IsoId("_AuRQttokEeC60axPepSq7g_-232941151")]
    [DisplayName("Lending With Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgWthColl")]
    #endif
    [IsoXmlTag("LndgWthColl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LendingWithCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LendingWithCollateral { get; init; } 
    #else
    public System.String? LendingWithCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the underlying reason for the borrowing, for instance, sale on my behalf or on behalf of a third party.
    /// </summary>
    [IsoId("_AubBsNokEeC60axPepSq7g_-1443291770")]
    [DisplayName("Borrowing Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwgRsn")]
    #endif
    [IsoXmlTag("BrrwgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BorrowingReason1Choice_? BorrowingReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BorrowingReason1Choice_? BorrowingReason { get; init; } 
    #else
    public BorrowingReason1Choice_? BorrowingReason { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of collateral, for insatnce, security, bond, etc.
    /// </summary>
    [IsoId("_AubBsdokEeC60axPepSq7g_-412210548")]
    [DisplayName("Collateral Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTp")]
    #endif
    [IsoXmlTag("CollTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType1Choice_? CollateralType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType1Choice_? CollateralType { get; init; } 
    #else
    public CollateralType1Choice_? CollateralType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the contract terms changed.
    /// </summary>
    [IsoId("_AubBstokEeC60axPepSq7g_-1017643701")]
    [DisplayName("Contract Terms Modification Changed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTermsModChngd")]
    #endif
    [IsoXmlTag("CtrctTermsModChngd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ContractTermsModificationChanged { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ContractTermsModificationChanged { get; init; } 
    #else
    public System.String? ContractTermsModificationChanged { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate to be paid as agreed between the counterparties.
    /// </summary>
    [IsoId("_AubBs9okEeC60axPepSq7g_1287973967")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? InterestRate { get; init; } 
    #else
    public Rate2? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate to be paid by the Borrower to the Lender for the securities borrowed.
    /// </summary>
    [IsoId("_AubBtNokEeC60axPepSq7g_-228030791")]
    [DisplayName("Borrowing Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwgRate")]
    #endif
    [IsoXmlTag("BrrwgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? BorrowingRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? BorrowingRate { get; init; } 
    #else
    public Rate2? BorrowingRate { get; set; } 
    #endif
    
    /// <summary>
    /// Method used to calculate the standard collateral amount.
    /// </summary>
    [IsoId("_AubBtdokEeC60axPepSq7g_367898826")]
    [DisplayName("Standard Collateral Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdCollRatio")]
    #endif
    [IsoXmlTag("StdCollRatio")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? StandardCollateralRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? StandardCollateralRatio { get; init; } 
    #else
    public Rate2? StandardCollateralRatio { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage of earnings paid to shareholders in dividends.
    /// </summary>
    [IsoId("_AukysNokEeC60axPepSq7g_641828188")]
    [DisplayName("Dividend Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddRatio")]
    #endif
    [IsoXmlTag("DvddRatio")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? DividendRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? DividendRatio { get; init; } 
    #else
    public Rate2? DividendRatio { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days the securities are lent or borrowed where the contract has an agreed closing date.
    /// </summary>
    [IsoId("_AukysdokEeC60axPepSq7g_-1206770256")]
    [DisplayName("Number Of Days Lending Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysLndgBrrwg")]
    #endif
    [IsoXmlTag("NbOfDaysLndgBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number21Choice_? NumberOfDaysLendingBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number21Choice_? NumberOfDaysLendingBorrowing { get; init; } 
    #else
    public Number21Choice_? NumberOfDaysLendingBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the standard collateral amount.
    /// </summary>
    [IsoId("_AukystokEeC60axPepSq7g_1937742031")]
    [DisplayName("Standard Collateral Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StdCollAmt")]
    #endif
    [IsoXmlTag("StdCollAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection5? StandardCollateralAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5? StandardCollateralAmount { get; init; } 
    #else
    public AmountAndDirection5? StandardCollateralAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate tax that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_Aukys9okEeC60axPepSq7g_-1335503795")]
    [DisplayName("Accrued Interest Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstTax")]
    #endif
    [IsoXmlTag("AcrdIntrstTax")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AccruedInterestTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccruedInterestTax { get; init; } 
    #else
    public System.String? AccruedInterestTax { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days accrued at the instant of closing trade.
    /// </summary>
    [IsoId("_AukytNokEeC60axPepSq7g_460885409")]
    [DisplayName("End Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndNbOfDaysAcrd")]
    #endif
    [IsoXmlTag("EndNbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? EndNumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EndNumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? EndNumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// End ratio of principal outstanding to the original balance.
    /// </summary>
    [IsoId("_AukytdokEeC60axPepSq7g_1286453782")]
    [DisplayName("End Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndFctr")]
    #endif
    [IsoXmlTag("EndFctr")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoBaseOneRate? EndFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? EndFactor { get; init; } 
    #else
    public System.Decimal? EndFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Type of securities lending.
    /// </summary>
    [IsoId("_AukyttokEeC60axPepSq7g_702451242")]
    [DisplayName("Securities Lending Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesLndgTp")]
    #endif
    [IsoXmlTag("SctiesLndgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; init; } 
    #else
    public SecuritiesLendingType1Choice_? SecuritiesLendingType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
    /// </summary>
    [IsoId("_Aut8oNokEeC60axPepSq7g_-1062983843")]
    [DisplayName("Reversible")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvsbl")]
    #endif
    [IsoXmlTag("Rvsbl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reversible1Choice_? Reversible { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reversible1Choice_? Reversible { get; init; } 
    #else
    public Reversible1Choice_? Reversible { get; set; } 
    #endif
    
    /// <summary>
    /// This is the minimum date at which the Borrower is allowed to give back the securities.
    /// </summary>
    [IsoId("_Aut8odokEeC60axPepSq7g_1976821560")]
    [DisplayName("Minimum Date For Call Back")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinDtForCallBck")]
    #endif
    [IsoXmlTag("MinDtForCallBck")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MinimumDateForCallBack { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MinimumDateForCallBack { get; init; } 
    #else
    public System.DateOnly? MinimumDateForCallBack { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the contract can be rolled over.
    /// </summary>
    [IsoId("_Aut8otokEeC60axPepSq7g_446006542")]
    [DisplayName("Roll Over")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RollOver")]
    #endif
    [IsoXmlTag("RollOver")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RollOver { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RollOver { get; init; } 
    #else
    public System.String? RollOver { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the securities lending fees can be paid periodically or at the end of the contract.
    /// </summary>
    [IsoId("_Aut8o9okEeC60axPepSq7g_788130492")]
    [DisplayName("Periodic Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdcPmt")]
    #endif
    [IsoXmlTag("PrdcPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PeriodicPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PeriodicPayment { get; init; } 
    #else
    public System.String? PeriodicPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the trade is executed ex coupon.
    /// </summary>
    [IsoId("_Aut8pNokEeC60axPepSq7g_1099234723")]
    [DisplayName("Ex Coupon")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExCpn")]
    #endif
    [IsoXmlTag("ExCpn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ExCoupon { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ExCoupon { get; init; } 
    #else
    public System.String? ExCoupon { get; set; } 
    #endif
    
    
    #nullable disable
    
}
