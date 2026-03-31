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
/// This record is an implementation of the caam.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ATMDiagnosticRequest message is sent from an ATM to an acquirer to verify the availability of the acquirer. The acquirer will also validate that this ATM is a valid ATM for its particular network.
/// </summary>
[Description(
    @"The ATMDiagnosticRequest message is sent from an ATM to an acquirer to verify the availability of the acquirer. The acquirer will also validate that this ATM is a valid ATM for its particular network."
)]
[IsoId("_Vfn5Ua46EeWRfYPBaeOY8w")]
[DisplayName("ATM Diagnostic Request V")]
public record ATMDiagnosticRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "caam.005.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMDgnstcReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:caam.005.001.02";

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
    [IsoId("_Vfn5U646EeWRfYPBaeOY8w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; }

    /// <summary>
    /// Encrypted body of the message.
    /// </summary>
    [IsoId("_Vfn5Va46EeWRfYPBaeOY8w")]
    [DisplayName("Protected ATM Diagnostic Request")]
    [IsoXmlTag("PrtctdATMDgnstcReq")]
    public ContentInformationType10? ProtectedATMDiagnosticRequest { get; init; }

    /// <summary>
    /// Information related to the request of a diagnostic from an ATM.
    /// </summary>
    [IsoId("_Vfn5V646EeWRfYPBaeOY8w")]
    [DisplayName("ATM Diagnostic Request")]
    [IsoXmlTag("ATMDgnstcReq")]
    public ATMDiagnosticRequest2? ATMDiagnosticRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC.
    /// </summary>
    [IsoId("_Vfn5Wa46EeWRfYPBaeOY8w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ATMDiagnosticRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMDiagnosticRequestV02.
