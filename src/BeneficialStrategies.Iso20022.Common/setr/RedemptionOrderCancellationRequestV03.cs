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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.setr;

/// <summary>
/// This record is an implementation of the setr.005.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent RedemptionOrder instruction.
/// Usage
/// The RedemptionOrderCancellationRequest message is used to either:
/// - request the cancellation of an entire RedemptionOrder message, that is, all the individual orders that it contained, or,
/// - request the cancellation of one or more individual orders.
/// There is no amendment, but a cancellation and re-instruct policy.
/// There are two ways to use the message:
/// (1) When the RedemptionOrderCancellationRequest message is used to request the cancellation of an entire RedemptionOrder message, this can be done by either:
/// - quoting the order references of all the individual orders listed in the RedemptionOrder message, or,
/// - quoting the details of all the individual orders (this includes the OrderReference) listed in RedemptionOrder message, but this is not recommended.
/// The message identification of the RedemptionOrder message may also be quoted in PreviousReference.
/// It is also possible to request the cancellation of an entire RedemptionOrder message by quoting its message identification in PreviousReference, but this is not recommended.
/// (2) When the RedemptionOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:
/// - quoting the OrderReference of each individual order listed in the RedemptionOrder message, or,
/// - quoting the details of each individual order (including the OrderReference) listed in RedemptionOrder message, but this is not recommended.
/// The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in PreviousReference.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.
/// The rejection or acceptance of a RedemptionOrderCancellationRequest is made using an OrderCancellationStatusReport message.
/// </summary>
[Description(@"Scope|An instructing party, for example, an investment manager or its authorised representative, sends the RedemptionOrderCancellationRequest message to the executing party, for example, a transfer agent, to request the cancellation of a previously sent RedemptionOrder instruction.|Usage|The RedemptionOrderCancellationRequest message is used to either:|- request the cancellation of an entire RedemptionOrder message, that is, all the individual orders that it contained, or,|- request the cancellation of one or more individual orders.|There is no amendment, but a cancellation and re-instruct policy.|There are two ways to use the message:|(1) When the RedemptionOrderCancellationRequest message is used to request the cancellation of an entire RedemptionOrder message, this can be done by either:|- quoting the order references of all the individual orders listed in the RedemptionOrder message, or,|- quoting the details of all the individual orders (this includes the OrderReference) listed in RedemptionOrder message, but this is not recommended.|The message identification of the RedemptionOrder message may also be quoted in PreviousReference.|It is also possible to request the cancellation of an entire RedemptionOrder message by quoting its message identification in PreviousReference, but this is not recommended.|(2) When the RedemptionOrderCancellationRequest message is used to request the cancellation of one or more individual orders, this can be done by either:|- quoting the OrderReference of each individual order listed in the RedemptionOrder message, or,|- quoting the details of each individual order (including the OrderReference) listed in RedemptionOrder message, but this is not recommended.|The message identification of the RedemptionOrder message in which the individual order was conveyed may also be quoted in PreviousReference.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation.|The rejection or acceptance of a RedemptionOrderCancellationRequest is made using an OrderCancellationStatusReport message.")]
[IsoId("_soQTS9E7Ed-BzquC8wXy7w_973068169")]
[DisplayName("Redemption Order Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RedemptionOrderCancellationRequestV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.005.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "RedOrdrCxlReqV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.005.001.03";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RedemptionOrderCancellationRequestV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RedemptionOrderCancellationRequestV03( MessageIdentification1 reqMessageIdentification )
    {
        MessageIdentification = reqMessageIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_soQTTNE7Ed-BzquC8wXy7w_-1939457083")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 MessageIdentification { get; init; } 
    #else
    public MessageIdentification1 MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_soaEQNE7Ed-BzquC8wXy7w_973068465")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PoolReference { get; init; } 
    #else
    public AdditionalReference3? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_soaEQdE7Ed-BzquC8wXy7w_973068440")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference3? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3? PreviousReference { get; init; } 
    #else
    public AdditionalReference3? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// References of the orders to be cancelled.
    /// </summary>
    [IsoId("_soaEQtE7Ed-BzquC8wXy7w_-899692129")]
    [DisplayName("Cancellation By Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByRef")]
    #endif
    [IsoXmlTag("CxlByRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentFundOrder1? CancellationByReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundOrder1? CancellationByReference { get; init; } 
    #else
    public InvestmentFundOrder1? CancellationByReference { get; set; } 
    #endif
    
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_soaEQ9E7Ed-BzquC8wXy7w_973068189")]
    [DisplayName("Cancellation By Order Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlByOrdrDtls")]
    #endif
    [IsoXmlTag("CxlByOrdrDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RedemptionMultipleOrderInstruction2? CancellationByOrderDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RedemptionMultipleOrderInstruction2? CancellationByOrderDetails { get; init; } 
    #else
    public RedemptionMultipleOrderInstruction2? CancellationByOrderDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_soaERNE7Ed-BzquC8wXy7w_-632605056")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation2? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation2? CopyDetails { get; init; } 
    #else
    public CopyInformation2? CopyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since RedemptionOrderCancellationRequestV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to RedemptionOrderCancellationRequestV03.

