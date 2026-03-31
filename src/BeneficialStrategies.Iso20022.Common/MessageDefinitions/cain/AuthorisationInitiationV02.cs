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
/// This record is an implementation of the cain.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.
///
///
/// </summary>
[Description(
    @"AuthorisationInitiation message is sent by an acquirer or an agent to an issuer to request approval of a card transaction by the issuer or to inform the issuer about the completion of the authorisation. It can also be sent by an issuer to an acquirer or agent to advise about the result of an authorisation already performed.||"
)]
[IsoId("_SBa-kFKeEeeFcfYfFkVztg")]
[DisplayName("Authorisation Initiation V")]
public record AuthorisationInitiationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "cain.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AuthstnInitn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:cain.001.001.02";

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
    [IsoId("_BfrOEFKfEeeFcfYfFkVztg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header42 Header { get; init; }

    /// <summary>
    /// Information related to the authorisation initiation.
    /// </summary>
    [IsoId("_RkTIQFKfEeeFcfYfFkVztg")]
    [DisplayName("Body")]
    [IsoXmlTag("Body")]
    public required AuthorisationInitiation1 Body { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_e333IFKfEeeFcfYfFkVztg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType20? SecurityTrailer { get; init; }
}

// Since AuthorisationInitiationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AuthorisationInitiationV02.
