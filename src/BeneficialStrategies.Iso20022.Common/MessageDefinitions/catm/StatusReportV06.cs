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
/// This record is an implementation of the catm.001.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Informs the master terminal manager (MTM) or the terminal manager (TM) about the status of the acceptor system including the identification of the POI, its components and their installed versions.
/// </summary>
[Description(
    @"Informs the master terminal manager (MTM) or the terminal manager (TM) about the status of the acceptor system including the identification of the POI, its components and their installed versions."
)]
[IsoId("_QXS6wbCaEeapjPTKZHuM2w")]
[DisplayName("Status Report V")]
public record StatusReportV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.001.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.001.001.06";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics related to the transfer of the status report.
    /// </summary>
    [IsoId("_QXS6xbCaEeapjPTKZHuM2w")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header27 Header { get; init; }

    /// <summary>
    /// Status of the point of interaction (POI), its components and their installed versions.
    /// </summary>
    [IsoId("_QXS6x7CaEeapjPTKZHuM2w")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required StatusReport6 StatusReport { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_QXS6ybCaEeapjPTKZHuM2w")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType12? SecurityTrailer { get; init; }
}

// Since StatusReportV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusReportV06.
