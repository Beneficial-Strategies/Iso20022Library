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
[IsoId("_5Tn2yc3yEee5nJBZsW8MFQ")]
[DisplayName("Securities Financing Transaction Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesFinancingTransactionDetails39
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
    [IsoId("_5Tn2y83yEee5nJBZsW8MFQ")]
    [DisplayName("Securities Financing Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesFincgTradId")]
    #endif
    [IsoXmlTag("SctiesFincgTradId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? SecuritiesFinancingTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecuritiesFinancingTradeIdentification { get; init; } 
    #else
    public System.String? SecuritiesFinancingTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the second leg of the transaction as known by the account owner (or the instructing party acting on its behalf).
    /// </summary>
    [IsoId("_5Tn2083yEee5nJBZsW8MFQ")]
    [DisplayName("Closing Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgLegId")]
    #endif
    [IsoXmlTag("ClsgLegId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax16Text? ClosingLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClosingLegIdentification { get; init; } 
    #else
    public System.String? ClosingLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_5Tn2283yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TerminationDate7Choice_? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminationDate7Choice_? TerminationDate { get; init; } 
    #else
    public TerminationDate7Choice_? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/Time at which rate change has taken place.
    /// </summary>
    [IsoId("_5Tn2483yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn2683yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn27c3yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn2783yEee5nJBZsW8MFQ")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateType67Choice_? RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType67Choice_? RateType { get; init; } 
    #else
    public RateType67Choice_? RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the collateral position should be subject to automatic revaluation by the account servicer.
    /// </summary>
    [IsoId("_5Tn2983yEee5nJBZsW8MFQ")]
    [DisplayName("Revaluation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rvaltn")]
    #endif
    [IsoXmlTag("Rvaltn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RevaluationIndicator4Choice_? Revaluation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RevaluationIndicator4Choice_? Revaluation { get; init; } 
    #else
    public RevaluationIndicator4Choice_? Revaluation { get; set; } 
    #endif
    
    /// <summary>
    /// Legal framework of the transaction.
    /// </summary>
    [IsoId("_5Tn2_83yEee5nJBZsW8MFQ")]
    [DisplayName("Legal Framework")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglFrmwk")]
    #endif
    [IsoXmlTag("LglFrmwk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalFramework4Choice_? LegalFramework { get; init; } 
    #else
    public LegalFramework4Choice_? LegalFramework { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the computation method of accrued interest of the related financial instrument.
    /// </summary>
    [IsoId("_5Tn3B83yEee5nJBZsW8MFQ")]
    [DisplayName("Interest Computation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstCmptnMtd")]
    #endif
    [IsoXmlTag("IntrstCmptnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; init; } 
    #else
    public InterestComputationMethodFormat5Choice_? InterestComputationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the maturity date of the securities financing transaction may be modified.
    /// </summary>
    [IsoId("_5Tn3D83yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3F83yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3H83yEee5nJBZsW8MFQ")]
    [DisplayName("Variable Rate Support")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VarblRateSpprt")]
    #endif
    [IsoXmlTag("VarblRateSpprt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateName2? VariableRateSupport { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateName2? VariableRateSupport { get; init; } 
    #else
    public RateName2? VariableRateSupport { get; set; } 
    #endif
    
    /// <summary>
    /// Rate to be used to recalculate the repurchase amount.
    /// </summary>
    [IsoId("_5Tn3J83yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3L83yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3N83yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3P83yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3Qc3yEee5nJBZsW8MFQ")]
    [DisplayName("Pricing Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgRate")]
    #endif
    [IsoXmlTag("PricgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateOrName2Choice_? PricingRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrName2Choice_? PricingRate { get; init; } 
    #else
    public RateOrName2Choice_? PricingRate { get; set; } 
    #endif
    
    /// <summary>
    /// Repurchase spread expressed as a rate; margin over or under an index that determines the repurchase rate.
    /// </summary>
    [IsoId("_5Tn3Sc3yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3Uc3yEee5nJBZsW8MFQ")]
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
    [IsoId("_5Tn3Wc3yEee5nJBZsW8MFQ")]
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
    /// Principal amount of a trade (for second leg).
    /// </summary>
    [IsoId("_5Tn3Yc3yEee5nJBZsW8MFQ")]
    [DisplayName("Deal Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealAmt")]
    #endif
    [IsoXmlTag("DealAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? DealAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? DealAmount { get; init; } 
    #else
    public AmountAndDirection59? DealAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_5Tn3ac3yEee5nJBZsW8MFQ")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection59? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Fixed amount of money that has to be paid (instead of interest) in the case of a recall or at the closing date.
    /// </summary>
    [IsoId("_5Tn3cc3yEee5nJBZsW8MFQ")]
    [DisplayName("Forfeit Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrftAmt")]
    #endif
    [IsoXmlTag("FrftAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? ForfeitAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? ForfeitAmount { get; init; } 
    #else
    public AmountAndDirection59? ForfeitAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Difference between the amount of money of the first leg and the amount of the second leg of the transaction.
    /// </summary>
    [IsoId("_5Tn3ec3yEee5nJBZsW8MFQ")]
    [DisplayName("Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrmAmt")]
    #endif
    [IsoXmlTag("PrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? PremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? PremiumAmount { get; init; } 
    #else
    public AmountAndDirection59? PremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be settled per piece of collateral to terminate the transaction.
    /// </summary>
    [IsoId("_5Tn3gc3yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Amount Per Piece Of Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnAmtPerPcOfColl")]
    #endif
    [IsoXmlTag("TermntnAmtPerPcOfColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; init; } 
    #else
    public AmountAndDirection59? TerminationAmountPerPieceOfCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of money to be settled to terminate the transaction.
    /// </summary>
    [IsoId("_5Tn3ic3yEee5nJBZsW8MFQ")]
    [DisplayName("Termination Transaction Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnTxAmt")]
    #endif
    [IsoXmlTag("TermntnTxAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection59? TerminationTransactionAmount { get; init; } 
    #else
    public AmountAndDirection59? TerminationTransactionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information about the second leg in narrative form.
    /// </summary>
    [IsoId("_5Tn3kc3yEee5nJBZsW8MFQ")]
    [DisplayName("Second Leg Narrative")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndLegNrrtv")]
    #endif
    [IsoXmlTag("ScndLegNrrtv")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? SecondLegNarrative { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondLegNarrative { get; init; } 
    #else
    public System.String? SecondLegNarrative { get; set; } 
    #endif
    
    
    #nullable disable
    
}
