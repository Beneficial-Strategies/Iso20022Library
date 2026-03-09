// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// This record is an implementation of the trea.012.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeOptionNotification message is sent by a central system to a participant to provide details of a foreign exchange option trade.
/// Usage
/// The notification is sent by the central settlement system to the two trading parties after it has received Create, Amend or Cancel messages from both. The message may also contain information on the settlement of the trade and/or premium.
/// </summary>
[Description(@"Scope|The ForeignExchangeOptionNotification message is sent by a central system to a participant to provide details of a foreign exchange option trade.|Usage|The notification is sent by the central settlement system to the two trading parties after it has received Create, Amend or Cancel messages from both. The message may also contain information on the settlement of the trade and/or premium.")]
[IsoId("_QCIK6NE8Ed-BzquC8wXy7w_-2045814163")]
[DisplayName("Foreign Exchange Option Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeOptionNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.012.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXOptnNtfctnV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.012.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeOptionNotificationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeOptionNotificationV02( TradePartyIdentification4 reqTradingSideIdentification,TradePartyIdentification4 reqCounterpartySideIdentification,OptionData2 reqOptionData,TradeStatus1 reqTradeStatus )
    {
        TradingSideIdentification = reqTradingSideIdentification;
        CounterpartySideIdentification = reqCounterpartySideIdentification;
        OptionData = reqOptionData;
        TradeStatus = reqTradeStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the trading side of the currency option trade which is reported.
    /// </summary>
    [IsoId("_QCIK6dE8Ed-BzquC8wXy7w_-28711885")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification4 TradingSideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification4 TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification4 TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification4 TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is reported.
    /// </summary>
    [IsoId("_QCIK6tE8Ed-BzquC8wXy7w_-1363683318")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification4 CounterpartySideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification4 CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification4 CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification4 CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the conditions of the option.
    /// </summary>
    [IsoId("_QCIK69E8Ed-BzquC8wXy7w_1138794159")]
    [DisplayName("Option Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnData")]
    #endif
    [IsoXmlTag("OptnData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionData2 OptionData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionData2 OptionData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionData2 OptionData { get; init; } 
    #else
    public OptionData2 OptionData { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the status of a trade in a settlement system.
    /// </summary>
    [IsoId("_QCR74NE8Ed-BzquC8wXy7w_1207820711")]
    [DisplayName("Trade Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradSts")]
    #endif
    [IsoXmlTag("TradSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeStatus1 TradeStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeStatus1 TradeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeStatus1 TradeStatus { get; init; } 
    #else
    public TradeStatus1 TradeStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the settlement of a trade.
    /// </summary>
    [IsoId("_QCR74dE8Ed-BzquC8wXy7w_949234653")]
    [DisplayName("Settlement Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmData")]
    #endif
    [IsoXmlTag("SttlmData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementData2? SettlementData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementData2? SettlementData { get; init; } 
    #else
    public SettlementData2? SettlementData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ForeignExchangeOptionNotificationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeOptionNotificationV02.

