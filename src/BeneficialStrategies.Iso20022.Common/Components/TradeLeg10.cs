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
[IsoId("_LpIEAS6aEeSQQqw1BT_aMg")]
[DisplayName("Trade Leg")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeLeg10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeLeg10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeLeg10( System.String reqTradeLegIdentification,System.String reqTradeExecutionIdentification,System.DateOnly reqTradeDate,DateFormat15Choice_ reqSettlementDate,Side1Code reqBuySellIndicator,FinancialInstrumentQuantity1Choice_ reqTradeQuantity,Price4 reqDealPrice,MarketIdentification84 reqPlaceOfTrade,TradeType1Code reqTradeType,PartyIdentification35Choice_ reqTradingParty,TradingCapacity5Code reqTradingCapacity )
    {
        TradeLegIdentification = reqTradeLegIdentification;
        TradeExecutionIdentification = reqTradeExecutionIdentification;
        TradeDate = reqTradeDate;
        SettlementDate = reqSettlementDate;
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
    /// Unambiguous identification of the transaction (that is the trade leg) as know by the instructing party.
    /// </summary>
    [IsoId("_L9qJkS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJky6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJlS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_rk0PoC69EeSQQqw1BT_aMg")]
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
    [IsoId("_0pJBwC67EeSQQqw1BT_aMg")]
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
    /// Provides the date and time of trade transaction.
    /// </summary>
    [IsoId("_L9qJly6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate TradeDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly TradeDate { get; init; } 
    #else
    public System.DateOnly TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time used to determine the price applicable to a trade. If the trade is registered &quot;after market&quot; hours, the trading price will the price of the day but the actual trade date will be the next working day.
    /// </summary>
    [IsoId("_p0ynAC6-EeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJmS6aEeSQQqw1BT_aMg")]
    [DisplayName("Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmDt")]
    #endif
    [IsoXmlTag("SttlmDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat15Choice_ SettlementDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat15Choice_ SettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat15Choice_ SettlementDate { get; init; } 
    #else
    public DateFormat15Choice_ SettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the ISO code of the trade currency.
    /// </summary>
    [IsoId("_L9qJmy6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJnS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJny6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJoS6aEeSQQqw1BT_aMg")]
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
    /// Principal amount of a trade (price multiplied by quantity).
    /// </summary>
    [IsoId("_Nm6RcC69EeSQQqw1BT_aMg")]
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
    
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_L9qJoy6aEeSQQqw1BT_aMg")]
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
    /// Place where the referenced financial instrument is listed.
    /// </summary>
    [IsoId("_L9qJpS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJpy6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJqS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_GtZXwC7EEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJqy6aEeSQQqw1BT_aMg")]
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
    [IsoId("_pqoI8C6_EeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJrS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJry6aEeSQQqw1BT_aMg")]
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
    [IsoId("_L9qJsS6aEeSQQqw1BT_aMg")]
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
    [IsoId("_JGdagC68EeSQQqw1BT_aMg")]
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
    [IsoId("_kgqF0C68EeSQQqw1BT_aMg")]
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
    
    
    #nullable disable
    
}
