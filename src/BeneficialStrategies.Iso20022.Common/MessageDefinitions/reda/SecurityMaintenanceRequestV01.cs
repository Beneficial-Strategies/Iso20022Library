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
/// This record is an implementation of the reda.007.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// An instructing party sends a SecurityMaintenanceRequest message to an executing/servicing party to request the maintenance of financial instrument details in their system.
///
/// The instructing party - executing/servicing party relationship may be:
/// - Central Securities Depositories (CSD) who would like to publish security static data, or
/// - a Corporate, or
/// - a Bank, or
/// - a Market Infrastructure, or
/// - a Market Data Provider.
///
/// USAGE
/// The request is sent when the instructing party identified a gap in the security data within the executing/servicing party system. The instructing party needs this security to be updated at the executing /servicing party to perform its activities.
///
/// Initiator: instructing party.
/// </summary>
[Description(
    @"SCOPE|An instructing party sends a SecurityMaintenanceRequest message to an executing/servicing party to request the maintenance of financial instrument details in their system.||The instructing party - executing/servicing party relationship may be:|- Central Securities Depositories (CSD) who would like to publish security static data, or |- a Corporate, or|- a Bank, or|- a Market Infrastructure, or |- a Market Data Provider.||USAGE|The request is sent when the instructing party identified a gap in the security data within the executing/servicing party system. The instructing party needs this security to be updated at the executing /servicing party to perform its activities.||Initiator: instructing party."
)]
[IsoId("_jTvNwR62Eeu31YsWNiv_cw")]
[DisplayName("Security Maintenance Request V")]
public record SecurityMaintenanceRequestV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.007.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctyMntncReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.007.001.01";

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
    [IsoId("_Qqn3IZIxEeuAlLVx8pyt3w")]
    [DisplayName("Message Header")]
    [IsoXmlTag("MsgHdr")]
    public MessageHeader1? MessageHeader { get; init; }

    /// <summary>
    /// Request to maintain data&apos;s of a security.
    /// </summary>
    [IsoId("_jTvNzx62Eeu31YsWNiv_cw")]
    [DisplayName("Update Type")]
    [IsoXmlTag("UpdTp")]
    public required UpdateType36Choice_ UpdateType { get; init; }

    /// <summary>
    /// Reason for the update of a security.
    /// </summary>
    [IsoId("_nwYQwZI8EeuAlLVx8pyt3w")]
    [DisplayName("Update Reason")]
    [IsoXmlTag("UpdRsn")]
    public SecuritiesUpdateReason1Choice_? UpdateReason { get; init; }

    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_jTvN0R62Eeu31YsWNiv_cw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_wEnt8ZIzEeuAlLVx8pyt3w")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since SecurityMaintenanceRequestV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecurityMaintenanceRequestV01.
