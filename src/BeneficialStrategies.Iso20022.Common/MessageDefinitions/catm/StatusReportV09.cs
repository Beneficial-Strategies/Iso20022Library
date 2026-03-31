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
/// This record is an implementation of the catm.001.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The StatusReport message is sent by a POI to inform the master terminal manager (MTM) or the terminal manager (TM) about the status of the acceptor system including the identification of the POI, its components and their installed versions.
/// </summary>
[Description(
    @"The StatusReport message is sent by a POI to inform the master terminal manager (MTM) or the terminal manager (TM) about the status of the acceptor system including the identification of the POI, its components and their installed versions."
)]
[IsoId("_PQf58RBcEeqgJK7e3n_EXA")]
[DisplayName("Status Report V")]
public record StatusReportV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.001.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.001.001.09";

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
    [IsoId("_PQf59RBcEeqgJK7e3n_EXA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required TMSHeader1 Header { get; init; }

    /// <summary>
    /// Status of the point of interaction (POI), its components and their installed versions.
    /// </summary>
    [IsoId("_PQf59xBcEeqgJK7e3n_EXA")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required StatusReport9 StatusReport { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_PQf5-RBcEeqgJK7e3n_EXA")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType21? SecurityTrailer { get; init; }
}

// Since StatusReportV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusReportV09.
