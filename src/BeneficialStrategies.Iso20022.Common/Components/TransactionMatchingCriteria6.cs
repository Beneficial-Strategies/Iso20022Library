// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Compares information related to both sides of a transaction.
/// </summary>
[IsoId("_v_bxkVoyEe23K4GXSpBSeg")]
[DisplayName("Transaction Matching Criteria")]
public partial record TransactionMatchingCriteria6
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the reporting tracking numbers are matching or not.
    /// </summary>
    [IsoId("_wBBF8VoyEe23K4GXSpBSeg")]
    [DisplayName("Report Tracking Number")]
    [IsoXmlTag("RptTrckgNb")]
    public CompareText2? ReportTrackingNumber { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the Unique Transaction Identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBF81oyEe23K4GXSpBSeg")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public CompareUniqueTransactionIdentifier2? UniqueTransactionIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the Prior Unique Transaction Identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBF9VoyEe23K4GXSpBSeg")]
    [DisplayName("Prior Unique Transaction Identifier")]
    [IsoXmlTag("PrrUnqTxIdr")]
    public CompareUniqueTransactionIdentifier2? PriorUniqueTransactionIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the Subsequent Position Unique Transaction Identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBF91oyEe23K4GXSpBSeg")]
    [DisplayName("Subsequent Position Unique Transaction Identifier")]
    [IsoXmlTag("SbsqntPosUnqTxIdr")]
    public CompareUniqueTransactionIdentifier2? SubsequentPositionUniqueTransactionIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the delta are matching or not.
    /// </summary>
    [IsoId("_wBBF-VoyEe23K4GXSpBSeg")]
    [DisplayName("Delta")]
    [IsoXmlTag("Dlta")]
    public CompareLongFraction19DecimalNumber1? Delta { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the trade confirmations are matching or not.
    /// </summary>
    [IsoId("_wBBF-1oyEe23K4GXSpBSeg")]
    [DisplayName("Trade Confirmation")]
    [IsoXmlTag("TradConf")]
    public CompareTradeConfirmation2? TradeConfirmation { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the trade clearing obligations are matching or not.
    /// </summary>
    [IsoId("_wBBF_VoyEe23K4GXSpBSeg")]
    [DisplayName("Trade Clearing Obligation")]
    [IsoXmlTag("TradClrOblgtn")]
    public CompareTradeClearingObligation1? TradeClearingObligation { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the trade clearing statuses are matching or not.
    /// </summary>
    [IsoId("_wBBF_1oyEe23K4GXSpBSeg")]
    [DisplayName("Trade Clearing Status")]
    [IsoXmlTag("TradClrSts")]
    public CompareTradeClearingStatus3? TradeClearingStatus { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the master agreement types are matching or not.
    /// </summary>
    [IsoId("_wBBGAVoyEe23K4GXSpBSeg")]
    [DisplayName("Master Agreement Type")]
    [IsoXmlTag("MstrAgrmtTp")]
    public CompareMasterAgreementType1? MasterAgreementType { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the master agreement versions are matching or not.
    /// </summary>
    [IsoId("_wBBGA1oyEe23K4GXSpBSeg")]
    [DisplayName("Master Agreement Version")]
    [IsoXmlTag("MstrAgrmtVrsn")]
    public CompareMax50Text1? MasterAgreementVersion { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the intra groups are matching or not.
    /// </summary>
    [IsoId("_wBBGBVoyEe23K4GXSpBSeg")]
    [DisplayName("Intra Group")]
    [IsoXmlTag("IntraGrp")]
    public CompareTrueFalseIndicator3? IntraGroup { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the post trade risk reductions are matching or not.
    /// </summary>
    [IsoId("_wBBGB1oyEe23K4GXSpBSeg")]
    [DisplayName("Post Trade Risk Reduction")]
    [IsoXmlTag("PstTradRskRdctn")]
    public ComparePostTradeRiskReduction2? PostTradeRiskReduction { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the derivative event are matching or not.
    /// </summary>
    [IsoId("_wBBGCVoyEe23K4GXSpBSeg")]
    [DisplayName("Derivative Event")]
    [IsoXmlTag("DerivEvt")]
    public CompareDerivativeEvent1? DerivativeEvent { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the platform identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBGC1oyEe23K4GXSpBSeg")]
    [DisplayName("Platform Identifier")]
    [IsoXmlTag("PltfmIdr")]
    public CompareMICIdentifier3? PlatformIdentifier { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the execution time stamps are matching or not.
    /// </summary>
    [IsoId("_wBBGDVoyEe23K4GXSpBSeg")]
    [DisplayName("Execution Time Stamp")]
    [IsoXmlTag("ExctnTmStmp")]
    public CompareDateTime3? ExecutionTimeStamp { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGD1oyEe23K4GXSpBSeg")]
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public CompareDate3? EffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the expiration dates are matching or not.
    /// </summary>
    [IsoId("_wBBGEVoyEe23K4GXSpBSeg")]
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public CompareDate3? ExpirationDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the early termination dates are matching or not.
    /// </summary>
    [IsoId("_wBBGE1oyEe23K4GXSpBSeg")]
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    public CompareDate3? EarlyTerminationDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the settlement dates are matching or not.
    /// </summary>
    [IsoId("_wBBGFVoyEe23K4GXSpBSeg")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public CompareDate3? SettlementDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the delivery types are matching or not.
    /// </summary>
    [IsoId("_wBBGF1oyEe23K4GXSpBSeg")]
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public CompareDeliveryType1? DeliveryType { get; init; } 
    
    /// <summary>
    /// Specifies whether the the transaction prices are matching or not.
    /// </summary>
    [IsoId("_wBBGGVoyEe23K4GXSpBSeg")]
    [DisplayName("Transaction Price")]
    [IsoXmlTag("TxPric")]
    public CompareUnitPrice5? TransactionPrice { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGG1oyEe23K4GXSpBSeg")]
    [DisplayName("Price Schedule Unadjusted Effective Date")]
    [IsoXmlTag("PricSchdlUadjstdFctvDt")]
    public CompareDate3? PriceScheduleUnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGHVoyEe23K4GXSpBSeg")]
    [DisplayName("Price Schedule Unadjusted End Date")]
    [IsoXmlTag("PricSchdlUadjstdEndDt")]
    public CompareDate3? PriceScheduleUnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the transaction price in effect between the unadjusted effective and end date are matching or not.
    /// </summary>
    [IsoId("_wBBGH1oyEe23K4GXSpBSeg")]
    [DisplayName("Transaction Schedule Price")]
    [IsoXmlTag("TxSchdlPric")]
    public CompareUnitPrice5? TransactionSchedulePrice { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the package prices are matching or not.
    /// </summary>
    [IsoId("_wBBGIVoyEe23K4GXSpBSeg")]
    [DisplayName("Package Price")]
    [IsoXmlTag("PackgPric")]
    public CompareUnitPrice5? PackagePrice { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional amount first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGI1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg")]
    [IsoXmlTag("NtnlAmtFrstLeg")]
    public CompareAmountAndDirection3? NotionalAmountFirstLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGJVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlAmtFrstLegUadjstdFctvDt")]
    public CompareDate3? NotionalAmountFirstLegUnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGJ1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlAmtFrstLegUadjstdEndDt")]
    public CompareDate3? NotionalAmountFirstLegUnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional amount in effect on associated effective date of first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGKVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg Schedule Amount")]
    [IsoXmlTag("NtnlAmtFrstLegSchdlAmt")]
    public CompareAmountAndDirection3? NotionalAmountFirstLegScheduleAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional quantity first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGK1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg")]
    [IsoXmlTag("NtnlQtyFrstLeg")]
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGLVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlQtyFrstLegUadjstdFctvDt")]
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGL1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlQtyFrstLegUadjstdEndDt")]
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional quantity in effect on associated effective date of first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGMVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg Schedule Quantity")]
    [IsoXmlTag("NtnlQtyFrstLegSchdlQty")]
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLegScheduleQuantity { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional amount second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGM1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg")]
    [IsoXmlTag("NtnlAmtScndLeg")]
    public CompareNotionalAmount1? NotionalAmountSecondLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGNVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlAmtScndLegUadjstdFctvDt")]
    public CompareDate3? NotionalAmountSecondLegUnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGN1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlAmtScndLegUadjstdEndDt")]
    public CompareDate3? NotionalAmountSecondLegUnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional amount in effect on associated effective date of second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGOVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg Schedule Amount")]
    [IsoXmlTag("NtnlAmtScndLegSchdlAmt")]
    public CompareAmountAndDirection3? NotionalAmountSecondLegScheduleAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional quantity second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGO1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg")]
    [IsoXmlTag("NtnlQtyScndLeg")]
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGPVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlQtyScndLegUadjstdFctvDt")]
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGP1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlQtyScndLegUadjstdEndDt")]
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the notional quantity in effect on associated effective date of second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGQVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg Schedule Quantity")]
    [IsoXmlTag("NtnlQtyScndLegSchdlQty")]
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLegScheduleQuantity { get; init; } 
    
    /// <summary>
    /// Payment related to elements not reported in dedicated fields.
    /// </summary>
    [IsoId("_wBBGQ1oyEe23K4GXSpBSeg")]
    [DisplayName("Other Payment")]
    [IsoXmlTag("OthrPmt")]
    public CompareOtherPayment1? OtherPayment { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest fixed rate legs are matching or not.
    /// </summary>
    [IsoId("_wBBGRVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg")]
    [IsoXmlTag("IntrstFxdRateFrstLeg")]
    public CompareUnitPrice7? InterestFixedRateFirstLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGR1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg Day Count")]
    [IsoXmlTag("IntrstFxdRateFrstLegDayCnt")]
    public CompareDayCount1? InterestFixedRateFirstLegDayCount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGSVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFxdRateFrstLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFixedRateFirstLegPaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGS1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFxdRateFrstLegPmtFrqcyVal")]
    public CompareNumber5? InterestFixedRateFirstLegPaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBGTVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Identification")]
    [IsoXmlTag("IntrstFltgRateFrstLegId")]
    public CompareISINIdentifier4? InterestFloatingRateFirstLegIdentification { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate codes are matching or not.
    /// </summary>
    [IsoId("_wBBGT1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Code")]
    [IsoXmlTag("IntrstFltgRateFrstLegCd")]
    public CompareBenchmarkCode1? InterestFloatingRateFirstLegCode { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate names are matching or not.
    /// </summary>
    [IsoId("_wBBGUVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Name")]
    [IsoXmlTag("IntrstFltgRateFrstLegNm")]
    public CompareMax350Text1? InterestFloatingRateFirstLegName { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGU1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Day Count")]
    [IsoXmlTag("IntrstFltgRateFrstLegDayCnt")]
    public CompareDayCount1? InterestFloatingRateFirstLegDayCount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGVVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateFrstLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegPaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGV1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFltgRateFrstLegPmtFrqcyVal")]
    public CompareNumber5? InterestFloatingRateFirstLegPaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reference period units are matching or not.
    /// </summary>
    [IsoId("_wBBGWVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reference Period Unit")]
    [IsoXmlTag("IntrstFltgRateFrstLegRefPrdUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegReferencePeriodUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reference period values are matching or not.
    /// </summary>
    [IsoId("_wBBGW1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reference Period Value")]
    [IsoXmlTag("IntrstFltgRateFrstLegRefPrdVal")]
    public CompareNumber5? InterestFloatingRateFirstLegReferencePeriodValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reset frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGXVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reset Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateFrstLegRstFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegResetFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reset frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGX1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reset Frequency Value")]
    [IsoXmlTag("IntrstFltgRateFrstLegRstFrqcyVal")]
    public CompareNumber5? InterestFloatingRateFirstLegResetFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the spreads are matching or not.
    /// </summary>
    [IsoId("_wBBGYVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Spread")]
    [IsoXmlTag("IntrstFltgRateFrstLegSprd")]
    public CompareUnitPrice8? InterestFloatingRateFirstLegSpread { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest fixed rate legs are matching or not.
    /// </summary>
    [IsoId("_wBBGY1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Rate Fixed Second Leg")]
    [IsoXmlTag("IntrstRateFxdScndLeg")]
    public CompareUnitPrice7? InterestRateFixedSecondLeg { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGZVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate Second Leg Day Count")]
    [IsoXmlTag("IntrstFxdRateScndLegDayCnt")]
    public CompareDayCount1? InterestFixedRateSecondLegDayCount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGZ1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate Second Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFxdRateScndLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFixedRateSecondLegPaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGaVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate Second Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFxdRateScndLegPmtFrqcyVal")]
    public CompareNumber5? InterestFixedRateSecondLegPaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBGa1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Identification")]
    [IsoXmlTag("IntrstFltgRateScndLegId")]
    public CompareISINIdentifier4? InterestFloatingRateSecondLegIdentification { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate codes are matching or not.
    /// </summary>
    [IsoId("_wBBGbVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Code")]
    [IsoXmlTag("IntrstFltgRateScndLegCd")]
    public CompareBenchmarkCode1? InterestFloatingRateSecondLegCode { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate names are matching or not.
    /// </summary>
    [IsoId("_wBBGb1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Name")]
    [IsoXmlTag("IntrstFltgRateScndLegNm")]
    public CompareMax350Text1? InterestFloatingRateSecondLegName { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGcVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Day Count")]
    [IsoXmlTag("IntrstFltgRateScndLegDayCnt")]
    public CompareDayCount1? InterestFloatingRateSecondLegDayCount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGc1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateScndLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegPaymentFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGdVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFltgRateScndLegPmtFrqcyVal")]
    public CompareNumber5? InterestFloatingRateSecondLegPaymentFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reference period units are matching or not.
    /// </summary>
    [IsoId("_wBBGd1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reference Period Unit")]
    [IsoXmlTag("IntrstFltgRateScndLegRefPrdUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegReferencePeriodUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reference period values are matching or not.
    /// </summary>
    [IsoId("_wBBGeVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reference Period Value")]
    [IsoXmlTag("IntrstFltgRateScndLegRefPrdVal")]
    public CompareNumber5? InterestFloatingRateSecondLegReferencePeriodValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reset frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGe1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reset Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateScndLegRstFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegResetFrequencyUnit { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the reset frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGfVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reset Frequency Value")]
    [IsoXmlTag("IntrstFltgRateScndLegRstFrqcyVal")]
    public CompareNumber5? InterestFloatingRateSecondLegResetFrequencyValue { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the spreads are matching or not.
    /// </summary>
    [IsoId("_wBBGf1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Spread")]
    [IsoXmlTag("IntrstFltgRateScndLegSprd")]
    public CompareUnitPrice8? InterestFloatingRateSecondLegSpread { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the package spreads are matching or not.
    /// </summary>
    [IsoId("_wBBGgVoyEe23K4GXSpBSeg")]
    [DisplayName("Package Spread")]
    [IsoXmlTag("PackgSprd")]
    public CompareUnitPrice8? PackageSpread { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the currency exchange rates are matching or not.
    /// </summary>
    [IsoId("_wBBGg1oyEe23K4GXSpBSeg")]
    [DisplayName("Currency Exchange Rate")]
    [IsoXmlTag("CcyXchgRate")]
    public CompareExchangeRate1? CurrencyExchangeRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the forward currency exchange rates are matching or not.
    /// </summary>
    [IsoId("_wBBGhVoyEe23K4GXSpBSeg")]
    [DisplayName("Currency Forward Exchange Rate")]
    [IsoXmlTag("CcyFwdXchgRate")]
    public CompareExchangeRate1? CurrencyForwardExchangeRate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the currency exchange rate basis are matching or not.
    /// </summary>
    [IsoId("_wBBGh1oyEe23K4GXSpBSeg")]
    [DisplayName("Currency Exchange Rate Basis")]
    [IsoXmlTag("CcyXchgRateBsis")]
    public CompareExchangeRateBasis1? CurrencyExchangeRateBasis { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the commodities are matching or not.
    /// </summary>
    [IsoId("_wBBGiVoyEe23K4GXSpBSeg")]
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public CompareCommodityAssetClass4? Commodity { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the delivery points or zones are matching or not.
    /// </summary>
    [IsoId("_wBBGi1oyEe23K4GXSpBSeg")]
    [DisplayName("Energy Delivery Point Or Zone")]
    [IsoXmlTag("NrgyDlvryPtOrZone")]
    public CompareDeliveryInterconnectionPoint1? EnergyDeliveryPointOrZone { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the interconnection points are matching or not.
    /// </summary>
    [IsoId("_wBBGjVoyEe23K4GXSpBSeg")]
    [DisplayName("Energy Inter Connection Point")]
    [IsoXmlTag("NrgyIntrCnnctnPt")]
    public CompareDeliveryInterconnectionPoint1? EnergyInterConnectionPoint { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the load types are matching or not.
    /// </summary>
    [IsoId("_wBBGj1oyEe23K4GXSpBSeg")]
    [DisplayName("Energy Load Type")]
    [IsoXmlTag("NrgyLdTp")]
    public CompareEnergyLoadType1? EnergyLoadType { get; init; } 
    
    /// <summary>
    /// Attributes related to delivery of derivative contracts.
    /// </summary>
    [IsoId("_wBBGkVoyEe23K4GXSpBSeg")]
    [DisplayName("Delivery Attribute")]
    [IsoXmlTag("DlvryAttr")]
    public CompareEnergyDeliveryAttribute1? DeliveryAttribute { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the option types are matching or not.
    /// </summary>
    [IsoId("_wBBGk1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CompareOptionType1? OptionType { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the exercise styles are matching or not.
    /// </summary>
    [IsoId("_wBBGlVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Exercise Style")]
    [IsoXmlTag("OptnExrcStyle")]
    public CompareOptionStyle1? OptionExerciseStyle { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the strike prices are matching or not.
    /// </summary>
    [IsoId("_wBBGl1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price")]
    [IsoXmlTag("OptnStrkPric")]
    public CompareUnitPrice4? OptionStrikePrice { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGmVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price Schedule Unadjusted Effective Date")]
    [IsoXmlTag("OptnStrkPricSchdlUadjstdFctvDt")]
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEffectiveDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGm1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price Schedule Unadjusted End Date")]
    [IsoXmlTag("OptnStrkPricSchdlUadjstdEndDt")]
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEndDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the strike price in effect on associated effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGnVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price Schedule Amount")]
    [IsoXmlTag("OptnStrkPricSchdlAmt")]
    public CompareUnitPrice4? OptionStrikePriceScheduleAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the premium amounts are matching or not.
    /// </summary>
    [IsoId("_wBBGn1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Premium Amount")]
    [IsoXmlTag("OptnPrmAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount4? OptionPremiumAmount { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the premium payment dates are matching or not.
    /// </summary>
    [IsoId("_wBBGoVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Premium Payment Date")]
    [IsoXmlTag("OptnPrmPmtDt")]
    public CompareDate3? OptionPremiumPaymentDate { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the maturity date of the underlying are matching or not.
    /// </summary>
    [IsoId("_wBBGo1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Maturity Date Of Underlying")]
    [IsoXmlTag("OptnMtrtyDtOfUndrlyg")]
    public CompareDate3? OptionMaturityDateOfUnderlying { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the credity seniority are matching or not.
    /// </summary>
    [IsoId("_wBBGpVoyEe23K4GXSpBSeg")]
    [DisplayName("Credit Seniority")]
    [IsoXmlTag("CdtSnrty")]
    public CompareSeniorityType1? CreditSeniority { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the credit reference parties are matching or not.
    /// </summary>
    [IsoId("_wBBGp1oyEe23K4GXSpBSeg")]
    [DisplayName("Credit Reference Party")]
    [IsoXmlTag("CdtRefPty")]
    public CompareReferenceParty1? CreditReferenceParty { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the credit series are matching or not.
    /// </summary>
    [IsoId("_wBBGqVoyEe23K4GXSpBSeg")]
    [DisplayName("Credit Series")]
    [IsoXmlTag("CdtSrs")]
    public CompareNumber7? CreditSeries { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the credit versions are matching or not.
    /// </summary>
    [IsoId("_wBBGq1oyEe23K4GXSpBSeg")]
    [DisplayName("Credit Version")]
    [IsoXmlTag("CdtVrsn")]
    public CompareNumber7? CreditVersion { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the index factors are matching or not.
    /// </summary>
    [IsoId("_wBBGrVoyEe23K4GXSpBSeg")]
    [DisplayName("Credit Index Factor")]
    [IsoXmlTag("CdtIndxFctr")]
    public ComparePercentageRate3? CreditIndexFactor { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the credit tranches are matching or not.
    /// </summary>
    [IsoId("_wBBGr1oyEe23K4GXSpBSeg")]
    [DisplayName("Credit Tranche")]
    [IsoXmlTag("CdtTrch")]
    public CompareTrancheIndicator1? CreditTranche { get; init; } 
    
    /// <summary>
    /// Specifies whether the information on the levels are matching or not.
    /// </summary>
    [IsoId("_wBBGsVoyEe23K4GXSpBSeg")]
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public CompareReportingLevelType2? Level { get; init; } 
    
    
    #nullable disable
    
}
