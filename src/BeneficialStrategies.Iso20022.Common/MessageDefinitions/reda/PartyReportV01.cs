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

namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.017.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// The PartyReport message is sent by the executing party to a central securities depository, a national central bank, a central securities depository participant, a central counter party, a payment bank, a trading party or a stock exchange to provide detailed information on the requested party reference data of the party defined in the system.
/// </summary>
[Description(
    @"Scope:|The PartyReport message is sent by the executing party to a central securities depository, a national central bank, a central securities depository participant, a central counter party, a payment bank, a trading party or a stock exchange to provide detailed information on the requested party reference data of the party defined in the system."
)]
[IsoId("_6SbBIZeSEeen_cyMrluY4w")]
[DisplayName("Party Report V")]
public record PartyReportV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.017.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PtyRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.017.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Point to point reference elements, as assigned by the instructing party, to unambiguously identify the report message.
    /// </summary>
    [IsoId("_6SbBI5eSEeen_cyMrluY4w")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader3? MessageHeader { get; init; }

    /// <summary>
    /// Provides information on report or error resulting from the originating query message.
    /// </summary>
    [IsoId("_6SbBKZeSEeen_cyMrluY4w")]
    [DisplayName("Report Or Error")]
    [IsoXmlTag("RptOrErr")]
    public required PartyOrOperationalError3Choice_ ReportOrError { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_6SbBK5eSEeen_cyMrluY4w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since PartyReportV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PartyReportV01.
