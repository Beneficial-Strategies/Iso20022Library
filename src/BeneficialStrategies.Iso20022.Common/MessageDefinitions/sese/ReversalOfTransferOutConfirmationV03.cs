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
/// This record is an implementation of the sese.004.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the ReversalOfTransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent TransferOutConfirmation message.
/// Usage
/// The ReversalOfTransferOutConfirmation message is used to reverse a previously sent TransferOutConfirmation.
/// There are two ways to specify the reversal of the transfer out confirmation. Either:
/// - the business references, for example, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,
/// - all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.
/// The message identification of the TransferOutConfirmation message in which the transfer out confirmation was conveyed may also be quoted in PreviousReference. The message identification of the TransferOutInstruction message in which the transfer out instruction was conveyed may also be quoted in RelatedReference.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the ReversalOfTransferOutConfirmation message to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent TransferOutConfirmation message.|Usage|The ReversalOfTransferOutConfirmation message is used to reverse a previously sent TransferOutConfirmation.|There are two ways to specify the reversal of the transfer out confirmation. Either:|- the business references, for example, TransferReference, TransferConfirmationIdentification, of the transfer confirmation are quoted, or,|- all the details of the transfer confirmation (this includes TransferReference and TransferConfirmationIdentification) are quoted but this is not recommended.|The message identification of the TransferOutConfirmation message in which the transfer out confirmation was conveyed may also be quoted in PreviousReference. The message identification of the TransferOutInstruction message in which the transfer out instruction was conveyed may also be quoted in RelatedReference."
)]
[IsoId("_0JtHAfpbEeCPwaG9zjUPNQ")]
[DisplayName("Reversal Of Transfer Out Confirmation V")]
public record ReversalOfTransferOutConfirmationV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.004.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RvslOfTrfOutConf";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.004.001.03";

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
    [IsoId("_0JtHDfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to the transaction identifier issued by the counterparty. Building block may also be used to reference a previous transaction, or tie a set of messages together.
    /// </summary>
    [IsoId("_m7A0v_r2EeCJc7cZxzE2fg")]
    [DisplayName("References")]
    [IsoXmlTag("Refs")]
    public required References11 References { get; init; }

    /// <summary>
    /// Reference of the transfer out confirmation to be reversed.
    /// </summary>
    [IsoId("_0JtHHfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Reversal By Reference")]
    [IsoXmlTag("RvslByRef")]
    public TransferReference2? ReversalByReference { get; init; }

    /// <summary>
    /// Copy of the transfer out confirmation to reverse.
    /// </summary>
    [IsoId("_0JtHIfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Reversal By Transfer Out Confirmation Details")]
    [IsoXmlTag("RvslByTrfOutConfDtls")]
    public TransferOut8? ReversalByTransferOutConfirmationDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_0JtHJfpbEeCPwaG9zjUPNQ")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
}

// Since ReversalOfTransferOutConfirmationV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ReversalOfTransferOutConfirmationV03.
