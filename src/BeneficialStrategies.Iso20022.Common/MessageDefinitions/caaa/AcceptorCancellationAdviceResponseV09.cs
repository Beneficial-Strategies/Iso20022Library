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
/// This record is an implementation of the caaa.008.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCancellationAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) about the notification of the payment cancellation.
/// </summary>
[Description(
    @"The AcceptorCancellationAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) about the notification of the payment cancellation."
)]
[IsoId("__rwmsS1xEeuZtpnZJ4v-5Q")]
[DisplayName("Acceptor Cancellation Advice Response V")]
public record AcceptorCancellationAdviceResponseV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.008.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvcRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.008.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Cancellation advice response message management information.
    /// </summary>
    [IsoId("__rwmtS1xEeuZtpnZJ4v-5Q")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header59 Header { get; init; }

    /// <summary>
    /// Information related to the cancellation advice response.
    /// </summary>
    [IsoId("__rwmty1xEeuZtpnZJ4v-5Q")]
    [DisplayName("Cancellation Advice Response")]
    [IsoXmlTag("CxlAdvcRspn")]
    public required AcceptorCancellationAdviceResponse9 CancellationAdviceResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("__rwmuS1xEeuZtpnZJ4v-5Q")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType27? SecurityTrailer { get; init; }
}

// Since AcceptorCancellationAdviceResponseV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationAdviceResponseV09.
