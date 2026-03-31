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
/// This record is an implementation of the setr.055.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SwitchOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SwitchOrderConfirmation.
/// Usage
/// To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SwitchOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SwitchOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the switch order confirmation cancellation is to be followed by an amendment An amendment of a switch order confirmation is carried out by sending a SwitchOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’.
/// </summary>
[Description(
    @"Scope|The SwitchOrderConfirmationCancellationInstruction message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or its authorised representative, to cancel a previously sent SwitchOrderConfirmation.|Usage|To request the cancellation of one or more individual order executions, the order reference and deal reference of each individual order execution in the original SwitchOrderConfirmation are specified in the order reference and deal reference elements respectively. The message identification of the SwitchOrderConfirmation message in which the individual order execution was conveyed may also be quoted in PreviousReference but this is not recommended. The AmendmentIndicator is used to specify whether the switch order confirmation cancellation is to be followed by an amendment An amendment of a switch order confirmation is carried out by sending a SwitchOrderConfirmation message in which the AmendmentIndicator contains the value ‘true’."
)]
[IsoId("_Aab8CzbLEead9bDRE_1DAQ")]
[DisplayName("Switch Order Confirmation Cancellation Instruction V")]
public record SwitchOrderConfirmationCancellationInstructionV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.055.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrConfCxlInstr";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.055.001.02";

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
    [IsoId("_Aab8ETbLEead9bDRE_1DAQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_Aab8EzbLEead9bDRE_1DAQ")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference9? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab8FTbLEead9bDRE_1DAQ")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference8? PreviousReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_Aab8FzbLEead9bDRE_1DAQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public AdditionalReference8? RelatedReference { get; init; }

    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_8YrRs1AZEea5nPE5ezGuuw")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmendmentIndicator { get; init; }

    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_8YrRtFAZEea5nPE5ezGuuw")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification of the individual order confirmation to be cancelled.
    /// </summary>
    [IsoId("_8YrRtVAZEea5nPE5ezGuuw")]
    [DisplayName("Order References")]
    [IsoXmlTag("OrdrRefs")]
    public required InvestmentFundOrder11 OrderReferences { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab8HTbLEead9bDRE_1DAQ")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation4? CopyDetails { get; init; }
}

// Since SwitchOrderConfirmationCancellationInstructionV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderConfirmationCancellationInstructionV02.
