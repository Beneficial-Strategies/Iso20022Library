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
/// Provides the trade leg details.
/// </summary>
[IsoId("_bBw7kS6SEeSQQqw1BT_aMg")]
[DisplayName("Trade Leg")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeLeg9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeLeg9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeLeg9( System.String reqTradeLegIdentification,System.String reqTradeExecutionIdentification,System.DateTime reqTradeDate,SecurityIdentification14 reqFinancialInstrumentIdentification,Side1Code reqBuySellIndicator,FinancialInstrumentQuantity1Choice_ reqTradeQuantity,Price4 reqDealPrice,MarketIdentification84 reqPlaceOfTrade,TradeType1Code reqTradeType,PartyIdentification35Choice_ reqTradingParty,TradingCapacity5Code reqTradingCapacity )
    {
        TradeLegIdentification = reqTradeLegIdentification;
        TradeExecutionIdentification = reqTradeExecutionIdentification;
        TradeDate = reqTradeDate;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        BuySellIndicator = reqBuySellIndicator;
        TradeQuantity = reqTradeQuantity;
        DealPrice = reqDealPrice;
        PlaceOfTrade = reqPlaceOfTrade;
        TradeType = reqTradeType;
        TradingParty = reqTradingParty;
        TradingCapacity = reqTradingCapacity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Margin account where the negotiation and liquidation risks will be calculated.
    /// </summary>
    [IsoId("_bVGuUy6SEeSQQqw1BT_aMg")]
    [DisplayName("Margin Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnAcct")]
    #endif
    [IsoXmlTag("MrgnAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? MarginAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? MarginAccount { get; init; } 
    #else
    public SecuritiesAccount19? MarginAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_bVGuVS6SEeSQQqw1BT_aMg")]
    [DisplayName("Delivery Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DlvryAcct")]
    #endif
    [IsoXmlTag("DlvryAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? DeliveryAccount { get; init; } 
    #else
    public SecuritiesAccount19? DeliveryAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the transaction (that is the trade leg) as known by the instructing party.
    /// </summary>
    [IsoId("_bVGuVy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Leg Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLegId")]
    #endif
    [IsoXmlTag("TradLegId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeLegIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeLegIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeLegIdentification { get; init; } 
    #else
    public System.String TradeLegIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reference allocated by the broker dealer.
    /// </summary>
    [IsoId("_bVGuWS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradId")]
    #endif
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeIdentification { get; init; } 
    #else
    public System.String? TradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference assigned by the trading venue when the trade is executed.
    /// </summary>
    [IsoId("_bVGuWy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Execution Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradExctnId")]
    #endif
    [IsoXmlTag("TradExctnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TradeExecutionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TradeExecutionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TradeExecutionIdentification { get; init; } 
    #else
    public System.String TradeExecutionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the order sent by the final investor to an intermediary in order to initiate a trade in the former&apos;s name. This identification is then matched with the equivalent trade by the clearing.
    /// </summary>
    [IsoId("_qeNwkC6UEeSQQqw1BT_aMg")]
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
    /// Identifies the portion of assets within a determined trade that shall be allocated to different clients.
    /// </summary>
    [IsoId("_YReIwC6TEeSQQqw1BT_aMg")]
    [DisplayName("Allocation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllcnId")]
    #endif
    [IsoXmlTag("AllcnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AllocationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AllocationIdentification { get; init; } 
    #else
    public System.String? AllocationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the non clearing member identification and account.
    /// </summary>
    [IsoId("_bVGuXS6SEeSQQqw1BT_aMg")]
    [DisplayName("Non Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonClrMmb")]
    #endif
    [IsoXmlTag("NonClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount31? NonClearingMember { get; init; } 
    #else
    public PartyIdentificationAndAccount31? NonClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date and time of trade transaction.
    /// </summary>
    [IsoId("_bVGuXy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime TradeDate { get; init; } 
    #else
    public System.DateTime TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time used to determine the price applicable to a trade. If the trade is registered &quot;after market&quot; hours, the trading price will the price of the day but the actual trade date will be the next working day.
    /// </summary>
    [IsoId("_QTIHQC6VEeSQQqw1BT_aMg")]
    [DisplayName("Transaction Date And Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDtAndTm")]
    #endif
    [IsoXmlTag("TxDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? TransactionDateAndTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? TransactionDateAndTime { get; init; } 
    #else
    public System.DateTime? TransactionDateAndTime { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_bVGuYS6SEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat15Choice_? SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat15Choice_? SettlementDate { get; init; } 
    #else
    public DateFormat15Choice_? SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_bVGuYy6SEeSQQqw1BT_aMg")]
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
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_bVGuZS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCcy")]
    #endif
    [IsoXmlTag("TradgCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? TradingCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? TradingCurrency { get; init; } 
    #else
    public string? TradingCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trade leg indicator which gives the trade side (buy or sell).
    /// </summary>
    [IsoId("_bVGuZy6SEeSQQqw1BT_aMg")]
    [DisplayName("Buy Sell Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BuySellInd")]
    #endif
    [IsoXmlTag("BuySellInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Side1Code BuySellIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Side1Code BuySellIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Side1Code BuySellIndicator { get; init; } 
    #else
    public Side1Code BuySellIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_bVGuaS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradQty")]
    #endif
    [IsoXmlTag("TradQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ TradeQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ TradeQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the price of the traded financial instrument.
    /// </summary>
    [IsoId("_bVGuay6SEeSQQqw1BT_aMg")]
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
    /// Interest that has accumulated on a bond since the last interest payment up to, but not including, the settlement date.
    /// </summary>
    [IsoId("_bVGubS6SEeSQQqw1BT_aMg")]
    [DisplayName("Accrued Interest Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcrdIntrstAmt")]
    #endif
    [IsoXmlTag("AcrdIntrstAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? AccruedInterestAmount { get; init; } 
    #else
    public AmountAndDirection21? AccruedInterestAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_bVGuby6SEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MarketIdentification84 PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification84 PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification84 PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Place at which the security is listed.
    /// </summary>
    [IsoId("_bVGucS6SEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Listing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfListg")]
    #endif
    [IsoXmlTag("PlcOfListg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification85? PlaceOfListing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification85? PlaceOfListing { get; init; } 
    #else
    public MarketIdentification85? PlaceOfListing { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the type of trade transaction.
    /// </summary>
    [IsoId("_bVGucy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradTp")]
    #endif
    [IsoXmlTag("TradTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeType1Code TradeType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeType1Code TradeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeType1Code TradeType { get; init; } 
    #else
    public TradeType1Code TradeType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that the trade is for settlement of an exercised derivatives contract.
    /// </summary>
    [IsoId("_bVGudS6SEeSQQqw1BT_aMg")]
    [DisplayName("Derivative Related Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DerivRltdTrad")]
    #endif
    [IsoXmlTag("DerivRltdTrad")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DerivativeRelatedTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DerivativeRelatedTrade { get; init; } 
    #else
    public System.String? DerivativeRelatedTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Party that identifies a broker when required (for example, authorised broker or prime broker).
    /// </summary>
    [IsoId("_12bGQC9VEeS94oXWDaBauA")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentificationAndAccount100? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentificationAndAccount100? Broker { get; init; } 
    #else
    public PartyIdentificationAndAccount100? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification of the trading party.
    /// </summary>
    [IsoId("_bVGudy6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPty")]
    #endif
    [IsoXmlTag("TradgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification35Choice_ TradingParty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification35Choice_ TradingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification35Choice_ TradingParty { get; init; } 
    #else
    public PartyIdentification35Choice_ TradingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates in which session the transaction/operation was executed by the final investor or an intermediary.
    /// </summary>
    [IsoId("_qEZs8C6VEeSQQqw1BT_aMg")]
    [DisplayName("Trade Registration Origin")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradRegnOrgn")]
    #endif
    [IsoXmlTag("TradRegnOrgn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TradeRegistrationOrigin { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TradeRegistrationOrigin { get; init; } 
    #else
    public System.String? TradeRegistrationOrigin { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of the trading participant&apos;s account at the trading venue using the venue&apos;s coding system.
    /// </summary>
    [IsoId("_bVGueS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Party Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgPtyAcct")]
    #endif
    [IsoXmlTag("TradgPtyAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? TradingPartyAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? TradingPartyAccount { get; init; } 
    #else
    public SecuritiesAccount19? TradingPartyAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the role of the trading party in the transaction.
    /// </summary>
    [IsoId("_bVGuey6SEeSQQqw1BT_aMg")]
    [DisplayName("Trading Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCpcty")]
    #endif
    [IsoXmlTag("TradgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradingCapacity5Code TradingCapacity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradingCapacity5Code TradingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity5Code TradingCapacity { get; init; } 
    #else
    public TradingCapacity5Code TradingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates how a trade is maintained in the clearing account.
    /// </summary>
    [IsoId("_bVGufS6SEeSQQqw1BT_aMg")]
    [DisplayName("Trade Posting Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradPstngCd")]
    #endif
    [IsoXmlTag("TradPstngCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePosting1Code? TradePostingCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePosting1Code? TradePostingCode { get; init; } 
    #else
    public TradePosting1Code? TradePostingCode { get; set; } 
    #endif
    
    /// <summary>
    /// Place where the securities are safe-kept, physically or notionally. This place can be, for example, a local custodian, a Central Securities Depository (CSD) or an International Central Securities Depository (ICSD).
    /// </summary>
    [IsoId("_UbaAsC6UEeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Place")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgPlc")]
    #endif
    [IsoXmlTag("SfkpgPlc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; init; } 
    #else
    public SafekeepingPlaceFormat7Choice_? SafekeepingPlace { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_dmB9MC6UEeSQQqw1BT_aMg")]
    [DisplayName("Safekeeping Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfkpgAcct")]
    #endif
    [IsoXmlTag("SfkpgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    #else
    public SecuritiesAccount19? SafekeepingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides settlement details such as the settlement amount or the place of settlement.
    /// </summary>
    [IsoId("_bVGufy6SEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDtls")]
    #endif
    [IsoXmlTag("SttlmDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Settlement1? SettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Settlement1? SettlementDetails { get; init; } 
    #else
    public Settlement1? SettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides clearing details such as the non clearing member identification or the settlement netting (or not) eligibility code.
    /// </summary>
    [IsoId("_bVGugS6SEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrDtls")]
    #endif
    [IsoXmlTag("ClrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Clearing4? ClearingDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Clearing4? ClearingDetails { get; init; } 
    #else
    public Clearing4? ClearingDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_Gq1eoC9WEeS94oXWDaBauA")]
    [DisplayName("Gross Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrssAmt")]
    #endif
    [IsoXmlTag("GrssAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? GrossAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? GrossAmount { get; init; } 
    #else
    public AmountAndDirection21? GrossAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
