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
/// This record is an implementation of the caaa.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCancellationResponse message is sent by the acquirer to inform the card acceptor of the outcome of the cancellation process. The message can be sent directly to the acceptor or through an agent.
/// Usage
/// The AcceptorCancellationResponse message is used to indicate one of the possible outcomes of a cancellation process:
/// - a successful cancellation;
/// - a rejection from the acquirer for financial reasons;
/// - a rejection from the acquirer for technical reasons.
/// </summary>
[Description(@"Scope|The AcceptorCancellationResponse message is sent by the acquirer to inform the card acceptor of the outcome of the cancellation process. The message can be sent directly to the acceptor or through an agent.|Usage|The AcceptorCancellationResponse message is used to indicate one of the possible outcomes of a cancellation process:|- a successful cancellation;|- a rejection from the acquirer for financial reasons;|- a rejection from the acquirer for technical reasons.")]
[IsoId("_bXUntaMVEeCJ6YNENx4h-w_-227867844")]
[DisplayName("Acceptor Cancellation Response V")]
public partial record AcceptorCancellationResponseV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.006.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlRspn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.006.001.01";
    
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
    /// Cancellation response message management information.
    /// </summary>
    [IsoId("_bXUntqMVEeCJ6YNENx4h-w_1580455257")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header1 Header { get; init; } 
    
    /// <summary>
    /// Information related to the cancellation response.
    /// </summary>
    [IsoId("_bXUnt6MVEeCJ6YNENx4h-w_-827095491")]
    [DisplayName("Cancellation Response")]
    [IsoXmlTag("CxlRspn")]
    public required AcceptorCancellationResponse1 CancellationResponse { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_bXUnuKMVEeCJ6YNENx4h-w_1794760137")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AcceptorCancellationResponseV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationResponseV01.

