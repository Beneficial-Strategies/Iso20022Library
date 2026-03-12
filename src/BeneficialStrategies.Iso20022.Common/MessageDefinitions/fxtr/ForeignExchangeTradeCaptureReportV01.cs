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


namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.031.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeCaptureReport message is sent by a trading system to a participant for notification and providing details of a treasury trade.
/// Usage
/// The report is sent by the trading system to the two trading parties after their trade has been executed. 
/// The report can also be sent by the trading system to a trading parties to respond their inquiry (TradeCaptureRequest). 
/// Note that multiple reports can be sent to respond one inquiry message.
/// The message may contains trade details and trading parties&apos; information.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeCaptureReport message is sent by a trading system to a participant for notification and providing details of a treasury trade.|Usage|The report is sent by the trading system to the two trading parties after their trade has been executed. |The report can also be sent by the trading system to a trading parties to respond their inquiry (TradeCaptureRequest). |Note that multiple reports can be sent to respond one inquiry message.|The message may contains trade details and trading parties' information.")]
[IsoId("_OqvAMkRZEeSWxNI5mwqKGQ")]
[DisplayName("Foreign Exchange Trade Capture Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeCaptureReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.031.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.031.001.01";
    
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
    /// Constructs a ForeignExchangeTradeCaptureReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeCaptureReportV01( Header23 reqHeader,System.String reqRequestResponder )
    {
        Header = reqHeader;
        RequestResponder = reqRequestResponder;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Capture report message management information.
    /// </summary>
    [IsoId("_ZlYv4ERZEeSWxNI5mwqKGQ")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header23 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header23 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header23 Header { get; init; } 
    #else
    public Header23 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the capture report message.
    /// </summary>
    [IsoId("_gWVfQERZEeSWxNI5mwqKGQ")]
    [DisplayName("Report Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptId")]
    #endif
    [IsoXmlTag("RptId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? ReportIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? ReportIdentification { get; init; } 
    #else
    public MessageIdentification1? ReportIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_kvGPQERZEeSWxNI5mwqKGQ")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentification7? TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification7? TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification7? TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_t_XgwERZEeSWxNI5mwqKGQ")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentification7? CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification7? CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification7? CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the treasury trade captured.
    /// </summary>
    [IsoId("_qakFwEU0EeS7YamWDFxbDA")]
    [DisplayName("Trade Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtl")]
    #endif
    [IsoXmlTag("TradDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Trade1? TradeDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trade1? TradeDetail { get; init; } 
    #else
    public Trade1? TradeDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the report.
    /// </summary>
    [IsoId("_yvuZ4EU0EeS7YamWDFxbDA")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReferences? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReferences? Reference { get; init; } 
    #else
    public AdditionalReferences? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this report is for responding to a capture request.
    /// </summary>
    [IsoId("__yMKoEU0EeS7YamWDFxbDA")]
    [DisplayName("Request Responder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqRspndr")]
    #endif
    [IsoXmlTag("ReqRspndr")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator RequestResponder { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RequestResponder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RequestResponder { get; init; } 
    #else
    public System.String RequestResponder { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this report is a rejection report for responding to a capture request.
    /// </summary>
    [IsoId("_E2SWoEU1EeS7YamWDFxbDA")]
    [DisplayName("Request Rejected")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqRjctd")]
    #endif
    [IsoXmlTag("ReqRjctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RequestRejected { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RequestRejected { get; init; } 
    #else
    public System.String? RequestRejected { get; set; } 
    #endif
    
    /// <summary>
    /// Reason of rejection.
    /// </summary>
    [IsoId("_HyozAEU1EeS7YamWDFxbDA")]
    [DisplayName("Query Reject Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryRjctRsn")]
    #endif
    [IsoXmlTag("QryRjctRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryRejectReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryRejectReason { get; init; } 
    #else
    public System.String? QueryRejectReason { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the total number of trades.
    /// </summary>
    [IsoId("_4M2w8EU0EeS7YamWDFxbDA")]
    [DisplayName("Total Number Trades")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbTrds")]
    #endif
    [IsoXmlTag("TtlNbTrds")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TotalNumberTrades { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TotalNumberTrades { get; init; } 
    #else
    public System.UInt64? TotalNumberTrades { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if this report is the last report sent for responding to one capture request.
    /// </summary>
    [IsoId("_71d2YEU0EeS7YamWDFxbDA")]
    [DisplayName("Last Report Requested")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastRptReqd")]
    #endif
    [IsoXmlTag("LastRptReqd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LastReportRequested { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LastReportRequested { get; init; } 
    #else
    public System.String? LastReportRequested { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_IoQyQKHhEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeCaptureReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportV01.

