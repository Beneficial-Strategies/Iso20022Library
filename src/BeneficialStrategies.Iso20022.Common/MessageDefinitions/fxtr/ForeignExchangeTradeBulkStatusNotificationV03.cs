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


namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.030.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.
/// </summary>
[Description(@"Scope||The ForeignExchangeTradeBulkStatusNotification message is sent by a central system to the participant to provide notification of the current status of one or more foreign exchange trades.")]
[IsoId("_1RUgUTJ5EeOd1OidA-8_VQ")]
[DisplayName("Foreign Exchange Trade Bulk Status Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeBulkStatusNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.030.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradBlkStsNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.030.001.03";
    
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
    /// Constructs a ForeignExchangeTradeBulkStatusNotificationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeBulkStatusNotificationV03( TradeData10 reqStatusDetails,TradeData11 reqTradeData )
    {
        StatusDetails = reqStatusDetails;
        TradeData = reqTradeData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Information on the status of the trade in the central system.
    /// </summary>
    [IsoId("_1RUgUzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Status Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDtls")]
    #endif
    [IsoXmlTag("StsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeData10 StatusDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeData10 StatusDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData10 StatusDetails { get; init; } 
    #else
    public TradeData10 StatusDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies one or more trades for which the status notification is sent.
    /// </summary>
    [IsoId("_1RUgVTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trade Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradData")]
    #endif
    [IsoXmlTag("TradData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeData11 TradeData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeData11 TradeData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData11 TradeData { get; init; } 
    #else
    public TradeData11 TradeData { get; set; } 
    #endif
    
    /// <summary>
    /// Page number of the message (within the status report) and continuation indicator to indicate that the statement is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_1RUgVzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Pagination? MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination? MessagePagination { get; init; } 
    #else
    public Pagination? MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1RUgWTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeBulkStatusNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeBulkStatusNotificationV03.

