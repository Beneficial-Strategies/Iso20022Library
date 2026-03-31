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

namespace BeneficialStrategies.Iso20022.secl;

/// <summary>
/// This record is an implementation of the secl.010.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_YZ-Mk4cPEe-m68RYMhvgvg")]
[DisplayName("Settlement Obligation Report V04")]
public record SettlementObligationReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "secl.010.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SttlmOblgtnRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:secl.010.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Clearing Member.
    /// </summary>
    [DisplayName("Clearing Member")]
    [IsoXmlTag("ClrMmb")]
    public PartyIdentification253Choice_? ClearingMember { get; init; }

    /// <summary>
    /// Clearing Segment.
    /// </summary>
    [DisplayName("Clearing Segment")]
    [IsoXmlTag("ClrSgmt")]
    public PartyIdentification253Choice_? ClearingSegment { get; init; }

    /// <summary>
    /// Delivery Account.
    /// </summary>
    [DisplayName("Delivery Account")]
    [IsoXmlTag("DlvryAcct")]
    public SecuritiesAccount19? DeliveryAccount { get; init; }

    /// <summary>
    /// Pagination.
    /// </summary>
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Report Details.
    /// </summary>
    [DisplayName("Report Details")]
    [IsoXmlTag("RptDtls")]
    public ValueList<Report7> ReportDetails { get; init; } = [];

    /// <summary>
    /// Report Parameters.
    /// </summary>
    [DisplayName("Report Parameters")]
    [IsoXmlTag("RptParams")]
    public required ReportParameters8 ReportParameters { get; init; }

    /// <summary>
    /// Settlement Parties.
    /// </summary>
    [DisplayName("Settlement Parties")]
    [IsoXmlTag("SttlmPties")]
    public SettlementParties37Choice_? SettlementParties { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}

// Since SettlementObligationReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SettlementObligationReportV04.
