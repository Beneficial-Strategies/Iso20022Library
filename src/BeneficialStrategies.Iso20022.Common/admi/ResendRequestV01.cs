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


namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// A system member or any parties authorised by them send a ResendRequest message to the Central System (such as the T2S platform). The purpose of this request is, that the requesting party wants to receive the “original” message once again. This might be caused through technical problems on the receiving side (message could not be received or processed or is missing in the message sequencing) or for archiving purposes.
/// </summary>
[Description(@"A system member or any parties authorised by them send a ResendRequest message to the Central System (such as the T2S platform). The purpose of this request is, that the requesting party wants to receive the “original” message once again. This might be caused through technical problems on the receiving side (message could not be received or processed or is missing in the message sequencing) or for archiving purposes.")]
[IsoId("_5xUioZb3Eee4htziCyV8eA")]
[DisplayName("Resend Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ResendRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RsndReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.006.001.01";
    
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
    /// Constructs a ResendRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ResendRequestV01( MessageHeader7 reqMessageHeader,ResendSearchCriteria2 reqResendSearchCriteria )
    {
        MessageHeader = reqMessageHeader;
        ResendSearchCriteria = reqResendSearchCriteria;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements to identify the resend message.
    /// </summary>
    [IsoId("_5xUio5b3Eee4htziCyV8eA")]
    [DisplayName("Message Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgHdr")]
    #endif
    [IsoXmlTag("MsgHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageHeader7 MessageHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageHeader7 MessageHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageHeader7 MessageHeader { get; init; } 
    #else
    public MessageHeader7 MessageHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria to unambiguously identify the information to be resent.
    /// </summary>
    [IsoId("_5xUipZb3Eee4htziCyV8eA")]
    [DisplayName("Resend Search Criteria")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsndSchCrit")]
    #endif
    [IsoXmlTag("RsndSchCrit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResendSearchCriteria2 ResendSearchCriteria { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResendSearchCriteria2 ResendSearchCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResendSearchCriteria2 ResendSearchCriteria { get; init; } 
    #else
    public ResendSearchCriteria2 ResendSearchCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5xUip5b3Eee4htziCyV8eA")]
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


// Since ResendRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ResendRequestV01.

