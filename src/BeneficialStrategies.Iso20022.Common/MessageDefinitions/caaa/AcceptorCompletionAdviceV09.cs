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
/// This record is an implementation of the caaa.003.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCompletionAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the outcome of the payment at the acceptor, and to transfer the financial data of the transaction to the acquirer (capture).
/// A AcceptorCompletionAdvice message is also sent to reverse an approved authorisation and any associated financial transfer (capture), if the card payment transaction could not be completed successfully.
/// </summary>
[Description(
    @"The AcceptorCompletionAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the outcome of the payment at the acceptor, and to transfer the financial data of the transaction to the acquirer (capture).|A AcceptorCompletionAdvice message is also sent to reverse an approved authorisation and any associated financial transfer (capture), if the card payment transaction could not be completed successfully."
)]
[IsoId("_KdsH4QueEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Completion Advice V")]
public record AcceptorCompletionAdviceV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.003.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.003.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Completion advice message management information.
    /// </summary>
    [IsoId("_KdsH5QueEeqw5uEXxQ9H4g")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header58 Header { get; init; }

    /// <summary>
    /// Information related to the completion advice.
    /// </summary>
    [IsoId("_KdsH5wueEeqw5uEXxQ9H4g")]
    [DisplayName("Completion Advice")]
    [IsoXmlTag("CmpltnAdvc")]
    public required AcceptorCompletionAdvice9 CompletionAdvice { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_KdsH6QueEeqw5uEXxQ9H4g")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType24? SecurityTrailer { get; init; }
}

// Since AcceptorCompletionAdviceV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCompletionAdviceV09.
