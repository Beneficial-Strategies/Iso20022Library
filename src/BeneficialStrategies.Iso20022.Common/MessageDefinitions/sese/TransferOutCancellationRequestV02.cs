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
/// This record is an implementation of the sese.002.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, eg, an investment manager or its authorised representative, sends the TransferOutCancellationRequest message to the executing party, eg, a transfer agent, to request the cancellation of a previously sent TransferOutInstruction.
/// Usage
/// The TransferOutCancellationRequest message is used to request cancellation of a previously sent TransferOutInstruction. There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferOutInstruction message in which the original transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferOutInstruction message by quoting its message identification in PreviousReference.
/// </summary>
[Description(
    @"Scope|An instructing party, eg, an investment manager or its authorised representative, sends the TransferOutCancellationRequest message to the executing party, eg, a transfer agent, to request the cancellation of a previously sent TransferOutInstruction.|Usage|The TransferOutCancellationRequest message is used to request cancellation of a previously sent TransferOutInstruction. There are two ways to specify the transfer cancellation request. Either:|- the transfer reference of the original transfer is quoted, or,|- all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.|The message identification of the TransferOutInstruction message in which the original transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferOutInstruction message by quoting its message identification in PreviousReference."
)]
[IsoId("_K1UZvtE6Ed-BzquC8wXy7w_-1994475109")]
[DisplayName("Transfer Out Cancellation Request V")]
public record TransferOutCancellationRequestV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.002.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfOutCxlReqV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.002.001.02";

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
    [IsoId("_K1eKsNE6Ed-BzquC8wXy7w_-2090193405")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_K1eKsdE6Ed-BzquC8wXy7w_-1994475091")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference2? PreviousReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K1eKstE6Ed-BzquC8wXy7w_-1994475031")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K1eKs9E6Ed-BzquC8wXy7w_-1994474996")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_K1eKtNE6Ed-BzquC8wXy7w_647125791")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public TransferReference1? CancellationByReference { get; init; }

    /// <summary>
    /// The transfer out request message to cancel.
    /// </summary>
    [IsoId("_K1eKtdE6Ed-BzquC8wXy7w_-1994475073")]
    [DisplayName("Cancellation By Transfer Out Details")]
    [IsoXmlTag("CxlByTrfOutDtls")]
    public TransferOut5? CancellationByTransferOutDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_K1eKttE6Ed-BzquC8wXy7w_-549065046")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
}

// Since TransferOutCancellationRequestV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutCancellationRequestV02.
