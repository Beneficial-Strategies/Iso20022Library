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
/// This record is an implementation of the setr.011.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the SubscriptionOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SubscriptionOrder.
/// Usage
/// The SubscriptionOrderCancellationRequest message is used to either:
/// - request the cancellation of an entire SubscriptionOrder message, that is, all the individual orders that it contained, or,
/// - request the cancellation of one or more individual orders.
/// There is no amendment, but a cancellation and re-instruct policy.
/// There are two ways to use the message:
/// (1) When the SubscriptionOrderCancellationRequest message is used to request the cancellation of an entire SubscriptionOrder message, this can be done by either:
/// - quoting the order references of all the individual orders listed in the SubscriptionOrder message, or,
/// - quoting the details of all the individual orders (this includes the OrderReference) listed in SubscriptionOrder message, but this is not recommended.
/// The message identification of the SubscriptionOrder message may also be quoted in PreviousReference.
/// It is also possible to request the cancellation of an entire SubscriptionOrder message by quoting its message identification in PreviousReference, but this is not recommended.
/// (2) When the SubscriptionOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:
/// - quoting the OrderReference of each individual order listed in the SubscriptionOrder message, or,
/// - quoting the details of each individual order (including the OrderReference) listed in SubscriptionOrder message, but this is not recommended.
/// The message identification of the SubscriptionOrder message in which the individual order was conveyed may also be quoted in PreviousReference.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a SubscriptionOrderCancellationRequest is made using an OrderCancellationStatusReport message.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the SubscriptionOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SubscriptionOrder.|Usage|The SubscriptionOrderCancellationRequest message is used to either:|- request the cancellation of an entire SubscriptionOrder message, that is, all the individual orders that it contained, or,|- request the cancellation of one or more individual orders.|There is no amendment, but a cancellation and re-instruct policy.|There are two ways to use the message:|(1) When the SubscriptionOrderCancellationRequest message is used to request the cancellation of an entire SubscriptionOrder message, this can be done by either:|- quoting the order references of all the individual orders listed in the SubscriptionOrder message, or,|- quoting the details of all the individual orders (this includes the OrderReference) listed in SubscriptionOrder message, but this is not recommended.|The message identification of the SubscriptionOrder message may also be quoted in PreviousReference.|It is also possible to request the cancellation of an entire SubscriptionOrder message by quoting its message identification in PreviousReference, but this is not recommended.|(2) When the SubscriptionOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:|- quoting the OrderReference of each individual order listed in the SubscriptionOrder message, or,|- quoting the details of each individual order (including the OrderReference) listed in SubscriptionOrder message, but this is not recommended.|The message identification of the SubscriptionOrder message in which the individual order was conveyed may also be quoted in PreviousReference.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a SubscriptionOrderCancellationRequest is made using an OrderCancellationStatusReport message.")]
[IsoId("_2S829dE7Ed-BzquC8wXy7w_-1906672216")]
[DisplayName("Subscription Order Cancellation Request V")]
public partial record SubscriptionOrderCancellationRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.011.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SbcptOrdrCxlReqV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.011.001.03";
    
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
    [IsoId("_2S829tE7Ed-BzquC8wXy7w_-537553524")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    public required MessageIdentification1 MessageIdentification { get; init; } 
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_2S8299E7Ed-BzquC8wXy7w_-1906672120")]
    [DisplayName("Pool Reference")]
    [IsoXmlTag("PoolRef")]
    public AdditionalReference3? PoolReference { get; init; } 
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_2S82-NE7Ed-BzquC8wXy7w_-1906672155")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public AdditionalReference3? PreviousReference { get; init; } 
    
    /// <summary>
    /// References of the orders to be cancelled.
    /// </summary>
    [IsoId("_2S82-dE7Ed-BzquC8wXy7w_1525410004")]
    [DisplayName("Cancellation By Reference")]
    [IsoXmlTag("CxlByRef")]
    public InvestmentFundOrder1? CancellationByReference { get; init; } 
    
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_2TGn8NE7Ed-BzquC8wXy7w_-1906672085")]
    [DisplayName("Cancellation By Order Details")]
    [IsoXmlTag("CxlByOrdrDtls")]
    public SubscriptionMultipleOrderInstruction2? CancellationByOrderDetails { get; init; } 
    
    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_2TGn8dE7Ed-BzquC8wXy7w_-1747169345")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation2? CopyDetails { get; init; } 
    
    
    #nullable disable
    
}


// Since SubscriptionOrderCancellationRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SubscriptionOrderCancellationRequestV03.

