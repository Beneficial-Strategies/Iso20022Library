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



namespace BeneficialStrategies.Iso20022.auth;

/// <summary>
/// This record is an implementation of the auth.045.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.
/// </summary>
[Description(@"The FinancialInstrumentReportingNonEquityTradingActivityResult message is sent by the trading venue to the national competent authority to report on computed results data of non-equity specific trading activity.")]
[IsoId("_4LK8c0RNEee7JdgA9zPESA")]
[DisplayName("Financial Instrument Reporting Non Equity Trading Activity Result V")]
public partial record FinancialInstrumentReportingNonEquityTradingActivityResultV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.045.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgNonEqtyTradgActvtyRslt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.045.001.01";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #nullable enable
    
    /// <summary>
    /// Header information related to the global report.
    /// </summary>
    [IsoId("_4LK8dURNEee7JdgA9zPESA")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; } 
    
    /// <summary>
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_4LK8d0RNEee7JdgA9zPESA")]
    [DisplayName("Non Equity Transparency Data")]
    [IsoXmlTag("NonEqtyTrnsprncyData")]
    public required TransparencyDataReport14 NonEquityTransparencyData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4LK8eURNEee7JdgA9zPESA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since FinancialInstrumentReportingNonEquityTradingActivityResultV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingNonEquityTradingActivityResultV01.

