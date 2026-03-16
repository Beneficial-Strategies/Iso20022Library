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
/// This record is an implementation of the setr.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionOrder message to the executing party, for example, a transfer agent, to instruct the redemption of one or more financial instruments for one investment fund account.
/// Usage
/// The RedemptionOrder message is used to instruct single redemption orders, that is, a message containing one order for one financial instrument and related to one investment account. The RedemptionOrder message may also be used for multiple orders, that is, a message containing several orders related to the same investment account for different financial instruments.
/// For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.
/// If there are redemption orders for the same financial instrument but for different accounts, then the RedemptionBulkOrder message must be used.
/// </summary>
[Description(
    @"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionOrder message to the executing party, for example, a transfer agent, to instruct the redemption of one or more financial instruments for one investment fund account.|Usage|The RedemptionOrder message is used to instruct single redemption orders, that is, a message containing one order for one financial instrument and related to one investment account. The RedemptionOrder message may also be used for multiple orders, that is, a message containing several orders related to the same investment account for different financial instruments.|For a single redemption order, the RedemptionOrder message, not the RedemptionBulkOrder message, must be used.|If there are redemption orders for the same financial instrument but for different accounts, then the RedemptionBulkOrder message must be used."
)]
[IsoId("_vhoUKNE7Ed-BzquC8wXy7w_2081067888")]
[DisplayName("Redemption Order V")]
public record RedemptionOrderV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.004.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrV03";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.004.001.03";

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
    [IsoId("_vhoUKdE7Ed-BzquC8wXy7w_-1426904851")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_vhoUKtE7Ed-BzquC8wXy7w_-1796466923")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_vhxeENE7Ed-BzquC8wXy7w_-1793698233")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_vhxeEdE7Ed-BzquC8wXy7w_576058002")]
    [DisplayName("Multiple Order Details")]
    [IsoXmlTag("MltplOrdrDtls")]
    public required RedemptionMultipleOrder4 MultipleOrderDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_vhxeEtE7Ed-BzquC8wXy7w_-1567433633")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_vhxeE9E7Ed-BzquC8wXy7w_-1565586255")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_vhxeFNE7Ed-BzquC8wXy7w_-1557274391")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RedemptionOrderV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionOrderV03.
