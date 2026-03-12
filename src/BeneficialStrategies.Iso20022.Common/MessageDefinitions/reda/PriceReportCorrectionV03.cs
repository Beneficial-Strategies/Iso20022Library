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
/// This record is an implementation of the reda.003.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReportCorrection message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or any other interested party to correct at least one of the prices for a financial instrument that was reported in a previously sent PriceReport message.
/// Usage
/// The PriceReportCorrection message is used to correct information reported in a previously sent PriceReport.
/// If an entire PriceReport message must be corrected, eg, due to an incorrect trade date, it is recommended that a PriceReportCancellation message is used to cancel the entire PriceReport message and a new PriceReport sent.
/// </summary>
[Description(@"Scope|A report provider, eg, a transfer agent, fund accountant or market data provider, sends the PriceReportCorrection message to the report recipient, eg, a fund management company, transfer agent, market data provider, regulator or any other interested party to correct at least one of the prices for a financial instrument that was reported in a previously sent PriceReport message.|Usage|The PriceReportCorrection message is used to correct information reported in a previously sent PriceReport.|If an entire PriceReport message must be corrected, eg, due to an incorrect trade date, it is recommended that a PriceReportCancellation message is used to cancel the entire PriceReport message and a new PriceReport sent.")]
[IsoId("_ZtBOz9EvEd-BzquC8wXy7w_-770509177")]
[DisplayName("Price Report Correction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceReportCorrectionV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.003.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCrrctnV03";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.003.001.03";
    
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
    /// Constructs a PriceReportCorrectionV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceReportCorrectionV03( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination,PriceCorrection3 reqPriceCorrectionDetails )
    {
        MessageIdentification = reqMessageIdentification;
        MessagePagination = reqMessagePagination;
        PriceCorrectionDetails = reqPriceCorrectionDetails;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_ZtBO0NEvEd-BzquC8wXy7w_1796163719")]
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
    [IsoId("_ZtKYsNEvEd-BzquC8wXy7w_133617453")]
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
    [IsoId("_ZtKYsdEvEd-BzquC8wXy7w_144699623")]
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
    /// Pagination of the message.
    /// </summary>
    [IsoId("_ZtKYstEvEd-BzquC8wXy7w_-1002757457")]
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
    /// Information related to the correction of a price of a financial instrument.
    /// </summary>
    [IsoId("_ZtKYs9EvEd-BzquC8wXy7w_1468107589")]
    [DisplayName("Price Correction Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricCrrctnDtls")]
    #endif
    [IsoXmlTag("PricCrrctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PriceCorrection3 PriceCorrectionDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PriceCorrection3 PriceCorrectionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceCorrection3 PriceCorrectionDetails { get; init; } 
    #else
    public PriceCorrection3 PriceCorrectionDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PriceReportCorrectionV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportCorrectionV03.

