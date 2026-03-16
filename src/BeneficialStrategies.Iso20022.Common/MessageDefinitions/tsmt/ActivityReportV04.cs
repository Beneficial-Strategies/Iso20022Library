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

namespace BeneficialStrategies.Iso20022.tsmt;

/// <summary>
/// This record is an implementation of the tsmt.002.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ActivityReport message is sent by the matching application to the requester of an activity report.
/// This message is used to report on all transactions for which an activity has taken place within a given time span.
/// Usage
/// The ActivityReport message can be sent
/// - at a pre-determined time every 24 hours. The message reports on all transactions that the requester is involved in and for which an activity has taken place within the last 24 hours.
/// - on demand in response to an ActivityReportRequest message. The message reports on all transactions that the requester is involved in and for which an activity has taken place within a time span specified by the requester in the ActivityReportRequest message.
/// </summary>
[Description(
    @"Scope|The ActivityReport message is sent by the matching application to the requester of an activity report.|This message is used to report on all transactions for which an activity has taken place within a given time span.|Usage|The ActivityReport message can be sent|- at a pre-determined time every 24 hours. The message reports on all transactions that the requester is involved in and for which an activity has taken place within the last 24 hours.|- on demand in response to an ActivityReportRequest message. The message reports on all transactions that the requester is involved in and for which an activity has taken place within a time span specified by the requester in the ActivityReportRequest message."
)]
[IsoId("_fPCaYefGEeKNfc-Rw_dPYg")]
[DisplayName("Activity Report V")]
public record ActivityReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.002.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ActvtyRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.002.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the report.
    /// </summary>
    [IsoId("_fPCaZefGEeKNfc-Rw_dPYg")]
    [DisplayName("Report Identification")]
    [IsoXmlTag("RptId")]
    public required MessageIdentification1 ReportIdentification { get; init; }

    /// <summary>
    /// Reference to the previous message requesting the report.
    /// </summary>
    [IsoId("_fPCaZ-fGEeKNfc-Rw_dPYg")]
    [DisplayName("Related Message Reference")]
    [IsoXmlTag("RltdMsgRef")]
    public MessageIdentification1? RelatedMessageReference { get; init; }

    /// <summary>
    /// Describes the events that occurred for one transaction.
    /// </summary>
    [IsoId("_fPCaaefGEeKNfc-Rw_dPYg")]
    [DisplayName("Report")]
    [IsoXmlTag("Rpt")]
    public ActivityReportItems3? Report { get; init; }
}

// Since ActivityReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ActivityReportV04.
