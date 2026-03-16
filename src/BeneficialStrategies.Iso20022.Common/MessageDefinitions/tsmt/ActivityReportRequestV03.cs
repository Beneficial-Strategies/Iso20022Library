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
/// This record is an implementation of the tsmt.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ActivityReportRequest message is sent by any party involved in a transaction to the matching application.
/// This message is used to request a report on all transactions for which an activity has taken place within a given time span.
/// Usage
/// The ActivityReportRequest message can be sent
/// - at a pre-determined time. The message requests a report on all transactions that the requester is involved in and for which an activity has taken place within the last 24 hours.
/// - on demand. The message requests a report on all transactions that the requester is involved in and for which an activity has taken place within a time span specified by the requester.
/// </summary>
[Description(
    @"Scope|The ActivityReportRequest message is sent by any party involved in a transaction to the matching application.|This message is used to request a report on all transactions for which an activity has taken place within a given time span.|Usage|The ActivityReportRequest message can be sent|- at a pre-determined time. The message requests a report on all transactions that the requester is involved in and for which an activity has taken place within the last 24 hours.|- on demand. The message requests a report on all transactions that the requester is involved in and for which an activity has taken place within a time span specified by the requester."
)]
[IsoId("_iE0UQNE8Ed-BzquC8wXy7w_1228841128")]
[DisplayName("Activity Report Request V")]
public record ActivityReportRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.003.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ActvtyReqRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.003.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Identifies the request message.
    /// </summary>
    [IsoId("_iE0UQdE8Ed-BzquC8wXy7w_1228841159")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Specifies the entities of the submitter for which the activities have to be reported.
    /// </summary>
    [IsoId("_iE0UQtE8Ed-BzquC8wXy7w_1228841591")]
    [DisplayName("Entities To Be Reported")]
    [IsoXmlTag("NttiesToBeRptd")]
    public BICIdentification1? EntitiesToBeReported { get; init; }

    /// <summary>
    /// Specifies the period for which activities have to be reported.
    /// </summary>
    [IsoId("_iE0UQ9E8Ed-BzquC8wXy7w_1228841529")]
    [DisplayName("Report Period")]
    [IsoXmlTag("RptPrd")]
    public required DateTimePeriodDetails1 ReportPeriod { get; init; }
}

// Since ActivityReportRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ActivityReportRequestV03.
