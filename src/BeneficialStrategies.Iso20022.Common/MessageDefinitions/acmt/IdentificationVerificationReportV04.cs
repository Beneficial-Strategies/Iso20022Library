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

namespace BeneficialStrategies.Iso20022.acmt;

/// <summary>
/// This record is an implementation of the acmt.024.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_R3M1AzEZEe6kQ-WGAhcVPQ")]
[DisplayName("Identification Verification Report V04")]
public record IdentificationVerificationReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "acmt.024.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "IdVrfctnRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:acmt.024.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Assignment.
    /// </summary>
    [DisplayName("Assignment")]
    [IsoXmlTag("Assgnmt")]
    public required IdentificationAssignment4 Assignment { get; init; }

    /// <summary>
    /// Original Assignment.
    /// </summary>
    [DisplayName("Original Assignment")]
    [IsoXmlTag("OrgnlAssgnmt")]
    public MessageIdentification8? OriginalAssignment { get; init; }

    /// <summary>
    /// Report.
    /// </summary>
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public ValueList<VerificationReport5> Report { get; init; } = [];

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since IdentificationVerificationReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to IdentificationVerificationReportV04.
