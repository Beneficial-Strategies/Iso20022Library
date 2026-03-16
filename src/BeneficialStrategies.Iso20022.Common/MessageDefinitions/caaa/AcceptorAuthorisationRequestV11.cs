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
/// This record is an implementation of the caaa.001.001.11 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided.
/// </summary>
[Description(
    @"The AcceptorAuthorisationRequest message is sent by an acceptor (or its agent) to the acquirer (or its agent), to check with the issuer (or its agent) that the account associated to the card has the resources to fund the payment. This checking will include validation of the card data and any additional transaction data provided."
)]
[IsoId("_sxWGUU3jEey_VecAUE-C9Q")]
[DisplayName("Acceptor Authorisation Request V")]
public record AcceptorAuthorisationRequestV11 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caaa.001.001.11";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AccptrAuthstnReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caaa.001.001.11";

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
    [IsoId("_sxWGVU3jEey_VecAUE-C9Q")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header59 Header { get; init; }

    /// <summary>
    /// Information related to the authorisation request.
    /// </summary>
    [IsoId("_sxWGV03jEey_VecAUE-C9Q")]
    [DisplayName("Authorisation Request")]
    [IsoXmlTag("AuthstnReq")]
    public required AcceptorAuthorisationRequest11 AuthorisationRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_sxWGWU3jEey_VecAUE-C9Q")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType31? SecurityTrailer { get; init; }
}

// Since AcceptorAuthorisationRequestV11Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AcceptorAuthorisationRequestV11.
