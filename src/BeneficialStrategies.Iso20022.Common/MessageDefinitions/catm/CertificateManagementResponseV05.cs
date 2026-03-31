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
/// This record is an implementation of the catm.008.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The CertificateManagementResponse is sent by a terminal manager in response to a CertificateManagementRequest to provide the outcome of the requested service.
/// </summary>
[Description(
    @"The CertificateManagementResponse is sent by a terminal manager in response to a CertificateManagementRequest to provide the outcome of the requested service."
)]
[IsoId("_Nwo8kVE_EeyApZmLzm74zA")]
[DisplayName("Certificate Management Response V")]
public record CertificateManagementResponseV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.008.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CertMgmtRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.008.001.05";

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
    [IsoId("_Nwo8k1E_EeyApZmLzm74zA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required TMSHeader1 Header { get; init; }

    /// <summary>
    /// Information related to the result of the certificate management request.
    /// </summary>
    [IsoId("_Nwo8lVE_EeyApZmLzm74zA")]
    [DisplayName("Certificate Management Response")]
    [IsoXmlTag("CertMgmtRspn")]
    public required CertificateManagementResponse2 CertificateManagementResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_Nwo8l1E_EeyApZmLzm74zA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType29? SecurityTrailer { get; init; }
}

// Since CertificateManagementResponseV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CertificateManagementResponseV05.
