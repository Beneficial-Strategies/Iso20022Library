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
/// This record is an implementation of the sese.006.001.07 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, a transfer agent, sends the TransferInCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.
/// Usage
/// The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.
/// There are two ways to specify the transfer cancellation request. Either:
/// - the transfer reference of the original transfer is quoted, or,
/// - all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.
/// The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference.
/// </summary>
[Description(
    @"Scope|An instructing party, for example, a transfer agent, sends the TransferInCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent TransferInInstruction.|Usage|The TransferInCancellationRequest message is used to request cancellation of a previously sent TransferInInstruction.|There are two ways to specify the transfer cancellation request. Either:|- the transfer reference of the original transfer is quoted, or,|- all the details of the original transfer (this includes TransferReference) are quoted but this is not recommended.|The message identification of the TransferInInstruction message in which the transfer was conveyed may also be quoted in PreviousReference. It is also possible to request the cancellation of a TransferInInstruction message by quoting its message identification in PreviousReference."
)]
[IsoId("_5T5PER8NEeWpZde3LQh6dg")]
[DisplayName("Transfer In Cancellation Request V")]
public record TransferInCancellationRequestV07 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.006.001.07";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.07";

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
    [IsoId("_5T5PEx8NEeWpZde3LQh6dg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
    /// </summary>
    [IsoId("_5T5PFR8NEeWpZde3LQh6dg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public References20? References { get; init; }

    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a request to cancel a previously sent instruction or as a cancellation of a previously sent advice and request for information. The absence of Function indicates the message is a request to cancel a previously sent instruction.
    /// </summary>
    [IsoId("_TCU4oSVPEeWI0orciOKunQ")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public TransferInFunction1Code? Function { get; init; }

    /// <summary>
    /// Choice between cancellation by reference or by transfer details.
    /// </summary>
    [IsoId("_5T5PFx8NEeWpZde3LQh6dg")]
    [DisplayName("Cancellation")]
    [IsoXmlTag("Cxl")]
    public required Cancellation10Choice_ Cancellation { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_5T5PGR8NEeWpZde3LQh6dg")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_5T5PGx8NEeWpZde3LQh6dg")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
}

// Since TransferInCancellationRequestV07Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInCancellationRequestV07.
