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
/// This record is an implementation of the setr.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RedemptionBulkOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message is used to instruct the executing party to redeem a financial instrument for two or more accounts.
/// Usage
/// The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, ie, account owners, but are the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.
/// This message will be typically used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.
/// For a single redemption order, the RedemptionMultipleOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for different financial instruments but for the same account, then the RedemptionMultipleOrder must be used.
/// </summary>
[Description(
    @"Scope|The RedemptionBulkOrder message is sent by an instructing party, eg, an investment manager or its authorised representative, to an executing party, eg, a transfer agent. There may be one or more intermediary parties between the instructing party and the executing party. The intermediary party is, for example, an intermediary or a concentrator.|This message is used to instruct the executing party to redeem a financial instrument for two or more accounts.|Usage|The RedemptionBulkOrder message is used to bulk several individual orders into one bulk order. The individual orders come from different instructing parties, ie, account owners, but are the same financial instrument. The RedemptionBulkOrder can result in one single bulk cash settlement or several individual cash settlements.|This message will be typically used by a party collecting orders and bulking these individual orders into one bulk order before sending it to another party.|For a single redemption order, the RedemptionMultipleOrder message, not the RedemptionBulkOrder message, must be used.|If there are redemption orders for different financial instruments but for the same account, then the RedemptionMultipleOrder must be used."
)]
[IsoId("_p-h38NE7Ed-BzquC8wXy7w_-1554802764")]
[DisplayName("Redemption Bulk Order V")]
public record RedemptionBulkOrderV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.001.001.02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.001.001.02";

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
    [IsoId("_p-h38dE7Ed-BzquC8wXy7w_-1390267861")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_p-h38tE7Ed-BzquC8wXy7w_-1379184076")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_p-h389E7Ed-BzquC8wXy7w_-1381034585")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Common information related to all the orders.
    /// </summary>
    [IsoId("_p-h39NE7Ed-BzquC8wXy7w_-1057946997")]
    [DisplayName("Bulk Order Details")]
    [IsoXmlTag("BlkOrdrDtls")]
    public required RedemptionBulkOrder2 BulkOrderDetails { get; init; }

    /// <summary>
    /// The information related to an intermediary.
    /// </summary>
    [IsoId("_p-h39dE7Ed-BzquC8wXy7w_-1159389506")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_p-ro8NE7Ed-BzquC8wXy7w_-667614163")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_p-ro8dE7Ed-BzquC8wXy7w_-684127238")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionBulkOrderV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionBulkOrderV02.
