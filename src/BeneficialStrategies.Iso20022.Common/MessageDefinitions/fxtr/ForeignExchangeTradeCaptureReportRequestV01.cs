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
/// This record is an implementation of the fxtr.032.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report. 
/// Usage
/// The request is sent by the trading member to the trading system to inquire trade capture report. 
/// Note a capture request could be rejected.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeCaptureReportRequest message is sent by a trading member to the trading system for inquiry of trade capture report. |Usage|The request is sent by the trading member to the trading system to inquire trade capture report. |Note a capture request could be rejected.")]
[IsoId("_KgkR8oHHEeSY3ulMDfpmvA")]
[DisplayName("Foreign Exchange Trade Capture Report Request V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeCaptureReportRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.032.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.01";
    
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
    /// Constructs a ForeignExchangeTradeCaptureReportRequestV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeCaptureReportRequestV01( MessageIdentification1 reqQueryRequestIdentification,QueryOrderStatus1Code reqQueryOrderStatus,System.String reqQueryStartNumber,System.String reqQueryByPeriod )
    {
        QueryRequestIdentification = reqQueryRequestIdentification;
        QueryOrderStatus = reqQueryOrderStatus;
        QueryStartNumber = reqQueryStartNumber;
        QueryByPeriod = reqQueryByPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the capture request message.
    /// </summary>
    [IsoId("_VzU_oIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryReqId")]
    #endif
    [IsoXmlTag("QryReqId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required MessageIdentification1 QueryRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required MessageIdentification1 QueryRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1 QueryRequestIdentification { get; init; } 
    #else
    public MessageIdentification1 QueryRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Range of the trade for the inquire.
    /// </summary>
    [IsoId("_bTutIIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Order Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryOrdrSts")]
    #endif
    [IsoXmlTag("QryOrdrSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required QueryOrderStatus1Code QueryOrderStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required QueryOrderStatus1Code QueryOrderStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueryOrderStatus1Code QueryOrderStatus { get; init; } 
    #else
    public QueryOrderStatus1Code QueryOrderStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the inquiry type of the data.
    /// </summary>
    [IsoId("_JCuBAKbAEeSxuMLA5o46jQ")]
    [DisplayName("Query Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTp")]
    #endif
    [IsoXmlTag("QryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QueryDataType1Code? QueryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QueryDataType1Code? QueryType { get; init; } 
    #else
    public QueryDataType1Code? QueryType { get; set; } 
    #endif
    
    /// <summary>
    /// Start number in request result.
    /// </summary>
    [IsoId("_e_2ZkIHHEeSY3ulMDfpmvA")]
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
    /// Indicates whether the request is query trade for a period of time.
    /// </summary>
    [IsoId("_iSHbkIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query By Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryByPrd")]
    #endif
    [IsoXmlTag("QryByPrd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator QueryByPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QueryByPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QueryByPeriod { get; init; } 
    #else
    public System.String QueryByPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Period of the inquiry.
    /// </summary>
    [IsoId("_uLTQEIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryPrd")]
    #endif
    [IsoXmlTag("QryPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4? QueryPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4? QueryPeriod { get; init; } 
    #else
    public Period4? QueryPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// States the identification of the trade which the trading member inquires.
    /// </summary>
    [IsoId("_r0UKkIHHEeSY3ulMDfpmvA")]
    [DisplayName("Query Trade Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryTradId")]
    #endif
    [IsoXmlTag("QryTradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryTradeIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryTradeIdentification { get; init; } 
    #else
    public System.String? QueryTradeIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the end of the request result.
    /// </summary>
    [IsoId("_BOrPMKa7EeSxuMLA5o46jQ")]
    [DisplayName("Query End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryEndId")]
    #endif
    [IsoXmlTag("QryEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryEndIdentification { get; init; } 
    #else
    public System.String? QueryEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_a2e2MKHhEeS69KkQis5bYg")]
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
    
    /// <summary>
    /// Largest number of request result.
    /// </summary>
    [IsoId("_eP9iMKa9EeSxuMLA5o46jQ")]
    [DisplayName("Query Page Size")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryPgSz")]
    #endif
    [IsoXmlTag("QryPgSz")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? QueryPageSize { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryPageSize { get; init; } 
    #else
    public System.String? QueryPageSize { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the inquiry value of the parameter.
    /// </summary>
    [IsoId("_Ex-IEKbBEeSxuMLA5o46jQ")]
    [DisplayName("Query Parameter Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QryParamVal")]
    #endif
    [IsoXmlTag("QryParamVal")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? QueryParameterValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? QueryParameterValue { get; init; } 
    #else
    public System.String? QueryParameterValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeCaptureReportRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportRequestV01.

