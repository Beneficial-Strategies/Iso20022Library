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
/// This record is an implementation of the setr.017.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An executing party, for example, a transfer agent, sends the OrderCancellationStatusReport to the instructing party, for example, an investment manager or its authorised representative, to report the status of an order cancellation request that was previously received.
/// Usage
/// The OrderCancellationStatusReport message is used to provide the status of:
/// - one or more individual order cancellation requests by using IndividualCancellationStatusReport, or,
/// - an order cancellation request message by using CancellationStatusReport.
/// If the OrderCancellationStatusReport message is used to report the status of an individual order cancellation request, then the repetitive IndividualCancellationStatusReport sequence is used and the order reference of the individual order is quoted in OrderReference. The message identification of the message in which the individual order was conveyed may also be quoted in RelatedReference.
/// If the OrderCancellationStatusReport message is used to report the status of an entire order cancellation request message, for example, the SubscriptionBulkOrderCancellationRequest, or a SubscriptionOrderCancellationRequest containing several orders, then the CancellationStatusReport sequence. is used and the message identification of the order cancellation request message is quoted in RelatedReference. All the order cancellation requests within the message must have the same status.
/// One of the following statuses can be reported:
/// - the order cancellation is pending, or,
/// - the order cancellation request is rejected, or,
/// - the order is cancelled.
/// When the cancellation is rejected, the reason for the rejection must be specified.
/// </summary>
[Description(@"Scope|An executing party, for example, a transfer agent, sends the OrderCancellationStatusReport to the instructing party, for example, an investment manager or its authorised representative, to report the status of an order cancellation request that was previously received.|Usage|The OrderCancellationStatusReport message is used to provide the status of:|- one or more individual order cancellation requests by using IndividualCancellationStatusReport, or,|- an order cancellation request message by using CancellationStatusReport.|If the OrderCancellationStatusReport message is used to report the status of an individual order cancellation request, then the repetitive IndividualCancellationStatusReport sequence is used and the order reference of the individual order is quoted in OrderReference. The message identification of the message in which the individual order was conveyed may also be quoted in RelatedReference.|If the OrderCancellationStatusReport message is used to report the status of an entire order cancellation request message, for example, the SubscriptionBulkOrderCancellationRequest, or a SubscriptionOrderCancellationRequest containing several orders, then the CancellationStatusReport sequence. is used and the message identification of the order cancellation request message is quoted in RelatedReference. All the order cancellation requests within the message must have the same status.|One of the following statuses can be reported:|- the order cancellation is pending, or,|- the order cancellation request is rejected, or,|- the order is cancelled.|When the cancellation is rejected, the reason for the rejection must be specified.")]
[IsoId("_g9jmudE7Ed-BzquC8wXy7w_-1949489273")]
[DisplayName("Order Cancellation Status Report V")]
public partial record OrderCancellationStatusReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.017.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "OrdrCxlStsRptV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.017.001.03";
    
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
    [IsoId("_g9jmutE7Ed-BzquC8wXy7w_-1666125057")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously received.
    /// </summary>
    [IsoId("_g9jmu9E7Ed-BzquC8wXy7w_-1949489212")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> RelatedReference { get; init; } = [];
    
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_g9jmvNE7Ed-BzquC8wXy7w_-1949488875")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<AdditionalReference3> OtherReference { get; init; } = [];
    
    /// <summary>
    /// Status report details of a bulk or multiple or switch order cancellation message.
    /// </summary>
    [IsoId("_g9jmvdE7Ed-BzquC8wXy7w_-1949488917")]
    [DisplayName("Cancellation Status Report")]
    [IsoXmlTag("CxlStsRpt")]
    public required OrderStatusAndReason8 CancellationStatusReport { get; init; } 
    
    /// <summary>
    /// Status report details of one or more individual orders from a bulk or multiple or switch order cancellation request.
    /// </summary>
    [IsoId("_g9tXsNE7Ed-BzquC8wXy7w_-358353694")]
    [DisplayName("Individual Cancellation Status Report")]
    [IsoXmlTag("IndvCxlStsRpt")]
    public required IndividualOrderStatusAndReason4 IndividualCancellationStatusReport { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_g9tXsdE7Ed-BzquC8wXy7w_819197774")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; } 
    
    
    #nullable disable
    
}


// Since OrderCancellationStatusReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to OrderCancellationStatusReportV03.

