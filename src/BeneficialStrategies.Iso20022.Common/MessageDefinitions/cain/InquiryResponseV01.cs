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

namespace BeneficialStrategies.Iso20022.cain;

/// <summary>
/// This record is an implementation of the cain.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The InquiryResponse message is sent by an issuer or an agent to an acquirer in response to an  InquiryInitiation message.
/// </summary>
[Description(
    @"The InquiryResponse message is sent by an issuer or an agent to an acquirer in response to an  InquiryInitiation message."
)]
[IsoId("_J4V1pVfjEeeg8PDQoAs78Q")]
[DisplayName("Inquiry Response V")]
public record InquiryResponseV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.017.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NqryRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.017.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the management of the protocol.
    /// </summary>
    [IsoId("_J4V1p1fjEeeg8PDQoAs78Q")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header39 Header { get; init; }

    /// <summary>
    /// Information related to the inquiry response.
    /// </summary>
    [IsoId("_J4V1qVfjEeeg8PDQoAs78Q")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required InquiryResponse1 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC
    /// </summary>
    [IsoId("_J4V1qFfjEeeg8PDQoAs78Q")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since InquiryResponseV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to InquiryResponseV01.
