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
/// Provides the net positions details.
/// </summary>
[IsoId("_Hkd7wS6aEeSQQqw1BT_aMg")]
[DisplayName("Net Position")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetPosition3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetPosition3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetPosition3( SecuritiesAccount18 reqClearingAccount,SecurityIdentification14 reqFinancialInstrumentIdentification,AmountAndDirection21 reqNetPositionAmount,FinancialInstrumentQuantity1Choice_ reqNetQuantity,ReceiveDelivery1Code reqSecuritiesMovementType,PartyIdentification34Choice_ reqDepository )
    {
        ClearingAccount = reqClearingAccount;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        NetPositionAmount = reqNetPositionAmount;
        NetQuantity = reqNetQuantity;
        SecuritiesMovementType = reqSecuritiesMovementType;
        Depository = reqDepository;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the clearing member account at the Central counterparty through which the trade must be cleared (sometimes called position account).
    /// </summary>
    [IsoId("_H3p9gy6aEeSQQqw1BT_aMg")]
    [DisplayName("Clearing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrAcct")]
    #endif
    [IsoXmlTag("ClrAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount18 ClearingAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount18 ClearingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount18 ClearingAccount { get; init; } 
    #else
    public SecuritiesAccount18 ClearingAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the identification for the non-clearing member.
    /// </summary>
    [IsoId("_H3p9hS6aEeSQQqw1BT_aMg")]
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
    /// An account opened by the central counterparty in the name of the clearing member or its settlement agent within the account structure, for settlement purposes (gives information about the clearing member/its settlement agent account at the central securities depository).
    /// </summary>
    [IsoId("_H3p9hy6aEeSQQqw1BT_aMg")]
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
    /// Provides details about the security identification.
    /// </summary>
    [IsoId("_H3p9iS6aEeSQQqw1BT_aMg")]
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
    /// Provides the initial position amount.
    /// </summary>
    [IsoId("_H3p9iy6aEeSQQqw1BT_aMg")]
    [DisplayName("Initial Position Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlPosAmt")]
    #endif
    [IsoXmlTag("InitlPosAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection21? InitialPositionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21? InitialPositionAmount { get; init; } 
    #else
    public AmountAndDirection21? InitialPositionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the net position amount.
    /// </summary>
    [IsoId("_H3p9jS6aEeSQQqw1BT_aMg")]
    [DisplayName("Net Position Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetPosAmt")]
    #endif
    [IsoXmlTag("NetPosAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection21 NetPositionAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection21 NetPositionAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21 NetPositionAmount { get; init; } 
    #else
    public AmountAndDirection21 NetPositionAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Interest that has accumulated on a bond since the last interest payment up to, but not including, the settlement date.
    /// </summary>
    [IsoId("_H3p9jy6aEeSQQqw1BT_aMg")]
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
    /// This is the price of the trade.
    /// </summary>
    [IsoId("_H3p9kS6aEeSQQqw1BT_aMg")]
    [DisplayName("Average Deal Price")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AvrgDealPric")]
    #endif
    [IsoXmlTag("AvrgDealPric")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Price4? AverageDealPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Price4? AverageDealPrice { get; init; } 
    #else
    public Price4? AverageDealPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the quantity of the trade leg.
    /// </summary>
    [IsoId("_H3p9ky6aEeSQQqw1BT_aMg")]
    [DisplayName("Net Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetQty")]
    #endif
    [IsoXmlTag("NetQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity1Choice_ NetQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity1Choice_ NetQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_ NetQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_ NetQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the securities movement direction, that is, whether this is a delivery or return.
    /// </summary>
    [IsoId("_H3p9lS6aEeSQQqw1BT_aMg")]
    [DisplayName("Securities Movement Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesMvmntTp")]
    #endif
    [IsoXmlTag("SctiesMvmntTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReceiveDelivery1Code SecuritiesMovementType { get; init; } 
    #else
    public ReceiveDelivery1Code SecuritiesMovementType { get; set; } 
    #endif
    
    /// <summary>
    /// Place at which a trade settles.
    /// </summary>
    [IsoId("_H3p9ly6aEeSQQqw1BT_aMg")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification34Choice_ Depository { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification34Choice_ Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification34Choice_ Depository { get; init; } 
    #else
    public PartyIdentification34Choice_ Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the trading capacity of the seller.
    /// </summary>
    [IsoId("_H3p9mS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trading Capacity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgCpcty")]
    #endif
    [IsoXmlTag("TradgCpcty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingCapacity5Code? TradingCapacity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingCapacity5Code? TradingCapacity { get; init; } 
    #else
    public TradingCapacity5Code? TradingCapacity { get; set; } 
    #endif
    
    /// <summary>
    /// Place at which the security is traded.
    /// </summary>
    [IsoId("_H3p9my6aEeSQQqw1BT_aMg")]
    [DisplayName("Place Of Trade")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcOfTrad")]
    #endif
    [IsoXmlTag("PlcOfTrad")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MarketIdentification20? PlaceOfTrade { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MarketIdentification20? PlaceOfTrade { get; init; } 
    #else
    public MarketIdentification20? PlaceOfTrade { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the date of the trade.
    /// </summary>
    [IsoId("_H3p9nS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDt")]
    #endif
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? TradeDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? TradeDate { get; init; } 
    #else
    public System.DateOnly? TradeDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the contractual settlement date.
    /// </summary>
    [IsoId("_H3p9ny6aEeSQQqw1BT_aMg")]
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
    /// Provides the trade leg details such as trade leg identification and trade type.
    /// </summary>
    [IsoId("_H3p9oS6aEeSQQqw1BT_aMg")]
    [DisplayName("Trade Leg Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradLegDtls")]
    #endif
    [IsoXmlTag("TradLegDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeLeg10? TradeLegDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeLeg10? TradeLegDetails { get; init; } 
    #else
    public TradeLeg10? TradeLegDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
