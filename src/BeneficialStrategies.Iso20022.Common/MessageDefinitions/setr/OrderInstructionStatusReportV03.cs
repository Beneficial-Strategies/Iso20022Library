// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;



namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.016.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the OrderInstructionStatusReport to the instructing party, for example, an investment manager or its authorised representative to report the status of an order from the time the executing party receives the order until the time the order is executed.
/// Usage
/// The OrderInstructionStatusReport message is used to report on the status of a subscription, redemption or a switch order.
/// The OrderInstructionStatusReport message may be used to give the status of:
/// - one order message by using OrderDetailsReport or,
/// - one or more individual order instructions by using IndividualOrderDetailsReport, or
/// - one or more switch orders by using SwitchOrderDetailsReport.
/// If the OrderInstructionStatusReport message is used to report the status of an individual order, then IndividualOrderDetailsReport is used and the order reference of the individual order is quoted in OrderReference. The message identification of the message in which the individual order was conveyed may also be quoted in RelatedReference.
/// If the OrderInstructionStatusReport message is used to report the status of a switch order, then SwitchOrderDetailsReport is used and the order reference of the switch order is quoted in OrderReference. The message identification of the message in which the switch order was conveyed may also be quoted in RelatedReference.
/// If the OrderInstructionStatusReport message is used to report the status of an entire order message, for example, the SubscriptionBulkOrder, or a SubscriptionOrder containing several orders, then OrderDetailsReport is used and the message identification of the order message is quoted in RelatedReference. All the orders within the message must have the same status.
/// One of the following statuses can be reported:
/// - an accepted status, or,
/// - an already executed status, or,
/// - a sent to next party status, or,
/// - a received status, or,
/// - a settled status, or,
/// - a communication problem with next party status, or,
/// - a confirmation amendment status, or,
/// - a done for the day status, or,
/// - a partially done status, or,
/// - an open status, or,
/// - a cancelled status, or
/// - a conditionally accepted status, or,
/// - a rejected status, or,
/// - a suspended status, or,
/// - a partially settled status, or,
/// - an in-repair status (only for an individual or switch order).
/// For a switch order, the OrderInstructionStatusReport message provides the status of the whole switch order, that is, it is not possible to accept one leg and to reject the other leg: the entire switch order has to be rejected. In order to identify the legs within the switch that are causing the problem, the leg is identified in either the RedemptionLegIdentification or SubscriptionLegIdentification elements.
/// When the OrderInstructionStatusReport is used to give the status of an individual or a switch order, the following can be specified:
/// - repaired conditions (for a switch, this is at the level of a leg),
/// - information related to the order, for example, settlement amount, number of units, expected trade date, etc.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the OrderInstructionStatusReport to the instructing party, for example, an investment manager or its authorised representative to report the status of an order from the time the executing party receives the order until the time the order is executed.|Usage|The OrderInstructionStatusReport message is used to report on the status of a subscription, redemption or a switch order.|The OrderInstructionStatusReport message may be used to give the status of:|- one order message by using OrderDetailsReport or,|- one or more individual order instructions by using IndividualOrderDetailsReport, or|- one or more switch orders by using SwitchOrderDetailsReport.|If the OrderInstructionStatusReport message is used to report the status of an individual order, then IndividualOrderDetailsReport is used and the order reference of the individual order is quoted in OrderReference. The message identification of the message in which the individual order was conveyed may also be quoted in RelatedReference.|If the OrderInstructionStatusReport message is used to report the status of a switch order, then SwitchOrderDetailsReport is used and the order reference of the switch order is quoted in OrderReference. The message identification of the message in which the switch order was conveyed may also be quoted in RelatedReference.|If the OrderInstructionStatusReport message is used to report the status of an entire order message, for example, the SubscriptionBulkOrder, or a SubscriptionOrder containing several orders, then OrderDetailsReport is used and the message identification of the order message is quoted in RelatedReference. All the orders within the message must have the same status.|One of the following statuses can be reported:|- an accepted status, or,|- an already executed status, or,|- a sent to next party status, or,|- a received status, or,|- a settled status, or,|- a communication problem with next party status, or,|- a confirmation amendment status, or,|- a done for the day status, or,|- a partially done status, or,|- an open status, or,|- a cancelled status, or|- a conditionally accepted status, or,|- a rejected status, or,|- a suspended status, or,|- a partially settled status, or,|- an in-repair status (only for an individual or switch order).|For a switch order, the OrderInstructionStatusReport message provides the status of the whole switch order, that is, it is not possible to accept one leg and to reject the other leg: the entire switch order has to be rejected. In order to identify the legs within the switch that are causing the problem, the leg is identified in either the RedemptionLegIdentification or SubscriptionLegIdentification elements.|When the OrderInstructionStatusReport is used to give the status of an individual or a switch order, the following can be specified:|- repaired conditions (for a switch, this is at the level of a leg),|- information related to the order, for example, settlement amount, number of units, expected trade date, etc.")]
[IsoId("_jk5cZdE7Ed-BzquC8wXy7w_-141988055")]
[DisplayName("Order Instruction Status Report V")]
public partial record OrderInstructionStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.016.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrInstrStsRptV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.016.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_jk5cZtE7Ed-BzquC8wXy7w_387710946")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_jk5cZ9E7Ed-BzquC8wXy7w_-1984080310")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> OtherReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_jk5caNE7Ed-BzquC8wXy7w_-1831700378")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> RelatedReference { get; init; } = new ValueList<AdditionalReference3>(){};
    
    /// <summary>
    /// Status report details of all the individual orders conveyed in a bulk or multiple order message. Can be used if all the individual orders conveyed in a bulk or multiple order message have the same status.
    /// </summary>
    [IsoId("_jk5cadE7Ed-BzquC8wXy7w_-1236141352")]
    [DisplayName("Order Details Report")]
    [IsoXmlTag("OrdrDtlsRpt")]
    public required OrderStatusAndReason7 OrderDetailsReport { get; init; } 
    
    /// <summary>
    /// Status report details of an individual order.
    /// </summary>
    [IsoId("_jlDNYNE7Ed-BzquC8wXy7w_1516458830")]
    [DisplayName("Individual Order Details Report")]
    [IsoXmlTag("IndvOrdrDtlsRpt")]
    public required IndividualOrderStatusAndReason2 IndividualOrderDetailsReport { get; init; } 
    
    /// <summary>
    /// Status report details of a switch order.
    /// </summary>
    [IsoId("_jlDNYdE7Ed-BzquC8wXy7w_-475245778")]
    [DisplayName("Switch Order Details Report")]
    [IsoXmlTag("SwtchOrdrDtlsRpt")]
    public required SwitchOrderStatusAndReason1 SwitchOrderDetailsReport { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jlDNYtE7Ed-BzquC8wXy7w_1340149318")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since OrderInstructionStatusReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to OrderInstructionStatusReportV03.

