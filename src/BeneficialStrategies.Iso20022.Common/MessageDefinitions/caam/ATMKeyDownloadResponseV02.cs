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
/// This record is an implementation of the caam.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys.
/// </summary>
[Description(
    @"The ATMKeyDownloadResponse message is sent from an acquirer to an ATM in response to an ATMKeyDownloadRequest message, to download of one or several cryptographic keys."
)]
[IsoId("__AA4sa45EeWRfYPBaeOY8w")]
[DisplayName("ATM Key Download Response V")]
public record ATMKeyDownloadResponseV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.004.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.004.001.02";

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
    [IsoId("__AA4s645EeWRfYPBaeOY8w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("__AA4ta45EeWRfYPBaeOY8w")]
    [DisplayName("Protected ATM Key Download Response")]
    [IsoXmlTag("PrtctdATMKeyDwnldRspn")]
    public ContentInformationType10? ProtectedATMKeyDownloadResponse { get; init; }

    /// <summary>
    /// Information related to the response of an ATM key download from an ATM manager.
    /// </summary>
    [IsoId("__AA4t645EeWRfYPBaeOY8w")]
    [DisplayName("ATM Key Download Response")]
    [IsoXmlTag("ATMKeyDwnldRspn")]
    public ATMKeyDownloadResponse2? ATMKeyDownloadResponse { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("__AA4ua45EeWRfYPBaeOY8w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
}

// Since ATMKeyDownloadResponseV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMKeyDownloadResponseV02.
