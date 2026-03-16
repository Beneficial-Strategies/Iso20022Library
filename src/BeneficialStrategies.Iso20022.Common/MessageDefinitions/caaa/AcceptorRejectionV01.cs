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
/// This record is an implementation of the caaa.015.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorRejection message is used by the acquirer to reject a message received from the card acceptor. The acquirer uses this message as a substitute to a response or an advice response message sent to the card acceptor.
/// Usage
/// The AcceptorRejection message is used to indicate that the received message could not be processed by the acquirer (for example, unable to read or process the message, security error, duplicate message).
/// </summary>
[Description(
    @"Scope|The AcceptorRejection message is used by the acquirer to reject a message received from the card acceptor. The acquirer uses this message as a substitute to a response or an advice response message sent to the card acceptor.|Usage|The AcceptorRejection message is used to indicate that the received message could not be processed by the acquirer (for example, unable to read or process the message, security error, duplicate message)."
)]
[IsoId("_NR9PhaMVEeCJ6YNENx4h-w_449190071")]
[DisplayName("Acceptor Rejection V")]
public record AcceptorRejectionV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.015.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRjctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.015.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Rejection message management information.
    /// </summary>
    [IsoId("_NR9PhqMVEeCJ6YNENx4h-w_-1188630353")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header1 Header { get; init; }

    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_NR9Ph6MVEeCJ6YNENx4h-w_-377399680")]
    [DisplayName("Reject")]
    [IsoXmlTag("Rjct")]
    public required AcceptorRejection1 Reject { get; init; }
}

// Since AcceptorRejectionV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorRejectionV01.
