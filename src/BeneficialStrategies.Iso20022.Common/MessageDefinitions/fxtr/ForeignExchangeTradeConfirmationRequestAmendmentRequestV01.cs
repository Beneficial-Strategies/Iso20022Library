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
/// This record is an implementation of the fxtr.035.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeConfirmationRequestAmendmentRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.
/// 
/// Usage
/// The request is sent by the market participants to the CMU after the confirmation is requested.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeConfirmationRequestAmendmentRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.||Usage|The request is sent by the market participants to the CMU after the confirmation is requested.")]
[IsoId("_orQF4IHdEeSY3ulMDfpmvA")]
[DisplayName("Foreign Exchange Trade Confirmation Request Amendment Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeConfirmationRequestAmendmentRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.035.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReqAmdmntReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.035.001.01";
    
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
    /// Constructs a ForeignExchangeTradeConfirmationRequestAmendmentRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeConfirmationRequestAmendmentRequestV01( Header23 reqHeader,MessageIdentification1 reqAmendmentRequestIdentification,Trade2 reqTradeDetail,Period4 reqQueryPeriod,System.String reqQueryStartNumber,QueryTradeStatus1Code reqQueryTradeStatus )
    {
        Header = reqHeader;
        AmendmentRequestIdentification = reqAmendmentRequestIdentification;
        TradeDetail = reqTradeDetail;
        QueryPeriod = reqQueryPeriod;
        QueryStartNumber = reqQueryStartNumber;
        QueryTradeStatus = reqQueryTradeStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Message management information.
    /// </summary>
    [IsoId("_yesV4IHdEeSY3ulMDfpmvA")]
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
    /// Identifies the amendment request messge.
    /// </summary>
    [IsoId("_ywTqUIHdEeSY3ulMDfpmvA")]
    [DisplayName("Amendment Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntReqId")]
    #endif
    [IsoXmlTag("AmdmntReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 AmendmentRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 AmendmentRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 AmendmentRequestIdentification { get; init; } 
    #else
    public MessageIdentification1 AmendmentRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_zF5f0IHdEeSY3ulMDfpmvA")]
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
    [IsoId("_aVIqwIdVEeS8A78Q2OnhsA")]
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
    /// Details of the treasury trade confirmed.
    /// </summary>
    [IsoId("_zpFFYIHdEeSY3ulMDfpmvA")]
    [DisplayName("Trade Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtl")]
    #endif
    [IsoXmlTag("TradDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Trade2 TradeDetail { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Trade2 TradeDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trade2 TradeDetail { get; init; } 
    #else
    public Trade2 TradeDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Period of the inquiry.
    /// </summary>
    [IsoId("_1bgsUIHdEeSY3ulMDfpmvA")]
    [DisplayName("Query Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryPrd")]
    #endif
    [IsoXmlTag("QryPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period4 QueryPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period4 QueryPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4 QueryPeriod { get; init; } 
    #else
    public Period4 QueryPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Number which the query results will start from.
    /// </summary>
    [IsoId("_2S1V4IHdEeSY3ulMDfpmvA")]
    [DisplayName("Query Start Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryStartNb")]
    #endif
    [IsoXmlTag("QryStartNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35NumericText QueryStartNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueryStartNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueryStartNumber { get; init; } 
    #else
    public System.String QueryStartNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the inquiry status of the trade.
    /// </summary>
    [IsoId("_ZbwkcKaeEeSR8qifggAitQ")]
    [DisplayName("Query Trade Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTradSts")]
    #endif
    [IsoXmlTag("QryTradSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QueryTradeStatus1Code QueryTradeStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QueryTradeStatus1Code QueryTradeStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueryTradeStatus1Code QueryTradeStatus { get; init; } 
    #else
    public QueryTradeStatus1Code QueryTradeStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_gyxZAKHiEeS69KkQis5bYg")]
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


// Since ForeignExchangeTradeConfirmationRequestAmendmentRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestAmendmentRequestV01.

