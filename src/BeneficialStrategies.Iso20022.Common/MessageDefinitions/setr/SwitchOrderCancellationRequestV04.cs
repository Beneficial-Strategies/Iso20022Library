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
/// This record is an implementation of the setr.014.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The SwitchOrderCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SwitchOrder instruction.
/// Usage
/// The SwitchOrderCancellationRequest is used to cancel the entire previously sent SwitchOrder instruction/s and all the individual legs that it contains. There is no amendment, but a cancellation and re-instruct policy.
/// To request the cancellation of a switch order, the order reference of the original switch order is quoted in the order reference element. The message identification of the SwitchOrder message may also be quoted in PreviousReference but this is not recommended.
/// The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation request.
/// The rejection or acceptance of a SwitchOrderCancellationRequest is made using an OrderCancellationStatusReport message.
/// </summary>
[Description(@"Scope|The SwitchOrderCancellationRequest message is sent by an instructing party, for example, an investment manager or its authorised representative, to the executing party, for example, a transfer agent, to request the cancellation of a previously sent SwitchOrder instruction.|Usage|The SwitchOrderCancellationRequest is used to cancel the entire previously sent SwitchOrder instruction/s and all the individual legs that it contains. There is no amendment, but a cancellation and re-instruct policy.|To request the cancellation of a switch order, the order reference of the original switch order is quoted in the order reference element. The message identification of the SwitchOrder message may also be quoted in PreviousReference but this is not recommended.|The deadline and acceptance of a cancellation request is subject to a service level agreement (SLA). This cancellation message is a cancellation request. There is no automatic acceptance of the cancellation request.|The rejection or acceptance of a SwitchOrderCancellationRequest is made using an OrderCancellationStatusReport message.")]
[IsoId("_Aab6-TbLEead9bDRE_1DAQ")]
[DisplayName("Switch Order Cancellation Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SwitchOrderCancellationRequestV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "setr.014.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SwtchOrdrCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:setr.014.001.04";
    
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
    /// Constructs a SwitchOrderCancellationRequestV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SwitchOrderCancellationRequestV04( MessageIdentification1 reqMessageIdentification,InvestmentFundOrder9 reqOrderReferences )
    {
        MessageIdentification = reqMessageIdentification;
        OrderReferences = reqOrderReferences;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies the message from a business application standpoint.
    /// </summary>
    [IsoId("_Aab7ATbLEead9bDRE_1DAQ")]
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
    [IsoId("_Aab7AzbLEead9bDRE_1DAQ")]
    [DisplayName("Pool Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolRef")]
    #endif
    [IsoXmlTag("PoolRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference9? PoolReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference9? PoolReference { get; init; } 
    #else
    public AdditionalReference9? PoolReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_Aab7BTbLEead9bDRE_1DAQ")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReference8? PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference8? PreviousReference { get; init; } 
    #else
    public AdditionalReference8? PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference assigned to a set of orders or trades in order to link them together.
    /// </summary>
    [IsoId("_W4-yglAYEea5nPE5ezGuuw")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the individual order to be cancelled.
    /// </summary>
    [IsoId("_W4-yg1AYEea5nPE5ezGuuw")]
    [DisplayName("Order References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRefs")]
    #endif
    [IsoXmlTag("OrdrRefs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentFundOrder9 OrderReferences { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentFundOrder9 OrderReferences { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentFundOrder9 OrderReferences { get; init; } 
    #else
    public InvestmentFundOrder9 OrderReferences { get; set; } 
    #endif
    
    /// <summary>
    /// Information provided when the message is a copy of a previous message.
    /// </summary>
    [IsoId("_Aab7CzbLEead9bDRE_1DAQ")]
    [DisplayName("Copy Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpyDtls")]
    #endif
    [IsoXmlTag("CpyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CopyInformation4? CopyDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CopyInformation4? CopyDetails { get; init; } 
    #else
    public CopyInformation4? CopyDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since SwitchOrderCancellationRequestV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SwitchOrderCancellationRequestV04.

