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
/// This record is an implementation of the catm.001.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The StatusReport message is sent by the card acceptor to the master terminal manager or delegated terminal manager to inform these entities about the status of the acceptor system.
/// Usage
/// The StatusReport message may embed the information required by the master terminal manager or delegated terminal manager for preparing the needed TMS actions in the management plan to be replaced and the acceptor parameters to be updated.
/// </summary>
[Description(
    @"Scope|The StatusReport message is sent by the card acceptor to the master terminal manager or delegated terminal manager to inform these entities about the status of the acceptor system.|Usage|The StatusReport message may embed the information required by the master terminal manager or delegated terminal manager for preparing the needed TMS actions in the management plan to be replaced and the acceptor parameters to be updated."
)]
[IsoId("_8ki24OQWEeCGktPI9k4Dlw_716782601")]
[DisplayName("Status Report V")]
public record StatusReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "catm.001.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "StsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:catm.001.001.01";

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
    [IsoId("_8ki24eQWEeCGktPI9k4Dlw_817647362")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header4 Header { get; init; }

    /// <summary>
    /// Status of the point of interaction (POI), its components and their installed versions.
    /// </summary>
    [IsoId("_8ki24uQWEeCGktPI9k4Dlw_2054938442")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required StatusReport1 StatusReport { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_8ki24-QWEeCGktPI9k4Dlw_1773797778")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public required ContentInformationType1 SecurityTrailer { get; init; }
}

// Since StatusReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to StatusReportV01.
