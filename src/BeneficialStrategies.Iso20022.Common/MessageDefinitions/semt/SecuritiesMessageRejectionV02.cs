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
/// This record is an implementation of the semt.001.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An account servicer, for example, a registrar, transfer agent or custodian bank, sends the SecuritiesMessageRejection message to the account owner, for example, an investor or its authorised agent, to reject a previously received message on which action cannot be taken.
/// The message may also be sent by an executing party, for example, transfer agent to the instructing party, for example, investment manager or its authorised representative to reject a previously received message on which action cannot be taken.
/// Usage
/// The SecuritiesMessageRejection message is used for the following reasons:
/// - the executing party does not recognise the linked reference, so the executing party cannot process the message
/// - the instructing party should not have sent the message.
/// Reasons that a receiver does not expect a message include no SLA in place between the Sender and the Receiver.
/// The SecuritiesMessageRejection message must not be used to reject an instruction message that cannot be processed for business reasons, for example, if information is missing in an instruction message or because securities are not available for settlement.
/// </summary>
[Description(
    @"Scope|An account servicer, for example, a registrar, transfer agent or custodian bank, sends the SecuritiesMessageRejection message to the account owner, for example, an investor or its authorised agent, to reject a previously received message on which action cannot be taken.|The message may also be sent by an executing party, for example, transfer agent to the instructing party, for example, investment manager or its authorised representative to reject a previously received message on which action cannot be taken.|Usage|The SecuritiesMessageRejection message is used for the following reasons:|- the executing party does not recognise the linked reference, so the executing party cannot process the message|- the instructing party should not have sent the message.|Reasons that a receiver does not expect a message include no SLA in place between the Sender and the Receiver.|The SecuritiesMessageRejection message must not be used to reject an instruction message that cannot be processed for business reasons, for example, if information is missing in an instruction message or because securities are not available for settlement."
)]
[IsoId("_MaWw_NFSEd-BzquC8wXy7w_-365444555")]
[DisplayName("Securities Message Rejection V")]
public record SecuritiesMessageRejectionV02 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "semt.001.001.02";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesMsgRjctnV02";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:semt.001.001.02";

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
    [IsoId("_MaWw_dFSEd-BzquC8wXy7w_2101589408")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_MaWw_tFSEd-BzquC8wXy7w_-365444294")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    public required AdditionalReference3 RelatedReference { get; init; }

    /// <summary>
    /// Reason to reject the message.
    /// </summary>
    [IsoId("_Magh8NFSEd-BzquC8wXy7w_-365444259")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required RejectionReason3 Reason { get; init; }
}

// Since SecuritiesMessageRejectionV02Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesMessageRejectionV02.
