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

namespace BeneficialStrategies.Iso20022.semt;

/// <summary>
/// This record is an implementation of the semt.001.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a registrar, transfer agent, first intermediary or custodian bank, sends the SecuritiesMessageRejection message to the sender (for example account owner, an investor, an issuer or its authorised agent), to reject a previously received message on which action cannot be taken.
/// The message may also be sent by an executing party, for example, transfer agent to the instructing party, for example, investment manager or its authorised representative to reject a previously received message on which action cannot be taken.
/// Usage
/// The SecuritiesMessageRejection message is used for the following reasons:
/// - the executing party does not recognise the linked reference, so the executing party cannot process the message
/// - the instructing party should not have sent the message.
/// Reasons that a receiver does not expect a message include no SLA in place between the Sender and the Receiver.
/// The sender doesn’t comply with minimum requirements to allow processing at first intermediary level (for example for seev.045, seev.001, seev.031).
/// The SecuritiesMessageRejection message must not be used to reject an instruction message (for example sese.023, seev.004, seev.047, seev.033) that cannot be processed for business reasons, for example, if information is missing in an instruction message or because securities are not available for settlement.
/// The message should be used with the business Application Header.
/// </summary>
[Description(
    @"Scope|An account servicer, for example, a registrar, transfer agent, first intermediary or custodian bank, sends the SecuritiesMessageRejection message to the sender (for example account owner, an investor, an issuer or its authorised agent), to reject a previously received message on which action cannot be taken.|The message may also be sent by an executing party, for example, transfer agent to the instructing party, for example, investment manager or its authorised representative to reject a previously received message on which action cannot be taken.|Usage|The SecuritiesMessageRejection message is used for the following reasons:|- the executing party does not recognise the linked reference, so the executing party cannot process the message|- the instructing party should not have sent the message.|Reasons that a receiver does not expect a message include no SLA in place between the Sender and the Receiver.|The sender doesn’t comply with minimum requirements to allow processing at first intermediary level (for example for seev.045, seev.001, seev.031). |The SecuritiesMessageRejection message must not be used to reject an instruction message (for example sese.023, seev.004, seev.047, seev.033) that cannot be processed for business reasons, for example, if information is missing in an instruction message or because securities are not available for settlement.|The message should be used with the business Application Header."
)]
[IsoId("_wsZu0TWfEe2OzdGcZrUAEQ")]
[DisplayName("Securities Message Rejection V")]
public record SecuritiesMessageRejectionV04 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.001.001.04";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgRjctn";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.001.001.04";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_wsZu2zWfEe2OzdGcZrUAEQ")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference14 RelatedReference { get; init; }

    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_wsZu3TWfEe2OzdGcZrUAEQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectionReason69 Reason { get; init; }
}

// Since SecuritiesMessageRejectionV04Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesMessageRejectionV04.
