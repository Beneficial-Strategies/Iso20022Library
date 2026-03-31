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
/// This record is an implementation of the sese.002.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferOutCancellationInstruction message is sent by an instructing party or an instructing party&apos;s designated agent to the executing party.
/// This message is used to request the cancellation of a TransferOutInstruction that was previously sent by the instructing party.
/// Usage
/// The TransferOutCancellationInstruction message is sent by an instructing party to request cancellation of a previously sent TransferOutInstruction.
/// This message must contain the reference of the message to be cancelled. The message may also contain all the details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(
    @"Scope|The TransferOutCancellationInstruction message is sent by an instructing party or an instructing party's designated agent to the executing party.|This message is used to request the cancellation of a TransferOutInstruction that was previously sent by the instructing party.|Usage|The TransferOutCancellationInstruction message is sent by an instructing party to request cancellation of a previously sent TransferOutInstruction.|This message must contain the reference of the message to be cancelled. The message may also contain all the details of the message to be cancelled, but this is not recommended."
)]
[IsoId("_K1LPztE6Ed-BzquC8wXy7w_-1400319754")]
[DisplayName("Transfer Out Cancellation Instruction")]
public record TransferOutCancellationInstruction : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.002.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.002.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.002.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_K1LPz9E6Ed-BzquC8wXy7w_1122541530")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference2 PreviousReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_K1LP0NE6Ed-BzquC8wXy7w_-627107887")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_K1UZsNE6Ed-BzquC8wXy7w_-615102237")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// </summary>
    [IsoId("_K1UZsdE6Ed-BzquC8wXy7w_-1481678373")]
    [DisplayName("Transfer Out To Be Cancelled")]
    [IsoXmlTag("TrfOutToBeCanc")]
    public TransferOut2? TransferOutToBeCancelled { get; init; }
}

// Since TransferOutCancellationInstructionDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferOutCancellationInstruction.
