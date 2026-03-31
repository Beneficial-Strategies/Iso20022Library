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
/// This record is an implementation of the caam.003.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys.
/// </summary>
[Description(
    @"The ATMKeyDownloadRequest message is sent by an ATM to an ATM manager to initiate the download of one or several cryptographic keys."
)]
[IsoId("_ohA3UItKEeSxlKlAGYErFg")]
[DisplayName("ATM Key Download Request V")]
public record ATMKeyDownloadRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.003.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMKeyDwnldReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.003.001.01";

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
    [IsoId("_vxyWQItKEeSxlKlAGYErFg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header20 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_367noItKEeSxlKlAGYErFg")]
    [DisplayName("Protected ATM Key Download Request")]
    [IsoXmlTag("PrtctdATMKeyDwnldReq")]
    public ContentInformationType10? ProtectedATMKeyDownloadRequest { get; init; }

    /// <summary>
    /// Information related to the request of a key download from an ATM.
    /// </summary>
    [IsoId("_A7d0AItLEeSxlKlAGYErFg")]
    [DisplayName("ATM Key Download Request")]
    [IsoXmlTag("ATMKeyDwnldReq")]
    public ATMKeyDownloadRequest1? ATMKeyDownloadRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_FP42kItLEeSxlKlAGYErFg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType13? SecurityTrailer { get; init; }
}

// Since ATMKeyDownloadRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMKeyDownloadRequestV01.
