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

namespace BeneficialStrategies.Iso20022.sese;

/// <summary>
/// This record is an implementation of the sese.004.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReversalOfTransferOutConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer out confirmation.
/// Usage
/// The ReversalOfTransferOutConfirmation message is used to reverse a previously sent transfer out confirmation.
/// To request the reversal of a transfer out confirmation, the transfer reference of the transfer out instruction, as specified in the original TransferOutInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.
/// The message identification of the original TransferOutConfirmation message may also be quoted in PreviousReference but this is not recommended.
/// </summary>
[Description(
    @"Scope|The ReversalOfTransferOutConfirmation message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer out confirmation.|Usage|The ReversalOfTransferOutConfirmation message is used to reverse a previously sent transfer out confirmation.|To request the reversal of a transfer out confirmation, the transfer reference of the transfer out instruction, as specified in the original TransferOutInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.|The message identification of the original TransferOutConfirmation message may also be quoted in PreviousReference but this is not recommended."
)]
[IsoId("_TKCqsZDhEem7fvtoGpNpow")]
[DisplayName("Reversal Of Transfer Out Confirmation V")]
public record ReversalOfTransferOutConfirmationV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfOutConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.09";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_TKCqs5DhEem7fvtoGpNpow")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_TKCqtZDhEem7fvtoGpNpow")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference11? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_TKCqt5DhEem7fvtoGpNpow")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference10? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_TKCquZDhEem7fvtoGpNpow")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference10? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_yFMdwZGxEem-9Y6mq5ZH3Q")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_TKCqu5DhEem7fvtoGpNpow")]
    [DisplayName("Reversal References")]
    [IsoXmlTag("RvslRefs")]
    public required TransferReference16 ReversalReferences { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_TKCqvZDhEem7fvtoGpNpow")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_TKCqv5DhEem7fvtoGpNpow")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation5? CopyDetails { get; init; }
}

// Since ReversalOfTransferOutConfirmationV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferOutConfirmationV09.
