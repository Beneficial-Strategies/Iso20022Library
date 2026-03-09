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
/// Compares information related to both sides of a transaction.
/// </summary>
[IsoId("_v_bxkVoyEe23K4GXSpBSeg")]
[DisplayName("Transaction Matching Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionMatchingCriteria6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies whether the information on the reporting tracking numbers are matching or not.
    /// </summary>
    [IsoId("_wBBF8VoyEe23K4GXSpBSeg")]
    [DisplayName("Report Tracking Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTrckgNb")]
    #endif
    [IsoXmlTag("RptTrckgNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareText2? ReportTrackingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareText2? ReportTrackingNumber { get; init; } 
    #else
    public CompareText2? ReportTrackingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the Unique Transaction Identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBF81oyEe23K4GXSpBSeg")]
    [DisplayName("Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnqTxIdr")]
    #endif
    [IsoXmlTag("UnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUniqueTransactionIdentifier2? UniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUniqueTransactionIdentifier2? UniqueTransactionIdentifier { get; init; } 
    #else
    public CompareUniqueTransactionIdentifier2? UniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the Prior Unique Transaction Identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBF9VoyEe23K4GXSpBSeg")]
    [DisplayName("Prior Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrrUnqTxIdr")]
    #endif
    [IsoXmlTag("PrrUnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUniqueTransactionIdentifier2? PriorUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUniqueTransactionIdentifier2? PriorUniqueTransactionIdentifier { get; init; } 
    #else
    public CompareUniqueTransactionIdentifier2? PriorUniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the Subsequent Position Unique Transaction Identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBF91oyEe23K4GXSpBSeg")]
    [DisplayName("Subsequent Position Unique Transaction Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbsqntPosUnqTxIdr")]
    #endif
    [IsoXmlTag("SbsqntPosUnqTxIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUniqueTransactionIdentifier2? SubsequentPositionUniqueTransactionIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUniqueTransactionIdentifier2? SubsequentPositionUniqueTransactionIdentifier { get; init; } 
    #else
    public CompareUniqueTransactionIdentifier2? SubsequentPositionUniqueTransactionIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the delta are matching or not.
    /// </summary>
    [IsoId("_wBBF-VoyEe23K4GXSpBSeg")]
    [DisplayName("Delta")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dlta")]
    #endif
    [IsoXmlTag("Dlta")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareLongFraction19DecimalNumber1? Delta { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareLongFraction19DecimalNumber1? Delta { get; init; } 
    #else
    public CompareLongFraction19DecimalNumber1? Delta { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the trade confirmations are matching or not.
    /// </summary>
    [IsoId("_wBBF-1oyEe23K4GXSpBSeg")]
    [DisplayName("Trade Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradConf")]
    #endif
    [IsoXmlTag("TradConf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTradeConfirmation2? TradeConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTradeConfirmation2? TradeConfirmation { get; init; } 
    #else
    public CompareTradeConfirmation2? TradeConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the trade clearing obligations are matching or not.
    /// </summary>
    [IsoId("_wBBF_VoyEe23K4GXSpBSeg")]
    [DisplayName("Trade Clearing Obligation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradClrOblgtn")]
    #endif
    [IsoXmlTag("TradClrOblgtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTradeClearingObligation1? TradeClearingObligation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTradeClearingObligation1? TradeClearingObligation { get; init; } 
    #else
    public CompareTradeClearingObligation1? TradeClearingObligation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the trade clearing statuses are matching or not.
    /// </summary>
    [IsoId("_wBBF_1oyEe23K4GXSpBSeg")]
    [DisplayName("Trade Clearing Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradClrSts")]
    #endif
    [IsoXmlTag("TradClrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTradeClearingStatus3? TradeClearingStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTradeClearingStatus3? TradeClearingStatus { get; init; } 
    #else
    public CompareTradeClearingStatus3? TradeClearingStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the master agreement types are matching or not.
    /// </summary>
    [IsoId("_wBBGAVoyEe23K4GXSpBSeg")]
    [DisplayName("Master Agreement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmtTp")]
    #endif
    [IsoXmlTag("MstrAgrmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMasterAgreementType1? MasterAgreementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMasterAgreementType1? MasterAgreementType { get; init; } 
    #else
    public CompareMasterAgreementType1? MasterAgreementType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the master agreement versions are matching or not.
    /// </summary>
    [IsoId("_wBBGA1oyEe23K4GXSpBSeg")]
    [DisplayName("Master Agreement Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmtVrsn")]
    #endif
    [IsoXmlTag("MstrAgrmtVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMax50Text1? MasterAgreementVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMax50Text1? MasterAgreementVersion { get; init; } 
    #else
    public CompareMax50Text1? MasterAgreementVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the intra groups are matching or not.
    /// </summary>
    [IsoId("_wBBGBVoyEe23K4GXSpBSeg")]
    [DisplayName("Intra Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntraGrp")]
    #endif
    [IsoXmlTag("IntraGrp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrueFalseIndicator3? IntraGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrueFalseIndicator3? IntraGroup { get; init; } 
    #else
    public CompareTrueFalseIndicator3? IntraGroup { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the post trade risk reductions are matching or not.
    /// </summary>
    [IsoId("_wBBGB1oyEe23K4GXSpBSeg")]
    [DisplayName("Post Trade Risk Reduction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstTradRskRdctn")]
    #endif
    [IsoXmlTag("PstTradRskRdctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePostTradeRiskReduction2? PostTradeRiskReduction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePostTradeRiskReduction2? PostTradeRiskReduction { get; init; } 
    #else
    public ComparePostTradeRiskReduction2? PostTradeRiskReduction { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the derivative event are matching or not.
    /// </summary>
    [IsoId("_wBBGCVoyEe23K4GXSpBSeg")]
    [DisplayName("Derivative Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivEvt")]
    #endif
    [IsoXmlTag("DerivEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDerivativeEvent1? DerivativeEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDerivativeEvent1? DerivativeEvent { get; init; } 
    #else
    public CompareDerivativeEvent1? DerivativeEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the platform identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBGC1oyEe23K4GXSpBSeg")]
    [DisplayName("Platform Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PltfmIdr")]
    #endif
    [IsoXmlTag("PltfmIdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMICIdentifier3? PlatformIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMICIdentifier3? PlatformIdentifier { get; init; } 
    #else
    public CompareMICIdentifier3? PlatformIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the execution time stamps are matching or not.
    /// </summary>
    [IsoId("_wBBGDVoyEe23K4GXSpBSeg")]
    [DisplayName("Execution Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTmStmp")]
    #endif
    [IsoXmlTag("ExctnTmStmp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDateTime3? ExecutionTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDateTime3? ExecutionTimeStamp { get; init; } 
    #else
    public CompareDateTime3? ExecutionTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGD1oyEe23K4GXSpBSeg")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? EffectiveDate { get; init; } 
    #else
    public CompareDate3? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the expiration dates are matching or not.
    /// </summary>
    [IsoId("_wBBGEVoyEe23K4GXSpBSeg")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? ExpirationDate { get; init; } 
    #else
    public CompareDate3? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the early termination dates are matching or not.
    /// </summary>
    [IsoId("_wBBGE1oyEe23K4GXSpBSeg")]
    [DisplayName("Early Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyTermntnDt")]
    #endif
    [IsoXmlTag("EarlyTermntnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? EarlyTerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? EarlyTerminationDate { get; init; } 
    #else
    public CompareDate3? EarlyTerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the settlement dates are matching or not.
    /// </summary>
    [IsoId("_wBBGFVoyEe23K4GXSpBSeg")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? SettlementDate { get; init; } 
    #else
    public CompareDate3? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the delivery types are matching or not.
    /// </summary>
    [IsoId("_wBBGF1oyEe23K4GXSpBSeg")]
    [DisplayName("Delivery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTp")]
    #endif
    [IsoXmlTag("DlvryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDeliveryType1? DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDeliveryType1? DeliveryType { get; init; } 
    #else
    public CompareDeliveryType1? DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the the transaction prices are matching or not.
    /// </summary>
    [IsoId("_wBBGGVoyEe23K4GXSpBSeg")]
    [DisplayName("Transaction Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxPric")]
    #endif
    [IsoXmlTag("TxPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice5? TransactionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice5? TransactionPrice { get; init; } 
    #else
    public CompareUnitPrice5? TransactionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGG1oyEe23K4GXSpBSeg")]
    [DisplayName("Price Schedule Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricSchdlUadjstdFctvDt")]
    #endif
    [IsoXmlTag("PricSchdlUadjstdFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? PriceScheduleUnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? PriceScheduleUnadjustedEffectiveDate { get; init; } 
    #else
    public CompareDate3? PriceScheduleUnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGHVoyEe23K4GXSpBSeg")]
    [DisplayName("Price Schedule Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricSchdlUadjstdEndDt")]
    #endif
    [IsoXmlTag("PricSchdlUadjstdEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? PriceScheduleUnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? PriceScheduleUnadjustedEndDate { get; init; } 
    #else
    public CompareDate3? PriceScheduleUnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the transaction price in effect between the unadjusted effective and end date are matching or not.
    /// </summary>
    [IsoId("_wBBGH1oyEe23K4GXSpBSeg")]
    [DisplayName("Transaction Schedule Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSchdlPric")]
    #endif
    [IsoXmlTag("TxSchdlPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice5? TransactionSchedulePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice5? TransactionSchedulePrice { get; init; } 
    #else
    public CompareUnitPrice5? TransactionSchedulePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the package prices are matching or not.
    /// </summary>
    [IsoId("_wBBGIVoyEe23K4GXSpBSeg")]
    [DisplayName("Package Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgPric")]
    #endif
    [IsoXmlTag("PackgPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice5? PackagePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice5? PackagePrice { get; init; } 
    #else
    public CompareUnitPrice5? PackagePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional amount first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGI1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtFrstLeg")]
    #endif
    [IsoXmlTag("NtnlAmtFrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection3? NotionalAmountFirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection3? NotionalAmountFirstLeg { get; init; } 
    #else
    public CompareAmountAndDirection3? NotionalAmountFirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGJVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtFrstLegUadjstdFctvDt")]
    #endif
    [IsoXmlTag("NtnlAmtFrstLegUadjstdFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalAmountFirstLegUnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalAmountFirstLegUnadjustedEffectiveDate { get; init; } 
    #else
    public CompareDate3? NotionalAmountFirstLegUnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGJ1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtFrstLegUadjstdEndDt")]
    #endif
    [IsoXmlTag("NtnlAmtFrstLegUadjstdEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalAmountFirstLegUnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalAmountFirstLegUnadjustedEndDate { get; init; } 
    #else
    public CompareDate3? NotionalAmountFirstLegUnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional amount in effect on associated effective date of first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGKVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount First Leg Schedule Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtFrstLegSchdlAmt")]
    #endif
    [IsoXmlTag("NtnlAmtFrstLegSchdlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection3? NotionalAmountFirstLegScheduleAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection3? NotionalAmountFirstLegScheduleAmount { get; init; } 
    #else
    public CompareAmountAndDirection3? NotionalAmountFirstLegScheduleAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional quantity first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGK1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyFrstLeg")]
    #endif
    [IsoXmlTag("NtnlQtyFrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLeg { get; init; } 
    #else
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGLVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyFrstLegUadjstdFctvDt")]
    #endif
    [IsoXmlTag("NtnlQtyFrstLegUadjstdFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEffectiveDate { get; init; } 
    #else
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGL1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyFrstLegUadjstdEndDt")]
    #endif
    [IsoXmlTag("NtnlQtyFrstLegUadjstdEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEndDate { get; init; } 
    #else
    public CompareDate3? NotionalQuantityFirstLegUnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional quantity in effect on associated effective date of first legs are matching or not.
    /// </summary>
    [IsoId("_wBBGMVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity First Leg Schedule Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyFrstLegSchdlQty")]
    #endif
    [IsoXmlTag("NtnlQtyFrstLegSchdlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLegScheduleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLegScheduleQuantity { get; init; } 
    #else
    public CompareLongFraction19DecimalNumber1? NotionalQuantityFirstLegScheduleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional amount second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGM1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtScndLeg")]
    #endif
    [IsoXmlTag("NtnlAmtScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNotionalAmount1? NotionalAmountSecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNotionalAmount1? NotionalAmountSecondLeg { get; init; } 
    #else
    public CompareNotionalAmount1? NotionalAmountSecondLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGNVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtScndLegUadjstdFctvDt")]
    #endif
    [IsoXmlTag("NtnlAmtScndLegUadjstdFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalAmountSecondLegUnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalAmountSecondLegUnadjustedEffectiveDate { get; init; } 
    #else
    public CompareDate3? NotionalAmountSecondLegUnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGN1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtScndLegUadjstdEndDt")]
    #endif
    [IsoXmlTag("NtnlAmtScndLegUadjstdEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalAmountSecondLegUnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalAmountSecondLegUnadjustedEndDate { get; init; } 
    #else
    public CompareDate3? NotionalAmountSecondLegUnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional amount in effect on associated effective date of second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGOVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Amount Second Leg Schedule Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmtScndLegSchdlAmt")]
    #endif
    [IsoXmlTag("NtnlAmtScndLegSchdlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareAmountAndDirection3? NotionalAmountSecondLegScheduleAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareAmountAndDirection3? NotionalAmountSecondLegScheduleAmount { get; init; } 
    #else
    public CompareAmountAndDirection3? NotionalAmountSecondLegScheduleAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional quantity second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGO1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyScndLeg")]
    #endif
    [IsoXmlTag("NtnlQtyScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLeg { get; init; } 
    #else
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGPVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyScndLegUadjstdFctvDt")]
    #endif
    [IsoXmlTag("NtnlQtyScndLegUadjstdFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEffectiveDate { get; init; } 
    #else
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGP1oyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyScndLegUadjstdEndDt")]
    #endif
    [IsoXmlTag("NtnlQtyScndLegUadjstdEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEndDate { get; init; } 
    #else
    public CompareDate3? NotionalQuantitySecondLegUnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the notional quantity in effect on associated effective date of second legs are matching or not.
    /// </summary>
    [IsoId("_wBBGQVoyEe23K4GXSpBSeg")]
    [DisplayName("Notional Quantity Second Leg Schedule Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQtyScndLegSchdlQty")]
    #endif
    [IsoXmlTag("NtnlQtyScndLegSchdlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLegScheduleQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLegScheduleQuantity { get; init; } 
    #else
    public CompareLongFraction19DecimalNumber1? NotionalQuantitySecondLegScheduleQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Payment related to elements not reported in dedicated fields.
    /// </summary>
    [IsoId("_wBBGQ1oyEe23K4GXSpBSeg")]
    [DisplayName("Other Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmt")]
    #endif
    [IsoXmlTag("OthrPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOtherPayment1? OtherPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOtherPayment1? OtherPayment { get; init; } 
    #else
    public CompareOtherPayment1? OtherPayment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest fixed rate legs are matching or not.
    /// </summary>
    [IsoId("_wBBGRVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateFrstLeg")]
    #endif
    [IsoXmlTag("IntrstFxdRateFrstLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice7? InterestFixedRateFirstLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice7? InterestFixedRateFirstLeg { get; init; } 
    #else
    public CompareUnitPrice7? InterestFixedRateFirstLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGR1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg Day Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateFrstLegDayCnt")]
    #endif
    [IsoXmlTag("IntrstFxdRateFrstLegDayCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDayCount1? InterestFixedRateFirstLegDayCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDayCount1? InterestFixedRateFirstLegDayCount { get; init; } 
    #else
    public CompareDayCount1? InterestFixedRateFirstLegDayCount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGSVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateFrstLegPmtFrqcyUnit")]
    #endif
    [IsoXmlTag("IntrstFxdRateFrstLegPmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFixedRateFirstLegPaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFixedRateFirstLegPaymentFrequencyUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFixedRateFirstLegPaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGS1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate First Leg Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateFrstLegPmtFrqcyVal")]
    #endif
    [IsoXmlTag("IntrstFxdRateFrstLegPmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFixedRateFirstLegPaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFixedRateFirstLegPaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber5? InterestFixedRateFirstLegPaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBGTVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegId")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareISINIdentifier4? InterestFloatingRateFirstLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareISINIdentifier4? InterestFloatingRateFirstLegIdentification { get; init; } 
    #else
    public CompareISINIdentifier4? InterestFloatingRateFirstLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate codes are matching or not.
    /// </summary>
    [IsoId("_wBBGT1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegCd")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCode1? InterestFloatingRateFirstLegCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCode1? InterestFloatingRateFirstLegCode { get; init; } 
    #else
    public CompareBenchmarkCode1? InterestFloatingRateFirstLegCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate names are matching or not.
    /// </summary>
    [IsoId("_wBBGUVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegNm")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMax350Text1? InterestFloatingRateFirstLegName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMax350Text1? InterestFloatingRateFirstLegName { get; init; } 
    #else
    public CompareMax350Text1? InterestFloatingRateFirstLegName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGU1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Day Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegDayCnt")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegDayCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDayCount1? InterestFloatingRateFirstLegDayCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDayCount1? InterestFloatingRateFirstLegDayCount { get; init; } 
    #else
    public CompareDayCount1? InterestFloatingRateFirstLegDayCount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGVVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegPmtFrqcyUnit")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegPmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegPaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegPaymentFrequencyUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegPaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGV1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegPmtFrqcyVal")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegPmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFloatingRateFirstLegPaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFloatingRateFirstLegPaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber5? InterestFloatingRateFirstLegPaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reference period units are matching or not.
    /// </summary>
    [IsoId("_wBBGWVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reference Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegRefPrdUnit")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegRefPrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegReferencePeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegReferencePeriodUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegReferencePeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reference period values are matching or not.
    /// </summary>
    [IsoId("_wBBGW1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reference Period Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegRefPrdVal")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegRefPrdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFloatingRateFirstLegReferencePeriodValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFloatingRateFirstLegReferencePeriodValue { get; init; } 
    #else
    public CompareNumber5? InterestFloatingRateFirstLegReferencePeriodValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reset frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGXVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegRstFrqcyUnit")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegResetFrequencyUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFloatingRateFirstLegResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reset frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGX1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegRstFrqcyVal")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFloatingRateFirstLegResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFloatingRateFirstLegResetFrequencyValue { get; init; } 
    #else
    public CompareNumber5? InterestFloatingRateFirstLegResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the spreads are matching or not.
    /// </summary>
    [IsoId("_wBBGYVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate First Leg Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateFrstLegSprd")]
    #endif
    [IsoXmlTag("IntrstFltgRateFrstLegSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice8? InterestFloatingRateFirstLegSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice8? InterestFloatingRateFirstLegSpread { get; init; } 
    #else
    public CompareUnitPrice8? InterestFloatingRateFirstLegSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest fixed rate legs are matching or not.
    /// </summary>
    [IsoId("_wBBGY1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Rate Fixed Second Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRateFxdScndLeg")]
    #endif
    [IsoXmlTag("IntrstRateFxdScndLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice7? InterestRateFixedSecondLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice7? InterestRateFixedSecondLeg { get; init; } 
    #else
    public CompareUnitPrice7? InterestRateFixedSecondLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGZVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate Second Leg Day Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateScndLegDayCnt")]
    #endif
    [IsoXmlTag("IntrstFxdRateScndLegDayCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDayCount1? InterestFixedRateSecondLegDayCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDayCount1? InterestFixedRateSecondLegDayCount { get; init; } 
    #else
    public CompareDayCount1? InterestFixedRateSecondLegDayCount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGZ1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate Second Leg Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateScndLegPmtFrqcyUnit")]
    #endif
    [IsoXmlTag("IntrstFxdRateScndLegPmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFixedRateSecondLegPaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFixedRateSecondLegPaymentFrequencyUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFixedRateSecondLegPaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGaVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Fixed Rate Second Leg Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFxdRateScndLegPmtFrqcyVal")]
    #endif
    [IsoXmlTag("IntrstFxdRateScndLegPmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFixedRateSecondLegPaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFixedRateSecondLegPaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber5? InterestFixedRateSecondLegPaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate identifiers are matching or not.
    /// </summary>
    [IsoId("_wBBGa1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegId")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareISINIdentifier4? InterestFloatingRateSecondLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareISINIdentifier4? InterestFloatingRateSecondLegIdentification { get; init; } 
    #else
    public CompareISINIdentifier4? InterestFloatingRateSecondLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate codes are matching or not.
    /// </summary>
    [IsoId("_wBBGbVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegCd")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareBenchmarkCode1? InterestFloatingRateSecondLegCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareBenchmarkCode1? InterestFloatingRateSecondLegCode { get; init; } 
    #else
    public CompareBenchmarkCode1? InterestFloatingRateSecondLegCode { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interest floating rate names are matching or not.
    /// </summary>
    [IsoId("_wBBGb1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegNm")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareMax350Text1? InterestFloatingRateSecondLegName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareMax350Text1? InterestFloatingRateSecondLegName { get; init; } 
    #else
    public CompareMax350Text1? InterestFloatingRateSecondLegName { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the day counts are matching or not.
    /// </summary>
    [IsoId("_wBBGcVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Day Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegDayCnt")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegDayCnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDayCount1? InterestFloatingRateSecondLegDayCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDayCount1? InterestFloatingRateSecondLegDayCount { get; init; } 
    #else
    public CompareDayCount1? InterestFloatingRateSecondLegDayCount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGc1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Payment Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegPmtFrqcyUnit")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegPmtFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegPaymentFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegPaymentFrequencyUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegPaymentFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the payment frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGdVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Payment Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegPmtFrqcyVal")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegPmtFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFloatingRateSecondLegPaymentFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFloatingRateSecondLegPaymentFrequencyValue { get; init; } 
    #else
    public CompareNumber5? InterestFloatingRateSecondLegPaymentFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reference period units are matching or not.
    /// </summary>
    [IsoId("_wBBGd1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reference Period Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegRefPrdUnit")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegRefPrdUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegReferencePeriodUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegReferencePeriodUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegReferencePeriodUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reference period values are matching or not.
    /// </summary>
    [IsoId("_wBBGeVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reference Period Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegRefPrdVal")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegRefPrdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFloatingRateSecondLegReferencePeriodValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFloatingRateSecondLegReferencePeriodValue { get; init; } 
    #else
    public CompareNumber5? InterestFloatingRateSecondLegReferencePeriodValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reset frequency units are matching or not.
    /// </summary>
    [IsoId("_wBBGe1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reset Frequency Unit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegRstFrqcyUnit")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegRstFrqcyUnit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegResetFrequencyUnit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegResetFrequencyUnit { get; init; } 
    #else
    public CompareFrequencyUnit1? InterestFloatingRateSecondLegResetFrequencyUnit { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the reset frequency values are matching or not.
    /// </summary>
    [IsoId("_wBBGfVoyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Reset Frequency Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegRstFrqcyVal")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegRstFrqcyVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber5? InterestFloatingRateSecondLegResetFrequencyValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber5? InterestFloatingRateSecondLegResetFrequencyValue { get; init; } 
    #else
    public CompareNumber5? InterestFloatingRateSecondLegResetFrequencyValue { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the spreads are matching or not.
    /// </summary>
    [IsoId("_wBBGf1oyEe23K4GXSpBSeg")]
    [DisplayName("Interest Floating Rate Second Leg Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstFltgRateScndLegSprd")]
    #endif
    [IsoXmlTag("IntrstFltgRateScndLegSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice8? InterestFloatingRateSecondLegSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice8? InterestFloatingRateSecondLegSpread { get; init; } 
    #else
    public CompareUnitPrice8? InterestFloatingRateSecondLegSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the package spreads are matching or not.
    /// </summary>
    [IsoId("_wBBGgVoyEe23K4GXSpBSeg")]
    [DisplayName("Package Spread")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PackgSprd")]
    #endif
    [IsoXmlTag("PackgSprd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice8? PackageSpread { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice8? PackageSpread { get; init; } 
    #else
    public CompareUnitPrice8? PackageSpread { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the currency exchange rates are matching or not.
    /// </summary>
    [IsoId("_wBBGg1oyEe23K4GXSpBSeg")]
    [DisplayName("Currency Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyXchgRate")]
    #endif
    [IsoXmlTag("CcyXchgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareExchangeRate1? CurrencyExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareExchangeRate1? CurrencyExchangeRate { get; init; } 
    #else
    public CompareExchangeRate1? CurrencyExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the forward currency exchange rates are matching or not.
    /// </summary>
    [IsoId("_wBBGhVoyEe23K4GXSpBSeg")]
    [DisplayName("Currency Forward Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyFwdXchgRate")]
    #endif
    [IsoXmlTag("CcyFwdXchgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareExchangeRate1? CurrencyForwardExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareExchangeRate1? CurrencyForwardExchangeRate { get; init; } 
    #else
    public CompareExchangeRate1? CurrencyForwardExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the currency exchange rate basis are matching or not.
    /// </summary>
    [IsoId("_wBBGh1oyEe23K4GXSpBSeg")]
    [DisplayName("Currency Exchange Rate Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyXchgRateBsis")]
    #endif
    [IsoXmlTag("CcyXchgRateBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareExchangeRateBasis1? CurrencyExchangeRateBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareExchangeRateBasis1? CurrencyExchangeRateBasis { get; init; } 
    #else
    public CompareExchangeRateBasis1? CurrencyExchangeRateBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the commodities are matching or not.
    /// </summary>
    [IsoId("_wBBGiVoyEe23K4GXSpBSeg")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareCommodityAssetClass4? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareCommodityAssetClass4? Commodity { get; init; } 
    #else
    public CompareCommodityAssetClass4? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the delivery points or zones are matching or not.
    /// </summary>
    [IsoId("_wBBGi1oyEe23K4GXSpBSeg")]
    [DisplayName("Energy Delivery Point Or Zone")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyDlvryPtOrZone")]
    #endif
    [IsoXmlTag("NrgyDlvryPtOrZone")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDeliveryInterconnectionPoint1? EnergyDeliveryPointOrZone { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDeliveryInterconnectionPoint1? EnergyDeliveryPointOrZone { get; init; } 
    #else
    public CompareDeliveryInterconnectionPoint1? EnergyDeliveryPointOrZone { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the interconnection points are matching or not.
    /// </summary>
    [IsoId("_wBBGjVoyEe23K4GXSpBSeg")]
    [DisplayName("Energy Inter Connection Point")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyIntrCnnctnPt")]
    #endif
    [IsoXmlTag("NrgyIntrCnnctnPt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDeliveryInterconnectionPoint1? EnergyInterConnectionPoint { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDeliveryInterconnectionPoint1? EnergyInterConnectionPoint { get; init; } 
    #else
    public CompareDeliveryInterconnectionPoint1? EnergyInterConnectionPoint { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the load types are matching or not.
    /// </summary>
    [IsoId("_wBBGj1oyEe23K4GXSpBSeg")]
    [DisplayName("Energy Load Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgyLdTp")]
    #endif
    [IsoXmlTag("NrgyLdTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareEnergyLoadType1? EnergyLoadType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareEnergyLoadType1? EnergyLoadType { get; init; } 
    #else
    public CompareEnergyLoadType1? EnergyLoadType { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes related to delivery of derivative contracts.
    /// </summary>
    [IsoId("_wBBGkVoyEe23K4GXSpBSeg")]
    [DisplayName("Delivery Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAttr")]
    #endif
    [IsoXmlTag("DlvryAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareEnergyDeliveryAttribute1? DeliveryAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareEnergyDeliveryAttribute1? DeliveryAttribute { get; init; } 
    #else
    public CompareEnergyDeliveryAttribute1? DeliveryAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the option types are matching or not.
    /// </summary>
    [IsoId("_wBBGk1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOptionType1? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOptionType1? OptionType { get; init; } 
    #else
    public CompareOptionType1? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the exercise styles are matching or not.
    /// </summary>
    [IsoId("_wBBGlVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Exercise Style")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnExrcStyle")]
    #endif
    [IsoXmlTag("OptnExrcStyle")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareOptionStyle1? OptionExerciseStyle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareOptionStyle1? OptionExerciseStyle { get; init; } 
    #else
    public CompareOptionStyle1? OptionExerciseStyle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the strike prices are matching or not.
    /// </summary>
    [IsoId("_wBBGl1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStrkPric")]
    #endif
    [IsoXmlTag("OptnStrkPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice4? OptionStrikePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice4? OptionStrikePrice { get; init; } 
    #else
    public CompareUnitPrice4? OptionStrikePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGmVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price Schedule Unadjusted Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStrkPricSchdlUadjstdFctvDt")]
    #endif
    [IsoXmlTag("OptnStrkPricSchdlUadjstdFctvDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEffectiveDate { get; init; } 
    #else
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the unadjusted end dates are matching or not.
    /// </summary>
    [IsoId("_wBBGm1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price Schedule Unadjusted End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStrkPricSchdlUadjstdEndDt")]
    #endif
    [IsoXmlTag("OptnStrkPricSchdlUadjstdEndDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEndDate { get; init; } 
    #else
    public CompareDate3? OptionStrikePriceScheduleUnadjustedEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the strike price in effect on associated effective dates are matching or not.
    /// </summary>
    [IsoId("_wBBGnVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Strike Price Schedule Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnStrkPricSchdlAmt")]
    #endif
    [IsoXmlTag("OptnStrkPricSchdlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareUnitPrice4? OptionStrikePriceScheduleAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareUnitPrice4? OptionStrikePriceScheduleAmount { get; init; } 
    #else
    public CompareUnitPrice4? OptionStrikePriceScheduleAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the premium amounts are matching or not.
    /// </summary>
    [IsoId("_wBBGn1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Premium Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPrmAmt")]
    #endif
    [IsoXmlTag("OptnPrmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareActiveOrHistoricCurrencyAndAmount4? OptionPremiumAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareActiveOrHistoricCurrencyAndAmount4? OptionPremiumAmount { get; init; } 
    #else
    public CompareActiveOrHistoricCurrencyAndAmount4? OptionPremiumAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the premium payment dates are matching or not.
    /// </summary>
    [IsoId("_wBBGoVoyEe23K4GXSpBSeg")]
    [DisplayName("Option Premium Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnPrmPmtDt")]
    #endif
    [IsoXmlTag("OptnPrmPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? OptionPremiumPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? OptionPremiumPaymentDate { get; init; } 
    #else
    public CompareDate3? OptionPremiumPaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the maturity date of the underlying are matching or not.
    /// </summary>
    [IsoId("_wBBGo1oyEe23K4GXSpBSeg")]
    [DisplayName("Option Maturity Date Of Underlying")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnMtrtyDtOfUndrlyg")]
    #endif
    [IsoXmlTag("OptnMtrtyDtOfUndrlyg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareDate3? OptionMaturityDateOfUnderlying { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareDate3? OptionMaturityDateOfUnderlying { get; init; } 
    #else
    public CompareDate3? OptionMaturityDateOfUnderlying { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the credity seniority are matching or not.
    /// </summary>
    [IsoId("_wBBGpVoyEe23K4GXSpBSeg")]
    [DisplayName("Credit Seniority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtSnrty")]
    #endif
    [IsoXmlTag("CdtSnrty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareSeniorityType1? CreditSeniority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareSeniorityType1? CreditSeniority { get; init; } 
    #else
    public CompareSeniorityType1? CreditSeniority { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the credit reference parties are matching or not.
    /// </summary>
    [IsoId("_wBBGp1oyEe23K4GXSpBSeg")]
    [DisplayName("Credit Reference Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtRefPty")]
    #endif
    [IsoXmlTag("CdtRefPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareReferenceParty1? CreditReferenceParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareReferenceParty1? CreditReferenceParty { get; init; } 
    #else
    public CompareReferenceParty1? CreditReferenceParty { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the credit series are matching or not.
    /// </summary>
    [IsoId("_wBBGqVoyEe23K4GXSpBSeg")]
    [DisplayName("Credit Series")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtSrs")]
    #endif
    [IsoXmlTag("CdtSrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber7? CreditSeries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber7? CreditSeries { get; init; } 
    #else
    public CompareNumber7? CreditSeries { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the credit versions are matching or not.
    /// </summary>
    [IsoId("_wBBGq1oyEe23K4GXSpBSeg")]
    [DisplayName("Credit Version")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtVrsn")]
    #endif
    [IsoXmlTag("CdtVrsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareNumber7? CreditVersion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareNumber7? CreditVersion { get; init; } 
    #else
    public CompareNumber7? CreditVersion { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the index factors are matching or not.
    /// </summary>
    [IsoId("_wBBGrVoyEe23K4GXSpBSeg")]
    [DisplayName("Credit Index Factor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtIndxFctr")]
    #endif
    [IsoXmlTag("CdtIndxFctr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ComparePercentageRate3? CreditIndexFactor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ComparePercentageRate3? CreditIndexFactor { get; init; } 
    #else
    public ComparePercentageRate3? CreditIndexFactor { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the credit tranches are matching or not.
    /// </summary>
    [IsoId("_wBBGr1oyEe23K4GXSpBSeg")]
    [DisplayName("Credit Tranche")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtTrch")]
    #endif
    [IsoXmlTag("CdtTrch")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareTrancheIndicator1? CreditTranche { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareTrancheIndicator1? CreditTranche { get; init; } 
    #else
    public CompareTrancheIndicator1? CreditTranche { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the information on the levels are matching or not.
    /// </summary>
    [IsoId("_wBBGsVoyEe23K4GXSpBSeg")]
    [DisplayName("Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lvl")]
    #endif
    [IsoXmlTag("Lvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CompareReportingLevelType2? Level { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CompareReportingLevelType2? Level { get; init; } 
    #else
    public CompareReportingLevelType2? Level { get; set; } 
    #endif
    
    
    #nullable disable
    
}
