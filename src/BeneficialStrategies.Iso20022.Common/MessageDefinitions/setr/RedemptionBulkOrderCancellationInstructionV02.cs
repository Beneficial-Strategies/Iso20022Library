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

namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionBulkOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is sent to cancel a previously sent RedemptionBulkOrder instruction.
/// Usage
/// The RedemptionBulkOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionBulkOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.
/// This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.
/// The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.
/// The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message.
/// </summary>
[Description(
    @"Scope|The RedemptionBulkOrderCancellationInstruction message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is sent to cancel a previously sent RedemptionBulkOrder instruction.|Usage|The RedemptionBulkOrderCancellationInstruction message is used to cancel the entire previously sent RedemptionBulkOrder message and all the individual orders that it contained. There is no amendment, but a cancellation and re-instruct policy.|This message must contain the reference of the message to be cancelled. This message may also contain all the details of the message to be cancelled, but this is not recommended.|The deadline and acceptance of a cancellation instruction is subject to a service level agreement (SLA). This cancellation message is a cancellation instruction. There is no automatic acceptance of the cancellation instruction.|The rejection or acceptance of a cancellation message instruction is made using an OrderCancellationStatusReport message."
)]
[IsoId("_nOQIstE7Ed-BzquC8wXy7w_1647966589")]
[DisplayName("Redemption Bulk Order Cancellation Instruction V")]
public record RedemptionBulkOrderCancellationInstructionV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.002.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.002.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.002.001.02";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_nOQIs9E7Ed-BzquC8wXy7w_1157793130")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_nOQItNE7Ed-BzquC8wXy7w_1159641070")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_nOQItdE7Ed-BzquC8wXy7w_1161487708")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference3 PreviousReference { get; init; }

    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_nOQIttE7Ed-BzquC8wXy7w_2018298578")]
    [DisplayName("Order To Be Cancelled")]
    [IsoXmlTag("OrdrToBeCanc")]
    public RedemptionBulkOrderInstruction1? OrderToBeCancelled { get; init; }
}

// Since RedemptionBulkOrderCancellationInstructionV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionBulkOrderCancellationInstructionV02.
