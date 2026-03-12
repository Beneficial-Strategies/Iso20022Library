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


namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.035.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingTradingVolumeCapDataReport message is sent by the trading venue to the national competent authority to report the total volume of trading and volumes of trading under reference price waiver and negotiated transactions waiver.
/// </summary>
[Description(@"The FinancialInstrumentReportingTradingVolumeCapDataReport message is sent by the trading venue to the national competent authority to report the total volume of trading and volumes of trading under reference price waiver and negotiated transactions waiver.")]
[IsoId("_4LUGR0RNEee7JdgA9zPESA")]
[DisplayName("Financial Instrument Reporting Trading Volume Cap Data Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentReportingTradingVolumeCapDataReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.035.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgTradgVolCapDataRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.035.001.01";
    
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
    /// Constructs a FinancialInstrumentReportingTradingVolumeCapDataReportV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentReportingTradingVolumeCapDataReportV01( SecuritiesMarketReportHeader1 reqReportHeader,VolumeCapReport1 reqVolumeCapData )
    {
        ReportHeader = reqReportHeader;
        VolumeCapData = reqVolumeCapData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_4LUGSURNEee7JdgA9zPESA")]
    [DisplayName("Report Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptHdr")]
    #endif
    [IsoXmlTag("RptHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesMarketReportHeader1 ReportHeader { get; init; } 
    #else
    public SecuritiesMarketReportHeader1 ReportHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the volume of trades of financial instruments.
    /// </summary>
    [IsoId("_4LUGS0RNEee7JdgA9zPESA")]
    [DisplayName("Volume Cap Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VolCapData")]
    #endif
    [IsoXmlTag("VolCapData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VolumeCapReport1 VolumeCapData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VolumeCapReport1 VolumeCapData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VolumeCapReport1 VolumeCapData { get; init; } 
    #else
    public VolumeCapReport1 VolumeCapData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LUGTURNEee7JdgA9zPESA")]
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


// Since FinancialInstrumentReportingTradingVolumeCapDataReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingTradingVolumeCapDataReportV01.

