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

namespace BeneficialStrategies.Iso20022.camt;

/// <summary>
/// This record is an implementation of the camt.088.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_h34ZMUjqEe-KhcStGV4xTg")]
[DisplayName("Net Report V03")]
public record NetReportV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "camt.088.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "NetRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:camt.088.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Net Obligation.
    /// </summary>
    [DisplayName("Net Obligation")]
    [IsoXmlTag("NetOblgtn")]
    public ValueList<NetObligation3> NetObligation { get; init; } = [];

    /// <summary>
    /// Net Report Data.
    /// </summary>
    [DisplayName("Net Report Data")]
    [IsoXmlTag("NetRptData")]
    public required NetReportData2 NetReportData { get; init; }

    /// <summary>
    /// Net Service Counterparty Identification.
    /// </summary>
    [DisplayName("Net Service Counterparty Identification")]
    [IsoXmlTag("NetSvcCtrPtyId")]
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; }

    /// <summary>
    /// Net Service Participant Identification.
    /// </summary>
    [DisplayName("Net Service Participant Identification")]
    [IsoXmlTag("NetSvcPtcptId")]
    public required PartyIdentification242Choice_ NetServiceParticipantIdentification { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since NetReportV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to NetReportV03.
