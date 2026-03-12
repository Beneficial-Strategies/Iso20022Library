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
/// This record is an implementation of the auth.033.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingNonEquityTransparencyDataReport message is sent by the trading venue to the national competent authority to submit non equity specific details as part of classifying and applying necessary transparency non equity computations.
/// </summary>
[Description(@"The FinancialInstrumentReportingNonEquityTransparencyDataReport message is sent by the trading venue to the national competent authority to submit non equity specific details as part of classifying and applying necessary transparency non equity computations.")]
[IsoId("_MCQRcCcFEeiPcf9yet9QmA")]
[DisplayName("Financial Instrument Reporting Non Equity Transparency Data Report V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentReportingNonEquityTransparencyDataReportV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.033.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgNonEqtyTrnsprncyDataRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.033.001.02";
    
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
    /// Constructs a FinancialInstrumentReportingNonEquityTransparencyDataReportV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentReportingNonEquityTransparencyDataReportV02( SecuritiesMarketReportHeader1 reqReportHeader,TransparencyDataReport16 reqNonEquityTransparencyData )
    {
        ReportHeader = reqReportHeader;
        NonEquityTransparencyData = reqNonEquityTransparencyData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_MCjzcScFEeiPcf9yet9QmA")]
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
    /// Details the non-equity transparency qualitative data reported by a trading venue.
    /// </summary>
    [IsoId("_MC2uYScFEeiPcf9yet9QmA")]
    [DisplayName("Non Equity Transparency Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NonEqtyTrnsprncyData")]
    #endif
    [IsoXmlTag("NonEqtyTrnsprncyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransparencyDataReport16 NonEquityTransparencyData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransparencyDataReport16 NonEquityTransparencyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransparencyDataReport16 NonEquityTransparencyData { get; init; } 
    #else
    public TransparencyDataReport16 NonEquityTransparencyData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_MC2uYycFEeiPcf9yet9QmA")]
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


// Since FinancialInstrumentReportingNonEquityTransparencyDataReportV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingNonEquityTransparencyDataReportV02.

