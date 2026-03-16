// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.caaa;

/// <summary>
/// This record is an implementation of the caaa.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer to acknowledge the proper receipt of an AcceptorCompletionAdvice. The message can be sent directly to the card acceptor or through an agent.
/// Usage
/// The AcceptorCompletionAdviceResponse message is used to acknowledge the data capture process performed by the acquirer based on the data required to carry out the financial clearing and settlement of the transaction.
/// </summary>
[Description(
    @"Scope|The AcceptorCompletionAdviceResponse message is sent by the acquirer to acknowledge the proper receipt of an AcceptorCompletionAdvice. The message can be sent directly to the card acceptor or through an agent.|Usage|The AcceptorCompletionAdviceResponse message is used to acknowledge the data capture process performed by the acquirer based on the data required to carry out the financial clearing and settlement of the transaction."
)]
[IsoId("_X7-iNaMVEeCJ6YNENx4h-w_1511843266")]
[DisplayName("Acceptor Completion Advice Response V")]
public record AcceptorCompletionAdviceResponseV01 : IOuterRecord
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

    /// <summary>
    /// Completion advice response message management information.
    /// </summary>
    [IsoId("_X7-iNqMVEeCJ6YNENx4h-w_-827371409")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header2 Header { get; init; }

    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_X7-iN6MVEeCJ6YNENx4h-w_-1291534155")]
    [DisplayName("Completion Advice Response")]
    [IsoXmlTag("CmpltnAdvcRspn")]
    public required AcceptorCompletionAdviceResponse1 CompletionAdviceResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_X7-iOKMVEeCJ6YNENx4h-w_-2123909944")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; }
}

// Since AcceptorCompletionAdviceResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCompletionAdviceResponseV01.
