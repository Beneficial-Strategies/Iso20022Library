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
/// This record is an implementation of the auth.044.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The FinancialInstrumentReportingEquityTradingActivityResult message is sent by a national competent authority to report on computed results data of equity specific trading activity.
/// </summary>
[Description(@"The FinancialInstrumentReportingEquityTradingActivityResult message is sent by a national competent authority to report on computed results data of equity specific trading activity.")]
[IsoId("_ZoWOQSe2Eei12pGEsJIAeQ")]
[DisplayName("Financial Instrument Reporting Equity Trading Activity Result V")]
public partial record FinancialInstrumentReportingEquityTradingActivityResultV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.044.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FinInstrmRptgEqtyTradgActvtyRslt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.044.001.02";
    
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
    /// Header to provide details on when and from whom the message originates.
    /// </summary>
    [IsoId("_ZoWOQye2Eei12pGEsJIAeQ")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required SecuritiesMarketReportHeader1 ReportHeader { get; init; } 
    
    /// <summary>
    /// Details the transparency data reported by a trading venue.
    /// </summary>
    [IsoId("_ZoWORSe2Eei12pGEsJIAeQ")]
    [DisplayName("Equity Transparency Data")]
    [IsoXmlTag("EqtyTrnsprncyData")]
    public required TransparencyDataReport17 EquityTransparencyData { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_ZoWORye2Eei12pGEsJIAeQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since FinancialInstrumentReportingEquityTradingActivityResultV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to FinancialInstrumentReportingEquityTradingActivityResultV02.

