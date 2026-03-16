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
/// This record is an implementation of the sese.008.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, eg, a transfer agent, sends the ReversalOfTransferInConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to cancel a previously sent TransferInConfirmation message.
/// Usage
/// The ReversalOfTransferInConfirmation message is used to reverse a previously sent TransferInConfirmation.
/// There are two ways to specify the reversal of the transfer in confirmation. Either:
/// - the business references, eg, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,
/// - all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.
/// The message identification of the TransferInConfirmation message in which the transfer confirmation was conveyed may also be quoted in PreviousReference.
/// The message reference (MessageIdentification) of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// It is also possible to request a reversal of a TransferInConfirmation by quoting its message reference (MessageIdentification) in PreviousReference.
/// </summary>
[Description(
    @"Scope|An executing party, eg, a transfer agent, sends the ReversalOfTransferInConfirmation message to the instructing party, eg, an investment manager or its authorised representative, to cancel a previously sent TransferInConfirmation message.|Usage|The ReversalOfTransferInConfirmation message is used to reverse a previously sent TransferInConfirmation.|There are two ways to specify the reversal of the transfer in confirmation. Either:|- the business references, eg, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,|- all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.|The message identification of the TransferInConfirmation message in which the transfer confirmation was conveyed may also be quoted in PreviousReference.|The message reference (MessageIdentification) of the TransferInInstruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|It is also possible to request a reversal of a TransferInConfirmation by quoting its message reference (MessageIdentification) in PreviousReference."
)]
[IsoId("_pHChMNE5Ed-BzquC8wXy7w_-604499550")]
[DisplayName("Reversal Of Transfer In Confirmation V")]
public record ReversalOfTransferInConfirmationV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.008.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfInConfV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.008.001.02";

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
    [IsoId("_pHChMdE5Ed-BzquC8wXy7w_600695807")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_pHChMtE5Ed-BzquC8wXy7w_-604499531")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_pHChM9E5Ed-BzquC8wXy7w_-604499189")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_pHChNNE5Ed-BzquC8wXy7w_-604499479")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Reference of the transfer in confirmation to be reversed.
    /// </summary>
    [IsoId("_pHChNdE5Ed-BzquC8wXy7w_-191780069")]
    [DisplayName("Reversal By Reference")]
    [IsoXmlTag("RvslByRef")]
    public TransferReference2? ReversalByReference { get; init; }

    /// <summary>
    /// Copy of the transfer in confirmation to reverse.
    /// </summary>
    [IsoId("_pHChNtE5Ed-BzquC8wXy7w_-604499497")]
    [DisplayName("Reversal By Transfer In Confirmation Details")]
    [IsoXmlTag("RvslByTrfInConfDtls")]
    public TransferIn4? ReversalByTransferInConfirmationDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_pHChN9E5Ed-BzquC8wXy7w_739904383")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
}

// Since ReversalOfTransferInConfirmationV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferInConfirmationV02.
