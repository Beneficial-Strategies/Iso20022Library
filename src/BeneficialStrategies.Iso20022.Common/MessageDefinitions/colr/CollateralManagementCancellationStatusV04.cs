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

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.006.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralManagementCancellationStatus message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager, or
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager.
/// This message is used to provide the status of accepted or rejected for the CollateralManagementCancellationRequest message previously received.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// The CollateralManagementCancellationStatus message can be sent to provide a status for a previously received CollateralManagementCancellationRequest message.
/// </summary>
[Description(
    @"Scope|The CollateralManagementCancellationStatus message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager, or|- the collateral giver or its collateral manager to the collateral taker or its collateral manager.|This message is used to provide the status of accepted or rejected for the CollateralManagementCancellationRequest message previously received.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralManagementCancellationStatus message can be sent to provide a status for a previously received CollateralManagementCancellationRequest message."
)]
[IsoId("_cjxa8YFrEeWtPe6Crjmeug")]
[DisplayName("Collateral Management Cancellation Status V")]
public record CollateralManagementCancellationStatusV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.006.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollMgmtCxlSts";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.006.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Unambiguous identification of the transaction as know by the instructing party.
    /// </summary>
    [IsoId("_cjxa84FrEeWtPe6Crjmeug")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Provides reference to the previous received message.
    /// </summary>
    [IsoId("_cjxa9YFrEeWtPe6Crjmeug")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required Reference16 Reference { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_cjxa94FrEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation4 Obligation { get; init; }

    /// <summary>
    /// Provides status details of the collateral cancellation message.
    /// </summary>
    [IsoId("_cjxa-YFrEeWtPe6Crjmeug")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public required CollateralCancellationStatus1 CancellationStatus { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_cjxa-4FrEeWtPe6Crjmeug")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CollateralManagementCancellationStatusV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralManagementCancellationStatusV04.
