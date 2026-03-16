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
/// This record is an implementation of the setr.014.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the SwitchOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SwitchOrder instruction.
/// Usage
/// The SwitchOrderCancellationRequest is used to cancel the entire previously sent SwitchOrder instruction and all the individual legs that it contains. There is no amendment, but a cancellation and re-instruct policy.
/// There are two ways to specify the switch cancellation. Either:
/// - the order reference of the original switch order is quoted, or,
/// - all the details of the original switch order (this includes the OrderReference) are quoted, but this is not recommended.
/// The message identification of the SwitchOrder message may also be quoted in PreviousReference.
/// It is also possible to request the cancellation of a SwitchOrder message by quoting its message identification in PreviousReference, but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation request.
/// The rejection or acceptance of a SwitchOrderCancellationRequest is made using an OrderCancellationStatusReport message.
/// </summary>
[Description(
    @"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the SwitchOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SwitchOrder instruction.|Usage|The SwitchOrderCancellationRequest is used to cancel the entire previously sent SwitchOrder instruction and all the individual legs that it contains. There is no amendment, but a cancellation and re-instruct policy.|There are two ways to specify the switch cancellation. Either:|- the order reference of the original switch order is quoted, or,|- all the details of the original switch order (this includes the OrderReference) are quoted, but this is not recommended.|The message identification of the SwitchOrder message may also be quoted in PreviousReference.|It is also possible to request the cancellation of a SwitchOrder message by quoting its message identification in PreviousReference, but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation request.|The rejection or acceptance of a SwitchOrderCancellationRequest is made using an OrderCancellationStatusReport message."
)]
[IsoId("_6CayWNE7Ed-BzquC8wXy7w_1787145028")]
[DisplayName("Switch Order Cancellation Request V")]
public record SwitchOrderCancellationRequestV03 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.014.001.03";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrCxlReqV03";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.014.001.03";

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
    [IsoId("_6CayWdE7Ed-BzquC8wXy7w_264063025")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_6CayWtE7Ed-BzquC8wXy7w_1787145131")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_6Cj8QNE7Ed-BzquC8wXy7w_1787145191")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; }

    /// <summary>
    /// References of the switch orders to be cancelled.
    /// </summary>
    [IsoId("_6Cj8QdE7Ed-BzquC8wXy7w_1302905087")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public InvestmentFundOrder1? CancellationByReference { get; init; }

    /// <summary>
    /// Common information related to all the switch orders to be cancelled.
    /// </summary>
    [IsoId("_6Cj8QtE7Ed-BzquC8wXy7w_1787145055")]
    [DisplayName("Cancellation By Order Details")]
    [IsoXmlTag("CxlByOrdrDtls")]
    public SwitchOrderInstruction2? CancellationByOrderDetails { get; init; }

    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_6Cj8Q9E7Ed-BzquC8wXy7w_-925024126")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; }
}

// Since SwitchOrderCancellationRequestV03Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderCancellationRequestV03.
