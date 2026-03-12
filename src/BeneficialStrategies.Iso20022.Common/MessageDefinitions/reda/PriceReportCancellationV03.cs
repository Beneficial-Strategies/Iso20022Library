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


namespace BeneficialStrategies.Iso20022.reda;

/// <summary>
/// This record is an implementation of the reda.002.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel a previously sent PriceReport message.
/// Usage
/// The PriceReportCancellation is used to cancel an entire PriceReport message that was previously sent.
/// If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.
/// This message must contain the reference of the message to be cancelled.This message may also contain details of the message to be cancelled, but this is not recommended.
/// </summary>
[Description(@"Scope|A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel a previously sent PriceReport message.|Usage|The PriceReportCancellation is used to cancel an entire PriceReport message that was previously sent.|If only a part of the information needs to be cancelled and replaced, the PriceReportCorrection message must be used.|This message must contain the reference of the message to be cancelled.This message may also contain details of the message to be cancelled, but this is not recommended.")]
[IsoId("_ZstsytEvEd-BzquC8wXy7w_-609818463")]
[DisplayName("Price Report Cancellation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceReportCancellationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.002.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCxlV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.03";
    
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
    /// Constructs a PriceReportCancellationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceReportCancellationV03( MessageIdentification1 reqMessageIdentification,AdditionalReference3 reqPreviousReference,Pagination reqMessagePagination )
    {
        MessageIdentification = reqMessageIdentification;
        PreviousReference = reqPreviousReference;
        MessagePagination = reqMessagePagination;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_Zstsy9EvEd-BzquC8wXy7w_1351026833")]
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
    [IsoId("_ZstszNEvEd-BzquC8wXy7w_980486135")]
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
    [IsoId("_ZstszdEvEd-BzquC8wXy7w_990644277")]
    [DisplayName("Previous Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsRef")]
    #endif
    [IsoXmlTag("PrvsRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AdditionalReference3 PreviousReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AdditionalReference3 PreviousReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReference3 PreviousReference { get; init; } 
    #else
    public AdditionalReference3 PreviousReference { get; set; } 
    #endif
    
    /// <summary>
    /// Pagination of the message.
    /// </summary>
    [IsoId("_ZstsztEvEd-BzquC8wXy7w_-603797657")]
    [DisplayName("Message Pagination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgPgntn")]
    #endif
    [IsoXmlTag("MsgPgntn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Pagination MessagePagination { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Pagination MessagePagination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Pagination MessagePagination { get; init; } 
    #else
    public Pagination MessagePagination { get; set; } 
    #endif
    
    /// <summary>
    /// Common information related to all the price reports to be cancelled.
    /// </summary>
    [IsoId("_Zs3dwNEvEd-BzquC8wXy7w_675721186")]
    [DisplayName("Price Report To Be Cancelled")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricRptToBeCanc")]
    #endif
    [IsoXmlTag("PricRptToBeCanc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceReport2? PriceReportToBeCancelled { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceReport2? PriceReportToBeCancelled { get; init; } 
    #else
    public PriceReport2? PriceReportToBeCancelled { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PriceReportCancellationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportCancellationV03.

