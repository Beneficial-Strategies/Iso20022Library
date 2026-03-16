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
/// This record is an implementation of the setr.051.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to cancel a previously sent RedemptionOrderConfirmation message.
/// Usage
/// The RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more previously sent redemption order confirmations. The amendment indicator element is used to specify whether the redemption order confirmation cancellation is to be followed by a RedemptionOrderConfirmationAmendment.
/// The RedemptionOrderConfirmationCancellationInstruction message is used to either:
/// - cancel an entire RedemptionOrderConfirmation messae, that is, all the individual order confirmations that it contained, or,
/// - request the cancellation of one or more individual confirmations.
/// There are two ways to use the message.
/// (1) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel an entire message, this can be done by either:
/// - quoting the business references, for example, OrderReference, Deal Reference, of all the individual order confirmations listed in the RedemptionOrderConfirmation message, or,
/// - quoting the details of all the individual order confirmations (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.
/// The message identification of the RedemptionOrderConfirmation message may also be quoted in PreviousReference.
/// It is also possible to instruct the cancellation of an entire confirmation message by quoting its message identification in PreviousReference, but this is not recommended.
/// (2) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more individual order confirmations, this can be done by either:
/// - quoting the business references, for example, OrderReference, Deal Reference, of each individual order confirmation listed in the RedemptionOrderConfirmation message, or,
/// - quoting the details of each individual order execution (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.
/// The message identification of the RedemptionOrderConfirmation message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.
/// The rejection or acceptance of a RedemptionOrderConfirmationCancellationInstruction is made using an OrderConfirmationStatusReport message.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the RedemptionOrderConfirmationCancellationInstruction message to the instructing party, for example, an investment manager or its authorised representative to cancel a previously sent RedemptionOrderConfirmation message.|Usage|The RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more previously sent redemption order confirmations. The amendment indicator element is used to specify whether the redemption order confirmation cancellation is to be followed by a RedemptionOrderConfirmationAmendment.|The RedemptionOrderConfirmationCancellationInstruction message is used to either:|- cancel an entire RedemptionOrderConfirmation messae, that is, all the individual order confirmations that it contained, or,|- request the cancellation of one or more individual confirmations.|There are two ways to use the message.|(1) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel an entire message, this can be done by either:|- quoting the business references, for example, OrderReference, Deal Reference, of all the individual order confirmations listed in the RedemptionOrderConfirmation message, or,|- quoting the details of all the individual order confirmations (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.|The message identification of the RedemptionOrderConfirmation message may also be quoted in PreviousReference.|It is also possible to instruct the cancellation of an entire confirmation message by quoting its message identification in PreviousReference, but this is not recommended.|(2) When the RedemptionOrderConfirmationCancellationInstruction message is used to cancel one or more individual order confirmations, this can be done by either:|- quoting the business references, for example, OrderReference, Deal Reference, of each individual order confirmation listed in the RedemptionOrderConfirmation message, or,|- quoting the details of each individual order execution (this includes the OrderReference and DealReference) listed in RedemptionOrderConfirmation message but this is not recommended.|The message identification of the RedemptionOrderConfirmation message in which the individual order confirmation was conveyed may also be quoted in PreviousReference.|The rejection or acceptance of a RedemptionOrderConfirmationCancellationInstruction is made using an OrderConfirmationStatusReport message."
)]
[IsoId("_t5eDiNE7Ed-BzquC8wXy7w_-947588011")]
[DisplayName("Redemption Order Confirmation Cancellation Instruction V")]
public record RedemptionOrderConfirmationCancellationInstructionV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.051.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrConfCxlInstrV01";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.051.001.01";

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
    [IsoId("_t5eDidE7Ed-BzquC8wXy7w_-2099190872")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_t5eDitE7Ed-BzquC8wXy7w_-2101963887")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_t5eDi9E7Ed-BzquC8wXy7w_-2101960811")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_t5eDjNE7Ed-BzquC8wXy7w_-2101038795")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference3? RelatedReference { get; init; }

    /// <summary>
    /// References of the orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_t5n0gNE7Ed-BzquC8wXy7w_-2016074289")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public InvestmentFundOrderExecution1? CancellationByReference { get; init; }

    /// <summary>
    /// Common information related to all the orders confirmations to be cancelled.
    /// </summary>
    [IsoId("_t5n0gdE7Ed-BzquC8wXy7w_-2017920422")]
    [DisplayName("Cancellation By Order Confirmation Details")]
    [IsoXmlTag("CxlByOrdrConfDtls")]
    public RedemptionOrderConfirmation1? CancellationByOrderConfirmationDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_t5n0gtE7Ed-BzquC8wXy7w_-2100115835")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
}

// Since RedemptionOrderConfirmationCancellationInstructionV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionOrderConfirmationCancellationInstructionV01.
