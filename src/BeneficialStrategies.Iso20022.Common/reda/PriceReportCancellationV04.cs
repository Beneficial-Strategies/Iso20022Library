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
/// This record is an implementation of the reda.002.001.04 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// SCOPE
/// A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.|
/// USAGE
/// The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. 
/// 
/// 
/// </summary>
[Description(@"SCOPE|A report provider, for example, a transfer agent, fund accountant or market data provider, sends the PriceReportCancellation message to the report recipient, for example, a fund management company, transfer agent, market data provider, regulator or any other interested party to cancel previously sent prices.||USAGE|The PriceReportCancellation message is used to either: |- cancel an entire PriceReport that was previously sent (by quoting the business reference of the original price report in the PriceReportIdentification element), or,|- cancel one or more individual prices from a previously sent price report (by using the PriceDetailsToBeCancelled sequence).|Technically, it is possible to cancel all the prices individually by using the PriceDetailsToBeCancelled sequence, but this is not recommended.|The cancellation should not contain the cancellation of prices for more than one NAV date. ||")]
[IsoId("_M87dQRj3EeKxeog5DTmtgg")]
[DisplayName("Price Report Cancellation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PriceReportCancellationV04 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "reda.002.001.04";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "PricRptCxl";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:reda.002.001.04";
    
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
    /// Constructs a PriceReportCancellationV04 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PriceReportCancellationV04( MessageIdentification1 reqMessageIdentification,Pagination reqMessagePagination,System.String reqPriceReportIdentification,System.String reqCancellationIdentification,System.String reqCompletePriceCancellation )
    {
        MessageIdentification = reqMessageIdentification;
        MessagePagination = reqMessagePagination;
        PriceReportIdentification = reqPriceReportIdentification;
        CancellationIdentification = reqCancellationIdentification;
        CompletePriceCancellation = reqCompletePriceCancellation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference that uniquely identifies a message from a business application standpoint.
    /// </summary>
    [IsoId("_M87dQxj3EeKxeog5DTmtgg")]
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
    [IsoId("_M87dRxj3EeKxeog5DTmtgg")]
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
    [IsoId("_M87dSxj3EeKxeog5DTmtgg")]
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
    [IsoId("_M87dTxj3EeKxeog5DTmtgg")]
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
    /// Unique and unambiguous identifier for the price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_NPnKdRmAEeKxsrht2duUcg")]
    [DisplayName("Price Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricRptId")]
    #endif
    [IsoXmlTag("PricRptId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PriceReportIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PriceReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PriceReportIdentification { get; init; } 
    #else
    public System.String PriceReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for the cancellation of the previous price report, as assigned by the reporting party.
    /// </summary>
    [IsoId("_epzJZRmAEeKxsrht2duUcg")]
    [DisplayName("Cancellation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlId")]
    #endif
    [IsoXmlTag("CxlId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text CancellationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CancellationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CancellationIdentification { get; init; } 
    #else
    public System.String CancellationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the cancellation.
    /// </summary>
    [IsoId("_06rKcBmAEeKxsrht2duUcg")]
    [DisplayName("Cancellation Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CxlRsn")]
    #endif
    [IsoXmlTag("CxlRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CancellationReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CancellationReason { get; init; } 
    #else
    public System.String? CancellationReason { get; set; } 
    #endif
    
    /// <summary>
    /// Date or date and time the price will be corrected.
    /// </summary>
    [IsoId("_RTTz8BmBEeKxsrht2duUcg")]
    [DisplayName("Expected Price Correction Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpctdPricCrrctnDt")]
    #endif
    [IsoXmlTag("XpctdPricCrrctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime1Choice_? ExpectedPriceCorrectionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime1Choice_? ExpectedPriceCorrectionDate { get; init; } 
    #else
    public DateAndDateTime1Choice_? ExpectedPriceCorrectionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not all the prices of the referenced price report are cancelled.
    /// </summary>
    [IsoId("_Cj3HgBmCEeKxsrht2duUcg")]
    [DisplayName("Complete Price Cancellation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmpltPricCxl")]
    #endif
    [IsoXmlTag("CmpltPricCxl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CompletePriceCancellation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CompletePriceCancellation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CompletePriceCancellation { get; init; } 
    #else
    public System.String CompletePriceCancellation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of prices to be cancelled.
    /// </summary>
    [IsoId("_M87dUxj3EeKxeog5DTmtgg")]
    [DisplayName("Cancelled Price Valuation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CancPricValtnDtls")]
    #endif
    [IsoXmlTag("CancPricValtnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceReport3? CancelledPriceValuationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceReport3? CancelledPriceValuationDetails { get; init; } 
    #else
    public PriceReport3? CancelledPriceValuationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2sI2JRmCEeKxsrht2duUcg")]
    [DisplayName("Extension")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Xtnsn")]
    #endif
    [IsoXmlTag("Xtnsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Extension1? Extension { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Extension1? Extension { get; init; } 
    #else
    public Extension1? Extension { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since PriceReportCancellationV04Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to PriceReportCancellationV04.

