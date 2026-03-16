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

namespace BeneficialStrategies.Iso20022.catm;

/// <summary>
/// This record is an implementation of the catm.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The certificate management request message is sent by a POI terminal or any intermediary entity either to a terminal manager acting as a certificate authority for managing X.509 certificate of a public key owned by the initiating party, or for requesting the inclusion or the removal of the POI to a white list of the terminal manager.
///
/// </summary>
[Description(
    @"The certificate management request message is sent by a POI terminal or any intermediary entity either to a terminal manager acting as a certificate authority for managing X.509 certificate of a public key owned by the initiating party, or for requesting the inclusion or the removal of the POI to a white list of the terminal manager.|"
)]
[IsoId("_EQjhgI4KEeW6h7rGyYlyTg")]
[DisplayName("Certificate Management Request V")]
public record CertificateManagementRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CertMgmtReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.007.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Information related to the protocol management.
    /// </summary>
    [IsoId("_mxb7oI4KEeW6h7rGyYlyTg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header29 Header { get; init; }

    /// <summary>
    /// Information related to the request of certificate management.
    /// </summary>
    [IsoId("_FkqYQI4LEeW6h7rGyYlyTg")]
    [DisplayName("Certificate Management Request")]
    [IsoXmlTag("CertMgmtReq")]
    public required CertificateManagementRequest1 CertificateManagementRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_sYvF4I4LEeW6h7rGyYlyTg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
}

// Since CertificateManagementRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CertificateManagementRequestV01.
