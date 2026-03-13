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
/// This record is an implementation of the setr.016.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The OrderInstructionStatusReport is sent by an executing party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.
/// This message reports the status of an order from the time the executing party receives the order until the order is executed.
/// Usage
/// The OrderInstructionStatusReport message is sent by an executing party to the instructing party to report on the status of a subscription, redemption or a switch order.
/// The message can be used to report one of the following:
/// - a received status, or
/// - an accepted status, or
/// - a sent to next party status, or
/// - an already executed status, or
/// - a cancelled status, or
/// - a conditionally accepted status, or
/// - a rejected status, or
/// - a suspended status, or
/// - an in-repair status (at the individual order level only), or
/// - repaired conditions (at the individual order level only).
/// For subscription and redemption orders, the OrderInstructionStatusReport message covers both bulk and multiple categories of orders, and this message may provide the status either at the bulk or at the individual level.
/// For a switch order, this message provides the status of the whole order, ie, it is not possible to accept one leg and to reject the other leg, the entire switch order has to be rejected. In order to identify which leg within the switch is causing a problem, the redemption or subscription leg identification is used.
/// </summary>
[Description(@"Scope|The OrderInstructionStatusReport is sent by an executing party, eg, a transfer agent, to an instructing party, eg, an investment manager or its authorised representative. There may be one or more intermediary parties between the executing party and the instructing party. The intermediary party is, for example, an intermediary or a concentrator.|This message reports the status of an order from the time the executing party receives the order until the order is executed.|Usage|The OrderInstructionStatusReport message is sent by an executing party to the instructing party to report on the status of a subscription, redemption or a switch order.|The message can be used to report one of the following:|- a received status, or|- an accepted status, or|- a sent to next party status, or|- an already executed status, or|- a cancelled status, or|- a conditionally accepted status, or|- a rejected status, or|- a suspended status, or|- an in-repair status (at the individual order level only), or|- repaired conditions (at the individual order level only).|For subscription and redemption orders, the OrderInstructionStatusReport message covers both bulk and multiple categories of orders, and this message may provide the status either at the bulk or at the individual level.|For a switch order, this message provides the status of the whole order, ie, it is not possible to accept one leg and to reject the other leg, the entire switch order has to be rejected. In order to identify which leg within the switch is causing a problem, the redemption or subscription leg identification is used.")]
[IsoId("_jH1s-NE7Ed-BzquC8wXy7w_1853868190")]
[DisplayName("Order Instruction Status Report V")]
public partial record OrderInstructionStatusReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.016.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "setr.016.001.02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.016.001.02";
    
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
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_jH1s-dE7Ed-BzquC8wXy7w_-220954983")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> OtherReference { get; init; } = [];
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_jH1s-tE7Ed-BzquC8wXy7w_81957477")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> RelatedReference { get; init; } = [];
    
    /// <summary>
    /// Reference to a multiple order or bulk order that represents the common reference of several individual orders.
    /// </summary>
    [IsoId("_jH1s-9E7Ed-BzquC8wXy7w_-293915217")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public AdditionalReference3? MasterReference { get; init; } 
    
    /// <summary>
    /// Status report details of a bulk or multiple or switch order that was previously received.
    /// </summary>
    [IsoId("_jH_d8NE7Ed-BzquC8wXy7w_178929891")]
    [DisplayName("Order Details Report")]
    [IsoXmlTag("OrdrDtlsRpt")]
    public required OrderStatusAndReason3 OrderDetailsReport { get; init; } 
    
    /// <summary>
    /// Status report details of the individual orders of a bulk or multiple order that was previously received.
    /// </summary>
    [IsoId("_jH_d8dE7Ed-BzquC8wXy7w_289696390")]
    [DisplayName("Individual Order Details Report")]
    [IsoXmlTag("IndvOrdrDtlsRpt")]
    public required IndividualOrderStatusAndReason1 IndividualOrderDetailsReport { get; init; } 
    
    
    #nullable disable
    
}


// Since OrderInstructionStatusReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to OrderInstructionStatusReportV02.

