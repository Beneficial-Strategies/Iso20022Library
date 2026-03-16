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
/// This record is an implementation of the caaa.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorCancellationAdvice message is sent by a card acceptor to notify the cancellation of a successfully completed card payment transaction. The message can be sent directly to the acquirer or through an agent.
/// Usage
/// The AcceptorCancellationAdvice message is sent by the card acceptor to an acquirer when the acquirer did not receive a correct response to the AcceptorCompletionAdvice message.
/// </summary>
[Description(
    @"Scope|The AcceptorCancellationAdvice message is sent by a card acceptor to notify the cancellation of a successfully completed card payment transaction. The message can be sent directly to the acquirer or through an agent.|Usage|The AcceptorCancellationAdvice message is sent by the card acceptor to an acquirer when the acquirer did not receive a correct response to the AcceptorCompletionAdvice message."
)]
[IsoId("_dGVuRaMVEeCJ6YNENx4h-w_-1804997012")]
[DisplayName("Acceptor Cancellation Advice V")]
public record AcceptorCancellationAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.007.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Cancellation advice message management information.
    /// </summary>
    [IsoId("_dGffQKMVEeCJ6YNENx4h-w_1875096659")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header2 Header { get; init; }

    /// <summary>
    /// Information related to the cancellation advice.
    /// </summary>
    [IsoId("_dGffQaMVEeCJ6YNENx4h-w_2120079647")]
    [DisplayName("Cancellation Advice")]
    [IsoXmlTag("CxlAdvc")]
    public required AcceptorCancellationAdvice1 CancellationAdvice { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_dGffQqMVEeCJ6YNENx4h-w_-1140931739")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; }
}

// Since AcceptorCancellationAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationAdviceV01.
