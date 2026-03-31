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

namespace BeneficialStrategies.Iso20022.caam;

/// <summary>
/// This record is an implementation of the caam.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The HostToATMRequest message is sent by a host to an ATM to request the ATM to contact a host by sending of a maintenance messages.
/// </summary>
[Description(
    @"The HostToATMRequest message is sent by a host to an ATM to request the ATM to contact a host by sending of a maintenance messages."
)]
[IsoId("_ZgfQ4ItqEeSDLd7nI4Quzw")]
[DisplayName("Host To ATM Request V")]
public record HostToATMRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "HstToATMReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.007.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management on a segment of the path from the ATM to the acquirer.
    /// </summary>
    [IsoId("_fivHMItqEeSDLd7nI4Quzw")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header20 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_kvOaMItqEeSDLd7nI4Quzw")]
    [DisplayName("Protected Host To ATM Request")]
    [IsoXmlTag("PrtctdHstToATMReq")]
    public ContentInformationType10? ProtectedHostToATMRequest { get; init; }

    /// <summary>
    /// Information related to the request to an ATM to contact the ATM manager.
    /// </summary>
    [IsoId("_vd4VQItqEeSDLd7nI4Quzw")]
    [DisplayName("Host To ATM Request")]
    [IsoXmlTag("HstToATMReq")]
    public HostToATMRequest1? HostToATMRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_0CZCQItqEeSDLd7nI4Quzw")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since HostToATMRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to HostToATMRequestV01.
