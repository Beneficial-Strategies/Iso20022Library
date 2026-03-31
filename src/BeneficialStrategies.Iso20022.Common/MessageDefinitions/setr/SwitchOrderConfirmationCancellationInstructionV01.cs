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
/// This record is an implementation of the setr.055.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the SwitchOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SwitchOrderConfirmation message.
/// Usage
/// The SwitchOrderConfirmationCancellationInstruction message is used to cancel a previously sent SwitchOrderConfirmation.
/// The amendment indicator element is used to specify whether the switch order confirmation cancellation is to be followed by a switch order confirmation amendment.
/// There are two ways to specify the switch order confirmation cancellation. Either:
/// - the business references, for example, OrderReference, DealReference, of the switch order confirmation are quoted, or,
/// - all the details of the switch order confirmation (this includes the OrderReference and DealReference) are quoted, but this is not recommended.
/// The message identification of the SwitchOrderConfirmation message may also be quoted in PreviousReference.
/// It is also possible to instruct the cancellation of the confirmation message by quoting its message identification in PreviousReference, but this is not recommended.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the SwitchOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to amend a previously sent SwitchOrderConfirmation message.|Usage|The SwitchOrderConfirmationCancellationInstruction message is used to cancel a previously sent SwitchOrderConfirmation.|The amendment indicator element is used to specify whether the switch order confirmation cancellation is to be followed by a switch order confirmation amendment.|There are two ways to specify the switch order confirmation cancellation. Either:|- the business references, for example, OrderReference, DealReference, of the switch order confirmation are quoted, or,|- all the details of the switch order confirmation (this includes the OrderReference and DealReference) are quoted, but this is not recommended.|The message identification of the SwitchOrderConfirmation message may also be quoted in PreviousReference.|It is also possible to instruct the cancellation of the confirmation message by quoting its message identification in PreviousReference, but this is not recommended."
)]
[IsoId("_64NK2NE7Ed-BzquC8wXy7w_1641853769")]
[DisplayName("Switch Order Confirmation Cancellation Instruction V")]
public record SwitchOrderConfirmationCancellationInstructionV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.055.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConfCxlInstrV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.055.001.01";

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
    [IsoId("_64NK2dE7Ed-BzquC8wXy7w_2085142778")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_64W70NE7Ed-BzquC8wXy7w_1790539569")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_64W70dE7Ed-BzquC8wXy7w_1790540438")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_64W70tE7Ed-BzquC8wXy7w_1790541008")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// References of the switch orders to be cancelled.
    /// </summary>
    [IsoId("_64W709E7Ed-BzquC8wXy7w_2085142734")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public InvestmentFundOrderExecution1? CancellationByReference { get; init; }

    /// <summary>
    /// Common information related to all the switch orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_64W71NE7Ed-BzquC8wXy7w_2077756022")]
    [DisplayName("Cancellation By Order Confirmation Details")]
    [IsoXmlTag("CxlByOrdrConfDtls")]
    public SwitchOrderConfirmation1? CancellationByOrderConfirmationDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_64W71dE7Ed-BzquC8wXy7w_1791462023")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
}

// Since SwitchOrderConfirmationCancellationInstructionV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderConfirmationCancellationInstructionV01.
