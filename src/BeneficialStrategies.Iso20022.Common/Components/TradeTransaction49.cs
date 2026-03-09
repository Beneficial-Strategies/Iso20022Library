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
/// Provides details of the trade transaction.
/// </summary>
[IsoId("_fVX4YWEfEe2P-L9DBerEgA")]
[DisplayName("Trade Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeTransaction49
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty.
    /// </summary>
    [IsoId("_fWRQQWEfEe2P-L9DBerEgA")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
    #else
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier assigned to the predecessor transaction that has given rise to the reported transaction due to a lifecycle event.
    /// |
    /// Usage: This data element is not applicable when reporting many-to-one and many-to-many relations between transactions (for example, in the case of a compression).
    /// This data element may be applicable when reporting one-to-one and one-to-many relations between transactions (for example, in the case of a clearing).|
    /// </summary>
    [IsoId("_fWRQQ2EfEe2P-L9DBerEgA")]
    [DisplayName("Prior Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrrTxId")]
    #endif
    [IsoXmlTag("PrrTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier3Choice_? PriorTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier3Choice_? PriorTransactionIdentification { get; init; } 
    #else
    public UniqueTransactionIdentifier3Choice_? PriorTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier of the position in which a derivative is included. This field is applicable only for the reports related to the termination of a derivative due to its inclusion in a position. |
    /// </summary>
    [IsoId("_fWRQRWEfEe2P-L9DBerEgA")]
    [DisplayName("Subsequent Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SbsqntTxId")]
    #endif
    [IsoXmlTag("SbsqntTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UniqueTransactionIdentifier3Choice_? SubsequentTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UniqueTransactionIdentifier3Choice_? SubsequentTransactionIdentification { get; init; } 
    #else
    public UniqueTransactionIdentifier3Choice_? SubsequentTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the unique code assigned by the reporting counterparty to the portfolio if the collateral is posted on a portfolio basis.
    /// </summary>
    [IsoId("_fWRQR2EfEe2P-L9DBerEgA")]
    [DisplayName("Collateral Portfolio Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPrtflCd")]
    #endif
    [IsoXmlTag("CollPrtflCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; init; } 
    #else
    public CollateralPortfolioCode5Choice_? CollateralPortfolioCode { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number to indicate a group of reports which relate to the same execution.
    /// </summary>
    [IsoId("_fWRQSWEfEe2P-L9DBerEgA")]
    [DisplayName("Report Tracking Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptTrckgNb")]
    #endif
    [IsoXmlTag("RptTrckgNb")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? ReportTrackingNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReportTrackingNumber { get; init; } 
    #else
    public System.String? ReportTrackingNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading platform on which the derivative transaction was executed (for example, exchange, multilateral trading facility, swap execution facility). 
    /// Usage: For transactions where no trading facility was involved, specific predefined codes have to be used.
    /// </summary>
    [IsoId("_fWRQS2EfEe2P-L9DBerEgA")]
    [DisplayName("Platform Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PltfmIdr")]
    #endif
    [IsoXmlTag("PltfmIdr")]
    [IsoSimpleType(IsoSimpleType.MICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMICIdentifier? PlatformIdentifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlatformIdentifier { get; init; } 
    #else
    public System.String? PlatformIdentifier { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative transaction satisfies the definition of mirror transaction or trigger transaction.
    /// Usage: If the element is not present, the MirrorOrTriggerTransaction is False.
    /// </summary>
    [IsoId("_fWRQTWEfEe2P-L9DBerEgA")]
    [DisplayName("Mirror Or Trigger Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrrrOrTrggrTx")]
    #endif
    [IsoXmlTag("MrrrOrTrggrTx")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MirrorOrTriggerTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MirrorOrTriggerTransaction { get; init; } 
    #else
    public System.String? MirrorOrTriggerTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the price per derivative excluding, where applicable, commission and accrued interest.
    /// </summary>
    [IsoId("_fWRQT2EfEe2P-L9DBerEgA")]
    [DisplayName("Transaction Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxPric")]
    #endif
    [IsoXmlTag("TxPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceData2? TransactionPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceData2? TransactionPrice { get; init; } 
    #else
    public PriceData2? TransactionPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates monetary or converted amount for the derivatives transaction.
    /// Usage: In case of partial terminations, and amortisations and in case of contracts where the notional, due to the characteristics of the contract, varies over time, it shall reflect the remaining notional after the change took place.
    /// </summary>
    [IsoId("_fWRQUWEfEe2P-L9DBerEgA")]
    [DisplayName("Notional Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlAmt")]
    #endif
    [IsoXmlTag("NtnlAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalAmountLegs5? NotionalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalAmountLegs5? NotionalAmount { get; init; } 
    #else
    public NotionalAmountLegs5? NotionalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates for each leg of the transaction the total notional quantity of the underlying asset for the term of the transaction.|
    /// </summary>
    [IsoId("_fWRQU2EfEe2P-L9DBerEgA")]
    [DisplayName("Notional Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtnlQty")]
    #endif
    [IsoXmlTag("NtnlQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NotionalQuantityLegs5? NotionalQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NotionalQuantityLegs5? NotionalQuantity { get; init; } 
    #else
    public NotionalQuantityLegs5? NotionalQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of units of the financial instrument, that is, the nominal value.
    /// </summary>
    [IsoId("_fWRQVWEfEe2P-L9DBerEgA")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity32Choice_? Quantity { get; init; } 
    #else
    public FinancialInstrumentQuantity32Choice_? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instrument is settled physically or in cash or decided at expiration time by counterparty.
    /// </summary>
    [IsoId("_fWRQV2EfEe2P-L9DBerEgA")]
    [DisplayName("Delivery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryTp")]
    #endif
    [IsoXmlTag("DlvryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PhysicalTransferType4Code? DeliveryType { get; init; } 
    #else
    public PhysicalTransferType4Code? DeliveryType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the execution of the derivative transaction.
    /// </summary>
    [IsoId("_fWRQWWEfEe2P-L9DBerEgA")]
    [DisplayName("Execution Time Stamp")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnTmStmp")]
    #endif
    [IsoXmlTag("ExctnTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ExecutionTimeStamp { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ExecutionTimeStamp { get; init; } 
    #else
    public System.DateTime? ExecutionTimeStamp { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date when obligations under the contract come into effect.
    /// </summary>
    [IsoId("_fWRQW2EfEe2P-L9DBerEgA")]
    [DisplayName("Effective Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FctvDt")]
    #endif
    [IsoXmlTag("FctvDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EffectiveDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EffectiveDate { get; init; } 
    #else
    public System.DateOnly? EffectiveDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unadjusted date at which obligations under the derivative transaction stop being effective, as included in the confirmation.
    /// |
    /// For European style options, date on which the holder can exercise the right or let it lapse.|
    /// For American style options, the holder can exercise the right up to the expiry date.
    /// |
    /// Usage: 
    /// An early termination shall not be reported in this field.
    /// </summary>
    [IsoId("_fWRQXWEfEe2P-L9DBerEgA")]
    [DisplayName("Expiration Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XprtnDt")]
    #endif
    [IsoXmlTag("XprtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpirationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpirationDate { get; init; } 
    #else
    public System.DateOnly? ExpirationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the effective date of the early termination of the reported derivative transaction.
    /// </summary>
    [IsoId("_fWRQX2EfEe2P-L9DBerEgA")]
    [DisplayName("Early Termination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlyTermntnDt")]
    #endif
    [IsoXmlTag("EarlyTermntnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EarlyTerminationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EarlyTerminationDate { get; init; } 
    #else
    public System.DateOnly? EarlyTerminationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the unadjusted date, as per the contract, by which all transfer of cash or assets should take place and the counterparties should no longer have any outstanding obligations to each other.||
    /// For products that may not have a final contractual settlement date (eg American options), this data element reflects the date by which the transfer of cash or asset would take place if termination were to occur on the expiration date.
    /// </summary>
    [IsoId("_fWRQYWEfEe2P-L9DBerEgA")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? SettlementDate { get; init; } 
    #else
    public System.DateOnly? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the master agreement.
    /// </summary>
    [IsoId("_fWRQZWEfEe2P-L9DBerEgA")]
    [DisplayName("Master Agreement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrAgrmt")]
    #endif
    [IsoXmlTag("MstrAgrmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MasterAgreement8? MasterAgreement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MasterAgreement8? MasterAgreement { get; init; } 
    #else
    public MasterAgreement8? MasterAgreement { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether the contract results from a compression operation or not.
    /// Usage: If the element is not present, the Compression is False.
    /// </summary>
    [IsoId("_fWRQZ2EfEe2P-L9DBerEgA")]
    [DisplayName("Compression")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmprssn")]
    #endif
    [IsoXmlTag("Cmprssn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? Compression { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Compression { get; init; } 
    #else
    public System.String? Compression { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the contract results from a PTRR operation.
    /// </summary>
    [IsoId("_fWRQaWEfEe2P-L9DBerEgA")]
    [DisplayName("Post Trade Risk Reduction Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstTradRskRdctnFlg")]
    #endif
    [IsoXmlTag("PstTradRskRdctnFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? PostTradeRiskReductionFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PostTradeRiskReductionFlag { get; init; } 
    #else
    public System.String? PostTradeRiskReductionFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Identify whether the contract results from a Post Trade Risk Reduction operation. 
    /// </summary>
    [IsoId("_fWRQa2EfEe2P-L9DBerEgA")]
    [DisplayName("Post Trade Risk Reduction Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PstTradRskRdctnEvt")]
    #endif
    [IsoXmlTag("PstTradRskRdctnEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PTRREvent2? PostTradeRiskReductionEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PTRREvent2? PostTradeRiskReductionEvent { get; init; } 
    #else
    public PTRREvent2? PostTradeRiskReductionEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Indication of the derivative event of the transaction.
    /// </summary>
    [IsoId("_fWRQbWEfEe2P-L9DBerEgA")]
    [DisplayName("Derivative Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivEvt")]
    #endif
    [IsoXmlTag("DerivEvt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DerivativeEvent6? DerivativeEvent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DerivativeEvent6? DerivativeEvent { get; init; } 
    #else
    public DerivativeEvent6? DerivativeEvent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the contract was electronically confirmed, non-electronically confirmed or remains unconfirmed.
    /// </summary>
    [IsoId("_fWRQb2EfEe2P-L9DBerEgA")]
    [DisplayName("Trade Confirmation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradConf")]
    #endif
    [IsoXmlTag("TradConf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeConfirmation1Choice_? TradeConfirmation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeConfirmation1Choice_? TradeConfirmation { get; init; } 
    #else
    public TradeConfirmation1Choice_? TradeConfirmation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative transaction has one or more additional terms or provisions that materially affect the price of the transaction.
    /// Usage: If the element is not present, the NonStandardisedTerm is False.
    /// </summary>
    [IsoId("_fWRQcWEfEe2P-L9DBerEgA")]
    [DisplayName("Non Standardised Term")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonStdsdTerm")]
    #endif
    [IsoXmlTag("NonStdsdTerm")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? NonStandardisedTerm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NonStandardisedTerm { get; init; } 
    #else
    public System.String? NonStandardisedTerm { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to clearing of the reported contract.
    /// </summary>
    [IsoId("_fWRQc2EfEe2P-L9DBerEgA")]
    [DisplayName("Trade Clearing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradClr")]
    #endif
    [IsoXmlTag("TradClr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeClearing11? TradeClearing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeClearing11? TradeClearing { get; init; } 
    #else
    public TradeClearing11? TradeClearing { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an election has been made to report the derivative transaction as a block transaction.
    /// Usage: If the element is not present, the BlockTradeElection is False.
    /// </summary>
    [IsoId("_fWRQdWEfEe2P-L9DBerEgA")]
    [DisplayName("Block Trade Election")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckTradElctn")]
    #endif
    [IsoXmlTag("BlckTradElctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? BlockTradeElection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockTradeElection { get; init; } 
    #else
    public System.String? BlockTradeElection { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether an election has been made to report the derivative transaction as a large notional off-facility transaction.
    /// Usage: If the element is not present, the LargeNotionalOffFacilityElection is False.
    /// </summary>
    [IsoId("_fWRQd2EfEe2P-L9DBerEgA")]
    [DisplayName("Large Notional Off Facility Election")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LrgNtnlOffFcltyElctn")]
    #endif
    [IsoXmlTag("LrgNtnlOffFcltyElctn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? LargeNotionalOffFacilityElection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LargeNotionalOffFacilityElection { get; init; } 
    #else
    public System.String? LargeNotionalOffFacilityElection { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to interest rate asset class type.
    /// </summary>
    [IsoId("_fWRQeWEfEe2P-L9DBerEgA")]
    [DisplayName("Interest Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstRate")]
    #endif
    [IsoXmlTag("IntrstRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestRateLegs14? InterestRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestRateLegs14? InterestRate { get; init; } 
    #else
    public InterestRateLegs14? InterestRate { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to currency asset class type.
    /// </summary>
    [IsoId("_fWRQe2EfEe2P-L9DBerEgA")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange22? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange22? Currency { get; init; } 
    #else
    public CurrencyExchange22? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to commodity asset class type.
    /// </summary>
    [IsoId("_fWRQfWEfEe2P-L9DBerEgA")]
    [DisplayName("Commodity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmmdty")]
    #endif
    [IsoXmlTag("Cmmdty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassCommodity6Choice_? Commodity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassCommodity6Choice_? Commodity { get; init; } 
    #else
    public AssetClassCommodity6Choice_? Commodity { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_fWRQf2EfEe2P-L9DBerEgA")]
    [DisplayName("Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Optn")]
    #endif
    [IsoXmlTag("Optn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionOrSwaption10? Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionOrSwaption10? Option { get; init; } 
    #else
    public OptionOrSwaption10? Option { get; set; } 
    #endif
    
    /// <summary>
    /// Attributes specific for derivative contracts related to natural gas and electricity.
    /// </summary>
    [IsoId("_fWRQgWEfEe2P-L9DBerEgA")]
    [DisplayName("Energy Specific Attributes")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NrgySpcfcAttrbts")]
    #endif
    [IsoXmlTag("NrgySpcfcAttrbts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EnergySpecificAttribute9? EnergySpecificAttributes { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EnergySpecificAttribute9? EnergySpecificAttributes { get; init; } 
    #else
    public EnergySpecificAttribute9? EnergySpecificAttributes { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to credit derivative asset class type.
    /// </summary>
    [IsoId("_fWRQg2EfEe2P-L9DBerEgA")]
    [DisplayName("Credit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cdt")]
    #endif
    [IsoXmlTag("Cdt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDerivative4? Credit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDerivative4? Credit { get; init; } 
    #else
    public CreditDerivative4? Credit { get; set; } 
    #endif
    
    /// <summary>
    /// Payment related to elements not reported in dedicated fields.
    /// </summary>
    [IsoId("_fWRQhWEfEe2P-L9DBerEgA")]
    [DisplayName("Other Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPmt")]
    #endif
    [IsoXmlTag("OthrPmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherPayment5? OtherPayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherPayment5? OtherPayment { get; init; } 
    #else
    public OtherPayment5? OtherPayment { get; set; } 
    #endif
    
    /// <summary>
    /// A combination of two or more transactions that are reported separately but that are negotiated together as the product of a single economic agreement.
    /// </summary>
    [IsoId("_fWRQh2EfEe2P-L9DBerEgA")]
    [DisplayName("Package")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Packg")]
    #endif
    [IsoXmlTag("Packg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Package4? Package { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Package4? Package { get; init; } 
    #else
    public Package4? Package { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the trade is a pre-allocation or a post-allocation trade, or whether the trade is unallocated.
    /// </summary>
    [IsoId("_fWRQiWEfEe2P-L9DBerEgA")]
    [DisplayName("Trade Allocation Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAllcnSts")]
    #endif
    [IsoXmlTag("TradAllcnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AllocationIndicator1Code? TradeAllocationStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AllocationIndicator1Code? TradeAllocationStatus { get; init; } 
    #else
    public AllocationIndicator1Code? TradeAllocationStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}
