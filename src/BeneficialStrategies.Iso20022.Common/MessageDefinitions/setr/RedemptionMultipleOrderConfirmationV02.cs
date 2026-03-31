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
/// This record is an implementation of the setr.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionMultipleOrderConfirmation message is sent by an exacting party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to confirm the details of the execution of a RedemptionMultipleOrder message.
/// Usage
/// The RedemptionMultipleOrderConfirmation message is sent, after the price has been determined, to confirm the execution of all individual orders.
/// A RedemptionMultipleOrder may be responded to by more than one RedemptionMultipleOrderConfirmation, as the valuation cycle of the financial instruments in each individual order may be different.
/// When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation must be based on the references.
/// A RedemptionMultipleOrder must in all cases be responded to by a RedemptionMultipleOrderConfirmation message/s and in no circumstances by a RedemptionBulkOrderConfirmation message/s.
/// If the executing party needs to confirm a RedemptionBulkOrder message, then a RedemptionBulkOrderConfirmation message must be used.
/// </summary>
[Description(
    @"Scope|The RedemptionMultipleOrderConfirmation message is sent by an exacting party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to confirm the details of the execution of a RedemptionMultipleOrder message.|Usage|The RedemptionMultipleOrderConfirmation message is sent, after the price has been determined, to confirm the execution of all individual orders.|A RedemptionMultipleOrder may be responded to by more than one RedemptionMultipleOrderConfirmation, as the valuation cycle of the financial instruments in each individual order may be different.|When the executing party sends several confirmations, there is no specific indication in the message that it is an incomplete confirmation. Reconciliation must be based on the references.|A RedemptionMultipleOrder must in all cases be responded to by a RedemptionMultipleOrderConfirmation message/s and in no circumstances by a RedemptionBulkOrderConfirmation message/s.|If the executing party needs to confirm a RedemptionBulkOrder message, then a RedemptionBulkOrderConfirmation message must be used."
)]
[IsoId("_rWctKNE7Ed-BzquC8wXy7w_939882022")]
[DisplayName("Redemption Multiple Order Confirmation V")]
public record RedemptionMultipleOrderConfirmationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.006.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.006.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.006.001.02";

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
    [IsoId("_rWctKdE7Ed-BzquC8wXy7w_1820938179")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_rWmeINE7Ed-BzquC8wXy7w_1857877983")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_rWmeIdE7Ed-BzquC8wXy7w_1844950048")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_rWmeItE7Ed-BzquC8wXy7w_1847721622")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference3 RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_rWmeI9E7Ed-BzquC8wXy7w_191564288")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required RedemptionMultipleExecution2 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_rWmeJNE7Ed-BzquC8wXy7w_-1031425681")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_rWmeJdE7Ed-BzquC8wXy7w_-2143929681")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_rWmeJtE7Ed-BzquC8wXy7w_-8767689")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionMultipleOrderConfirmationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionMultipleOrderConfirmationV02.
