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


namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.057.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The NotificationToReceive message is sent by an account owner or by a party acting on the account owner&apos;s behalf to one of the account owner&apos;s account servicing institutions. It is an advance notice that the account servicing institution will receive funds to be credited to the account of the account owner.
/// Usage
/// The NotificationToReceive message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario.
/// </summary>
[Description(@"Scope|The NotificationToReceive message is sent by an account owner or by a party acting on the account owner's behalf to one of the account owner's account servicing institutions. It is an advance notice that the account servicing institution will receive funds to be credited to the account of the account owner.|Usage|The NotificationToReceive message is used to advise the account servicing institution of funds that the account owner expects to have credited to its account. The message can be used in either a direct or a relay scenario.")]
[IsoId("_sYylOmtdEeCY4-KZ9JEyUQ_-1019649132")]
[DisplayName("Notification To Receive V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NotificationToReceiveV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.057.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NtfctnToRcv";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.057.001.02";
    
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
    /// Constructs a NotificationToReceiveV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NotificationToReceiveV02( GroupHeader43 reqGroupHeader,AccountNotification4 reqNotification )
    {
        GroupHeader = reqGroupHeader;
        Notification = reqNotification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide further details on the message.
    /// </summary>
    [IsoId("_sYylO2tdEeCY4-KZ9JEyUQ_-1623737271")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader43 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader43 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader43 GroupHeader { get; init; } 
    #else
    public GroupHeader43 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide further details on the account notification.
    /// </summary>
    [IsoId("_sY8WMGtdEeCY4-KZ9JEyUQ_1787996738")]
    [DisplayName("Notification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ntfctn")]
    #endif
    [IsoXmlTag("Ntfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AccountNotification4 Notification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AccountNotification4 Notification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountNotification4 Notification { get; init; } 
    #else
    public AccountNotification4 Notification { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since NotificationToReceiveV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NotificationToReceiveV02.

