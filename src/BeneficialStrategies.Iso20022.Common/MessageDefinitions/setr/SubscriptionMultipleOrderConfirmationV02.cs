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
/// This record is an implementation of the setr.012.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SubscriptionMultipleOrderConfirmation message is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instruction party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to confirm the details of the execution of a SubscriptionMultipleOrder message.
/// Usage
/// The SubscriptionMultipleOrderConfirmation message is sent, after the price has been determined, to confirm the execution of the individual orders.
/// A SubscriptionMultipleOrder may be responded to by more than one SubscriptionMultipleOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.
/// When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation must be based on the references.
/// A SubscriptionMultipleOrder must in all cases be responded to by a SubscriptionMultipleOrderConfirmation message/s and in no circumstances by a SubscriptionBulkOrderConfirmation message/s.
/// If the executing party needs to confirm a SubscriptionBulkOrder message, then a SubscriptionBulkOrderConfirmation message must be used.
/// </summary>
[Description(
    @"Scope|The SubscriptionMultipleOrderConfirmation message is sent by an executing party, eg, a transfer agent, to the instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instruction party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to confirm the details of the execution of a SubscriptionMultipleOrder message.|Usage|The SubscriptionMultipleOrderConfirmation message is sent, after the price has been determined, to confirm the execution of the individual orders.|A SubscriptionMultipleOrder may be responded to by more than one SubscriptionMultipleOrderConfirmation message, as the valuation cycle of the financial instruments in each individual order may be different.|When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation must be based on the references.|A SubscriptionMultipleOrder must in all cases be responded to by a SubscriptionMultipleOrderConfirmation message/s and in no circumstances by a SubscriptionBulkOrderConfirmation message/s.|If the executing party needs to confirm a SubscriptionBulkOrder message, then a SubscriptionBulkOrderConfirmation message must be used."
)]
[IsoId("_1Ask6NE7Ed-BzquC8wXy7w_-475938277")]
[DisplayName("Subscription Multiple Order Confirmation V")]
public record SubscriptionMultipleOrderConfirmationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.012.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.012.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.012.001.02";

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
    [IsoId("_1Ask6dE7Ed-BzquC8wXy7w_2083815403")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_1A2V4NE7Ed-BzquC8wXy7w_2095819780")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_1A2V4dE7Ed-BzquC8wXy7w_2093971857")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_1A2V4tE7Ed-BzquC8wXy7w_2098590018")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference3 RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund order.
    /// </summary>
    [IsoId("_1A2V49E7Ed-BzquC8wXy7w_955522079")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required SubscriptionMultipleExecution2 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Confirmation of the information related to an intermediary.
    /// </summary>
    [IsoId("_1A2V5NE7Ed-BzquC8wXy7w_536472801")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_1A2V5dE7Ed-BzquC8wXy7w_1679115496")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1A2V5tE7Ed-BzquC8wXy7w_678927183")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since SubscriptionMultipleOrderConfirmationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SubscriptionMultipleOrderConfirmationV02.
