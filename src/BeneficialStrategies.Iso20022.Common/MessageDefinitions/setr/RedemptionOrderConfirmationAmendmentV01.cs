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
/// This record is an implementation of the setr.052.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent RedemptionOrderConfirmation message.
/// Usage
/// The RedemptionOrderConfirmationAmendment message is used to amend one or more previously sent redemption order confirmations.
/// Each individual order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.
/// The message identification of the RedemptionOrder message in which the individual orders were conveyed may also be quoted in RelatedReference. The message identification of the RedemptionOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmationAmendment message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent RedemptionOrderConfirmation message.|Usage|The RedemptionOrderConfirmationAmendment message is used to amend one or more previously sent redemption order confirmations.|Each individual order confirmation amendment specified is identified in DealReference. The reference of the original individual order is specified in OrderReference.|The message identification of the RedemptionOrder message in which the individual orders were conveyed may also be quoted in RelatedReference. The message identification of the RedemptionOrderConfirmation message in which the original order confirmations were conveyed may also be quoted in PreviousReference."
)]
[IsoId("_tf1biNE7Ed-BzquC8wXy7w_-840457611")]
[DisplayName("Redemption Order Confirmation Amendment V")]
public record RedemptionOrderConfirmationAmendmentV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.052.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrConfAmdmntV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.052.001.01";

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
    [IsoId("_tf1bidE7Ed-BzquC8wXy7w_-817484711")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_tf1bitE7Ed-BzquC8wXy7w_-818408671")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_tf_MgNE7Ed-BzquC8wXy7w_-818407706")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_tf_MgdE7Ed-BzquC8wXy7w_-818407148")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_tf_MgtE7Ed-BzquC8wXy7w_-817485227")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required RedemptionMultipleExecution3 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_tf_Mg9E7Ed-BzquC8wXy7w_-818406741")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_tf_MhNE7Ed-BzquC8wXy7w_-818405846")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_tf_MhdE7Ed-BzquC8wXy7w_-817485677")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionOrderConfirmationAmendmentV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionOrderConfirmationAmendmentV01.
