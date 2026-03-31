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
/// This record is an implementation of the setr.003.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionBulkOrderConfirmation message is sent by an executing party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to confirm the details of the execution of a RedemptionBulkOrder message.
/// Usage
/// The RedemptionBulkOrderConfirmation message is sent, after the price has been determined, to confirm the execution of all individual orders.
/// There is usually one bulk confirmation message for one bulk order message.
/// A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionMultipleOrderConfirmation.
/// If the executing party needs to confirm a RedemptionMultipleOrder message, then the RedemptionMultipleOrderConfirmation message must be used.
/// </summary>
[Description(
    @"Scope|The RedemptionBulkOrderConfirmation message is sent by an executing party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to confirm the details of the execution of a RedemptionBulkOrder message.|Usage|The RedemptionBulkOrderConfirmation message is sent, after the price has been determined, to confirm the execution of all individual orders.|There is usually one bulk confirmation message for one bulk order message.|A RedemptionBulkOrder must in all cases be responded to by a RedemptionBulkOrderConfirmation and in no circumstances by a RedemptionMultipleOrderConfirmation.|If the executing party needs to confirm a RedemptionMultipleOrder message, then the RedemptionMultipleOrderConfirmation message must be used."
)]
[IsoId("_pGD-5dE7Ed-BzquC8wXy7w_314405258")]
[DisplayName("Redemption Bulk Order Confirmation V")]
public record RedemptionBulkOrderConfirmationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.003.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.003.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.003.001.02";

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
    [IsoId("_pGD-5tE7Ed-BzquC8wXy7w_1787375845")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_pGD-59E7Ed-BzquC8wXy7w_1776292588")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_pGD-6NE7Ed-BzquC8wXy7w_1774443914")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_pGD-6dE7Ed-BzquC8wXy7w_1778141211")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference3 RelatedReference { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund orders.
    /// </summary>
    [IsoId("_pGNI0NE7Ed-BzquC8wXy7w_735528322")]
    [DisplayName("Bulk Execution Details")]
    [IsoXmlTag("BlkExctnDtls")]
    public required RedemptionBulkExecution2 BulkExecutionDetails { get; init; }

    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_pGNI0dE7Ed-BzquC8wXy7w_-833250151")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_pGNI0tE7Ed-BzquC8wXy7w_-1336774752")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_pGNI09E7Ed-BzquC8wXy7w_-338730008")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionBulkOrderConfirmationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionBulkOrderConfirmationV02.
