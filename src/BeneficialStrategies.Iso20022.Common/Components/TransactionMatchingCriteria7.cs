// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Matching Criteria7.
/// </summary>
[IsoId("_BWq7d5BIEe6Ojt1b3tfu9Q")]
[DisplayName("Transaction Matching Criteria7")]
public partial record TransactionMatchingCriteria7
{
    #nullable enable

    /// <summary>
    /// Commodity.
    /// </summary>
    [DisplayName("Commodity")]
    [IsoXmlTag("Cmmdty")]
    public CompareCommodityAssetClass4? Commodity { get; init; } 

    /// <summary>
    /// Credit Index Factor.
    /// </summary>
    [DisplayName("Credit Index Factor")]
    [IsoXmlTag("CdtIndxFctr")]
    public ComparePercentageRate3? CreditIndexFactor { get; init; } 

    /// <summary>
    /// Credit Reference Party.
    /// </summary>
    [DisplayName("Credit Reference Party")]
    [IsoXmlTag("CdtRefPty")]
    public CompareReferenceParty1? CreditReferenceParty { get; init; } 

    /// <summary>
    /// Credit Seniority.
    /// </summary>
    [DisplayName("Credit Seniority")]
    [IsoXmlTag("CdtSnrty")]
    public CompareSeniorityType1? CreditSeniority { get; init; } 

    /// <summary>
    /// Credit Series.
    /// </summary>
    [DisplayName("Credit Series")]
    [IsoXmlTag("CdtSrs")]
    public CompareNumber7? CreditSeries { get; init; } 

    /// <summary>
    /// Credit Tranche.
    /// </summary>
    [DisplayName("Credit Tranche")]
    [IsoXmlTag("CdtTrch")]
    public CompareTrancheIndicator1? CreditTranche { get; init; } 

    /// <summary>
    /// Credit Version.
    /// </summary>
    [DisplayName("Credit Version")]
    [IsoXmlTag("CdtVrsn")]
    public CompareNumber7? CreditVersion { get; init; } 

    /// <summary>
    /// Currency Exchange Rate.
    /// </summary>
    [DisplayName("Currency Exchange Rate")]
    [IsoXmlTag("CcyXchgRate")]
    public CompareExchangeRate1? CurrencyExchangeRate { get; init; } 

    /// <summary>
    /// Currency Exchange Rate Basis.
    /// </summary>
    [DisplayName("Currency Exchange Rate Basis")]
    [IsoXmlTag("CcyXchgRateBsis")]
    public CompareExchangeRateBasis1? CurrencyExchangeRateBasis { get; init; } 

    /// <summary>
    /// Currency Forward Exchange Rate.
    /// </summary>
    [DisplayName("Currency Forward Exchange Rate")]
    [IsoXmlTag("CcyFwdXchgRate")]
    public CompareExchangeRate1? CurrencyForwardExchangeRate { get; init; } 

    /// <summary>
    /// Delivery Attribute.
    /// </summary>
    [DisplayName("Delivery Attribute")]
    [IsoXmlTag("DlvryAttr")]
    public ValueList<CompareEnergyDeliveryAttribute1> DeliveryAttribute { get; init; } = [];

    /// <summary>
    /// Delivery Type.
    /// </summary>
    [DisplayName("Delivery Type")]
    [IsoXmlTag("DlvryTp")]
    public CompareDeliveryType1? DeliveryType { get; init; } 

    /// <summary>
    /// Delta.
    /// </summary>
    [DisplayName("Delta")]
    [IsoXmlTag("Dlta")]
    public CompareLongFraction19DecimalNumber1? Delta { get; init; } 

    /// <summary>
    /// Derivative Event.
    /// </summary>
    [DisplayName("Derivative Event")]
    [IsoXmlTag("DerivEvt")]
    public CompareDerivativeEvent1? DerivativeEvent { get; init; } 

    /// <summary>
    /// Early Termination Date.
    /// </summary>
    [DisplayName("Early Termination Date")]
    [IsoXmlTag("EarlyTermntnDt")]
    public CompareDate3? EarlyTerminationDate { get; init; } 

    /// <summary>
    /// Effective Date.
    /// </summary>
    [DisplayName("Effective Date")]
    [IsoXmlTag("FctvDt")]
    public CompareDate3? EffectiveDate { get; init; } 

    /// <summary>
    /// Energy Delivery Point Or Zone.
    /// </summary>
    [DisplayName("Energy Delivery Point Or Zone")]
    [IsoXmlTag("NrgyDlvryPtOrZone")]
    public ValueList<CompareDeliveryInterconnectionPoint1> EnergyDeliveryPointOrZone { get; init; } = [];

    /// <summary>
    /// Energy Inter Connection Point.
    /// </summary>
    [DisplayName("Energy Inter Connection Point")]
    [IsoXmlTag("NrgyIntrCnnctnPt")]
    public CompareDeliveryInterconnectionPoint1? EnergyInterConnectionPoint { get; init; } 

    /// <summary>
    /// Energy Load Type.
    /// </summary>
    [DisplayName("Energy Load Type")]
    [IsoXmlTag("NrgyLdTp")]
    public CompareEnergyLoadType1? EnergyLoadType { get; init; } 

    /// <summary>
    /// Execution Time Stamp.
    /// </summary>
    [DisplayName("Execution Time Stamp")]
    [IsoXmlTag("ExctnTmStmp")]
    public CompareDateTime3? ExecutionTimeStamp { get; init; } 

    /// <summary>
    /// Expiration Date.
    /// </summary>
    [DisplayName("Expiration Date")]
    [IsoXmlTag("XprtnDt")]
    public CompareDate3? ExpirationDate { get; init; } 

    /// <summary>
    /// Interest Fixed Rate First Leg.
    /// </summary>
    [DisplayName("Interest Fixed Rate First Leg")]
    [IsoXmlTag("IntrstFxdRateFrstLeg")]
    public CompareUnitPrice7? InterestFixedRateFirstLeg { get; init; } 

    /// <summary>
    /// Interest Fixed Rate First Leg Day Count.
    /// </summary>
    [DisplayName("Interest Fixed Rate First Leg Day Count")]
    [IsoXmlTag("IntrstFxdRateFrstLegDayCnt")]
    public CompareDayCount1? InterestFixedRateFirstLegDayCount { get; init; } 

    /// <summary>
    /// Interest Fixed Rate First Leg Payment Frequency Unit.
    /// </summary>
    [DisplayName("Interest Fixed Rate First Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFxdRateFrstLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFixedRateFirstLegPaymentFrequencyUnit { get; init; } 

    /// <summary>
    /// Interest Fixed Rate First Leg Payment Frequency Value.
    /// </summary>
    [DisplayName("Interest Fixed Rate First Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFxdRateFrstLegPmtFrqcyVal")]
    public CompareNumber5? InterestFixedRateFirstLegPaymentFrequencyValue { get; init; } 

    /// <summary>
    /// Interest Fixed Rate Second Leg Day Count.
    /// </summary>
    [DisplayName("Interest Fixed Rate Second Leg Day Count")]
    [IsoXmlTag("IntrstFxdRateScndLegDayCnt")]
    public CompareDayCount1? InterestFixedRateSecondLegDayCount { get; init; } 

    /// <summary>
    /// Interest Fixed Rate Second Leg Payment Frequency Unit.
    /// </summary>
    [DisplayName("Interest Fixed Rate Second Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFxdRateScndLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFixedRateSecondLegPaymentFrequencyUnit { get; init; } 

    /// <summary>
    /// Interest Fixed Rate Second Leg Payment Frequency Value.
    /// </summary>
    [DisplayName("Interest Fixed Rate Second Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFxdRateScndLegPmtFrqcyVal")]
    public CompareNumber5? InterestFixedRateSecondLegPaymentFrequencyValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Code.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Code")]
    [IsoXmlTag("IntrstFltgRateFrstLegCd")]
    public CompareBenchmarkCode1? InterestFloatingRateFirstLegCode { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Day Count.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Day Count")]
    [IsoXmlTag("IntrstFltgRateFrstLegDayCnt")]
    public CompareDayCount1? InterestFloatingRateFirstLegDayCount { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Identification.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Identification")]
    [IsoXmlTag("IntrstFltgRateFrstLegId")]
    public CompareISINIdentifier4? InterestFloatingRateFirstLegIdentification { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Name.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Name")]
    [IsoXmlTag("IntrstFltgRateFrstLegNm")]
    public CompareMax350Text1? InterestFloatingRateFirstLegName { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Payment Frequency Unit.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateFrstLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegPaymentFrequencyUnit { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Payment Frequency Value.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFltgRateFrstLegPmtFrqcyVal")]
    public CompareNumber5? InterestFloatingRateFirstLegPaymentFrequencyValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Reference Period Unit.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Reference Period Unit")]
    [IsoXmlTag("IntrstFltgRateFrstLegRefPrdUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegReferencePeriodUnit { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Reference Period Value.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Reference Period Value")]
    [IsoXmlTag("IntrstFltgRateFrstLegRefPrdVal")]
    public CompareNumber5? InterestFloatingRateFirstLegReferencePeriodValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Reset Frequency Unit.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Reset Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateFrstLegRstFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegResetFrequencyUnit { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Reset Frequency Value.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Reset Frequency Value")]
    [IsoXmlTag("IntrstFltgRateFrstLegRstFrqcyVal")]
    public CompareNumber5? InterestFloatingRateFirstLegResetFrequencyValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate First Leg Spread.
    /// </summary>
    [DisplayName("Interest Floating Rate First Leg Spread")]
    [IsoXmlTag("IntrstFltgRateFrstLegSprd")]
    public CompareUnitPrice8? InterestFloatingRateFirstLegSpread { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Code.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Code")]
    [IsoXmlTag("IntrstFltgRateScndLegCd")]
    public CompareBenchmarkCode1? InterestFloatingRateSecondLegCode { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Day Count.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Day Count")]
    [IsoXmlTag("IntrstFltgRateScndLegDayCnt")]
    public CompareDayCount1? InterestFloatingRateSecondLegDayCount { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Identification.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Identification")]
    [IsoXmlTag("IntrstFltgRateScndLegId")]
    public CompareISINIdentifier4? InterestFloatingRateSecondLegIdentification { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Name.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Name")]
    [IsoXmlTag("IntrstFltgRateScndLegNm")]
    public CompareMax350Text1? InterestFloatingRateSecondLegName { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Payment Frequency Unit.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Payment Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateScndLegPmtFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegPaymentFrequencyUnit { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Payment Frequency Value.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Payment Frequency Value")]
    [IsoXmlTag("IntrstFltgRateScndLegPmtFrqcyVal")]
    public CompareNumber5? InterestFloatingRateSecondLegPaymentFrequencyValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Reference Period Unit.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Reference Period Unit")]
    [IsoXmlTag("IntrstFltgRateScndLegRefPrdUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegReferencePeriodUnit { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Reference Period Value.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Reference Period Value")]
    [IsoXmlTag("IntrstFltgRateScndLegRefPrdVal")]
    public CompareNumber5? InterestFloatingRateSecondLegReferencePeriodValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Reset Frequency Unit.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Reset Frequency Unit")]
    [IsoXmlTag("IntrstFltgRateScndLegRstFrqcyUnit")]
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegResetFrequencyUnit { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Reset Frequency Value.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Reset Frequency Value")]
    [IsoXmlTag("IntrstFltgRateScndLegRstFrqcyVal")]
    public CompareNumber5? InterestFloatingRateSecondLegResetFrequencyValue { get; init; } 

    /// <summary>
    /// Interest Floating Rate Second Leg Spread.
    /// </summary>
    [DisplayName("Interest Floating Rate Second Leg Spread")]
    [IsoXmlTag("IntrstFltgRateScndLegSprd")]
    public CompareUnitPrice8? InterestFloatingRateSecondLegSpread { get; init; } 

    /// <summary>
    /// Interest Rate Fixed Second Leg.
    /// </summary>
    [DisplayName("Interest Rate Fixed Second Leg")]
    [IsoXmlTag("IntrstRateFxdScndLeg")]
    public CompareUnitPrice7? InterestRateFixedSecondLeg { get; init; } 

    /// <summary>
    /// Intra Group.
    /// </summary>
    [DisplayName("Intra Group")]
    [IsoXmlTag("IntraGrp")]
    public CompareTrueFalseIndicator3? IntraGroup { get; init; } 

    /// <summary>
    /// Level.
    /// </summary>
    [DisplayName("Level")]
    [IsoXmlTag("Lvl")]
    public CompareReportingLevelType2? Level { get; init; } 

    /// <summary>
    /// Master Agreement Type.
    /// </summary>
    [DisplayName("Master Agreement Type")]
    [IsoXmlTag("MstrAgrmtTp")]
    public CompareMasterAgreementType1? MasterAgreementType { get; init; } 

    /// <summary>
    /// Master Agreement Version.
    /// </summary>
    [DisplayName("Master Agreement Version")]
    [IsoXmlTag("MstrAgrmtVrsn")]
    public CompareMax50Text1? MasterAgreementVersion { get; init; } 

    /// <summary>
    /// Notional Amount First Leg.
    /// </summary>
    [DisplayName("Notional Amount First Leg")]
    [IsoXmlTag("NtnlAmtFrstLeg")]
    public CompareAmountAndDirection3? NotionalAmountFirstLeg { get; init; } 

    /// <summary>
    /// Notional Amount First Leg Schedule Amount.
    /// </summary>
    [DisplayName("Notional Amount First Leg Schedule Amount")]
    [IsoXmlTag("NtnlAmtFrstLegSchdlAmt")]
    public ValueList<CompareAmountAndDirection3> NotionalAmountFirstLegScheduleAmount { get; init; } = [];

    /// <summary>
    /// Notional Amount First Leg Unadjusted Effective Date.
    /// </summary>
    [DisplayName("Notional Amount First Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlAmtFrstLegUadjstdFctvDt")]
    public ValueList<CompareDate3> NotionalAmountFirstLegUnadjustedEffectiveDate { get; init; } = [];

    /// <summary>
    /// Notional Amount First Leg Unadjusted End Date.
    /// </summary>
    [DisplayName("Notional Amount First Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlAmtFrstLegUadjstdEndDt")]
    public ValueList<CompareDate3> NotionalAmountFirstLegUnadjustedEndDate { get; init; } = [];

    /// <summary>
    /// Notional Amount Second Leg.
    /// </summary>
    [DisplayName("Notional Amount Second Leg")]
    [IsoXmlTag("NtnlAmtScndLeg")]
    public CompareAmountAndDirection3? NotionalAmountSecondLeg { get; init; } 

    /// <summary>
    /// Notional Amount Second Leg Schedule Amount.
    /// </summary>
    [DisplayName("Notional Amount Second Leg Schedule Amount")]
    [IsoXmlTag("NtnlAmtScndLegSchdlAmt")]
    public ValueList<CompareAmountAndDirection3> NotionalAmountSecondLegScheduleAmount { get; init; } = [];

    /// <summary>
    /// Notional Amount Second Leg Unadjusted Effective Date.
    /// </summary>
    [DisplayName("Notional Amount Second Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlAmtScndLegUadjstdFctvDt")]
    public ValueList<CompareDate3> NotionalAmountSecondLegUnadjustedEffectiveDate { get; init; } = [];

    /// <summary>
    /// Notional Amount Second Leg Unadjusted End Date.
    /// </summary>
    [DisplayName("Notional Amount Second Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlAmtScndLegUadjstdEndDt")]
    public ValueList<CompareDate3> NotionalAmountSecondLegUnadjustedEndDate { get; init; } = [];

    /// <summary>
    /// Notional Quantity First Leg.
    /// </summary>
    [DisplayName("Notional Quantity First Leg")]
    [IsoXmlTag("NtnlQtyFrstLeg")]
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLeg { get; init; } 

    /// <summary>
    /// Notional Quantity First Leg Schedule Quantity.
    /// </summary>
    [DisplayName("Notional Quantity First Leg Schedule Quantity")]
    [IsoXmlTag("NtnlQtyFrstLegSchdlQty")]
    public ValueList<CompareLongFraction19DecimalNumber1> NotionalQuantityFirstLegScheduleQuantity { get; init; } = [];

    /// <summary>
    /// Notional Quantity First Leg Unadjusted Effective Date.
    /// </summary>
    [DisplayName("Notional Quantity First Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlQtyFrstLegUadjstdFctvDt")]
    public ValueList<CompareDate3> NotionalQuantityFirstLegUnadjustedEffectiveDate { get; init; } = [];

    /// <summary>
    /// Notional Quantity First Leg Unadjusted End Date.
    /// </summary>
    [DisplayName("Notional Quantity First Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlQtyFrstLegUadjstdEndDt")]
    public ValueList<CompareDate3> NotionalQuantityFirstLegUnadjustedEndDate { get; init; } = [];

    /// <summary>
    /// Notional Quantity Second Leg.
    /// </summary>
    [DisplayName("Notional Quantity Second Leg")]
    [IsoXmlTag("NtnlQtyScndLeg")]
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLeg { get; init; } 

    /// <summary>
    /// Notional Quantity Second Leg Schedule Quantity.
    /// </summary>
    [DisplayName("Notional Quantity Second Leg Schedule Quantity")]
    [IsoXmlTag("NtnlQtyScndLegSchdlQty")]
    public ValueList<CompareLongFraction19DecimalNumber1> NotionalQuantitySecondLegScheduleQuantity { get; init; } = [];

    /// <summary>
    /// Notional Quantity Second Leg Unadjusted Effective Date.
    /// </summary>
    [DisplayName("Notional Quantity Second Leg Unadjusted Effective Date")]
    [IsoXmlTag("NtnlQtyScndLegUadjstdFctvDt")]
    public ValueList<CompareDate3> NotionalQuantitySecondLegUnadjustedEffectiveDate { get; init; } = [];

    /// <summary>
    /// Notional Quantity Second Leg Unadjusted End Date.
    /// </summary>
    [DisplayName("Notional Quantity Second Leg Unadjusted End Date")]
    [IsoXmlTag("NtnlQtyScndLegUadjstdEndDt")]
    public ValueList<CompareDate3> NotionalQuantitySecondLegUnadjustedEndDate { get; init; } = [];

    /// <summary>
    /// Option Exercise Style.
    /// </summary>
    [DisplayName("Option Exercise Style")]
    [IsoXmlTag("OptnExrcStyle")]
    public ValueList<CompareOptionStyle1> OptionExerciseStyle { get; init; } = [];

    /// <summary>
    /// Option Maturity Date Of Underlying.
    /// </summary>
    [DisplayName("Option Maturity Date Of Underlying")]
    [IsoXmlTag("OptnMtrtyDtOfUndrlyg")]
    public CompareDate3? OptionMaturityDateOfUnderlying { get; init; } 

    /// <summary>
    /// Option Premium Amount.
    /// </summary>
    [DisplayName("Option Premium Amount")]
    [IsoXmlTag("OptnPrmAmt")]
    public CompareActiveOrHistoricCurrencyAndAmount4? OptionPremiumAmount { get; init; } 

    /// <summary>
    /// Option Premium Payment Date.
    /// </summary>
    [DisplayName("Option Premium Payment Date")]
    [IsoXmlTag("OptnPrmPmtDt")]
    public CompareDate3? OptionPremiumPaymentDate { get; init; } 

    /// <summary>
    /// Option Strike Price.
    /// </summary>
    [DisplayName("Option Strike Price")]
    [IsoXmlTag("OptnStrkPric")]
    public CompareUnitPrice4? OptionStrikePrice { get; init; } 

    /// <summary>
    /// Option Strike Price Schedule Amount.
    /// </summary>
    [DisplayName("Option Strike Price Schedule Amount")]
    [IsoXmlTag("OptnStrkPricSchdlAmt")]
    public ValueList<CompareUnitPrice4> OptionStrikePriceScheduleAmount { get; init; } = [];

    /// <summary>
    /// Option Strike Price Schedule Unadjusted Effective Date.
    /// </summary>
    [DisplayName("Option Strike Price Schedule Unadjusted Effective Date")]
    [IsoXmlTag("OptnStrkPricSchdlUadjstdFctvDt")]
    public ValueList<CompareDate3> OptionStrikePriceScheduleUnadjustedEffectiveDate { get; init; } = [];

    /// <summary>
    /// Option Strike Price Schedule Unadjusted End Date.
    /// </summary>
    [DisplayName("Option Strike Price Schedule Unadjusted End Date")]
    [IsoXmlTag("OptnStrkPricSchdlUadjstdEndDt")]
    public ValueList<CompareDate3> OptionStrikePriceScheduleUnadjustedEndDate { get; init; } = [];

    /// <summary>
    /// Option Type.
    /// </summary>
    [DisplayName("Option Type")]
    [IsoXmlTag("OptnTp")]
    public CompareOptionType1? OptionType { get; init; } 

    /// <summary>
    /// Other Payment.
    /// </summary>
    [DisplayName("Other Payment")]
    [IsoXmlTag("OthrPmt")]
    public ValueList<CompareOtherPayment1> OtherPayment { get; init; } = [];

    /// <summary>
    /// Package Price.
    /// </summary>
    [DisplayName("Package Price")]
    [IsoXmlTag("PackgPric")]
    public CompareUnitPrice5? PackagePrice { get; init; } 

    /// <summary>
    /// Package Spread.
    /// </summary>
    [DisplayName("Package Spread")]
    [IsoXmlTag("PackgSprd")]
    public CompareUnitPrice8? PackageSpread { get; init; } 

    /// <summary>
    /// Platform Identifier.
    /// </summary>
    [DisplayName("Platform Identifier")]
    [IsoXmlTag("PltfmIdr")]
    public CompareMICIdentifier3? PlatformIdentifier { get; init; } 

    /// <summary>
    /// Post Trade Risk Reduction.
    /// </summary>
    [DisplayName("Post Trade Risk Reduction")]
    [IsoXmlTag("PstTradRskRdctn")]
    public ComparePostTradeRiskReduction2? PostTradeRiskReduction { get; init; } 

    /// <summary>
    /// Price Schedule Unadjusted Effective Date.
    /// </summary>
    [DisplayName("Price Schedule Unadjusted Effective Date")]
    [IsoXmlTag("PricSchdlUadjstdFctvDt")]
    public ValueList<CompareDate3> PriceScheduleUnadjustedEffectiveDate { get; init; } = [];

    /// <summary>
    /// Price Schedule Unadjusted End Date.
    /// </summary>
    [DisplayName("Price Schedule Unadjusted End Date")]
    [IsoXmlTag("PricSchdlUadjstdEndDt")]
    public ValueList<CompareDate3> PriceScheduleUnadjustedEndDate { get; init; } = [];

    /// <summary>
    /// Prior Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Prior Unique Transaction Identifier")]
    [IsoXmlTag("PrrUnqTxIdr")]
    public CompareUniqueTransactionIdentifier2? PriorUniqueTransactionIdentifier { get; init; } 

    /// <summary>
    /// Report Tracking Number.
    /// </summary>
    [DisplayName("Report Tracking Number")]
    [IsoXmlTag("RptTrckgNb")]
    public CompareText2? ReportTrackingNumber { get; init; } 

    /// <summary>
    /// Settlement Date.
    /// </summary>
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public ValueList<CompareDate3> SettlementDate { get; init; } = [];

    /// <summary>
    /// Subsequent Position Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Subsequent Position Unique Transaction Identifier")]
    [IsoXmlTag("SbsqntPosUnqTxIdr")]
    public CompareUniqueTransactionIdentifier2? SubsequentPositionUniqueTransactionIdentifier { get; init; } 

    /// <summary>
    /// Trade Clearing Obligation.
    /// </summary>
    [DisplayName("Trade Clearing Obligation")]
    [IsoXmlTag("TradClrOblgtn")]
    public CompareTradeClearingObligation1? TradeClearingObligation { get; init; } 

    /// <summary>
    /// Trade Clearing Status.
    /// </summary>
    [DisplayName("Trade Clearing Status")]
    [IsoXmlTag("TradClrSts")]
    public CompareTradeClearingStatus3? TradeClearingStatus { get; init; } 

    /// <summary>
    /// Trade Confirmation.
    /// </summary>
    [DisplayName("Trade Confirmation")]
    [IsoXmlTag("TradConf")]
    public CompareTradeConfirmation2? TradeConfirmation { get; init; } 

    /// <summary>
    /// Transaction Price.
    /// </summary>
    [DisplayName("Transaction Price")]
    [IsoXmlTag("TxPric")]
    public CompareUnitPrice5? TransactionPrice { get; init; } 

    /// <summary>
    /// Transaction Schedule Price.
    /// </summary>
    [DisplayName("Transaction Schedule Price")]
    [IsoXmlTag("TxSchdlPric")]
    public ValueList<CompareUnitPrice5> TransactionSchedulePrice { get; init; } = [];

    /// <summary>
    /// Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public CompareUniqueTransactionIdentifier2? UniqueTransactionIdentifier { get; init; } 

    
    #nullable disable
    
}
