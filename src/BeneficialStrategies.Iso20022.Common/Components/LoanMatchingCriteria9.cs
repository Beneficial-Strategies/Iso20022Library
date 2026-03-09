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
[IsoId("_98YaQcgxEeuGrNSsxk3B0A")]
[DisplayName("Loan Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanMatchingCriteria9
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
    [IsoId("_9-J748gxEeuGrNSsxk3B0A")]
    [DisplayName("Unique Trade Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTradIdr")]
    #endif
    [IsoXmlTag("UnqTradIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareText2? UniqueTradeIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareText2? UniqueTradeIdentifier { get; init; } 
    #else
    public CompareText2? UniqueTradeIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J75cgxEeuGrNSsxk3B0A")]
    [DisplayName("Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnDt")]
    #endif
    [IsoXmlTag("TermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? TerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? TerminationDate { get; init; } 
    #else
    public CompareDate3? TerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as exposure type are matching or not.
    /// </summary>
    [IsoId("_9-J758gxEeuGrNSsxk3B0A")]
    [DisplayName("Contract Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctTp")]
    #endif
    [IsoXmlTag("CtrctTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareExposureType3? ContractType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareExposureType3? ContractType { get; init; } 
    #else
    public CompareExposureType3? ContractType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on contract clearing are matching or not.
    /// </summary>
    [IsoId("_9-J76cgxEeuGrNSsxk3B0A")]
    [DisplayName("Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrSts")]
    #endif
    [IsoXmlTag("ClrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareClearingStatus3? ClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareClearingStatus3? ClearingStatus { get; init; } 
    #else
    public CompareClearingStatus3? ClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_9-J768gxEeuGrNSsxk3B0A")]
    [DisplayName("Clearing Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtTm")]
    #endif
    [IsoXmlTag("ClrDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDateTime3? ClearingDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDateTime3? ClearingDateTime { get; init; } 
    #else
    public CompareDateTime3? ClearingDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    [IsoId("_9-J77cgxEeuGrNSsxk3B0A")]
    [DisplayName("CCP")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CCP")]
    #endif
    [IsoXmlTag("CCP")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOrganisationIdentification6? CCP { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOrganisationIdentification6? CCP { get; init; } 
    #else
    public CompareOrganisationIdentification6? CCP { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as MIC (Market Identifier Code-ISO10383) identifier are matching or not.
    /// </summary>
    [IsoId("_9-J778gxEeuGrNSsxk3B0A")]
    [DisplayName("Trading Venue")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgVn")]
    #endif
    [IsoXmlTag("TradgVn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMICIdentifier3? TradingVenue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMICIdentifier3? TradingVenue { get; init; } 
    #else
    public CompareMICIdentifier3? TradingVenue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on master agreement type is matching or not.
    /// </summary>
    [IsoId("_9-J78cgxEeuGrNSsxk3B0A")]
    [DisplayName("Master Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmtTp")]
    #endif
    [IsoXmlTag("MstrAgrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAgreementType2? MasterAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAgreementType2? MasterAgreementType { get; init; } 
    #else
    public CompareAgreementType2? MasterAgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_9-J788gxEeuGrNSsxk3B0A")]
    [DisplayName("Execution Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnDtTm")]
    #endif
    [IsoXmlTag("ExctnDtTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDateTime3? ExecutionDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDateTime3? ExecutionDateTime { get; init; } 
    #else
    public CompareDateTime3? ExecutionDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J79cgxEeuGrNSsxk3B0A")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? ValueDate { get; init; } 
    #else
    public CompareDate3? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J798gxEeuGrNSsxk3B0A")]
    [DisplayName("Maturity Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtrtyDt")]
    #endif
    [IsoXmlTag("MtrtyDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? MaturityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? MaturityDate { get; init; } 
    #else
    public CompareDate3? MaturityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J7-cgxEeuGrNSsxk3B0A")]
    [DisplayName("Minimum Notice Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinNtcePrd")]
    #endif
    [IsoXmlTag("MinNtcePrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? MinimumNoticePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? MinimumNoticePeriod { get; init; } 
    #else
    public CompareNumber5? MinimumNoticePeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J7-8gxEeuGrNSsxk3B0A")]
    [DisplayName("Earliest Call Back Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstCallBckDt")]
    #endif
    [IsoXmlTag("EarlstCallBckDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? EarliestCallBackDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? EarliestCallBackDate { get; init; } 
    #else
    public CompareDate3? EarliestCallBackDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as type of collateral agreement are matching or not.
    /// </summary>
    [IsoId("_9-J7_cgxEeuGrNSsxk3B0A")]
    [DisplayName("General Collateral")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlColl")]
    #endif
    [IsoXmlTag("GnlColl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareSpecialCollateral3? GeneralCollateral { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareSpecialCollateral3? GeneralCollateral { get; init; } 
    #else
    public CompareSpecialCollateral3? GeneralCollateral { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_9-J7_8gxEeuGrNSsxk3B0A")]
    [DisplayName("Delivery By Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryByVal")]
    #endif
    [IsoXmlTag("DlvryByVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator3? DeliveryByValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator3? DeliveryByValue { get; init; } 
    #else
    public CompareTrueFalseIndicator3? DeliveryByValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as collateral delivery method are matching or not.
    /// </summary>
    [IsoId("_9-J8AcgxEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Delivery Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollDlvryMtd")]
    #endif
    [IsoXmlTag("CollDlvryMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDeliveryMethod3? CollateralDeliveryMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDeliveryMethod3? CollateralDeliveryMethod { get; init; } 
    #else
    public CompareDeliveryMethod3? CollateralDeliveryMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_9-J8A8gxEeuGrNSsxk3B0A")]
    [DisplayName("Open Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OpnTerm")]
    #endif
    [IsoXmlTag("OpnTerm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator3? OpenTerm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator3? OpenTerm { get; init; } 
    #else
    public CompareTrueFalseIndicator3? OpenTerm { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as repo termination option are matching or not.
    /// </summary>
    [IsoId("_9-J8BcgxEeuGrNSsxk3B0A")]
    [DisplayName("Termination Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnOptn")]
    #endif
    [IsoXmlTag("TermntnOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTerminationOption3? TerminationOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTerminationOption3? TerminationOption { get; init; } 
    #else
    public CompareTerminationOption3? TerminationOption { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_9-J8B8gxEeuGrNSsxk3B0A")]
    [DisplayName("Fixed Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxdIntrstRate")]
    #endif
    [IsoXmlTag("FxdIntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate3? FixedInterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate3? FixedInterestRate { get; init; } 
    #else
    public ComparePercentageRate3? FixedInterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8CcgxEeuGrNSsxk3B0A")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareInterestComputationMethod3? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareInterestComputationMethod3? DayCountBasis { get; init; } 
    #else
    public CompareInterestComputationMethod3? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_9-J8C8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRefRate")]
    #endif
    [IsoXmlTag("FltgIntrstRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; } 
    #else
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8DcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Term Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateTermUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRateTermUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8D8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Term Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateTermVal")]
    #endif
    [IsoXmlTag("FltgIntrstRateTermVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? FloatingInterestRateTermValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? FloatingInterestRateTermValue { get; init; } 
    #else
    public CompareNumber5? FloatingInterestRateTermValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8EcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRatePmtFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRatePmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8E8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRatePmtFrqcyVal")]
    #endif
    [IsoXmlTag("FltgIntrstRatePmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8FcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateRstFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgIntrstRateRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8F8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgIntrstRateRstFrqcyVal")]
    #endif
    [IsoXmlTag("FltgIntrstRateRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; } 
    #else
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8GcgxEeuGrNSsxk3B0A")]
    [DisplayName("Basis Point Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsisPtSprd")]
    #endif
    [IsoXmlTag("BsisPtSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDecimalNumber3? BasisPointSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDecimalNumber3? BasisPointSpread { get; init; } 
    #else
    public CompareDecimalNumber3? BasisPointSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Data on amount and interest rates of the transaction.
    /// </summary>
    [IsoId("_sFf5MM3MEeuiU4QSC_BouQ")]
    [DisplayName("Margin Loan Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnLnAttr")]
    #endif
    [IsoXmlTag("MrgnLnAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareInterestRate1? MarginLoanAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareInterestRate1? MarginLoanAttribute { get; init; } 
    #else
    public CompareInterestRate1? MarginLoanAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8HcgxEeuGrNSsxk3B0A")]
    [DisplayName("Principal Amount Value Date Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmtValDtAmt")]
    #endif
    [IsoXmlTag("PrncplAmtValDtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountValueDateAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountValueDateAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountValueDateAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8H8gxEeuGrNSsxk3B0A")]
    [DisplayName("Principal Amount Maturity Date Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplAmtMtrtyDtAmt")]
    #endif
    [IsoXmlTag("PrncplAmtMtrtyDtAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountMaturityDateAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountMaturityDateAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountMaturityDateAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the asset type is matching or not.
    /// </summary>
    [IsoId("_9-J8IcgxEeuGrNSsxk3B0A")]
    [DisplayName("Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstTp")]
    #endif
    [IsoXmlTag("AsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityCommodity7Choice_? AssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityCommodity7Choice_? AssetType { get; init; } 
    #else
    public SecurityCommodity7Choice_? AssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8I8gxEeuGrNSsxk3B0A")]
    [DisplayName("Loan Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LnVal")]
    #endif
    [IsoXmlTag("LnVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount3? LoanValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount3? LoanValue { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount3? LoanValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_9-J8JcgxEeuGrNSsxk3B0A")]
    [DisplayName("Fixed Rebate Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FxdRbtRefRate")]
    #endif
    [IsoXmlTag("FxdRbtRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate3? FixedRebateReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate3? FixedRebateReferenceRate { get; init; } 
    #else
    public ComparePercentageRate3? FixedRebateReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_9-J8J8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Reference Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRefRate")]
    #endif
    [IsoXmlTag("FltgRbtRefRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCurveName3? FloatingRebateReferenceRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCurveName3? FloatingRebateReferenceRate { get; init; } 
    #else
    public CompareBenchmarkCurveName3? FloatingRebateReferenceRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8KcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Term Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateTermUnit")]
    #endif
    [IsoXmlTag("FltgRbtRateTermUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingRebateRateTermUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingRebateRateTermUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingRebateRateTermUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8K8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Term Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateTermVal")]
    #endif
    [IsoXmlTag("FltgRbtRateTermVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber6? FloatingRebateRateTermValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber6? FloatingRebateRateTermValue { get; init; } 
    #else
    public CompareNumber6? FloatingRebateRateTermValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8LcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRatePmtFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgRbtRatePmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingRebateRatePaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingRebateRatePaymentFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingRebateRatePaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8L8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRatePmtFrqcyVal")]
    #endif
    [IsoXmlTag("FltgRbtRatePmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber6? FloatingRebateRatePaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber6? FloatingRebateRatePaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber6? FloatingRebateRatePaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8McgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateRstFrqcyUnit")]
    #endif
    [IsoXmlTag("FltgRbtRateRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareRateBasis3? FloatingRebateRateResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareRateBasis3? FloatingRebateRateResetFrequencyUnit { get; init; } 
    #else
    public CompareRateBasis3? FloatingRebateRateResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8M8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRbtRateRstFrqcyVal")]
    #endif
    [IsoXmlTag("FltgRbtRateRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber6? FloatingRebateRateResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber6? FloatingRebateRateResetFrequencyValue { get; init; } 
    #else
    public CompareNumber6? FloatingRebateRateResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8NcgxEeuGrNSsxk3B0A")]
    [DisplayName("Rebate Rate Basis Point Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RbtRateBsisPtSprd")]
    #endif
    [IsoXmlTag("RbtRateBsisPtSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDecimalNumber3? RebateRateBasisPointSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDecimalNumber3? RebateRateBasisPointSpread { get; init; } 
    #else
    public CompareDecimalNumber3? RebateRateBasisPointSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as the adjusted rate are matching or not.
    /// </summary>
    [IsoId("_9-J8N8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rate Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRateAdjstmnt")]
    #endif
    [IsoXmlTag("FltgRateAdjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate3? FloatingRateAdjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate3? FloatingRateAdjustment { get; init; } 
    #else
    public ComparePercentageRate3? FloatingRateAdjustment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as the Rate Date are matching or not.
    /// </summary>
    [IsoId("_9-J8OcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rate Adjustment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FltgRateAdjstmntDt")]
    #endif
    [IsoXmlTag("FltgRateAdjstmntDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? FloatingRateAdjustmentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? FloatingRateAdjustmentDate { get; init; } 
    #else
    public CompareDate3? FloatingRateAdjustmentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_9-J8O8gxEeuGrNSsxk3B0A")]
    [DisplayName("Lending Fee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LndgFee")]
    #endif
    [IsoXmlTag("LndgFee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate3? LendingFee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate3? LendingFee { get; init; } 
    #else
    public ComparePercentageRate3? LendingFee { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8PcgxEeuGrNSsxk3B0A")]
    [DisplayName("Outstanding Margin Loan Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OutsdngMrgnLnAmt")]
    #endif
    [IsoXmlTag("OutsdngMrgnLnAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount3? OutstandingMarginLoanAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount3? OutstandingMarginLoanAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount3? OutstandingMarginLoanAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8P8gxEeuGrNSsxk3B0A")]
    [DisplayName("Short Market Value Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtMktValAmt")]
    #endif
    [IsoXmlTag("ShrtMktValAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount3? ShortMarketValueAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount3? ShortMarketValueAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount3? ShortMarketValueAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the values defined as transaction/position indicator are matching or not.
    /// </summary>
    [IsoId("_9-J8QcgxEeuGrNSsxk3B0A")]
    [DisplayName("Level Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LvlTp")]
    #endif
    [IsoXmlTag("LvlTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareReportingLevelType3? LevelType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareReportingLevelType3? LevelType { get; init; } 
    #else
    public CompareReportingLevelType3? LevelType { get; set; } 
    #endif
    
    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [IsoId("_9-J8Q8gxEeuGrNSsxk3B0A")]
    [DisplayName("Unit Of Measure")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitOfMeasr")]
    #endif
    [IsoXmlTag("UnitOfMeasr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitOfMeasure3? UnitOfMeasure { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitOfMeasure3? UnitOfMeasure { get; init; } 
    #else
    public CompareUnitOfMeasure3? UnitOfMeasure { get; set; } 
    #endif
    
    
    #nullable disable
    
}
