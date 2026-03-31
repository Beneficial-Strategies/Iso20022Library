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

namespace BeneficialStrategies.Iso20022.casp;

/// <summary>
/// This record is an implementation of the casp.009.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SaleToPOIReportRequest message is sent by sale system to request a report service.
/// </summary>
[Description(
    @"The SaleToPOIReportRequest message is sent by sale system to request a report service."
)]
[IsoId("_kfKQcS5LEeunNvJlR_vCbg")]
[DisplayName("Sale To POI Report Request V")]
public record SaleToPOIReportRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "casp.009.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SaleToPOIRptReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:casp.009.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Set of characteristics related to the transfer of the request.
    /// </summary>
    [IsoId("_kfKQcy5LEeunNvJlR_vCbg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header41 Header { get; init; }

    /// <summary>
    /// Information related to the report request.
    /// </summary>
    [IsoId("_kfKQdS5LEeunNvJlR_vCbg")]
    [DisplayName("Report Request")]
    [IsoXmlTag("RptReq")]
    public required ReportRequest4 ReportRequest { get; init; }

    /// <summary>
    /// Trailer of the message containing a MAC or a digital signature.
    /// </summary>
    [IsoId("_kfKQdy5LEeunNvJlR_vCbg")]
    [DisplayName("Security Trailer")]
    [IsoXmlTag("SctyTrlr")]
    public ContentInformationType25? SecurityTrailer { get; init; }
}

// Since SaleToPOIReportRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SaleToPOIReportRequestV03.
