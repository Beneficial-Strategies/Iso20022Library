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
/// This record is an implementation of the tsmt.004.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ActivityReportSetUpRequest message is sent by any party involved in a transaction to the matching application.
/// The ActivityReportSetUpRequest message can be sent to request the reset of the pre-determined time at which the daily production of the activity report should take place.
/// Usage
/// This message is sent to the matching application by a bank, in order to set the UTC offset specifying the hour when the matching application will generate every day an activity report covering the last 24 hours and send it. By default, this offset is equal to 0.
/// </summary>
[Description(
    @"Scope|The ActivityReportSetUpRequest message is sent by any party involved in a transaction to the matching application.|The ActivityReportSetUpRequest message can be sent to request the reset of the pre-determined time at which the daily production of the activity report should take place.|Usage|This message is sent to the matching application by a bank, in order to set the UTC offset specifying the hour when the matching application will generate every day an activity report covering the last 24 hours and send it. By default, this offset is equal to 0."
)]
[IsoId("_ihSN2NE8Ed-BzquC8wXy7w_-1378853261")]
[DisplayName("Activity Report Set Up Request V")]
public record ActivityReportSetUpRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "tsmt.004.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ActvtyRptSetUpReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:tsmt.004.001.02";

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
    [IsoId("_ihSN2dE8Ed-BzquC8wXy7w_-1378853229")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Specifies the parameters to calculate the local reporting time.
    /// </summary>
    [IsoId("_ihSN2tE8Ed-BzquC8wXy7w_-1378852898")]
    [DisplayName("UTC Offset")]
    [IsoXmlTag("UTCOffset")]
    public required UTCOffset1 UTCOffset { get; init; }
}

// Since ActivityReportSetUpRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ActivityReportSetUpRequestV02.
