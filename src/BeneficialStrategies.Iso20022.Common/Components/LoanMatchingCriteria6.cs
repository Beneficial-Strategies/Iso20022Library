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
/// Compares information related to both sides of a loan.
/// </summary>
[IsoId("_DBFZsf_oEemm3skPVSMJQg")]
[DisplayName("Loan Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanMatchingCriteria6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values for the Unique Trade Identifier (UTI) are matching or not.
    /// </summary>
    [IsoId("_DEzcEf_oEemm3skPVSMJQg")]
    [DisplayName("Unique Trade Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTradIdr")]
    #endif
    [IsoXmlTag("UnqTradIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareText1? UniqueTradeIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareText1? UniqueTradeIdentifier { get; init; } 
    #else
    public CompareText1? UniqueTradeIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcE__oEemm3skPVSMJQg")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? TerminationDate { get; init; } 
    #else
    public CompareDate2? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as exposure type are matching or not.
    /// </summary>
    [IsoId("_DEzcFf_oEemm3skPVSMJQg")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareExposureType2? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareExposureType2? ContractType { get; init; } 
    #else
    public CompareExposureType2? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on contract clearing are matching or not.
    /// </summary>
    [IsoId("_DEzcF__oEemm3skPVSMJQg")]
    [DisplayName("Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSts")]
    #endif
    [IsoXmlTag("ClrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareClearingStatus2? ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareClearingStatus2? ClearingStatus { get; init; } 
    #else
    public CompareClearingStatus2? ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_DEzcGf_oEemm3skPVSMJQg")]
    [DisplayName("Clearing Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtTm")]
    #endif
    [IsoXmlTag("ClrDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDateTime2? ClearingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDateTime2? ClearingDateTime { get; init; } 
    #else
    public CompareDateTime2? ClearingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    [IsoId("_DEzcG__oEemm3skPVSMJQg")]
    [DisplayName("CCP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCP")]
    #endif
    [IsoXmlTag("CCP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification1? CCP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification1? CCP { get; init; } 
    #else
    public CompareOrganisationIdentification1? CCP { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as MIC identifier are matching or not.
    /// </summary>
    [IsoId("_DEzcHf_oEemm3skPVSMJQg")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMICIdentifier2? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMICIdentifier2? TradingVenue { get; init; } 
    #else
    public CompareMICIdentifier2? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on master agreement type are matching or not.
    /// </summary>
    [IsoId("_DEzcH__oEemm3skPVSMJQg")]
    [DisplayName("Master Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmtTp")]
    #endif
    [IsoXmlTag("MstrAgrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAgreementType1? MasterAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAgreementType1? MasterAgreementType { get; init; } 
    #else
    public CompareAgreementType1? MasterAgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_DEzcIf_oEemm3skPVSMJQg")]
    [DisplayName("Executing Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctgDtTm")]
    #endif
    [IsoXmlTag("ExctgDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDateTime2? ExecutingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDateTime2? ExecutingDateTime { get; init; } 
    #else
    public CompareDateTime2? ExecutingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcI__oEemm3skPVSMJQg")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? StartDate { get; init; } 
    #else
    public CompareDate2? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcJf_oEemm3skPVSMJQg")]
    [DisplayName("End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndDt")]
    #endif
    [IsoXmlTag("EndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? EndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? EndDate { get; init; } 
    #else
    public CompareDate2? EndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcJ__oEemm3skPVSMJQg")]
    [DisplayName("Minimum Notice Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNtcePrd")]
    #endif
    [IsoXmlTag("MinNtcePrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber3? MinimumNoticePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber3? MinimumNoticePeriod { get; init; } 
    #else
    public CompareNumber3? MinimumNoticePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcKf_oEemm3skPVSMJQg")]
    [DisplayName("Earliest Call Back Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstCallBckDt")]
    #endif
    [IsoXmlTag("EarlstCallBckDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? EarliestCallBackDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? EarliestCallBackDate { get; init; } 
    #else
    public CompareDate2? EarliestCallBackDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as type of collateral agreement are matching or not.
    /// </summary>
    [IsoId("_DEzcK__oEemm3skPVSMJQg")]
    [DisplayName("General Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlColl")]
    #endif
    [IsoXmlTag("GnlColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareSpecialCollateral2? GeneralCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareSpecialCollateral2? GeneralCollateral { get; init; } 
    #else
    public CompareSpecialCollateral2? GeneralCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_DEzcLf_oEemm3skPVSMJQg")]
    [DisplayName("Delivery By Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryByVal")]
    #endif
    [IsoXmlTag("DlvryByVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator2? DeliveryByValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator2? DeliveryByValue { get; init; } 
    #else
    public CompareTrueFalseIndicator2? DeliveryByValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as collateral delivery method are matching or not.
    /// </summary>
    [IsoId("_DEzcL__oEemm3skPVSMJQg")]
    [DisplayName("Collateral Delivery Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollDlvryMtd")]
    #endif
    [IsoXmlTag("CollDlvryMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDeliveryMethod2? CollateralDeliveryMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDeliveryMethod2? CollateralDeliveryMethod { get; init; } 
    #else
    public CompareDeliveryMethod2? CollateralDeliveryMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_DEzcMf_oEemm3skPVSMJQg")]
    [DisplayName("Open Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnTerm")]
    #endif
    [IsoXmlTag("OpnTerm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator2? OpenTerm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator2? OpenTerm { get; init; } 
    #else
    public CompareTrueFalseIndicator2? OpenTerm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as repo termination option are matching or not.
    /// </summary>
    [IsoId("_DEzcM__oEemm3skPVSMJQg")]
    [DisplayName("Termination Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnOptn")]
    #endif
    [IsoXmlTag("TermntnOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTerminationOption2? TerminationOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTerminationOption2? TerminationOption { get; init; } 
    #else
    public CompareTerminationOption2? TerminationOption { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_DEzcNf_oEemm3skPVSMJQg")]
    [DisplayName("Fixed Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxdIntrstRate")]
    #endif
    [IsoXmlTag("FxdIntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate2? FixedInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate2? FixedInterestRate { get; init; } 
    #else
    public ComparePercentageRate2? FixedInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcN__oEemm3skPVSMJQg")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareInterestComputationMethod2? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareInterestComputationMethod2? DayCountBasis { get; init; } 
    #else
    public CompareInterestComputationMethod2? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_DEzcOf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRefRate")]
    #endif
    [IsoXmlTag("FltgIntrstRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCurveName2? FloatingInterestReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCurveName2? FloatingInterestReferenceRate { get; init; } 
    #else
    public CompareBenchmarkCurveName2? FloatingInterestReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcO__oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Term Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateTermUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRateTermUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis2? FloatingInterestRateTermUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis2? FloatingInterestRateTermUnit { get; init; } 
    #else
    public CompareRateBasis2? FloatingInterestRateTermUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcPf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Term Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateTermVal")]
    #endif
    [IsoXmlTag("FltgIntrstRateTermVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber3? FloatingInterestRateTermValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber3? FloatingInterestRateTermValue { get; init; } 
    #else
    public CompareNumber3? FloatingInterestRateTermValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcP__oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRatePmtFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRatePmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis2? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis2? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis2? FloatingInterestRatePaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcQf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRatePmtFrqcyVal")]
    #endif
    [IsoXmlTag("FltgIntrstRatePmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber3? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber3? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber3? FloatingInterestRatePaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcQ__oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateRstFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRateRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis2? FloatingInterestRateResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis2? FloatingInterestRateResetFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis2? FloatingInterestRateResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcRf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateRstFrqcyVal")]
    #endif
    [IsoXmlTag("FltgIntrstRateRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber2? FloatingInterestRateResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber2? FloatingInterestRateResetFrequencyValue { get; init; } 
    #else
    public CompareNumber2? FloatingInterestRateResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcR__oEemm3skPVSMJQg")]
    [DisplayName("Interest Rate Basis Point Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRateBsisPtSprd")]
    #endif
    [IsoXmlTag("IntrstRateBsisPtSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber2? InterestRateBasisPointSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber2? InterestRateBasisPointSpread { get; init; } 
    #else
    public CompareNumber2? InterestRateBasisPointSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcSf_oEemm3skPVSMJQg")]
    [DisplayName("Margin Loan Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnLnAmt")]
    #endif
    [IsoXmlTag("MrgnLnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    #else
    public CompareAmountAndDirection1? MarginLoanAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcS__oEemm3skPVSMJQg")]
    [DisplayName("Principal Amount Start Date Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmtStartDtAmt")]
    #endif
    [IsoXmlTag("PrncplAmtStartDtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountStartDateAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountStartDateAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountStartDateAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcTf_oEemm3skPVSMJQg")]
    [DisplayName("Principal Amount Maturity Date Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmtMtrtyDtAmt")]
    #endif
    [IsoXmlTag("PrncplAmtMtrtyDtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountMaturityDateAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountMaturityDateAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountMaturityDateAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the infromation on the asset type is matching or not.
    /// </summary>
    [IsoId("_DEzcT__oEemm3skPVSMJQg")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCommodity4? AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCommodity4? AssetType { get; init; } 
    #else
    public SecurityCommodity4? AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcUf_oEemm3skPVSMJQg")]
    [DisplayName("Loan Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnVal")]
    #endif
    [IsoXmlTag("LnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount2? LoanValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount2? LoanValue { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount2? LoanValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_DEzcU__oEemm3skPVSMJQg")]
    [DisplayName("Fixed Rebate Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxdRbtRefRate")]
    #endif
    [IsoXmlTag("FxdRbtRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate2? FixedRebateReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate2? FixedRebateReferenceRate { get; init; } 
    #else
    public ComparePercentageRate2? FixedRebateReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_DEzcVf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRefRate")]
    #endif
    [IsoXmlTag("FltgRbtRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCurveName2? FloatingRebateReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCurveName2? FloatingRebateReferenceRate { get; init; } 
    #else
    public CompareBenchmarkCurveName2? FloatingRebateReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcV__oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Term Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateTermUnit")]
    #endif
    [IsoXmlTag("FltgRbtRateTermUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis2? FloatingRebateRateTermUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis2? FloatingRebateRateTermUnit { get; init; } 
    #else
    public CompareRateBasis2? FloatingRebateRateTermUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcWf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Term Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateTermVal")]
    #endif
    [IsoXmlTag("FltgRbtRateTermVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber2? FloatingRebateRateTermValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber2? FloatingRebateRateTermValue { get; init; } 
    #else
    public CompareNumber2? FloatingRebateRateTermValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcW__oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRatePmtFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgRbtRatePmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis2? FloatingRebateRatePaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis2? FloatingRebateRatePaymentFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis2? FloatingRebateRatePaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcXf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRatePmtFrqcyVal")]
    #endif
    [IsoXmlTag("FltgRbtRatePmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber2? FloatingRebateRatePaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber2? FloatingRebateRatePaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber2? FloatingRebateRatePaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcX__oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateRstFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgRbtRateRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis2? FloatingRebateRateResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis2? FloatingRebateRateResetFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis2? FloatingRebateRateResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcYf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateRstFrqcyVal")]
    #endif
    [IsoXmlTag("FltgRbtRateRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber2? FloatingRebateRateResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber2? FloatingRebateRateResetFrequencyValue { get; init; } 
    #else
    public CompareNumber2? FloatingRebateRateResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcY__oEemm3skPVSMJQg")]
    [DisplayName("Rebate Rate Basis Point Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RbtRateBsisPtSprd")]
    #endif
    [IsoXmlTag("RbtRateBsisPtSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber2? RebateRateBasisPointSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber2? RebateRateBasisPointSpread { get; init; } 
    #else
    public CompareNumber2? RebateRateBasisPointSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as the adjusted rate are matching or not.
    /// </summary>
    [IsoId("_DEzcZf_oEemm3skPVSMJQg")]
    [DisplayName("Adjusted Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstdRate")]
    #endif
    [IsoXmlTag("AdjstdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate2? AdjustedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate2? AdjustedRate { get; init; } 
    #else
    public ComparePercentageRate2? AdjustedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as the Rate Date are matching or not.
    /// </summary>
    [IsoId("_DEzcZ__oEemm3skPVSMJQg")]
    [DisplayName("Adjustment Rate Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdjstmntRateDt")]
    #endif
    [IsoXmlTag("AdjstmntRateDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate2? AdjustmentRateDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate2? AdjustmentRateDate { get; init; } 
    #else
    public CompareDate2? AdjustmentRateDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_DEzcaf_oEemm3skPVSMJQg")]
    [DisplayName("Lending Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgFee")]
    #endif
    [IsoXmlTag("LndgFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate2? LendingFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate2? LendingFee { get; init; } 
    #else
    public ComparePercentageRate2? LendingFee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzca__oEemm3skPVSMJQg")]
    [DisplayName("Outstanding Loan")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngLn")]
    #endif
    [IsoXmlTag("OutsdngLn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount2? OutstandingLoan { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount2? OutstandingLoan { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount2? OutstandingLoan { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcbf_oEemm3skPVSMJQg")]
    [DisplayName("Short Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtMktVal")]
    #endif
    [IsoXmlTag("ShrtMktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount2? ShortMarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount2? ShortMarketValue { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount2? ShortMarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as transaction/position indicator are matching or not.
    /// </summary>
    [IsoId("_DEzcb__oEemm3skPVSMJQg")]
    [DisplayName("Level Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LvlTp")]
    #endif
    [IsoXmlTag("LvlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareReportingLevelType2? LevelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareReportingLevelType2? LevelType { get; init; } 
    #else
    public CompareReportingLevelType2? LevelType { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [IsoId("_DEzccf_oEemm3skPVSMJQg")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitOfMeasure2? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitOfMeasure2? UnitOfMeasure { get; init; } 
    #else
    public CompareUnitOfMeasure2? UnitOfMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
