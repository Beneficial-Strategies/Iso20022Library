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
/// This record is an implementation of the auth.014.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The MoneyMarketSecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all daily Foreign Exchange Swaps (FX Swaps) transactions.
/// </summary>
[Description(@"The MoneyMarketSecuredMarketStatisticalReport message is sent by the reporting agents to the relevant competent authority, to report all daily Foreign Exchange Swaps (FX Swaps) transactions.")]
[IsoId("_wXy2MZ2SEeW_58xcYxhewg")]
[DisplayName("Money Market Foreign Exchange Swaps Statistical Report V")]
public partial record MoneyMarketForeignExchangeSwapsStatisticalReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.014.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "MnyMktFXSwpsSttstclRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.014.001.01";
    
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
    /// Provides the elements specific to the report.
    /// </summary>
    [IsoId("_wXy2M52SEeW_58xcYxhewg")]
    [DisplayName("Report Header")]
    [IsoXmlTag("RptHdr")]
    public required MoneyMarketReportHeader1 ReportHeader { get; init; } 
    
    /// <summary>
    /// Provides the reason why no activity is reported or the required list of transactions for the foreign exchange swaps segment.
    /// </summary>
    [IsoId("_wXy2NZ2SEeW_58xcYxhewg")]
    [DisplayName("Foreign Exchange Swaps Report")]
    [IsoXmlTag("FXSwpsRpt")]
    public required ForeignExchangeSwap2Choice_ ForeignExchangeSwapsReport { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_wXy2N52SEeW_58xcYxhewg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since MoneyMarketForeignExchangeSwapsStatisticalReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to MoneyMarketForeignExchangeSwapsStatisticalReportV01.

