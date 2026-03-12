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
    
    #nullable enable
    
    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("_dy5SQ6MVEeCJ6YNENx4h-w_-1226388965")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header2 Header { get; init; } 
    
    /// <summary>
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("_dy5SRKMVEeCJ6YNENx4h-w_-1962834050")]
    [DisplayName("Acceptor Cancellation Advice Response")]
    [IsoXmlTag("AccptrCxlAdvcRspn")]
    public required AcceptorCancellationAdviceResponse1 AcceptorCancellationAdviceResponse { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_dy5SRaMVEeCJ6YNENx4h-w_1091066003")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AcceptorCancellationAdviceResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationAdviceResponseV01.

