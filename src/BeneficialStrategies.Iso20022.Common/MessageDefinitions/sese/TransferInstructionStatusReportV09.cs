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
/// This record is an implementation of the sese.011.001.09 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction.
///  It may also be used to report the status of an event related to the asset being transferred or provide additional information.
/// The TransferInstructionStatusReport message may also be sent by any party in the transfer transaction to another party in the transfer transaction chain to provide information relevant for the settlement of a transfer transaction.
/// Usage
/// The TransferInstructionStatusReport message is used to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction, or in response to a RequestForTransferStatus message. It may also be used to report the status of an event related to the asset being transferred or provide additional information.
/// </summary>
[Description(
    @"Scope|The TransferInstructionStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction.| It may also be used to report the status of an event related to the asset being transferred or provide additional information.|The TransferInstructionStatusReport message may also be sent by any party in the transfer transaction to another party in the transfer transaction chain to provide information relevant for the settlement of a transfer transaction. |Usage|The TransferInstructionStatusReport message is used to provide the status of a previously received request for holdings information, portfolio transfer or transfer instruction, or in response to a RequestForTransferStatus message. It may also be used to report the status of an event related to the asset being transferred or provide additional information."
)]
[IsoId("_NesJgdx9EeqKxsvOxFQHKA")]
[DisplayName("Transfer Instruction Status Report V")]
public record TransferInstructionStatusReportV09 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.011.001.09";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfInstrStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.011.001.09";

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
    [IsoId("_NesJi9x9EeqKxsvOxFQHKA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_NesJjdx9EeqKxsvOxFQHKA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference10? CounterpartyReference { get; init; }

    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_NesJj9x9EeqKxsvOxFQHKA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References64Choice_? Reference { get; init; }

    /// <summary>
    /// Status of the transfer instruction.
    /// </summary>
    [IsoId("_NesJkdx9EeqKxsvOxFQHKA")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required TransferStatusAndReason8 StatusReport { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_NesJk9x9EeqKxsvOxFQHKA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_NesJldx9EeqKxsvOxFQHKA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferInstructionStatusReportV09Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferInstructionStatusReportV09.
