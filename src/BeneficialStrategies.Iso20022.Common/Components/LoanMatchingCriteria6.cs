// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a loan.
/// </summary>
[IsoId("_DBFZsf_oEemm3skPVSMJQg")]
[DisplayName("Loan Matching Criteria")]
public partial record LoanMatchingCriteria6
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the values for the Unique Trade Identifier (UTI) are matching or not.
    /// </summary>
    [IsoId("_DEzcEf_oEemm3skPVSMJQg")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    public CompareText1? UniqueTradeIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcE__oEemm3skPVSMJQg")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public CompareDate2? TerminationDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as exposure type are matching or not.
    /// </summary>
    [IsoId("_DEzcFf_oEemm3skPVSMJQg")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public CompareExposureType2? ContractType { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on contract clearing are matching or not.
    /// </summary>
    [IsoId("_DEzcF__oEemm3skPVSMJQg")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public CompareClearingStatus2? ClearingStatus { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_DEzcGf_oEemm3skPVSMJQg")]
    [DisplayName("Clearing Date Time")]
    [IsoXmlTag("ClrDtTm")]
    public CompareDateTime2? ClearingDateTime { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    [IsoId("_DEzcG__oEemm3skPVSMJQg")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public CompareOrganisationIdentification1? CCP { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as MIC identifier are matching or not.
    /// </summary>
    [IsoId("_DEzcHf_oEemm3skPVSMJQg")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public CompareMICIdentifier2? TradingVenue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on master agreement type are matching or not.
    /// </summary>
    [IsoId("_DEzcH__oEemm3skPVSMJQg")]
    [DisplayName("Master Agreement Type")]
    [IsoXmlTag("MstrAgrmtTp")]
    public CompareAgreementType1? MasterAgreementType { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_DEzcIf_oEemm3skPVSMJQg")]
    [DisplayName("Executing Date Time")]
    [IsoXmlTag("ExctgDtTm")]
    public CompareDateTime2? ExecutingDateTime { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcI__oEemm3skPVSMJQg")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    public CompareDate2? StartDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcJf_oEemm3skPVSMJQg")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    public CompareDate2? EndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcJ__oEemm3skPVSMJQg")]
    [DisplayName("Minimum Notice Period")]
    [IsoXmlTag("MinNtcePrd")]
    public CompareNumber3? MinimumNoticePeriod { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_DEzcKf_oEemm3skPVSMJQg")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public CompareDate2? EarliestCallBackDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as type of collateral agreement are matching or not.
    /// </summary>
    [IsoId("_DEzcK__oEemm3skPVSMJQg")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public CompareSpecialCollateral2? GeneralCollateral { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_DEzcLf_oEemm3skPVSMJQg")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    public CompareTrueFalseIndicator2? DeliveryByValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as collateral delivery method are matching or not.
    /// </summary>
    [IsoId("_DEzcL__oEemm3skPVSMJQg")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CompareDeliveryMethod2? CollateralDeliveryMethod { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_DEzcMf_oEemm3skPVSMJQg")]
    [DisplayName("Open Term")]
    [IsoXmlTag("OpnTerm")]
    public CompareTrueFalseIndicator2? OpenTerm { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as repo termination option are matching or not.
    /// </summary>
    [IsoId("_DEzcM__oEemm3skPVSMJQg")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public CompareTerminationOption2? TerminationOption { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_DEzcNf_oEemm3skPVSMJQg")]
    [DisplayName("Fixed Interest Rate")]
    [IsoXmlTag("FxdIntrstRate")]
    public ComparePercentageRate2? FixedInterestRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcN__oEemm3skPVSMJQg")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public CompareInterestComputationMethod2? DayCountBasis { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_DEzcOf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Reference Rate")]
    [IsoXmlTag("FltgIntrstRefRate")]
    public CompareBenchmarkCurveName2? FloatingInterestReferenceRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcO__oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Term Unit")]
    [IsoXmlTag("FltgIntrstRateTermUnit")]
    public CompareRateBasis2? FloatingInterestRateTermUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcPf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Term Value")]
    [IsoXmlTag("FltgIntrstRateTermVal")]
    public CompareNumber3? FloatingInterestRateTermValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcP__oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Payment Frequency Unit")]
    [IsoXmlTag("FltgIntrstRatePmtFrqcyUnit")]
    public CompareRateBasis2? FloatingInterestRatePaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcQf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Payment Frequency Value")]
    [IsoXmlTag("FltgIntrstRatePmtFrqcyVal")]
    public CompareNumber3? FloatingInterestRatePaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcQ__oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Reset Frequency Unit")]
    [IsoXmlTag("FltgIntrstRateRstFrqcyUnit")]
    public CompareRateBasis2? FloatingInterestRateResetFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcRf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Interest Rate Reset Frequency Value")]
    [IsoXmlTag("FltgIntrstRateRstFrqcyVal")]
    public CompareNumber2? FloatingInterestRateResetFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcR__oEemm3skPVSMJQg")]
    [DisplayName("Interest Rate Basis Point Spread")]
    [IsoXmlTag("IntrstRateBsisPtSprd")]
    public CompareNumber2? InterestRateBasisPointSpread { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcSf_oEemm3skPVSMJQg")]
    [DisplayName("Margin Loan Amount")]
    [IsoXmlTag("MrgnLnAmt")]
    public CompareAmountAndDirection1? MarginLoanAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcS__oEemm3skPVSMJQg")]
    [DisplayName("Principal Amount Start Date Amount")]
    [IsoXmlTag("PrncplAmtStartDtAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountStartDateAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcTf_oEemm3skPVSMJQg")]
    [DisplayName("Principal Amount Maturity Date Amount")]
    [IsoXmlTag("PrncplAmtMtrtyDtAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount2? PrincipalAmountMaturityDateAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the infromation on the asset type is matching or not.
    /// </summary>
    [IsoId("_DEzcT__oEemm3skPVSMJQg")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public SecurityCommodity4? AssetType { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcUf_oEemm3skPVSMJQg")]
    [DisplayName("Loan Value")]
    [IsoXmlTag("LnVal")]
    public CompareActiveOrHistoricCurrencyAndAmount2? LoanValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_DEzcU__oEemm3skPVSMJQg")]
    [DisplayName("Fixed Rebate Reference Rate")]
    [IsoXmlTag("FxdRbtRefRate")]
    public ComparePercentageRate2? FixedRebateReferenceRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_DEzcVf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Reference Rate")]
    [IsoXmlTag("FltgRbtRefRate")]
    public CompareBenchmarkCurveName2? FloatingRebateReferenceRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcV__oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Term Unit")]
    [IsoXmlTag("FltgRbtRateTermUnit")]
    public CompareRateBasis2? FloatingRebateRateTermUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcWf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Term Value")]
    [IsoXmlTag("FltgRbtRateTermVal")]
    public CompareNumber2? FloatingRebateRateTermValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcW__oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Payment Frequency Unit")]
    [IsoXmlTag("FltgRbtRatePmtFrqcyUnit")]
    public CompareRateBasis2? FloatingRebateRatePaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcXf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Payment Frequency Value")]
    [IsoXmlTag("FltgRbtRatePmtFrqcyVal")]
    public CompareNumber2? FloatingRebateRatePaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_DEzcX__oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Reset Frequency Unit")]
    [IsoXmlTag("FltgRbtRateRstFrqcyUnit")]
    public CompareRateBasis2? FloatingRebateRateResetFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcYf_oEemm3skPVSMJQg")]
    [DisplayName("Floating Rebate Rate Reset Frequency Value")]
    [IsoXmlTag("FltgRbtRateRstFrqcyVal")]
    public CompareNumber2? FloatingRebateRateResetFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_DEzcY__oEemm3skPVSMJQg")]
    [DisplayName("Rebate Rate Basis Point Spread")]
    [IsoXmlTag("RbtRateBsisPtSprd")]
    public CompareNumber2? RebateRateBasisPointSpread { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as the adjusted rate are matching or not.
    /// </summary>
    [IsoId("_DEzcZf_oEemm3skPVSMJQg")]
    [DisplayName("Adjusted Rate")]
    [IsoXmlTag("AdjstdRate")]
    public ComparePercentageRate2? AdjustedRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as the Rate Date are matching or not.
    /// </summary>
    [IsoId("_DEzcZ__oEemm3skPVSMJQg")]
    [DisplayName("Adjustment Rate Date")]
    [IsoXmlTag("AdjstmntRateDt")]
    public CompareDate2? AdjustmentRateDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_DEzcaf_oEemm3skPVSMJQg")]
    [DisplayName("Lending Fee")]
    [IsoXmlTag("LndgFee")]
    public ComparePercentageRate2? LendingFee { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzca__oEemm3skPVSMJQg")]
    [DisplayName("Outstanding Loan")]
    [IsoXmlTag("OutsdngLn")]
    public CompareActiveOrHistoricCurrencyAndAmount2? OutstandingLoan { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_DEzcbf_oEemm3skPVSMJQg")]
    [DisplayName("Short Market Value")]
    [IsoXmlTag("ShrtMktVal")]
    public CompareActiveOrHistoricCurrencyAndAmount2? ShortMarketValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the values defined as transaction/position indicator are matching or not.
    /// </summary>
    [IsoId("_DEzcb__oEemm3skPVSMJQg")]
    [DisplayName("Level Type")]
    [IsoXmlTag("LvlTp")]
    public CompareReportingLevelType2? LevelType { get; init; } 
    
    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [IsoId("_DEzccf_oEemm3skPVSMJQg")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public CompareUnitOfMeasure2? UnitOfMeasure { get; init; } 
    
    
    #nullable disable
    
}
