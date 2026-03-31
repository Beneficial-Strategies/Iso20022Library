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
/// This record is an implementation of the sese.006.001.08 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferInCancellationRequest message is sent by, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent transfer in instruction.
/// Usage
/// The TransferInCancellationRequest message is used to request the cancellation of one or more transfer in instructions.
/// There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of one or more transfer in instructions, the transfer reference of the transfer, as specified in the original TransferInInstruction message, is specified in the transfer reference element.
/// The message identification of the original TransferOutInstruction message may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a TransferInCancellationRequest is made using an TransferCancellationStatusReport message.
/// </summary>
[Description(
    @"Scope|The TransferInCancellationRequest message is sent by, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent transfer in instruction.|Usage|The TransferInCancellationRequest message is used to request the cancellation of one or more transfer in instructions.|There is no amendment, but a cancellation and re-instruct policy.|To request the cancellation of one or more transfer in instructions, the transfer reference of the transfer, as specified in the original TransferInInstruction message, is specified in the transfer reference element.|The message identification of the original TransferOutInstruction message may also be quoted in PreviousReference but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a TransferInCancellationRequest is made using an TransferCancellationStatusReport message."
)]
[IsoId("_xYYfIYZLEeemXK0UETsSiA")]
[DisplayName("Transfer In Cancellation Request V")]
public record TransferInCancellationRequestV08 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.006.001.08";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInCxlReq";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.006.001.08";

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
    [IsoId("_xYYfI4ZLEeemXK0UETsSiA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_uoh8w4izEeefvMoXmllHqg")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_uoh8xIizEeefvMoXmllHqg")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_uoh8xYizEeefvMoXmllHqg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Function of the transfer-in, that is, whether the message is used as a request to cancel a previously sent instruction or as a cancellation of a previously sent advice and request for information. The absence of Function indicates the message is a request to cancel a previously sent instruction.
    /// </summary>
    [IsoId("_xYYfJ4ZLEeemXK0UETsSiA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    public TransferInFunction1Code? Function { get; init; }

    /// <summary>
    /// Reference of the transfer to be cancelled.
    /// </summary>
    [IsoId("_4WRNYYizEeefvMoXmllHqg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required TransferReference11 References { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_xYYfK4ZLEeemXK0UETsSiA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_xYYfLYZLEeemXK0UETsSiA")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
}

// Since TransferInCancellationRequestV08Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInCancellationRequestV08.
