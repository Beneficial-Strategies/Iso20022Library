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
[IsoId("_1ZROkY-eEeaEa8S_GI1QNA")]
[DisplayName("Securities Financing")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancing12
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
    [IsoId("_1oSiB4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiCY-eEeaEa8S_GI1QNA")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateType35Choice_? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType35Choice_? RateType { get; init; } 
    #else
    public RateType35Choice_? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_1oSiC4-eEeaEa8S_GI1QNA")]
    [DisplayName("Revaluation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvaltn")]
    #endif
    [IsoXmlTag("Rvaltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Revaluation3Choice_? Revaluation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Revaluation3Choice_? Revaluation { get; init; } 
    #else
    public Revaluation3Choice_? Revaluation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_1oSiDY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiD4-eEeaEa8S_GI1QNA")]
    [DisplayName("Interest Computation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstCmptnMtd")]
    #endif
    [IsoXmlTag("IntrstCmptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethod3Choice_? InterestComputationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethod3Choice_? InterestComputationMethod { get; init; } 
    #else
    public InterestComputationMethod3Choice_? InterestComputationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_1oSiEY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiE4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiFY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiF4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiGY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiG4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiHY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiH4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiIY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiI4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiJY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiJ4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiKY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiK4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiLY-eEeaEa8S_GI1QNA")]
    [DisplayName("Financing Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgAgrmt")]
    #endif
    [IsoXmlTag("FincgAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Agreement5? FinancingAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Agreement5? FinancingAgreement { get; init; } 
    #else
    public Agreement5? FinancingAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Method applied to a lending transaction.
    /// </summary>
    [IsoId("_1oSiL4-eEeaEa8S_GI1QNA")]
    [DisplayName("Lending Transaction Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgTxMtd")]
    #endif
    [IsoXmlTag("LndgTxMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LendingTransactionMethod2Choice_? LendingTransactionMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LendingTransactionMethod2Choice_? LendingTransactionMethod { get; init; } 
    #else
    public LendingTransactionMethod2Choice_? LendingTransactionMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the contract is with or without an exchange of collateral.
    /// </summary>
    [IsoId("_1oSiMY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiM4-eEeaEa8S_GI1QNA")]
    [DisplayName("Borrowing Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrrwgRsn")]
    #endif
    [IsoXmlTag("BrrwgRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BorrowingReason2Choice_? BorrowingReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BorrowingReason2Choice_? BorrowingReason { get; init; } 
    #else
    public BorrowingReason2Choice_? BorrowingReason { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of collateral, for insatnce, security, bond, etc.
    /// </summary>
    [IsoId("_1oSiNY-eEeaEa8S_GI1QNA")]
    [DisplayName("Collateral Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollTp")]
    #endif
    [IsoXmlTag("CollTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralType4Choice_? CollateralType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralType4Choice_? CollateralType { get; init; } 
    #else
    public CollateralType4Choice_? CollateralType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the contract terms changed.
    /// </summary>
    [IsoId("_1oSiN4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiOY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiO4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiPY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiP4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiQY-eEeaEa8S_GI1QNA")]
    [DisplayName("Number Of Days Lending Borrowing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysLndgBrrwg")]
    #endif
    [IsoXmlTag("NbOfDaysLndgBrrwg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Number24Choice_? NumberOfDaysLendingBorrowing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Number24Choice_? NumberOfDaysLendingBorrowing { get; init; } 
    #else
    public Number24Choice_? NumberOfDaysLendingBorrowing { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the standard collateral amount.
    /// </summary>
    [IsoId("_1oSiQ4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiRY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiR4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiSY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiS4-eEeaEa8S_GI1QNA")]
    [DisplayName("Securities Lending Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesLndgTp")]
    #endif
    [IsoXmlTag("SctiesLndgTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesLendingType2Choice_? SecuritiesLendingType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesLendingType2Choice_? SecuritiesLendingType { get; init; } 
    #else
    public SecuritiesLendingType2Choice_? SecuritiesLendingType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the possibility to terminate the securitiesc lending contract either by the borrower or lender before the expiration date.
    /// </summary>
    [IsoId("_1oSiTY-eEeaEa8S_GI1QNA")]
    [DisplayName("Reversible")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvsbl")]
    #endif
    [IsoXmlTag("Rvsbl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reversible2Choice_? Reversible { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reversible2Choice_? Reversible { get; init; } 
    #else
    public Reversible2Choice_? Reversible { get; set; } 
    #endif
    
    /// <summary>
    /// This is the minimum date at which the Borrower is allowed to give back the securities.
    /// </summary>
    [IsoId("_1oSiT4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiUY-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiU4-eEeaEa8S_GI1QNA")]
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
    [IsoId("_1oSiVY-eEeaEa8S_GI1QNA")]
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
