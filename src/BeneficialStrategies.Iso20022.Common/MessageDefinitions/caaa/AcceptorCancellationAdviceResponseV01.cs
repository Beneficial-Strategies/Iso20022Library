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
/// This record is an implementation of the caaa.008.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCancellationAdviceResponse message is sent by the acquirer to acknowledge the proper reception of the AcceptorCancellationAdvice. The message can be sent directly to the card acceptor or through an agent.
/// Usage
/// The AcceptorCancellationAdviceResponse message should be accepted by the card acceptor unless the message received was invalid.
/// </summary>
[Description(@"Scope|The AcceptorCancellationAdviceResponse message is sent by the acquirer to acknowledge the proper reception of the AcceptorCancellationAdvice. The message can be sent directly to the card acceptor or through an agent.|Usage|The AcceptorCancellationAdviceResponse message should be accepted by the card acceptor unless the message received was invalid.")]
[IsoId("_dy5SQqMVEeCJ6YNENx4h-w_-1253418701")]
[DisplayName("Acceptor Cancellation Advice Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCancellationAdviceResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.008.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvcRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.008.001.01";
    
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
    /// Constructs a AcceptorCancellationAdviceResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCancellationAdviceResponseV01( Header2 reqHeader,AcceptorCancellationAdviceResponse1 reqAcceptorCancellationAdviceResponse,ContentInformationType3 reqSecurityTrailer )
    {
        Header = reqHeader;
        AcceptorCancellationAdviceResponse = reqAcceptorCancellationAdviceResponse;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_dy5SQ6MVEeCJ6YNENx4h-w_-1226388965")]
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
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("_dy5SRKMVEeCJ6YNENx4h-w_-1962834050")]
    [DisplayName("Acceptor Cancellation Advice Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AccptrCxlAdvcRspn")]
    #endif
    [IsoXmlTag("AccptrCxlAdvcRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorCancellationAdviceResponse1 AcceptorCancellationAdviceResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorCancellationAdviceResponse1 AcceptorCancellationAdviceResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorCancellationAdviceResponse1 AcceptorCancellationAdviceResponse { get; init; } 
    #else
    public AcceptorCancellationAdviceResponse1 AcceptorCancellationAdviceResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_dy5SRaMVEeCJ6YNENx4h-w_1091066003")]
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


// Since AcceptorCancellationAdviceResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationAdviceResponseV01.

