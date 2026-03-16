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
/// This record is an implementation of the setr.006.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of execution for a previously received RedemptionOrder message.
/// Usage
/// The RedemptionOrderConfirmation message is used to confirm the execution of one or more individual orders.
/// A RedemptionOrder message containing more than one individual order may be responded to by more than one RedemptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.
/// Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in RelatedReference.
/// When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation should be based on the references.
/// A RedemptionOrder must in all cases be responded to by a RedemptionOrderConfirmation message and in no circumstances by a RedemptionBulkOrderConfirmation message.
/// If the executing party needs to confirm a RedemptionBulkOrder message, then a RedemptionBulkOrderConfirmation message must be used.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmation message to the instructing party, for example, an investment manager or its authorised representative to confirm the details of execution for a previously received RedemptionOrder message.|Usage|The RedemptionOrderConfirmation message is used to confirm the execution of one or more individual orders.|A RedemptionOrder message containing more than one individual order may be responded to by more than one RedemptionOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.|Each individual order confirmation specified is identified in DealReference. The reference of the original individual order is specified in OrderReference. The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in RelatedReference.|When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation should be based on the references.|A RedemptionOrder must in all cases be responded to by a RedemptionOrderConfirmation message and in no circumstances by a RedemptionBulkOrderConfirmation message.|If the executing party needs to confirm a RedemptionBulkOrder message, then a RedemptionBulkOrderConfirmation message must be used."
)]
[IsoId("_utoEWNE7Ed-BzquC8wXy7w_1346008013")]
[DisplayName("Redemption Order Confirmation V")]
public record RedemptionOrderConfirmationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.006.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrConfV03";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.006.001.03";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_utxOQNE7Ed-BzquC8wXy7w_-1539573830")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_utxOQdE7Ed-BzquC8wXy7w_-412970353")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_utxOQtE7Ed-BzquC8wXy7w_-411121699")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_utxOQ9E7Ed-BzquC8wXy7w_-400964997")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_utxORNE7Ed-BzquC8wXy7w_1763770658")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required RedemptionMultipleExecution3 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_utxORdE7Ed-BzquC8wXy7w_645385224")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_utxORtE7Ed-BzquC8wXy7w_647232459")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_utxOR9E7Ed-BzquC8wXy7w_649080424")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionOrderConfirmationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionOrderConfirmationV03.
