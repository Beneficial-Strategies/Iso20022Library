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
/// This record is an implementation of the catp.007.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_J2GiIaFFEe-MRKYsaX6JDg")]
[DisplayName("ATM Inquiry Response V03")]
public record ATMInquiryResponseV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catp.007.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ATMNqryRspn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catp.007.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// ATM Inquiry Response.
    /// </summary>
    [DisplayName("ATM Inquiry Response")]
    [IsoXmlTag("ATMNqryRspn")]
    public ATMInquiryResponse3? ATMInquiryResponse { get; init; }

    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header31 Header { get; init; }

    /// <summary>
    /// Protected ATM Inquiry Response.
    /// </summary>
    [DisplayName("Protected ATM Inquiry Response")]
    [IsoXmlTag("PrtctdATMNqryRspn")]
    public ContentInformationType10? ProtectedATMInquiryResponse { get; init; }

    /// <summary>
    /// Security Trailer.
    /// </summary>
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType15? SecurityTrailer { get; init; }
}

// Since ATMInquiryResponseV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ATMInquiryResponseV03.
