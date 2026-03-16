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
/// This record is an implementation of the setr.050.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent sends the SubscriptionBulkOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SubscriptionBulkOrderConfirmation message.
/// Usage
/// The SubscriptionBulkOrderConfirmationAmendment message is used to amend one or more previously sent subscription bulk order confirmations.
/// Each bulk order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.
/// The message identification of the SubscriptionBulkOrder message in which the orders were conveyed may also be quoted in RelatedReference. The message identification of the SubscriptionBulkOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent sends the SubscriptionBulkOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SubscriptionBulkOrderConfirmation message.|Usage|The SubscriptionBulkOrderConfirmationAmendment message is used to amend one or more previously sent subscription bulk order confirmations.|Each bulk order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.|The message identification of the SubscriptionBulkOrder message in which the orders were conveyed may also be quoted in RelatedReference. The message identification of the SubscriptionBulkOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference."
)]
[IsoId("_yFZRaNE7Ed-BzquC8wXy7w_-1237571162")]
[DisplayName("Subscription Bulk Order Confirmation Amendment V")]
public record SubscriptionBulkOrderConfirmationAmendmentV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.050.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptBlkOrdrConfAmdmntV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.050.001.01";

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
    [IsoId("_yFibUNE7Ed-BzquC8wXy7w_570833028")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_yFibUdE7Ed-BzquC8wXy7w_569909103")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_yFibUtE7Ed-BzquC8wXy7w_569909582")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_yFibU9E7Ed-BzquC8wXy7w_569910154")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment orders.
    /// </summary>
    [IsoId("_yFibVNE7Ed-BzquC8wXy7w_570832329")]
    [DisplayName("Bulk Execution Details")]
    [IsoXmlTag("BlkExctnDtls")]
    public required SubscriptionBulkExecution3 BulkExecutionDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_yFibVdE7Ed-BzquC8wXy7w_569910703")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_yFibVtE7Ed-BzquC8wXy7w_569911539")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_yFibV9E7Ed-BzquC8wXy7w_569911988")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since SubscriptionBulkOrderConfirmationAmendmentV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SubscriptionBulkOrderConfirmationAmendmentV01.
