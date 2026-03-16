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
/// This record is an implementation of the reda.030.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// An executing/servicing party sends a SecurityDeletionStatusAdvice message to an instructing party to report the status of a SecurityDeletionRequest message previously sent by the instructing party.
///
/// The SecurityDeletionStatusAdvice message is sent as a response to the request of the instructing party.
///
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or
/// - a Market Data Provider.
///
/// USAGE
/// Initiator: executing/servicing party.
/// </summary>
[Description(
    @"SCOPE|An executing/servicing party sends a SecurityDeletionStatusAdvice message to an instructing party to report the status of a SecurityDeletionRequest message previously sent by the instructing party. ||The SecurityDeletionStatusAdvice message is sent as a response to the request of the instructing party.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|Initiator: executing/servicing party."
)]
[IsoId("_jTumxx62Eeu31YsWNiv_cw")]
[DisplayName("Security Deletion Status Advice V")]
public record SecurityDeletionStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.030.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyDeltnStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.030.001.01";

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
    [IsoId("_OqBRUZIxEeuAlLVx8pyt3w")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader12? MessageHeader { get; init; }

    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_jTum2R62Eeu31YsWNiv_cw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Represents the processing status.
    /// </summary>
    [IsoId("_jTum2x62Eeu31YsWNiv_cw")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public required ProcessingStatus72Choice_ ProcessingStatus { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTum4R62Eeu31YsWNiv_cw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecurityDeletionStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecurityDeletionStatusAdviceV01.
