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
/// This record is an implementation of the setr.048.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the SubscriptionOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SubscriptionOrderConfirmation.
/// Usage
/// The SubscriptionOrderConfirmationAmendment message is used to amend one or more previously sent subscription order confirmations.
/// Each individual order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.
/// The message identification of the SubscriptionOrder message in which the individual orders were conveyed may also be quoted in RelatedReference. The message identification of the SubscriptionOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the SubscriptionOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SubscriptionOrderConfirmation.|Usage|The SubscriptionOrderConfirmationAmendment message is used to amend one or more previously sent subscription order confirmations.|Each individual order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.|The message identification of the SubscriptionOrder message in which the individual orders were conveyed may also be quoted in RelatedReference. The message identification of the SubscriptionOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference."
)]
[IsoId("_3HjjstE7Ed-BzquC8wXy7w_-2084438867")]
[DisplayName("Subscription Order Confirmation Amendment V")]
public record SubscriptionOrderConfirmationAmendmentV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.048.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdrConfAmdmntV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.048.001.01";

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
    [IsoId("_3Hjjs9E7Ed-BzquC8wXy7w_863350222")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_3HjjtNE7Ed-BzquC8wXy7w_858732782")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_3HjjtdE7Ed-BzquC8wXy7w_858735058")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_3HjjttE7Ed-BzquC8wXy7w_859657174")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund order.
    /// </summary>
    [IsoId("_3Hjjt9E7Ed-BzquC8wXy7w_862427227")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required SubscriptionMultipleExecution3 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_3HjjuNE7Ed-BzquC8wXy7w_860579233")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_3HtUsNE7Ed-BzquC8wXy7w_861502126")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_3HtUsdE7Ed-BzquC8wXy7w_861505547")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since SubscriptionOrderConfirmationAmendmentV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SubscriptionOrderConfirmationAmendmentV01.
