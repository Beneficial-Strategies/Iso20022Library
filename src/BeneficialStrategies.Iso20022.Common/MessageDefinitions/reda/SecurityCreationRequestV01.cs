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
/// This record is an implementation of the reda.006.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// An instructing party sends a SecurityCreationRequest message to an executing/servicing party to request the creation of financial instrument static details in their system.
///
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or
/// - a Market Data Provider.
///
/// USAGE
/// The request is sent when the instructing party identified a gap in the securities coverage of the executing/servicing party. The instructing party needs this security to be set-up at the executing /servicing party to perform its activities.
///
/// Initiator: instructing party.
/// </summary>
[Description(
    @"SCOPE|An instructing party sends a SecurityCreationRequest message to an executing/servicing party to request the creation of financial instrument static details in their system.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|The request is sent when the instructing party identified a gap in the securities coverage of the executing/servicing party. The instructing party needs this security to be set-up at the executing /servicing party to perform its activities.||Initiator: instructing party."
)]
[IsoId("_jTt_oR62Eeu31YsWNiv_cw")]
[DisplayName("Security Creation Request V")]
public record SecurityCreationRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.006.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyCreReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.006.001.01";

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
    [IsoId("_C0kGQZIxEeuAlLVx8pyt3w")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }

    /// <summary>
    /// Represents the financial instruments details.
    /// </summary>
    [IsoId("_jTt_rx62Eeu31YsWNiv_cw")]
    [DisplayName("Security")]
    [IsoXmlTag("Scty")]
    public required SecurityAttributes10 Security { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jTt_tR62Eeu31YsWNiv_cw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecurityCreationRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecurityCreationRequestV01.
