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
/// This record is an implementation of the reda.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesAccountModificationRequest message is sent by an instructing party to the executing party to instruct the update of an existing securities account by amending its existing attributes or by providing additional attibutes details.
/// 
/// Usage:
/// Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.
/// </summary>
[Description(@"The SecuritiesAccountModificationRequest message is sent by an instructing party to the executing party to instruct the update of an existing securities account by amending its existing attributes or by providing additional attibutes details.||Usage:|Processing and confirmation of the securities account creation request message are provided via a SecuritiesAccountStatusAdvice message.")]
[IsoId("_KAu-rZ2fEem_Be8NuxvF7Q")]
[DisplayName("Securities Account Modification Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountModificationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.023.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesAcctModReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.023.001.01";
    
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
    /// Constructs a SecuritiesAccountModificationRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAccountModificationRequestV01( SecuritiesAccount19 reqAccountIdentification,SecuritiesAccountModification2 reqModification )
    {
        AccountIdentification = reqAccountIdentification;
        Modification = reqModification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_Za_90J5HEemQg7pJhFUUYg")]
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
    /// Identification of the securities account to be updated in the executing party system.
    /// </summary>
    [IsoId("_KAu-u52fEem_Be8NuxvF7Q")]
    [DisplayName("Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctId")]
    #endif
    [IsoXmlTag("AcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccount19 AccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19 AccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19 AccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Further details about the requested modification.
    /// </summary>
    [IsoId("_KAu-vZ2fEem_Be8NuxvF7Q")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesAccountModification2 Modification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesAccountModification2 Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccountModification2 Modification { get; init; } 
    #else
    public SecuritiesAccountModification2 Modification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_KAu-v52fEem_Be8NuxvF7Q")]
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


// Since SecuritiesAccountModificationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesAccountModificationRequestV01.

