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
/// This record is an implementation of the caaa.015.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed.
/// </summary>
[Description(
    @"The AcceptorRejection message is sent by the acquirer (or its agent) to reject a message request or advice sent by an acceptor (or its agent), to indicate that the received message could not be processed."
)]
[IsoId("_Bu3IsWpCEeS4VPLpYyQgxQ")]
[DisplayName("Acceptor Rejection V")]
public record AcceptorRejectionV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.015.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrRjctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.015.001.04";

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
    [IsoId("_Bu3ItWpCEeS4VPLpYyQgxQ")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header13 Header { get; init; }

    /// <summary>
    /// Information related to the reject.
    /// </summary>
    [IsoId("_Bu3It2pCEeS4VPLpYyQgxQ")]
    [DisplayName("Reject")]
    [IsoXmlTag("Rjct")]
    public required AcceptorRejection2 Reject { get; init; }
}

// Since AcceptorRejectionV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorRejectionV04.
