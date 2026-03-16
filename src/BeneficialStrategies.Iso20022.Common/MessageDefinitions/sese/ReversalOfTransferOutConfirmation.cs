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
/// This record is an implementation of the sese.004.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ReversalOfTransferOutConfirmation message is sent by an executing party to the instructing party or the instructing party&apos;s designated agent. This message is used to reverse a TransferOutConfirmation that was previously sent by the instructing party.
/// Usage
/// The ReversalOfTransferOutConfirmation message is sent by an executing party to reverse a previously sent TransferOutConfirmation.
/// This message must contain the reference of the message to be reversed. The message may also contain all the details of the reversed message, but this is not recommended.
/// </summary>
[Description(
    @"Scope|The ReversalOfTransferOutConfirmation message is sent by an executing party to the instructing party or the instructing party's designated agent. This message is used to reverse a TransferOutConfirmation that was previously sent by the instructing party.|Usage|The ReversalOfTransferOutConfirmation message is sent by an executing party to reverse a previously sent TransferOutConfirmation.|This message must contain the reference of the message to be reversed. The message may also contain all the details of the reversed message, but this is not recommended."
)]
[IsoId("_pokg9tE5Ed-BzquC8wXy7w_938886633")]
[DisplayName("Reversal Of Transfer Out Confirmation")]
public record ReversalOfTransferOutConfirmation : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "sese.004.001.01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.01";

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
    [IsoId("_pokg99E5Ed-BzquC8wXy7w_-910378416")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference2 PreviousReference { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_pokg-NE5Ed-BzquC8wXy7w_233612787")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference2? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_pokg-dE5Ed-BzquC8wXy7w_-541223381")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference2? RelatedReference { get; init; }

    /// <summary>
    /// Copy of the transfer out confirmation to reverse.
    /// </summary>
    [IsoId("_pokg-tE5Ed-BzquC8wXy7w_1772260838")]
    [DisplayName("Transfer Out Confirmation To Be Reversed")]
    [IsoXmlTag("TrfOutConfToBeRvsd")]
    public TransferOut1? TransferOutConfirmationToBeReversed { get; init; }
}

// Since ReversalOfTransferOutConfirmationDocument is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferOutConfirmation.
