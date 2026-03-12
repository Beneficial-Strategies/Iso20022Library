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
/// This record is an implementation of the trea.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusNotification message is sent by a central system to a participant to notify the current status of a trade in the system.|Usage
/// This message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.
/// 
/// 
/// This message is obsolete please use ForeignExchangeAndDerivativeTradeStatusNotificationV03 - fxtr.008.001.03
/// </summary>
[Description(@"Scope|The StatusNotification message is sent by a central system to a participant to notify the current status of a trade in the system.|Usage|This message will be sent at specific times agreed upon by the central settlement system and a participant in a central settlement system.|||This message is obsolete please use ForeignExchangeAndDerivativeTradeStatusNotificationV03 - fxtr.008.001.03")]
[IsoId("_VgTq09E8Ed-BzquC8wXy7w_1259743081")]
[DisplayName("Status Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusNotificationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.008.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "trea.008.001.02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.008.001.02";
    
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
    /// Constructs a StatusNotificationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusNotificationV02( TradeData1 reqTradeData )
    {
        TradeData = reqTradeData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the status of a trade in a system.
    /// </summary>
    [IsoId("_VgTq1NE8Ed-BzquC8wXy7w_-575229954")]
    [DisplayName("Trade Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradData")]
    #endif
    [IsoXmlTag("TradData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeData1 TradeData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeData1 TradeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData1 TradeData { get; init; } 
    #else
    public TradeData1 TradeData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since StatusNotificationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusNotificationV02.

