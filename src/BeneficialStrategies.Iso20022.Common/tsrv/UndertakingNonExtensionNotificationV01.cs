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


namespace BeneficialStrategies.Iso20022.tsrv;

/// <summary>
/// This record is an implementation of the tsrv.011.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The UndertakingNonExtensionNotification message is sent by the party that issued the undertaking to the beneficiary, either directly or via one or more advising parties, to notify it of the non-extension of the referenced undertaking beyond the current expiry date.
/// </summary>
[Description(@"The UndertakingNonExtensionNotification message is sent by the party that issued the undertaking to the beneficiary, either directly or via one or more advising parties, to notify it of the non-extension of the referenced undertaking beyond the current expiry date.")]
[IsoId("_9i_O8nltEeG7BsjMvd1mEw_-188871383")]
[DisplayName("Undertaking Non Extension Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UndertakingNonExtensionNotificationV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsrv.011.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "UdrtkgNonXtnsnNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsrv.011.001.01";
    
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
    /// Constructs a UndertakingNonExtensionNotificationV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UndertakingNonExtensionNotificationV01( UndertakingNonExtensionStatusAdvice1 reqUndertakingNonExtensionNotificationDetails )
    {
        UndertakingNonExtensionNotificationDetails = reqUndertakingNonExtensionNotificationDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details of the non-extension notification.
    /// </summary>
    [IsoId("_9i_O83ltEeG7BsjMvd1mEw_1181398282")]
    [DisplayName("Undertaking Non Extension Notification Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgNonXtnsnNtfctnDtls")]
    #endif
    [IsoXmlTag("UdrtkgNonXtnsnNtfctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UndertakingNonExtensionStatusAdvice1 UndertakingNonExtensionNotificationDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UndertakingNonExtensionStatusAdvice1 UndertakingNonExtensionNotificationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UndertakingNonExtensionStatusAdvice1 UndertakingNonExtensionNotificationDetails { get; init; } 
    #else
    public UndertakingNonExtensionStatusAdvice1 UndertakingNonExtensionNotificationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Digital signature of the notification.
    /// </summary>
    [IsoId("_9i_O9HltEeG7BsjMvd1mEw_-676227762")]
    [DisplayName("Digital Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DgtlSgntr")]
    #endif
    [IsoXmlTag("DgtlSgntr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyAndSignature2? DigitalSignature { get; init; } 
    #else
    public PartyAndSignature2? DigitalSignature { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since UndertakingNonExtensionNotificationV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to UndertakingNonExtensionNotificationV01.

