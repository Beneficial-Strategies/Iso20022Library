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

namespace BeneficialStrategies.Iso20022.admi;

/// <summary>
/// This record is an implementation of the admi.005.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The ReportQueryRequest message is exchanged between system member and system transaction administrator.|It aims at querying the latest available report data of a specific report type. A report is stored and available for query until the event occurs again report is replaced.
/// </summary>
[Description(
    @"The ReportQueryRequest message is exchanged between system member and system transaction administrator.|It aims at querying the latest available report data of a specific report type. A report is stored and available for query until the event occurs again report is replaced."
)]
[IsoId("_5Ql0IZb3Eee4htziCyV8eA")]
[DisplayName("Report Query Request V")]
public record ReportQueryRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "admi.005.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RptQryReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:admi.005.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of elements to identify the report query request message.
    /// </summary>
    [IsoId("_5Ql0I5b3Eee4htziCyV8eA")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public required MessageHeader7 MessageHeader { get; init; }

    /// <summary>
    /// Definition of the report query criteria.
    /// </summary>
    [IsoId("_5Ql0JZb3Eee4htziCyV8eA")]
    [DisplayName("Report Query Criteria")]
    [IsoXmlTag("RptQryCrit")]
    public ReportQueryCriteria2? ReportQueryCriteria { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_5Ql0J5b3Eee4htziCyV8eA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since ReportQueryRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReportQueryRequestV01.
