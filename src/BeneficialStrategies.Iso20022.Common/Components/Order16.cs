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
/// Intention to transfer an ownership of a financial instrument.
/// </summary>
[IsoId("_App2ctokEeC60axPepSq7g_-83194478")]
[DisplayName("Order")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Order16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Order16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Order16( SecurityIdentification14 reqFinancialInstrumentIdentification,Side3Code reqSide,TradeDate4Choice_ reqTradeDate,SettlementDate8Choice_ reqSettlementDate,Quantity6Choice_ reqConfirmationQuantity,Price4 reqDealPrice )
    {
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        Side = reqSide;
        TradeDate = reqTradeDate;
        SettlementDate = reqSettlementDate;
        ConfirmationQuantity = reqConfirmationQuantity;
        DealPrice = reqDealPrice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of business process.
    /// </summary>
    [IsoId("_App2c9okEeC60axPepSq7g_-197033544")]
    [DisplayName("Business Process Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizPrcTp")]
    #endif
    [IsoXmlTag("BizPrcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BusinessProcessType1Choice_? BusinessProcessType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BusinessProcessType1Choice_? BusinessProcessType { get; init; } 
    #else
    public BusinessProcessType1Choice_? BusinessProcessType { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for Order as assigned by sell-side.
    /// </summary>
    [IsoId("_App2dNokEeC60axPepSq7g_-1194105897")]
    [DisplayName("Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrId")]
    #endif
    [IsoXmlTag("OrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OrderIdentification { get; init; } 
    #else
    public System.String? OrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for the order as assigned by the buy-side. Uniqueness must be guaranteed within a single trading day. Firms, particularly those that electronically submit multi-day orders, trade globally or throughout market close periods, should ensure uniqueness across days, for example by embedding a date within the ClientOrderIdentification element.
    /// </summary>
    [IsoId("_App2ddokEeC60axPepSq7g_2103789046")]
    [DisplayName("Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntOrdrId")]
    #endif
    [IsoXmlTag("ClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientOrderIdentification { get; init; } 
    #else
    public System.String? ClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Assigned by the party that originates the order. Can be used to provide the ClientOrderIdentification used by an exchange or executing system.
    /// </summary>
    [IsoId("_App2dtokEeC60axPepSq7g_1106716693")]
    [DisplayName("Secondary Client Order Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryClntOrdrId")]
    #endif
    [IsoXmlTag("ScndryClntOrdrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SecondaryClientOrderIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecondaryClientOrderIdentification { get; init; } 
    #else
    public System.String? SecondaryClientOrderIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    [IsoId("_App2d9okEeC60axPepSq7g_109644340")]
    [DisplayName("List Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListId")]
    #endif
    [IsoXmlTag("ListId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ListIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ListIdentification { get; init; } 
    #else
    public System.String? ListIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a financial instrument, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_App2eNokEeC60axPepSq7g_-49832084")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification14 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification14 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Coded list to specify the side of the order.
    /// </summary>
    [IsoId("_ApzncNokEeC60axPepSq7g_-887428013")]
    [DisplayName("Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sd")]
    #endif
    [IsoXmlTag("Sd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Side3Code Side { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Side3Code Side { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side3Code Side { get; init; } 
    #else
    public Side3Code Side { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_ApzncdokEeC60axPepSq7g_-1770661300")]
    [DisplayName("Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pmt")]
    #endif
    [IsoXmlTag("Pmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DeliveryReceiptType2Code? Payment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DeliveryReceiptType2Code? Payment { get; init; } 
    #else
    public DeliveryReceiptType2Code? Payment { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of transaction of which the order is a component.
    /// </summary>
    [IsoId("_ApznctokEeC60axPepSq7g_1527233643")]
    [DisplayName("Trade Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTxTp")]
    #endif
    [IsoXmlTag("TradTxTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeType3Choice_? TradeTransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeType3Choice_? TradeTransactionType { get; init; } 
    #else
    public TradeType3Choice_? TradeTransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the conditions under which the order/trade is to be/was executed.
    /// </summary>
    [IsoId("_Apznc9okEeC60axPepSq7g_1413394577")]
    [DisplayName("Trade Transaction Condition")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTxCond")]
    #endif
    [IsoXmlTag("TradTxCond")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeTransactionCondition4Choice_? TradeTransactionCondition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeTransactionCondition4Choice_? TradeTransactionCondition { get; init; } 
    #else
    public TradeTransactionCondition4Choice_? TradeTransactionCondition { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction is a pre-advice, that is, for matching purposes only.
    /// </summary>
    [IsoId("_ApzndNokEeC60axPepSq7g_-758868801")]
    [DisplayName("Pre Advice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreAdvc")]
    #endif
    [IsoXmlTag("PreAdvc")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PreAdvice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreAdvice { get; init; } 
    #else
    public System.String? PreAdvice { get; set; } 
    #endif
    
    /// <summary>
    /// Market in which a trade transaction is to be or has been executed.
    /// </summary>
    [IsoId("_ApznddokEeC60axPepSq7g_-1755941154")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification77? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification77? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification77? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time when an entry is posted to an account on the account servicer&apos;s books.
    /// </summary>
    [IsoId("_Ap8xYNokEeC60axPepSq7g_1541953789")]
    [DisplayName("Order Booking Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrBookgDt")]
    #endif
    [IsoXmlTag("OrdrBookgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? OrderBookingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? OrderBookingDate { get; init; } 
    #else
    public System.DateOnly? OrderBookingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    [IsoId("_Ap8xYdokEeC60axPepSq7g_544881436")]
    [DisplayName("Trade Origination Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradOrgtnDt")]
    #endif
    [IsoXmlTag("TradOrgtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TradeOriginationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TradeOriginationDate { get; init; } 
    #else
    public System.DateTime? TradeOriginationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_Ap8xYtokEeC60axPepSq7g_-452190917")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeDate4Choice_ TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeDate4Choice_ TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate4Choice_ TradeDate { get; init; } 
    #else
    public TradeDate4Choice_ TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Processing date of the trading session.
    /// </summary>
    [IsoId("_Ap8xY9okEeC60axPepSq7g_1429115902")]
    [DisplayName("Processing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgDt")]
    #endif
    [IsoXmlTag("PrcgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeDate4Choice_? ProcessingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeDate4Choice_? ProcessingDate { get; init; } 
    #else
    public TradeDate4Choice_? ProcessingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_Ap8xZNokEeC60axPepSq7g_-1449263270")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SettlementDate8Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SettlementDate8Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementDate8Choice_ SettlementDate { get; init; } 
    #else
    public SettlementDate8Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Valuation point, or valuation date of the portfolio (underlying assets). This is also known as price date.
    /// </summary>
    [IsoId("_Ap8xZdokEeC60axPepSq7g_2140589411")]
    [DisplayName("NAV Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NAVDt")]
    #endif
    [IsoXmlTag("NAVDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime1Choice_? NAVDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_? NAVDate { get; init; } 
    #else
    public DateAndDateTime1Choice_? NAVDate { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument bought or sold which is less than the quantity of financial instrument ordered.
    /// </summary>
    [IsoId("_Ap8xZtokEeC60axPepSq7g_1143517058")]
    [DisplayName("Partial Fill Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlFillDtls")]
    #endif
    [IsoXmlTag("PrtlFillDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartialFill1? PartialFillDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartialFill1? PartialFillDetails { get; init; } 
    #else
    public PartialFill1? PartialFillDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of financial instrument that is being confirmed for the account.The quantity of the security to be settled.
    /// </summary>
    [IsoId("_AqGiYNokEeC60axPepSq7g_-1506182803")]
    [DisplayName("Confirmation Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfQty")]
    #endif
    [IsoXmlTag("ConfQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity6Choice_ ConfirmationQuantity { get; init; } 
    #else
    public Quantity6Choice_ ConfirmationQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of a quantity into lots such as tax lots, instrument series, etc.
    /// </summary>
    [IsoId("_AqGiYdokEeC60axPepSq7g_-145513033")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown11? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown11? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown11? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_AqGiYtokEeC60axPepSq7g_-936289665")]
    [DisplayName("Gross Trade Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssTradAmt")]
    #endif
    [IsoXmlTag("GrssTradAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? GrossTradeAmount { get; init; } 
    #else
    public AmountAndDirection29? GrossTradeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money for which goods or services are offered, sold, or bought.
    /// </summary>
    [IsoId("_AqGiY9okEeC60axPepSq7g_467842735")]
    [DisplayName("Deal Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealPric")]
    #endif
    [IsoXmlTag("DealPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Price4 DealPrice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Price4 DealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4 DealPrice { get; init; } 
    #else
    public Price4 DealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of transaction price.
    /// </summary>
    [IsoId("_AqGiZNokEeC60axPepSq7g_-529229618")]
    [DisplayName("Type Of Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TpOfPric")]
    #endif
    [IsoXmlTag("TpOfPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfPrice10Choice_? TypeOfPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfPrice10Choice_? TypeOfPrice { get; init; } 
    #else
    public TypeOfPrice10Choice_? TypeOfPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies whether an order is a margin order or a non-margin order. This is primarily used when sending orders to Japanese exchanges to indicate sell margin or buy to cover. The same tag could be assigned also by buy-side to indicate the intent to sell or buy margin and the sell-side to accept or reject (base on some validation criteria) the margin request.
    /// </summary>
    [IsoId("_AqGiZdokEeC60axPepSq7g_-1526301971")]
    [DisplayName("Cash Margin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshMrgn")]
    #endif
    [IsoXmlTag("CshMrgn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashMarginOrder1Code? CashMargin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashMarginOrder1Code? CashMargin { get; init; } 
    #else
    public CashMarginOrder1Code? CashMargin { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money due to a party as compensation for a service.
    /// </summary>
    [IsoId("_AqGiZtokEeC60axPepSq7g_1771592972")]
    [DisplayName("Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Comssn")]
    #endif
    [IsoXmlTag("Comssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission16? Commission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission16? Commission { get; init; } 
    #else
    public Commission16? Commission { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days on which the interest rate accrues (daily accrual note).
    /// </summary>
    [IsoId("_AqPsUNokEeC60axPepSq7g_-222551734")]
    [DisplayName("Number Of Days Accrued")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfDaysAcrd")]
    #endif
    [IsoXmlTag("NbOfDaysAcrd")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? NumberOfDaysAccrued { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? NumberOfDaysAccrued { get; init; } 
    #else
    public System.UInt64? NumberOfDaysAccrued { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the number of days from trade date that the counterparty on the other side of the trade should be &quot;given up&quot; or divulged.
    /// </summary>
    [IsoId("_AqPsUdokEeC60axPepSq7g_-927666349")]
    [DisplayName("Give Up Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GvUpNbOfDays")]
    #endif
    [IsoXmlTag("GvUpNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3Number? GiveUpNumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? GiveUpNumberOfDays { get; init; } 
    #else
    public System.UInt64? GiveUpNumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the trade is cum interest or ex interest.
    /// </summary>
    [IsoId("_AqPsUtokEeC60axPepSq7g_-1924738702")]
    [DisplayName("Interest Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstTp")]
    #endif
    [IsoXmlTag("IntrstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestType2Code? InterestType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestType2Code? InterestType { get; init; } 
    #else
    public InterestType2Code? InterestType { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate that has been accrued in between coupon payment periods.
    /// </summary>
    [IsoId("_AqPsU9okEeC60axPepSq7g_1373156241")]
    [DisplayName("Accrued Interest Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstPctg")]
    #endif
    [IsoXmlTag("AcrdIntrstPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? AccruedInterestPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AccruedInterestPercentage { get; init; } 
    #else
    public System.Decimal? AccruedInterestPercentage { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the regulatory conditions type of the trade.
    /// </summary>
    [IsoId("_AqPsVNokEeC60axPepSq7g_-1618060818")]
    [DisplayName("Trade Regulatory Conditions Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRgltryCondsTp")]
    #endif
    [IsoXmlTag("TradRgltryCondsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; init; } 
    #else
    public TradeRegulatoryConditions1Code? TradeRegulatoryConditionsType { get; set; } 
    #endif
    
    /// <summary>
    /// Account servicer is instructed to buy the indicated currency after the receipt of cash proceeds or to sell the indicated currency in order to obtain the necessary currency to fund the transaction.
    /// </summary>
    [IsoId("_AqPsVdokEeC60axPepSq7g_1679834125")]
    [DisplayName("Currency To Buy Or Sell")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyToBuyOrSell")]
    #endif
    [IsoXmlTag("CcyToBuyOrSell")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; init; } 
    #else
    public CurrencyToBuyOrSell1Choice_? CurrencyToBuyOrSell { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparties eligibility as defined by article 24 of the EU MiFID Directive applicable to transactions executed by investment firms for eligible counterparties.
    /// </summary>
    [IsoId("_AqPsVtokEeC60axPepSq7g_-314310581")]
    [DisplayName("Order Originator Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrOrgtrElgblty")]
    #endif
    [IsoXmlTag("OrdrOrgtrElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Eligibility1Code? OrderOriginatorEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Eligibility1Code? OrderOriginatorEligibility { get; init; } 
    #else
    public Eligibility1Code? OrderOriginatorEligibility { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the resulting position after a trade should be an opening position or closing position. Used for omnibus accounting - where accounts are held on a gross basis instead of being netted together.
    /// </summary>
    [IsoId("_AqZdUNokEeC60axPepSq7g_-1311382934")]
    [DisplayName("Position Effect")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosFct")]
    #endif
    [IsoXmlTag("PosFct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PositionEffect2Code? PositionEffect { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PositionEffect2Code? PositionEffect { get; init; } 
    #else
    public PositionEffect2Code? PositionEffect { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    [IsoId("_AqZdUdokEeC60axPepSq7g_1986512009")]
    [DisplayName("Derivative Covered")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivCvrd")]
    #endif
    [IsoXmlTag("DerivCvrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DerivativeCovered { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DerivativeCovered { get; init; } 
    #else
    public System.String? DerivativeCovered { get; set; } 
    #endif
    
    /// <summary>
    /// Type of charge/tax basis.
    /// </summary>
    [IsoId("_AqZdUtokEeC60axPepSq7g_989439656")]
    [DisplayName("Charge Tax Basis Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgTaxBsisTp")]
    #endif
    [IsoXmlTag("ChrgTaxBsisTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; init; } 
    #else
    public ChargeTaxBasisType1Choice_? ChargeTaxBasisType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of capital gain.
    /// </summary>
    [IsoId("_AqZdU9okEeC60axPepSq7g_-7632697")]
    [DisplayName("Capital Gain Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlGnTp")]
    #endif
    [IsoXmlTag("CptlGnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGainType2Choice_? CapitalGainType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGainType2Choice_? CapitalGainType { get; init; } 
    #else
    public EUCapitalGainType2Choice_? CapitalGainType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the matching status of the trade confirmation.
    /// </summary>
    [IsoId("_AqZdVNokEeC60axPepSq7g_-1004705050")]
    [DisplayName("Match Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchSts")]
    #endif
    [IsoXmlTag("MtchSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MatchingStatus8Choice_? MatchStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MatchingStatus8Choice_? MatchStatus { get; init; } 
    #else
    public MatchingStatus8Choice_? MatchStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of pay-in call report.
    /// </summary>
    [IsoId("_AqZdVdokEeC60axPepSq7g_-2001777403")]
    [DisplayName("Call In Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallInTp")]
    #endif
    [IsoXmlTag("CallInTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CallIn1Code? CallInType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CallIn1Code? CallInType { get; init; } 
    #else
    public CallIn1Code? CallInType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of yield at which the transaction was effected.
    /// </summary>
    [IsoId("_AqjOUNokEeC60axPepSq7g_1296117540")]
    [DisplayName("Yield Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="YldTp")]
    #endif
    [IsoXmlTag("YldTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public YieldCalculation2? YieldType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public YieldCalculation2? YieldType { get; init; } 
    #else
    public YieldCalculation2? YieldType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that a trade is to be reported to a third party.
    /// </summary>
    [IsoId("_AqjOUdokEeC60axPepSq7g_299045187")]
    [DisplayName("Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rptg")]
    #endif
    [IsoXmlTag("Rptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reporting5Choice_? Reporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reporting5Choice_? Reporting { get; init; } 
    #else
    public Reporting5Choice_? Reporting { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_AqjOUtokEeC60axPepSq7g_1944312622")]
    [DisplayName("Additional Physical Or Registration Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlPhysOrRegnDtls")]
    #endif
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; init; } 
    #else
    public RegistrationParameters3? AdditionalPhysicalOrRegistrationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional details of the trade process not included within structured fields of this message.
    /// </summary>
    [IsoId("_AqjOU9okEeC60axPepSq7g_947240269")]
    [DisplayName("Additional Trade Instruction Processing Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlTradInstrPrcgInf")]
    #endif
    [IsoXmlTag("AddtlTradInstrPrcgInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalTradeInstructionProcessingInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalTradeInstructionProcessingInformation { get; init; } 
    #else
    public System.String? AdditionalTradeInstructionProcessingInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Interest amount that has accrued in between two periods, for example, in between interest payment periods.
    /// </summary>
    [IsoId("_AqjOVNokEeC60axPepSq7g_365865829")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection29? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection29? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection29? AccruedInterestAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
