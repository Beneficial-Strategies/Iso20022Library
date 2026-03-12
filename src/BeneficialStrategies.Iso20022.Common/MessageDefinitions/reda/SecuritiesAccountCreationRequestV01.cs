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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.018.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesAccountCreationRequest message message is sent by an instructing party to the executing party to instruct the creation of a new securities account with the required account attributes details.
/// |
/// Usage:|
/// Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.
/// </summary>
[Description(@"The SecuritiesAccountCreationRequest message message is sent by an instructing party to the executing party to instruct the creation of a new securities account with the required account attributes details.|||Usage:||Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.")]
[IsoId("_KAlNzZ2fEem_Be8NuxvF7Q")]
[DisplayName("Securities Account Creation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountCreationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.018.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctCreReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.018.001.01";
    
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
    /// Constructs a SecuritiesAccountCreationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountCreationRequestV01( SystemSecuritiesAccount7 reqSecuritiesAccount )
    {
        SecuritiesAccount = reqSecuritiesAccount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_gl0bMJ5GEemQg7pJhFUUYg")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageHeader1? MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader1? MessageHeader { get; init; } 
    #else
    public MessageHeader1? MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Securities account to be created in the executing party system.
    /// </summary>
    [IsoId("_KAu-l52fEem_Be8NuxvF7Q")]
    [DisplayName("Securities Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcct")]
    #endif
    [IsoXmlTag("SctiesAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SystemSecuritiesAccount7 SecuritiesAccount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SystemSecuritiesAccount7 SecuritiesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemSecuritiesAccount7 SecuritiesAccount { get; init; } 
    #else
    public SystemSecuritiesAccount7 SecuritiesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-mZ2fEem_Be8NuxvF7Q")]
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


// Since SecuritiesAccountCreationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesAccountCreationRequestV01.

