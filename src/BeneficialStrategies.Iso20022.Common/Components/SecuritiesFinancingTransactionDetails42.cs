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
[IsoId("_3AjGcdBvEeihG9bKfarOOA")]
[DisplayName("Securities Financing Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingTransactionDetails42
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the underlying securities financing trade as assigned by the instructing party. The identification is common to all collateral pieces (one or many).
    /// </summary>
    [IsoId("_3SjccdBvEeihG9bKfarOOA")]
    [DisplayName("Securities Financing Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgTradId")]
    #endif
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? SecuritiesFinancingTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesFinancingTradeIdentification { get; init; } 
    #else
    public System.String? SecuritiesFinancingTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_3SsmYdBvEeihG9bKfarOOA")]
    [DisplayName("Closing Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgLegId")]
    #endif
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClosingLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingLegIdentification { get; init; } 
    #else
    public System.String? ClosingLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_3SsmadBvEeihG9bKfarOOA")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminationDate6Choice_? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminationDate6Choice_? TerminationDate { get; init; } 
    #else
    public TerminationDate6Choice_? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_3SsmcdBvEeihG9bKfarOOA")]
    [DisplayName("Rate Change Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateChngDt")]
    #endif
    [IsoXmlTag("RateChngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? RateChangeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? RateChangeDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? RateChangeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_3SsmedBvEeihG9bKfarOOA")]
    [DisplayName("Earliest Call Back Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstCallBckDt")]
    #endif
    [IsoXmlTag("EarlstCallBckDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? EarliestCallBackDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_3Ssme9BvEeihG9bKfarOOA")]
    [DisplayName("Commission Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnClctnDt")]
    #endif
    [IsoXmlTag("ComssnClctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? CommissionCalculationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_3SsmfdBvEeihG9bKfarOOA")]
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
    [IsoId("_3SsmhdBvEeihG9bKfarOOA")]
    [DisplayName("Revaluation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvaltn")]
    #endif
    [IsoXmlTag("Rvaltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RevaluationIndicator3Choice_? Revaluation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RevaluationIndicator3Choice_? Revaluation { get; init; } 
    #else
    public RevaluationIndicator3Choice_? Revaluation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_3SsmjdBvEeihG9bKfarOOA")]
    [DisplayName("Legal Framework")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglFrmwk")]
    #endif
    [IsoXmlTag("LglFrmwk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalFramework3Choice_? LegalFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalFramework3Choice_? LegalFramework { get; init; } 
    #else
    public LegalFramework3Choice_? LegalFramework { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_3SsmldBvEeihG9bKfarOOA")]
    [DisplayName("Interest Computation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstCmptnMtd")]
    #endif
    [IsoXmlTag("IntrstCmptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat4Choice_? InterestComputationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat4Choice_? InterestComputationMethod { get; init; } 
    #else
    public InterestComputationMethodFormat4Choice_? InterestComputationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_3SsmndBvEeihG9bKfarOOA")]
    [DisplayName("Maturity Date Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDtMod")]
    #endif
    [IsoXmlTag("MtrtyDtMod")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MaturityDateModification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaturityDateModification { get; init; } 
    #else
    public System.String? MaturityDateModification { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_3SsmpdBvEeihG9bKfarOOA")]
    [DisplayName("Interest Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstPmt")]
    #endif
    [IsoXmlTag("IntrstPmt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? InterestPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InterestPayment { get; init; } 
    #else
    public System.String? InterestPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Index or support rate used together with the spread to calculate the repurchase rate.
    /// </summary>
    [IsoId("_3SsmrdBvEeihG9bKfarOOA")]
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
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_3SsmtdBvEeihG9bKfarOOA")]
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
    [IsoId("_3SsmvdBvEeihG9bKfarOOA")]
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
    [IsoId("_3SsmxdBvEeihG9bKfarOOA")]
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
    /// Interest rate paid in the context of a securities financing transaction.
    /// </summary>
    [IsoId("_3SsmzdBvEeihG9bKfarOOA")]
    [DisplayName("Charges Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsRate")]
    #endif
    [IsoXmlTag("ChrgsRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? ChargesRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? ChargesRate { get; init; } 
    #else
    public Rate2? ChargesRate { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_3Ssmz9BvEeihG9bKfarOOA")]
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
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_3Ssm19BvEeihG9bKfarOOA")]
    [DisplayName("Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sprd")]
    #endif
    [IsoXmlTag("Sprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Rate2? Spread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Rate2? Spread { get; init; } 
    #else
    public Rate2? Spread { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum number of days&apos; notice a counterparty needs for terminating the transaction.
    /// </summary>
    [IsoId("_3Ssm39BvEeihG9bKfarOOA")]
    [DisplayName("Transaction Call Delay")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxCallDely")]
    #endif
    [IsoXmlTag("TxCallDely")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? TransactionCallDelay { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionCallDelay { get; init; } 
    #else
    public System.String? TransactionCallDelay { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of collateral instructions involved in the transaction.
    /// </summary>
    [IsoId("_3Ssm59BvEeihG9bKfarOOA")]
    [DisplayName("Total Number Of Collateral Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfCollInstrs")]
    #endif
    [IsoXmlTag("TtlNbOfCollInstrs")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? TotalNumberOfCollateralInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TotalNumberOfCollateralInstructions { get; init; } 
    #else
    public System.String? TotalNumberOfCollateralInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of commission paid to a local broker.
    /// </summary>
    [IsoId("_3Ssm79BvEeihG9bKfarOOA")]
    [DisplayName("Local Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssn")]
    #endif
    [IsoXmlTag("LclBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? LocalBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? LocalBrokerCommission { get; init; } 
    #else
    public AmountAndDirection21? LocalBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_3Ssm8dBvEeihG9bKfarOOA")]
    [DisplayName("Deal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealAmt")]
    #endif
    [IsoXmlTag("DealAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? DealAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? DealAmount { get; init; } 
    #else
    public AmountAndDirection21? DealAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_3Ssm-dBvEeihG9bKfarOOA")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection21? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_3SsnAdBvEeihG9bKfarOOA")]
    [DisplayName("Forfeit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrftAmt")]
    #endif
    [IsoXmlTag("FrftAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? ForfeitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? ForfeitAmount { get; init; } 
    #else
    public AmountAndDirection21? ForfeitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_3SsnCdBvEeihG9bKfarOOA")]
    [DisplayName("Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmAmt")]
    #endif
    [IsoXmlTag("PrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? PremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? PremiumAmount { get; init; } 
    #else
    public AmountAndDirection21? PremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_3SsnEdBvEeihG9bKfarOOA")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnAmtPerPcOfColl")]
    #endif
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? TerminationAmountPerPieceOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? TerminationAmountPerPieceOfCollateral { get; init; } 
    #else
    public AmountAndDirection21? TerminationAmountPerPieceOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_3SsnGdBvEeihG9bKfarOOA")]
    [DisplayName("Termination Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnTxAmt")]
    #endif
    [IsoXmlTag("TermntnTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? TerminationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? TerminationTransactionAmount { get; init; } 
    #else
    public AmountAndDirection21? TerminationTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_3SsnIdBvEeihG9bKfarOOA")]
    [DisplayName("Second Leg Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLegNrrtv")]
    #endif
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? SecondLegNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondLegNarrative { get; init; } 
    #else
    public System.String? SecondLegNarrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
