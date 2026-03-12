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
/// This record is an implementation of the caaa.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCompletionAdvice message is sent by a card acceptor to notify an acquirer about the completion and final outcome of a card payment transaction. The message can be sent directly to the acquirer or through an agent.
/// Usage
/// The AcceptorCompletionAdvice message is used either to:
/// - inform the acquirer about the successful end of a transaction;
/// - reverse a transaction which was not successfully completed (for example, cancellation of transaction by the cardholder), but where an authorisation had been previously given.
/// The AcceptorCompletionAdvice message may also embed the information required for transferring to the acquirer all data needed to perform the financial settlement of the transaction (capture). Should the acquirer not receive a correct response to an AcceptorCompletionAdvice message; the card acceptor sends back an AcceptorCompletionAdvice message to the acquirer.
/// </summary>
[Description(@"Scope|The AcceptorCompletionAdvice message is sent by a card acceptor to notify an acquirer about the completion and final outcome of a card payment transaction. The message can be sent directly to the acquirer or through an agent.|Usage|The AcceptorCompletionAdvice message is used either to:|- inform the acquirer about the successful end of a transaction;|- reverse a transaction which was not successfully completed (for example, cancellation of transaction by the cardholder), but where an authorisation had been previously given.|The AcceptorCompletionAdvice message may also embed the information required for transferring to the acquirer all data needed to perform the financial settlement of the transaction (capture). Should the acquirer not receive a correct response to an AcceptorCompletionAdvice message; the card acceptor sends back an AcceptorCompletionAdvice message to the acquirer.")]
[IsoId("_W92GBaMVEeCJ6YNENx4h-w_871403476")]
[DisplayName("Acceptor Completion Advice V")]
public partial record AcceptorCompletionAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.003.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.003.001.01";
    
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
    /// Completion advice message management information.
    /// </summary>
    [IsoId("_W9_P8KMVEeCJ6YNENx4h-w_-1929143436")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header2 Header { get; init; } 
    
    /// <summary>
    /// Information related to the completion advice.
    /// </summary>
    [IsoId("_W9_P8aMVEeCJ6YNENx4h-w_808377335")]
    [DisplayName("Completion Advice")]
    [IsoXmlTag("CmpltnAdvc")]
    public required AcceptorCompletionAdvice1 CompletionAdvice { get; init; } 
    
    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_W9_P8qMVEeCJ6YNENx4h-w_-83776970")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; } 
    
    
    #nullable disable
    
}


// Since AcceptorCompletionAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCompletionAdviceV01.

