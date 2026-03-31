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
/// This record is an implementation of the caaa.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AcceptorAuthorisationRequest message is sent by the card acceptor to the acquirer or its agent when an online authorisation is required for the card payment transaction.
/// Usage
/// The AcceptorAuthorisationRequest message may embed the information required for transferring to the acquirer the data needed to perform the financial settlement of the transaction (capture). An intermediary agent may act on behalf of the card acceptor or of the acquirer in providing additional functionality such as: switching to different acquirers, loyalty processing or management of the acceptor system.
/// </summary>
[Description(
    @"Scope|The AcceptorAuthorisationRequest message is sent by the card acceptor to the acquirer or its agent when an online authorisation is required for the card payment transaction.|Usage|The AcceptorAuthorisationRequest message may embed the information required for transferring to the acquirer the data needed to perform the financial settlement of the transaction (capture). An intermediary agent may act on behalf of the card acceptor or of the acquirer in providing additional functionality such as: switching to different acquirers, loyalty processing or management of the acceptor system."
)]
[IsoId("_ghrzxaMVEeCJ6YNENx4h-w_1039526828")]
[DisplayName("Acceptor Authorisation Request V")]
public record AcceptorAuthorisationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.001.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.001.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Authorisation request message management information.
    /// </summary>
    [IsoId("_ghrzxqMVEeCJ6YNENx4h-w_1464733610")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header1 Header { get; init; }

    /// <summary>
    /// Information related to the authorisation request.
    /// </summary>
    [IsoId("_ghrzx6MVEeCJ6YNENx4h-w_-2042121614")]
    [DisplayName("Authorisation Request")]
    [IsoXmlTag("AuthstnReq")]
    public required AcceptorAuthorisationRequest1 AuthorisationRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_ghrzyKMVEeCJ6YNENx4h-w_-1655113788")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType3 SecurityTrailer { get; init; }
}

// Since AcceptorAuthorisationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorAuthorisationRequestV01.
