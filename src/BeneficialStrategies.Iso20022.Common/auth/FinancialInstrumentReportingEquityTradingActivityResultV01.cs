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
/// This record is an implementation of the auth.044.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingEquityTradingActivityResult message is sent by a national competent authority to report on computed results data of equity specific trading activity.
/// </summary>
[Description(@"The FinancialInstrumentReportingEquityTradingActivityResult message is sent by a national competent authority to report on computed results data of equity specific trading activity.")]
[IsoId("_4LK8RURNEee7JdgA9zPESA")]
[DisplayName("Financial Instrument Reporting Equity Trading Activity Result V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentReportingEquityTradingActivityResultV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.044.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgEqtyTradgActvtyRslt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.044.001.01";
    
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
    /// Constructs a FinancialInstrumentReportingEquityTradingActivityResultV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentReportingEquityTradingActivityResultV01( SecuritiesMarketReportHeader1 reqReportHeader,TransparencyDataReport12 reqEquityTransparencyData )
    {
        ReportHeader = reqReportHeader;
        EquityTransparencyData = reqEquityTransparencyData;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Header to provide details on when and from whom the message originates.
    /// </summary>
    [IsoId("_4LK8R0RNEee7JdgA9zPESA")]
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
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_4LK8SURNEee7JdgA9zPESA")]
    [DisplayName("Equity Transparency Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EqtyTrnsprncyData")]
    #endif
    [IsoXmlTag("EqtyTrnsprncyData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransparencyDataReport12 EquityTransparencyData { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransparencyDataReport12 EquityTransparencyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransparencyDataReport12 EquityTransparencyData { get; init; } 
    #else
    public TransparencyDataReport12 EquityTransparencyData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8S0RNEee7JdgA9zPESA")]
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


// Since FinancialInstrumentReportingEquityTradingActivityResultV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingEquityTradingActivityResultV01.

