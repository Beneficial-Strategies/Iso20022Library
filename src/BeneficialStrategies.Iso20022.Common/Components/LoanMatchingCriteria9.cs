// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a loan.
/// </summary>
[IsoId("_98YaQcgxEeuGrNSsxk3B0A")]
[DisplayName("Loan Matching Criteria")]
public record LoanMatchingCriteria9
{
    /// <summary>
    /// Specifies whether the values for the Unique Trade Identifier (UTI) are matching or not.
    /// </summary>
    [IsoId("_9-J748gxEeuGrNSsxk3B0A")]
    [DisplayName("Unique Trade Identifier")]
    [IsoXmlTag("UnqTradIdr")]
    public CompareText2? UniqueTradeIdentifier { get; init; }

    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J75cgxEeuGrNSsxk3B0A")]
    [DisplayName("Termination Date")]
    [IsoXmlTag("TermntnDt")]
    public CompareDate3? TerminationDate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as exposure type are matching or not.
    /// </summary>
    [IsoId("_9-J758gxEeuGrNSsxk3B0A")]
    [DisplayName("Contract Type")]
    [IsoXmlTag("CtrctTp")]
    public CompareExposureType3? ContractType { get; init; }

    /// <summary>
    /// Specifies whether the information on contract clearing are matching or not.
    /// </summary>
    [IsoId("_9-J76cgxEeuGrNSsxk3B0A")]
    [DisplayName("Clearing Status")]
    [IsoXmlTag("ClrSts")]
    public CompareClearingStatus3? ClearingStatus { get; init; }

    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_9-J768gxEeuGrNSsxk3B0A")]
    [DisplayName("Clearing Date Time")]
    [IsoXmlTag("ClrDtTm")]
    public CompareDateTime3? ClearingDateTime { get; init; }

    /// <summary>
    /// Specifies whether the values defined as LEI identifier are matching or not.
    /// </summary>
    [IsoId("_9-J77cgxEeuGrNSsxk3B0A")]
    [DisplayName("CCP")]
    [IsoXmlTag("CCP")]
    public CompareOrganisationIdentification6? CCP { get; init; }

    /// <summary>
    /// Specifies whether the values defined as MIC (Market Identifier Code-ISO10383) identifier are matching or not.
    /// </summary>
    [IsoId("_9-J778gxEeuGrNSsxk3B0A")]
    [DisplayName("Trading Venue")]
    [IsoXmlTag("TradgVn")]
    public CompareMICIdentifier3? TradingVenue { get; init; }

    /// <summary>
    /// Specifies whether the information on master agreement type is matching or not.
    /// </summary>
    [IsoId("_9-J78cgxEeuGrNSsxk3B0A")]
    [DisplayName("Master Agreement Type")]
    [IsoXmlTag("MstrAgrmtTp")]
    public CompareAgreementType2? MasterAgreementType { get; init; }

    /// <summary>
    /// Specifies whether the values defined as ISO date and time are matching or not.
    /// </summary>
    [IsoId("_9-J788gxEeuGrNSsxk3B0A")]
    [DisplayName("Execution Date Time")]
    [IsoXmlTag("ExctnDtTm")]
    public CompareDateTime3? ExecutionDateTime { get; init; }

    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J79cgxEeuGrNSsxk3B0A")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    public CompareDate3? ValueDate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J798gxEeuGrNSsxk3B0A")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    public CompareDate3? MaturityDate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J7-cgxEeuGrNSsxk3B0A")]
    [DisplayName("Minimum Notice Period")]
    [IsoXmlTag("MinNtcePrd")]
    public CompareNumber5? MinimumNoticePeriod { get; init; }

    /// <summary>
    /// Specifies whether the values defined as ISO date are matching or not.
    /// </summary>
    [IsoId("_9-J7-8gxEeuGrNSsxk3B0A")]
    [DisplayName("Earliest Call Back Date")]
    [IsoXmlTag("EarlstCallBckDt")]
    public CompareDate3? EarliestCallBackDate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as type of collateral agreement are matching or not.
    /// </summary>
    [IsoId("_9-J7_cgxEeuGrNSsxk3B0A")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public CompareSpecialCollateral3? GeneralCollateral { get; init; }

    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_9-J7_8gxEeuGrNSsxk3B0A")]
    [DisplayName("Delivery By Value")]
    [IsoXmlTag("DlvryByVal")]
    public CompareTrueFalseIndicator3? DeliveryByValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as collateral delivery method are matching or not.
    /// </summary>
    [IsoId("_9-J8AcgxEeuGrNSsxk3B0A")]
    [DisplayName("Collateral Delivery Method")]
    [IsoXmlTag("CollDlvryMtd")]
    public CompareDeliveryMethod3? CollateralDeliveryMethod { get; init; }

    /// <summary>
    /// Specifies whether the values defined as true/false indicator are matching or not.
    /// </summary>
    [IsoId("_9-J8A8gxEeuGrNSsxk3B0A")]
    [DisplayName("Open Term")]
    [IsoXmlTag("OpnTerm")]
    public CompareTrueFalseIndicator3? OpenTerm { get; init; }

    /// <summary>
    /// Specifies whether the values defined as repo termination option are matching or not.
    /// </summary>
    [IsoId("_9-J8BcgxEeuGrNSsxk3B0A")]
    [DisplayName("Termination Option")]
    [IsoXmlTag("TermntnOptn")]
    public CompareTerminationOption3? TerminationOption { get; init; }

    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_9-J8B8gxEeuGrNSsxk3B0A")]
    [DisplayName("Fixed Interest Rate")]
    [IsoXmlTag("FxdIntrstRate")]
    public ComparePercentageRate3? FixedInterestRate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8CcgxEeuGrNSsxk3B0A")]
    [DisplayName("Day Count Basis")]
    [IsoXmlTag("DayCntBsis")]
    public CompareInterestComputationMethod3? DayCountBasis { get; init; }

    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_9-J8C8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Reference Rate")]
    [IsoXmlTag("FltgIntrstRefRate")]
    public CompareBenchmarkCurveName3? FloatingInterestReferenceRate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8DcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Term Unit")]
    [IsoXmlTag("FltgIntrstRateTermUnit")]
    public CompareRateBasis3? FloatingInterestRateTermUnit { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8D8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Term Value")]
    [IsoXmlTag("FltgIntrstRateTermVal")]
    public CompareNumber5? FloatingInterestRateTermValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8EcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Payment Frequency Unit")]
    [IsoXmlTag("FltgIntrstRatePmtFrqcyUnit")]
    public CompareRateBasis3? FloatingInterestRatePaymentFrequencyUnit { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8E8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Payment Frequency Value")]
    [IsoXmlTag("FltgIntrstRatePmtFrqcyVal")]
    public CompareNumber5? FloatingInterestRatePaymentFrequencyValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8FcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Reset Frequency Unit")]
    [IsoXmlTag("FltgIntrstRateRstFrqcyUnit")]
    public CompareRateBasis3? FloatingInterestRateResetFrequencyUnit { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8F8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Interest Rate Reset Frequency Value")]
    [IsoXmlTag("FltgIntrstRateRstFrqcyVal")]
    public CompareNumber6? FloatingInterestRateResetFrequencyValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8GcgxEeuGrNSsxk3B0A")]
    [DisplayName("Basis Point Spread")]
    [IsoXmlTag("BsisPtSprd")]
    public CompareDecimalNumber3? BasisPointSpread { get; init; }

    /// <summary>
    /// Data on amount and interest rates of the transaction.
    /// </summary>
    [IsoId("_sFf5MM3MEeuiU4QSC_BouQ")]
    [DisplayName("Margin Loan Attribute")]
    [IsoXmlTag("MrgnLnAttr")]
    public CompareInterestRate1? MarginLoanAttribute { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8HcgxEeuGrNSsxk3B0A")]
    [DisplayName("Principal Amount Value Date Amount")]
    [IsoXmlTag("PrncplAmtValDtAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountValueDateAmount { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8H8gxEeuGrNSsxk3B0A")]
    [DisplayName("Principal Amount Maturity Date Amount")]
    [IsoXmlTag("PrncplAmtMtrtyDtAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount3? PrincipalAmountMaturityDateAmount { get; init; }

    /// <summary>
    /// Specifies whether the information on the asset type is matching or not.
    /// </summary>
    [IsoId("_9-J8IcgxEeuGrNSsxk3B0A")]
    [DisplayName("Asset Type")]
    [IsoXmlTag("AsstTp")]
    public SecurityCommodity7Choice_? AssetType { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8I8gxEeuGrNSsxk3B0A")]
    [DisplayName("Loan Value")]
    [IsoXmlTag("LnVal")]
    public CompareActiveOrHistoricCurrencyAndAmount3? LoanValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_9-J8JcgxEeuGrNSsxk3B0A")]
    [DisplayName("Fixed Rebate Reference Rate")]
    [IsoXmlTag("FxdRbtRefRate")]
    public ComparePercentageRate3? FixedRebateReferenceRate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as benchmark curve name are matching or not.
    /// </summary>
    [IsoId("_9-J8J8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Reference Rate")]
    [IsoXmlTag("FltgRbtRefRate")]
    public CompareBenchmarkCurveName3? FloatingRebateReferenceRate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8KcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Term Unit")]
    [IsoXmlTag("FltgRbtRateTermUnit")]
    public CompareRateBasis3? FloatingRebateRateTermUnit { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8K8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Term Value")]
    [IsoXmlTag("FltgRbtRateTermVal")]
    public CompareNumber6? FloatingRebateRateTermValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8LcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Payment Frequency Unit")]
    [IsoXmlTag("FltgRbtRatePmtFrqcyUnit")]
    public CompareRateBasis3? FloatingRebateRatePaymentFrequencyUnit { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8L8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Payment Frequency Value")]
    [IsoXmlTag("FltgRbtRatePmtFrqcyVal")]
    public CompareNumber6? FloatingRebateRatePaymentFrequencyValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as rate basis code are matching or not.
    /// </summary>
    [IsoId("_9-J8McgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Reset Frequency Unit")]
    [IsoXmlTag("FltgRbtRateRstFrqcyUnit")]
    public CompareRateBasis3? FloatingRebateRateResetFrequencyUnit { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 3 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8M8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rebate Rate Reset Frequency Value")]
    [IsoXmlTag("FltgRbtRateRstFrqcyVal")]
    public CompareNumber6? FloatingRebateRateResetFrequencyValue { get; init; }

    /// <summary>
    /// Specifies whether the values defined as number with max 5 characters are matching or not.
    /// </summary>
    [IsoId("_9-J8NcgxEeuGrNSsxk3B0A")]
    [DisplayName("Rebate Rate Basis Point Spread")]
    [IsoXmlTag("RbtRateBsisPtSprd")]
    public CompareDecimalNumber3? RebateRateBasisPointSpread { get; init; }

    /// <summary>
    /// Specifies whether the values defined as the adjusted rate are matching or not.
    /// </summary>
    [IsoId("_9-J8N8gxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rate Adjustment")]
    [IsoXmlTag("FltgRateAdjstmnt")]
    public ComparePercentageRate3? FloatingRateAdjustment { get; init; }

    /// <summary>
    /// Specifies whether the values defined as the Rate Date are matching or not.
    /// </summary>
    [IsoId("_9-J8OcgxEeuGrNSsxk3B0A")]
    [DisplayName("Floating Rate Adjustment Date")]
    [IsoXmlTag("FltgRateAdjstmntDt")]
    public CompareDate3? FloatingRateAdjustmentDate { get; init; }

    /// <summary>
    /// Specifies whether the values defined as percentage rate are matching or not.
    /// </summary>
    [IsoId("_9-J8O8gxEeuGrNSsxk3B0A")]
    [DisplayName("Lending Fee")]
    [IsoXmlTag("LndgFee")]
    public ComparePercentageRate3? LendingFee { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8PcgxEeuGrNSsxk3B0A")]
    [DisplayName("Outstanding Margin Loan Amount")]
    [IsoXmlTag("OutsdngMrgnLnAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount3? OutstandingMarginLoanAmount { get; init; }

    /// <summary>
    /// Specifies whether the values defined as active or historic currency and amount are matching or not.
    /// </summary>
    [IsoId("_9-J8P8gxEeuGrNSsxk3B0A")]
    [DisplayName("Short Market Value Amount")]
    [IsoXmlTag("ShrtMktValAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount3? ShortMarketValueAmount { get; init; }

    /// <summary>
    /// Specifies whether the values defined as transaction/position indicator are matching or not.
    /// </summary>
    [IsoId("_9-J8QcgxEeuGrNSsxk3B0A")]
    [DisplayName("Level Type")]
    [IsoXmlTag("LvlTp")]
    public CompareReportingLevelType3? LevelType { get; init; }

    /// <summary>
    /// Unit of measure in which the quantity is expressed.
    /// </summary>
    [IsoId("_9-J8Q8gxEeuGrNSsxk3B0A")]
    [DisplayName("Unit Of Measure")]
    [IsoXmlTag("UnitOfMeasr")]
    public CompareUnitOfMeasure3? UnitOfMeasure { get; init; }
}
