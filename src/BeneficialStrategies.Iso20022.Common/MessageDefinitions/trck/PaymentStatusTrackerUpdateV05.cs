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
/// This record is an implementation of the trck.001.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The PaymentStatusTrackerUpdate message is sent by an agent to a tracking facility to monitor the progress of a business transaction, and to update the status of this business transaction for obtaining tracking and transparency purpose.
/// Usage
/// Multiple business transaction statuses may be reported in a single message, and each status may include all relevant information of a single transaction or multiple transactions of the tracked payment(s) exchanged.
/// </summary>
[Description(
    @"The PaymentStatusTrackerUpdate message is sent by an agent to a tracking facility to monitor the progress of a business transaction, and to update the status of this business transaction for obtaining tracking and transparency purpose.|Usage|Multiple business transaction statuses may be reported in a single message, and each status may include all relevant information of a single transaction or multiple transactions of the tracked payment(s) exchanged."
)]
[IsoId("bfeb7dc1-7509-4665-9e03-a7726d28da33")]
[DisplayName("Payment Status Tracker Update V05")]
public record PaymentStatusTrackerUpdateV05 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trck.001.001.05";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtStsTrackerUpdt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trck.001.001.05";

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
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required TrackerHeader6 GroupHeader { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    /// <summary>
    /// Transaction data and status information to be updated in the tracker.
    /// </summary>
    [DisplayName("Tracker Status And Transaction")]
    [IsoXmlTag("TrckrStsAndTx")]
    public ValueList<TrackerStatusAndTransaction22> TrackerStatusAndTransaction { get; init; } = [];
}

// Since PaymentStatusTrackerUpdateV05Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PaymentStatusTrackerUpdateV05.
