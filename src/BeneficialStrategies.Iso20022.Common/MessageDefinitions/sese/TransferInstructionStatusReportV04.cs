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
/// This record is an implementation of the sese.011.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the TransferInstructionStatusReport message to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer instruction.
/// Usage
/// The TransferInstructionStatusReport message is used to report on the status of a transfer in or transfer out instruction. The reference of the transfer instruction for which the status is reported is identified in TransferReference.
/// The message identification of the transfer instruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// One of the following statuses can be reported:
/// - an accepted status, or,
/// - an already executed status, or,
/// - a sent to next party status, or,
/// - a matched status, or,
/// - a settled status, or,
/// - a pending settlement status and the reason for the status, or,
/// - an unmatched status and the reason for the status, or,
/// - an in-repair status and the reason for the status, or,
/// - a rejected status and the reason for the status, or,
/// - a failed settlement status and the reason for the status, or,
/// - a cancelled status and the reason for the status, or,
/// - a cancelled status and the reason for the status, or,
/// - a cancellation pending status and the reason for the status.
/// </summary>
[Description(
    @"Scope|An executing party, for example, a transfer agent, sends the TransferInstructionStatusReport message to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer instruction.|Usage|The TransferInstructionStatusReport message is used to report on the status of a transfer in or transfer out instruction. The reference of the transfer instruction for which the status is reported is identified in TransferReference.|The message identification of the transfer instruction message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|One of the following statuses can be reported:|- an accepted status, or,|- an already executed status, or,|- a sent to next party status, or,|- a matched status, or,|- a settled status, or,|- a pending settlement status and the reason for the status, or,|- an unmatched status and the reason for the status, or,|- an in-repair status and the reason for the status, or,|- a rejected status and the reason for the status, or,|- a failed settlement status and the reason for the status, or,|- a cancelled status and the reason for the status, or,|- a cancelled status and the reason for the status, or,|- a cancellation pending status and the reason for the status."
)]
[IsoId("_uh31cRXgEeOocOqSQt5Jbw")]
[DisplayName("Transfer Instruction Status Report V")]
public record TransferInstructionStatusReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.011.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInstrStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.04";

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
    [IsoId("_uh31eRXgEeOocOqSQt5Jbw")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_uh31exXgEeOocOqSQt5Jbw")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference2? CounterpartyReference { get; init; }

    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_iGSV0R6kEeOolf0-cMYhrw")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References40Choice_? Reference { get; init; }

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_uh31gRXgEeOocOqSQt5Jbw")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required TransferStatusAndReason3 StatusReport { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_sRG_gRw9EeOIveEnnb_1-A")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_uh31gxXgEeOocOqSQt5Jbw")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferInstructionStatusReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInstructionStatusReportV04.
