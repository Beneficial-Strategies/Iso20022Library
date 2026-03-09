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
[IsoId("_SnggcFL0EeG2M5YWM-8eJg_-1806973104")]
[DisplayName("Securities Financing Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingTransactionDetails19
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
    [IsoId("_SnggcVL0EeG2M5YWM-8eJg_-1920812170")]
    [DisplayName("Securities Financing Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgTradId")]
    #endif
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecuritiesFinancingTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesFinancingTradeIdentification { get; init; } 
    #else
    public System.String? SecuritiesFinancingTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_SnggclL0EeG2M5YWM-8eJg_1669040511")]
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
    [IsoId("_SnpqYFL0EeG2M5YWM-8eJg_493849486")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminationDate2Choice_? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminationDate2Choice_? TerminationDate { get; init; } 
    #else
    public TerminationDate2Choice_? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_SnpqYVL0EeG2M5YWM-8eJg_-503222867")]
    [DisplayName("Rate Change Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateChngDt")]
    #endif
    [IsoXmlTag("RateChngDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? RateChangeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? RateChangeDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? RateChangeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Earliest date/time at which the call back can take place.
    /// </summary>
    [IsoId("_SnzbYFL0EeG2M5YWM-8eJg_1142044568")]
    [DisplayName("Earliest Call Back Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstCallBckDt")]
    #endif
    [IsoXmlTag("EarlstCallBckDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? EarliestCallBackDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? EarliestCallBackDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? EarliestCallBackDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the commission is calculated.
    /// </summary>
    [IsoId("_SnzbYVL0EeG2M5YWM-8eJg_-1614134286")]
    [DisplayName("Commission Calculation Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnClctnDt")]
    #endif
    [IsoXmlTag("ComssnClctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeChoice_? CommissionCalculationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeChoice_? CommissionCalculationDate { get; init; } 
    #else
    public DateAndDateTimeChoice_? CommissionCalculationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the rate is fixed or variable.
    /// </summary>
    [IsoId("_Sn9MYFL0EeG2M5YWM-8eJg_1975718395")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateType5Choice_? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType5Choice_? RateType { get; init; } 
    #else
    public RateType5Choice_? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_Sn9MYVL0EeG2M5YWM-8eJg_800527370")]
    [DisplayName("Revaluation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvaltn")]
    #endif
    [IsoXmlTag("Rvaltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RevaluationIndicator1Choice_? Revaluation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RevaluationIndicator1Choice_? Revaluation { get; init; } 
    #else
    public RevaluationIndicator1Choice_? Revaluation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_Sn9MYlL0EeG2M5YWM-8eJg_-1849172491")]
    [DisplayName("Legal Framework")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglFrmwk")]
    #endif
    [IsoXmlTag("LglFrmwk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalFramework1Choice_? LegalFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalFramework1Choice_? LegalFramework { get; init; } 
    #else
    public LegalFramework1Choice_? LegalFramework { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_SoGWUFL0EeG2M5YWM-8eJg_-310384049")]
    [DisplayName("Interest Computation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstCmptnMtd")]
    #endif
    [IsoXmlTag("IntrstCmptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat1Choice_? InterestComputationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat1Choice_? InterestComputationMethod { get; init; } 
    #else
    public InterestComputationMethodFormat1Choice_? InterestComputationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_SoGWUVL0EeG2M5YWM-8eJg_-1015498664")]
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
    /// Specifies whether the interest is to be paid to the collateral taker. If set to no, the interest is paid to the collateral giver.
    /// </summary>
    [IsoId("_SoQHUFL0EeG2M5YWM-8eJg_2104277607")]
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
    /// Index or support rate used together with the spread to calculate the|repurchase rate.
    /// </summary>
    [IsoId("_SoQHUVL0EeG2M5YWM-8eJg_-545422254")]
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
    [IsoId("_SoQHUlL0EeG2M5YWM-8eJg_993366188")]
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
    [IsoId("_SoZRQFL0EeG2M5YWM-8eJg_288251573")]
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
    [IsoId("_SoZRQVL0EeG2M5YWM-8eJg_-886939452")]
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
    [IsoId("_SojCQFL0EeG2M5YWM-8eJg_758327983")]
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
    [IsoId("_SojCQVL0EeG2M5YWM-8eJg_-1997850871")]
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
    [IsoId("_SoszQFL0EeG2M5YWM-8eJg_1592001810")]
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
    [IsoId("_SoszQVL0EeG2M5YWM-8eJg_416810785")]
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
    [IsoId("_SoszQlL0EeG2M5YWM-8eJg_2062078220")]
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
    [IsoId("_So19MFL0EeG2M5YWM-8eJg_-1408540033")]
    [DisplayName("Local Broker Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LclBrkrComssn")]
    #endif
    [IsoXmlTag("LclBrkrComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? LocalBrokerCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? LocalBrokerCommission { get; init; } 
    #else
    public AmountAndDirection4? LocalBrokerCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_So19MVL0EeG2M5YWM-8eJg_-694100634")]
    [DisplayName("Deal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealAmt")]
    #endif
    [IsoXmlTag("DealAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? DealAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? DealAmount { get; init; } 
    #else
    public AmountAndDirection4? DealAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_So_uMFL0EeG2M5YWM-8eJg_-1399215249")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection4? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_So_uMVL0EeG2M5YWM-8eJg_1720561022")]
    [DisplayName("Forfeit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrftAmt")]
    #endif
    [IsoXmlTag("FrftAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? ForfeitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? ForfeitAmount { get; init; } 
    #else
    public AmountAndDirection4? ForfeitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_SpJfMFL0EeG2M5YWM-8eJg_-929138839")]
    [DisplayName("Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmAmt")]
    #endif
    [IsoXmlTag("PrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? PremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? PremiumAmount { get; init; } 
    #else
    public AmountAndDirection4? PremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_SpJfMVL0EeG2M5YWM-8eJg_609649603")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnAmtPerPcOfColl")]
    #endif
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? TerminationAmountPerPieceOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? TerminationAmountPerPieceOfCollateral { get; init; } 
    #else
    public AmountAndDirection4? TerminationAmountPerPieceOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_SpJfMlL0EeG2M5YWM-8eJg_-95465012")]
    [DisplayName("Termination Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnTxAmt")]
    #endif
    [IsoXmlTag("TermntnTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection4? TerminationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection4? TerminationTransactionAmount { get; init; } 
    #else
    public AmountAndDirection4? TerminationTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_SpSpIFL0EeG2M5YWM-8eJg_-1270656037")]
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
