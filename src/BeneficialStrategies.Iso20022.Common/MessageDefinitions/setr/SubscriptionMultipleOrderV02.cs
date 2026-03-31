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
/// This record is an implementation of the setr.010.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SubscriptionMultipleOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to instruct the executing party to subscribe to one or more financial instruments, for the same account.
/// Usage
/// The SubscriptionMultipleOrder message is used for multiple orders. It may also be used for single orders, ie, a message containing one order for one financial instrument and related to one investment account. For a single subscription order, the SubscriptionMultipleOrder message, not the SubscriptionBulkOrder message, must be used.
/// If there are subscription orders for the same financial instrument but for different accounts, then the SubscriptionBulkOrder message must be used.
/// </summary>
[Description(
    @"Scope|The SubscriptionMultipleOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to instruct the executing party to subscribe to one or more financial instruments, for the same account.|Usage|The SubscriptionMultipleOrder message is used for multiple orders. It may also be used for single orders, ie, a message containing one order for one financial instrument and related to one investment account. For a single subscription order, the SubscriptionMultipleOrder message, not the SubscriptionBulkOrder message, must be used.|If there are subscription orders for the same financial instrument but for different accounts, then the SubscriptionBulkOrder message must be used."
)]
[IsoId("_1eWxQNE7Ed-BzquC8wXy7w_1537721740")]
[DisplayName("Subscription Multiple Order V")]
public record SubscriptionMultipleOrderV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.010.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.010.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.010.001.02";

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
    [IsoId("_1eWxQdE7Ed-BzquC8wXy7w_2124617993")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_1eWxQtE7Ed-BzquC8wXy7w_-2096470603")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_1eWxQ9E7Ed-BzquC8wXy7w_2058121645")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_1eWxRNE7Ed-BzquC8wXy7w_-926146084")]
    [DisplayName("Multiple Order Details")]
    [IsoXmlTag("MltplOrdrDtls")]
    public required SubscriptionMultipleOrder2 MultipleOrderDetails { get; init; }

    /// <summary>
    /// Information related to the intermediary.
    /// </summary>
    [IsoId("_1eWxRdE7Ed-BzquC8wXy7w_1257163700")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_1eWxRtE7Ed-BzquC8wXy7w_-816960596")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_1eWxR9E7Ed-BzquC8wXy7w_581032056")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since SubscriptionMultipleOrderV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SubscriptionMultipleOrderV02.
