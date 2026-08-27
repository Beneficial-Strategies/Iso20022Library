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
/// This record is an implementation of the trck.004.001.03 ISO standard message type.
/// The PaymentStatusCustomerTrackerReport message is sent by a tracking facility or any authorised party to relevant parties involved in the business transaction to report on the progress of one or more business transaction(s) and obtain transparency on the status.
/// </summary>
[Description(
    @"The PaymentStatusCustomerTrackerReport message is sent by a tracking facility or any authorised party to relevant parties involved in the business transaction to report on the progress of one or more business transaction(s) and obtain transparency on the status."
)]
[IsoId("_--KG4UN7Ee-QZYT2pcGFZw")]
[DisplayName("Payment Status Customer Tracker Report V03")]
public record PaymentStatusCustomerTrackerReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trck.004.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PmtStsCstmrTrckrRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trck.004.001.03";

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
    [IsoId("_--KG60N7Ee-QZYT2pcGFZw")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required TrackerHeader5 GroupHeader { get; init; }

    /// <summary>
    /// Transaction data and status information to be updated in the tracker.
    /// </summary>
    [IsoId("_--KG7UN7Ee-QZYT2pcGFZw")]
    [DisplayName("Tracker Status And Transaction")]
    [IsoXmlTag("TrckrStsAndTx")]
    [MinLength(1)]
    public ValueList<TrackerStatusAndTransaction18> TrackerStatusAndTransaction { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_--KG70N7Ee-QZYT2pcGFZw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
