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
/// This record is an implementation of the caaa.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCancellationRequest message is sent by a card acceptor to cancel a successfully completed card payment transaction. The message can be sent directly to the acquirer or through an agent.
/// Usage
/// The AcceptorCancellationRequest message is used when the card acceptor is unaware of the cancellation of the transaction by the acquirer.
/// </summary>
[Description(
    @"Scope|The AcceptorCancellationRequest message is sent by a card acceptor to cancel a successfully completed card payment transaction. The message can be sent directly to the acquirer or through an agent.|Usage|The AcceptorCancellationRequest message is used when the card acceptor is unaware of the cancellation of the transaction by the acquirer."
)]
[IsoId("_cMhxZaMVEeCJ6YNENx4h-w_602094635")]
[DisplayName("Acceptor Cancellation Request V")]
public record AcceptorCancellationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.005.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.005.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Cancellation request message management information.
    /// </summary>
    [IsoId("_cMhxZqMVEeCJ6YNENx4h-w_368944245")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header1 Header { get; init; }

    /// <summary>
    /// Information related to the cancellation request.
    /// </summary>
    [IsoId("_cMq7UKMVEeCJ6YNENx4h-w_-1782226179")]
    [DisplayName("Cancellation Request")]
    [IsoXmlTag("CxlReq")]
    public required AcceptorCancellationRequest1 CancellationRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_cMq7UaMVEeCJ6YNENx4h-w_2083735573")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; }
}

// Since AcceptorCancellationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationRequestV01.
