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
/// This record is an implementation of the caaa.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorAuthorisationResponse message is sent by the acquirer to inform the card acceptor of the outcome of the authorisation process. The message can be sent directly to the acceptor or through an agent.
/// Usage
/// The AcceptorAuthorisationResponse message is used to indicate one of the possible outcomes of an authorisation process:
/// - a successful authorisation;
/// - a decline from the acquirer for financial reasons;
/// - a decline from the acquirer for technical reasons (for instance, a timeout).
/// </summary>
[Description(@"Scope|The AcceptorAuthorisationResponse message is sent by the acquirer to inform the card acceptor of the outcome of the authorisation process. The message can be sent directly to the acceptor or through an agent.|Usage|The AcceptorAuthorisationResponse message is used to indicate one of the possible outcomes of an authorisation process:|- a successful authorisation;|- a decline from the acquirer for financial reasons;|- a decline from the acquirer for technical reasons (for instance, a timeout).")]
[IsoId("_fvUitaMVEeCJ6YNENx4h-w_-1631980984")]
[DisplayName("Acceptor Authorisation Response V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorAuthorisationResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.002.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.002.001.01";
    
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
    /// Constructs a AcceptorAuthorisationResponseV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorAuthorisationResponseV01( Header1 reqHeader,AcceptorAuthorisationResponse1 reqAuthorisationResponse,ContentInformationType3 reqSecurityTrailer )
    {
        Header = reqHeader;
        AuthorisationResponse = reqAuthorisationResponse;
        SecurityTrailer = reqSecurityTrailer;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Authorisation response message management information.
    /// </summary>
    [IsoId("_fvUitqMVEeCJ6YNENx4h-w_-1929213849")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header1 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header1 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header1 Header { get; init; } 
    #else
    public Header1 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Information related to the response of the authorisation.
    /// </summary>
    [IsoId("_fvUit6MVEeCJ6YNENx4h-w_-930350884")]
    [DisplayName("Authorisation Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRspn")]
    #endif
    [IsoXmlTag("AuthstnRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AcceptorAuthorisationResponse1 AuthorisationResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AcceptorAuthorisationResponse1 AuthorisationResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AcceptorAuthorisationResponse1 AuthorisationResponse { get; init; } 
    #else
    public AcceptorAuthorisationResponse1 AuthorisationResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_fvUiuKMVEeCJ6YNENx4h-w_112512761")]
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


// Since AcceptorAuthorisationResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorAuthorisationResponseV01.

