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

namespace BeneficialStrategies.Iso20022.catp;

/// <summary>
/// This record is an implementation of the catp.016.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMTransferRequest message is sent by an ATM to an ATM manager to request the approval of a fund transfer at the ATM.
/// </summary>
[Description(
    @"The ATMTransferRequest message is sent by an ATM to an ATM manager to request the approval of a fund transfer at the ATM."
)]
[IsoId("_vueJoK4rEeWLdt0vLARX2Q")]
[DisplayName("ATM Transfer Request V")]
public record ATMTransferRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.016.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMTrfReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.016.001.01";

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
    [IsoId("_7z5qYK4rEeWLdt0vLARX2Q")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_Ag7aMK4sEeWLdt0vLARX2Q")]
    [DisplayName("Protected ATM Transfer Request")]
    [IsoXmlTag("PrtctdATMTrfReq")]
    public ContentInformationType10? ProtectedATMTransferRequest { get; init; }

    /// <summary>
    /// Information related to the request of a fund transfer from an ATM.
    /// </summary>
    [IsoId("_HwpwQK4sEeWLdt0vLARX2Q")]
    [DisplayName("ATM Transfer Request")]
    [IsoXmlTag("ATMTrfReq")]
    public ATMTransferRequest1? ATMTransferRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_A9cA8K41EeWpsoxRhdX-8A")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ATMTransferRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMTransferRequestV01.
