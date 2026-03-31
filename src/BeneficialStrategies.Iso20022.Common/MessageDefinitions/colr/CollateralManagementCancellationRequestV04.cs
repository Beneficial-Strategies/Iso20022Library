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
/// This record is an implementation of the colr.005.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CollateralManagementCancellationRequest message is sent by:
/// - the collateral taker or its collateral manager to the collateral giver or its collateral manager,
/// - the collateral giver or its collateral manager to the collateral taker or its collateral manager
/// This message is used to request the cancellation of a previously sent MarginCallRequest message, MarginCallResponse message, CollateralProposal message, CollateralProposalResponse message, MarginCallDisputeNotification message or a CollateralSubstitutionRequest message.
///
/// The message definition is intended for use with the ISO20022 Business Application Header.
///
/// Usage
/// The CollateralManagementCancellationRequest message is used to request the cancellation of a collateral message. When requesting the cancellation of a message there must be a cancellation reason specified.
/// When the CollateralManagementCancellationRequest message is used to cancel a collateral message the reference of the original message must be specified. The rejection or acceptance of a CollateralManagementCancellationRequest message is made using a CollateralManagementCancellationStatus message.
/// </summary>
[Description(
    @"Scope|The CollateralManagementCancellationRequest message is sent by:|- the collateral taker or its collateral manager to the collateral giver or its collateral manager,|- the collateral giver or its collateral manager to the collateral taker or its collateral manager|This message is used to request the cancellation of a previously sent MarginCallRequest message, MarginCallResponse message, CollateralProposal message, CollateralProposalResponse message, MarginCallDisputeNotification message or a CollateralSubstitutionRequest message.||The message definition is intended for use with the ISO20022 Business Application Header.||Usage|The CollateralManagementCancellationRequest message is used to request the cancellation of a collateral message. When requesting the cancellation of a message there must be a cancellation reason specified.|When the CollateralManagementCancellationRequest message is used to cancel a collateral message the reference of the original message must be specified. The rejection or acceptance of a CollateralManagementCancellationRequest message is made using a CollateralManagementCancellationStatus message."
)]
[IsoId("_Z6K7cYFrEeWtPe6Crjmeug")]
[DisplayName("Collateral Management Cancellation Request V")]
public record CollateralManagementCancellationRequestV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.005.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CollMgmtCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.005.001.04";

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
    [IsoId("_Z6K7c4FrEeWtPe6Crjmeug")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the message advised to be cancelled.
    /// </summary>
    [IsoId("_Z6K7dYFrEeWtPe6Crjmeug")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required Reference2Choice_ Reference { get; init; }

    /// <summary>
    /// Provides information like the identification of the party or parties associated with the collateral agreement, the exposure type and the valuation date.
    /// </summary>
    [IsoId("_Z6K7d4FrEeWtPe6Crjmeug")]
    [DisplayName("Obligation")]
    [IsoXmlTag("Oblgtn")]
    public required Obligation4 Obligation { get; init; }

    /// <summary>
    /// It is used to detail the reason for the cancellation of a previously sent request.
    /// </summary>
    [IsoId("_Z6K7eYFrEeWtPe6Crjmeug")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public required CollateralCancellationReason1 CancellationReason { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Z6K7e4FrEeWtPe6Crjmeug")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since CollateralManagementCancellationRequestV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CollateralManagementCancellationRequestV04.
