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
/// This record is an implementation of the caaa.004.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice.
/// </summary>
[Description(
    @"The AcceptorCompletionAdviceResponse message is sent by the acquirer (or its agent) to acknowledge the acceptor (or its agent) of the outcome of the payment transaction, and the transfer the financial data of the transaction contained in the completion advice."
)]
[IsoId("_wjV0QY0-EeWPUZwhUA4U-w")]
[DisplayName("Acceptor Completion Advice Response V")]
public record AcceptorCompletionAdviceResponseV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.004.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCmpltnAdvcRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.004.001.05";

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
    [IsoId("_wjV0RY0-EeWPUZwhUA4U-w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header24 Header { get; init; }

    /// <summary>
    /// Information related to the completion advice response.
    /// </summary>
    [IsoId("_wjV0R40-EeWPUZwhUA4U-w")]
    [DisplayName("Completion Advice Response")]
    [IsoXmlTag("CmpltnAdvcRspn")]
    public required AcceptorCompletionAdviceResponse5 CompletionAdviceResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_wjV0SY0-EeWPUZwhUA4U-w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since AcceptorCompletionAdviceResponseV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCompletionAdviceResponseV05.
