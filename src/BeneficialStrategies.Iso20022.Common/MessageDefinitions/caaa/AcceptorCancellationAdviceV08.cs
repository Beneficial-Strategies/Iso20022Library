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
/// This record is an implementation of the caaa.007.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorCancellationAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the cancellation of a successfully completed transaction. The transaction has been completed without financial transfer, or the acceptor is aware that the transaction was not cleared by the acquirer.
/// </summary>
[Description(
    @"The AcceptorCancellationAdvice message is sent by an acceptor (or its agent) to notify the acquirer (or its agent) of the cancellation of a successfully completed transaction. The transaction has been completed without financial transfer, or the acceptor is aware that the transaction was not cleared by the acquirer."
)]
[IsoId("_xq2iwdgzEeipBO1pkKK6zg")]
[DisplayName("Acceptor Cancellation Advice V")]
public record AcceptorCancellationAdviceV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.007.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrCxlAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.007.001.08";

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
    [IsoId("_xq3J09gzEeipBO1pkKK6zg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header36 Header { get; init; }

    /// <summary>
    /// Information related to the cancellation advice.
    /// </summary>
    [IsoId("_xq3J1dgzEeipBO1pkKK6zg")]
    [DisplayName("Cancellation Advice")]
    [IsoXmlTag("CxlAdvc")]
    public required AcceptorCancellationAdvice8 CancellationAdvice { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_xq3J19gzEeipBO1pkKK6zg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType16? SecurityTrailer { get; init; }
}

// Since AcceptorCancellationAdviceV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorCancellationAdviceV08.
