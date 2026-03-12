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


namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer to acknowledge the proper receipt of an AcceptorCompletionAdvice. The message can be sent directly to the card acceptor or through an agent.
/// Usage
/// The AcceptorCompletionAdviceResponse message is used to acknowledge the data capture process performed by the acquirer based on the data required to carry out the financial clearing and settlement of the transaction.
/// </summary>
[Description(@"Scope|The AcceptorCompletionAdviceResponse message is sent by the acquirer to acknowledge the proper receipt of an AcceptorCompletionAdvice. The message can be sent directly to the card acceptor or through an agent.|Usage|The AcceptorCompletionAdviceResponse message is used to acknowledge the data capture process performed by the acquirer based on the data required to carry out the financial clearing and settlement of the transaction.")]
[IsoId("_X7-iNaMVEeCJ6YNENx4h-w_1511843266")]
[DisplayName("Acceptor Completion Advice Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCompletionAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.004.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.01";
    
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
    /// Constructs a AcceptorCompletionAdviceResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCompletionAdviceResponseV01( Header2 reqHeader,AcceptorCompletionAdviceResponse1 reqCompletionAdviceResponse,ContentInformationType3 reqSecurityTrailer )
    {
        Header = reqHeader;
        CompletionAdviceResponse = reqCompletionAdviceResponse;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Completion advice response message management information.
    /// </summary>
    [IsoId("_X7-iNqMVEeCJ6YNENx4h-w_-827371409")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header2 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header2 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header2 Header { get; init; } 
    #else
    public Header2 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_X7-iN6MVEeCJ6YNENx4h-w_-1291534155")]
    [DisplayName("Completion Advice Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltnAdvcRspn")]
    #endif
    [IsoXmlTag("CmpltnAdvcRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCompletionAdviceResponse1 CompletionAdviceResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorCompletionAdviceResponse1 CompletionAdviceResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorCompletionAdviceResponse1 CompletionAdviceResponse { get; init; } 
    #else
    public AcceptorCompletionAdviceResponse1 CompletionAdviceResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_X7-iOKMVEeCJ6YNENx4h-w_-2123909944")]
    [DisplayName("Security Trailer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyTrlr")]
    #endif
    [IsoXmlTag("SctyTrlr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType3 SecurityTrailer { get; init; } 
    #else
    public ContentInformationType3 SecurityTrailer { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AcceptorCompletionAdviceResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCompletionAdviceResponseV01.

