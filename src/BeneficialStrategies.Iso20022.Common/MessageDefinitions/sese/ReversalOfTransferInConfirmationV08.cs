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
/// This record is an implementation of the sese.008.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReversalOfTransferInConfirmation message is sent by the executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.
/// Usage
/// The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.
/// To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.
/// The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended.
/// </summary>
[Description(
    @"Scope|The ReversalOfTransferInConfirmation message is sent by the executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent transfer in confirmation.|Usage|The ReversalOfTransferInConfirmation message is used to reverse a previously sent transfer in confirmation.|To request the reversal of a transfer in confirmation, the transfer reference of the transfer in instruction, as specified in the original TransferInInstruction message, is specified in the transfer reference element. The executing party’s reference for the execution of the transfer may also be specified in the TransferConfirmationReference element.|The message identification of the original TransferInConfirmation message may also be quoted in PreviousReference but this is not recommended."
)]
[IsoId("_2G_jUYZLEeemXK0UETsSiA")]
[DisplayName("Reversal Of Transfer In Confirmation V")]
public record ReversalOfTransferInConfirmationV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.008.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfInConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.008.001.08";

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
    [IsoId("_2G_jVYZLEeemXK0UETsSiA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_m_nYs4i1EeefvMoXmllHqg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_m_nYtIi1EeefvMoXmllHqg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_m_n_wIi1EeefvMoXmllHqg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_yjJGQYi1EeefvMoXmllHqg")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a reversal of a previously sent confirmation or as a reversal of a previously sent advice. The absence of Function indicates the message is a reversal of a previously sent confirmation.
    /// </summary>
    [IsoId("_2G_jWYZLEeemXK0UETsSiA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public TransferInFunction2Code? Function { get; init; }

    /// <summary>
    /// Reference of the transfer confirmation to be reversed.
    /// </summary>
    [IsoId("_wTn6sYi1EeefvMoXmllHqg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public required TransferReference12 Reference { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_2G_jXYZLEeemXK0UETsSiA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_2G_jX4ZLEeemXK0UETsSiA")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
}

// Since ReversalOfTransferInConfirmationV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferInConfirmationV08.
