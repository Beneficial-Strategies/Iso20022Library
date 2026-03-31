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
/// This record is an implementation of the setr.018.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The RequestForOrderStatusReport message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the status of one or more order instructions or order cancellation requests.
/// Usage
/// The RequestForOrderStatusReport message is used to request the status of:
/// - one or several individual order instructions, or,
/// - one or several order messages, or
/// - one or several individual order cancellation requests, or,
/// - one or several order cancellation request messages.
/// The response to a RequestForOrderStatusReport message is the OrderInstructionStatusReport message or OrderCancellationStatusReport message.
/// If the RequestForOrderStatusReport message is used to request the status of several individual order instructions or one or more order instruction messages, then the instructing party may receive several OrderInstructionStatusReport messages from the executing party.
/// If the RequestForOrderStatusReport message is used to request the status of several individual order cancellation requests or one or more order cancellation messages, then the instructing party may receive several OrderCancellationStatusReport messages from the executing party.
/// When the RequestForOrderStatusReport is used to request the status of one or more individual orders or order cancellations, each individual order is identified with its order reference. The investment account and/or financial instrument related to the order can also be identified. The message identification of the message in which the individual order was conveyed may also be quoted in PreviousReference.
/// When the RequestForOrderStatusReport is used to request the status of an order message or an order cancellations request message, then the message identification of the order or cancellation message is identified in PreviousReference.
/// The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument.
/// </summary>
[Description(
    @"Scope|The RequestForOrderStatusReport message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the status of one or more order instructions or order cancellation requests.|Usage|The RequestForOrderStatusReport message is used to request the status of:|- one or several individual order instructions, or,|- one or several order messages, or|- one or several individual order cancellation requests, or,|- one or several order cancellation request messages.|The response to a RequestForOrderStatusReport message is the OrderInstructionStatusReport message or OrderCancellationStatusReport message.|If the RequestForOrderStatusReport message is used to request the status of several individual order instructions or one or more order instruction messages, then the instructing party may receive several OrderInstructionStatusReport messages from the executing party.|If the RequestForOrderStatusReport message is used to request the status of several individual order cancellation requests or one or more order cancellation messages, then the instructing party may receive several OrderCancellationStatusReport messages from the executing party.|When the RequestForOrderStatusReport is used to request the status of one or more individual orders or order cancellations, each individual order is identified with its order reference. The investment account and/or financial instrument related to the order can also be identified. The message identification of the message in which the individual order was conveyed may also be quoted in PreviousReference.|When the RequestForOrderStatusReport is used to request the status of an order message or an order cancellations request message, then the message identification of the order or cancellation message is identified in PreviousReference.|The RequestForOrderStatusReport message may not be used to request the status of an investment account, a transfer or the status of a financial instrument."
)]
[IsoId("_Aab7UzbLEead9bDRE_1DAQ")]
[DisplayName("Request For Order Status Report V")]
public record RequestForOrderStatusReportV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.018.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "ReqForOrdrStsRpt";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.018.001.04";

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
    [IsoId("_Aab7VTbLEead9bDRE_1DAQ")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Information to identify the order(s) for which the status is requested.
    /// </summary>
    [IsoId("_Aab7VzbLEead9bDRE_1DAQ")]
    [DisplayName("Request Details")]
    [IsoXmlTag("ReqDtls")]
    public required MessageAndBusinessReference10 RequestDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Aab7WTbLEead9bDRE_1DAQ")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}

// Since RequestForOrderStatusReportV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RequestForOrderStatusReportV04.
