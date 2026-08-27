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

namespace BeneficialStrategies.Iso20022.trck;

/// <summary>
/// This record is an implementation of the trck.001.001.04 ISO standard message type.
/// The PaymentStatusTrackerUpdate message is sent by an agent to a tracking facility to monitor the progress of a business transaction, and to update the status of this business transaction for obtaining tracking and transparency purpose.
/// </summary>
/// <remarks>
/// Usage:
/// Multiple business transaction statuses may be reported in a single message, and each status may include all relevant information of a single transaction or multiple transactions of the tracked payment(s) exchanged.
///
/// Constraints (not separately modeled as properties — enforced by validators):
/// TrackerInformingPartyRule: GroupHeader/TrackerInformingParty or TrackerStatusAndTransaction/TrackerInformingParty must be present.
/// TrackerInformedPartyRule: GroupHeader/TrackerInformedParty must be absent or TrackerStatusAndTransaction/Transaction/TrackerInformedParty must be absent.
/// TrackerInformingParty2Rule: If GroupHeader/TrackerInformingParty is present, then TrackerStatusAndTransaction/TrackerInformingParty is not allowed.
/// </remarks>
[Description(
    @"The PaymentStatusTrackerUpdate message is sent by an agent to a tracking facility to monitor the progress of a business transaction, and to update the status of this business transaction for obtaining tracking and transparency purpose.||Usage:|Multiple business transaction statuses may be reported in a single message, and each status may include all relevant information of a single transaction or multiple transactions of the tracked payment(s) exchanged."
)]
[IsoId("_9WJnQUN7Ee-QZYT2pcGFZw")]
[DisplayName("Payment Status Tracker Update V04")]
public record PaymentStatusTrackerUpdateV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trck.001.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtStsTrckrUpd";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trck.001.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Common business identification for the message.
    /// </summary>
    [IsoId("_9WJnT0N7Ee-QZYT2pcGFZw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required TrackerHeader6 GroupHeader { get; init; }

    /// <summary>
    /// Transaction data and status information to be updated in the tracker.
    /// </summary>
    [IsoId("_9WJnUUN7Ee-QZYT2pcGFZw")]
    [DisplayName("Tracker Status And Transaction")]
    [IsoXmlTag("TrckrStsAndTx")]
    [MinLength(1)]
    public ValueList<TrackerStatusAndTransaction19> TrackerStatusAndTransaction { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_9WJnU0N7Ee-QZYT2pcGFZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
