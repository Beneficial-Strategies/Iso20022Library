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
/// This record is an implementation of the sese.010.001.06 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The TransferCancellationStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer cancellation instruction.
/// Usage
/// The TransferCancellationStatusReport message is used to report on the status of a transfer in or transfer out cancellation request.
/// The reference of the transfer instruction for which the cancellation status is reported is identified in TransferReference. The message identification of the transfer cancellation request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// The message identification of the transfer instruction request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.
/// One of the following statuses can be reported:
/// - the transfer cancellation is accepted, or,
/// - the transfer cancellation has been sent to the next party, or,
/// - the transfer cancellation is complete and the reason for the status,
/// - the transfer cancellation pending and the reason for the status,
/// - the transfer cancellation is rejected and the reason for the status.
/// </summary>
[Description(
    @"Scope|The TransferCancellationStatusReport message is sent by an executing party, for example, a transfer agent, to the instructing party, for example, an investment manager or one of its authorised representatives to provide the status of a previously received transfer cancellation instruction.|Usage|The TransferCancellationStatusReport message is used to report on the status of a transfer in or transfer out cancellation request.|The reference of the transfer instruction for which the cancellation status is reported is identified in TransferReference. The message identification of the transfer cancellation request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|The message identification of the transfer instruction request message in which the transfer instruction was conveyed may also be quoted in RelatedReference.|One of the following statuses can be reported:|- the transfer cancellation is accepted, or,|- the transfer cancellation has been sent to the next party, or,|- the transfer cancellation is complete and the reason for the status,|- the transfer cancellation pending and the reason for the status,|- the transfer cancellation is rejected and the reason for the status."
)]
[IsoId("_XJ91AYZMEeemXK0UETsSiA")]
[DisplayName("Transfer Cancellation Status Report V")]
public record TransferCancellationStatusReportV06 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "sese.010.001.06";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrfCxlStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:sese.010.001.06";

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
    [IsoId("_XJ91B4ZMEeemXK0UETsSiA")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transfer allocated by the counterparty.
    /// </summary>
    [IsoId("_XJ91CYZMEeemXK0UETsSiA")]
    [DisplayName("Counterparty Reference")]
    [IsoXmlTag("CtrPtyRef")]
    public AdditionalReference8? CounterpartyReference { get; init; }

    /// <summary>
    /// Reference to the message or communication that was previously received.
    /// </summary>
    [IsoId("_XJ91C4ZMEeemXK0UETsSiA")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public References61Choice_? Reference { get; init; }

    /// <summary>
    /// Status of the transfer cancellation instruction.
    /// </summary>
    [IsoId("_XJ91DYZMEeemXK0UETsSiA")]
    [DisplayName("Status Report")]
    [IsoXmlTag("StsRpt")]
    public required CancellationStatusAndReason4 StatusReport { get; init; }

    /// <summary>
    /// Identifies the market practice to which the message conforms.
    /// </summary>
    [IsoId("_XJ91D4ZMEeemXK0UETsSiA")]
    [DisplayName("Market Practice Version")]
    [IsoXmlTag("MktPrctcVrsn")]
    public MarketPracticeVersion1? MarketPracticeVersion { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_XJ91EYZMEeemXK0UETsSiA")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since TransferCancellationStatusReportV06Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TransferCancellationStatusReportV06.
