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
/// This record is an implementation of the auth.036.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingReferenceDataDeltaReport message is sent by the trading venues to the national competent authority to report on changes that have occurred in the base data between reference data file generation.
/// </summary>
[Description(@"The FinancialInstrumentReportingReferenceDataDeltaReport message is sent by the trading venues to the national competent authority to report on changes that have occurred in the base data between reference data file generation.")]
[IsoId("_dA7JAaWuEeqZmriXpMtonA")]
[DisplayName("Financial Instrument Reporting Reference Data Delta Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentReportingReferenceDataDeltaReportV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.036.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgRefDataDltaRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.036.001.03";
    
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
    /// Constructs a FinancialInstrumentReportingReferenceDataDeltaReportV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentReportingReferenceDataDeltaReportV03( SecuritiesMarketReportHeader1 reqReportHeader )
    {
        ReportHeader = reqReportHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_dA7JA6WuEeqZmriXpMtonA")]
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
    /// Provides the details of the reference data that have been updated (since the last report).
    /// </summary>
    [IsoId("_dA7JBaWuEeqZmriXpMtonA")]
    [DisplayName("Financial Instrument")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrm")]
    #endif
    [IsoXmlTag("FinInstrm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesReferenceDeltaStatusReport5Choice_? FinancialInstrument { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesReferenceDeltaStatusReport5Choice_? FinancialInstrument { get; init; } 
    #else
    public SecuritiesReferenceDeltaStatusReport5Choice_? FinancialInstrument { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_dA7JB6WuEeqZmriXpMtonA")]
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


// Since FinancialInstrumentReportingReferenceDataDeltaReportV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingReferenceDataDeltaReportV03.

