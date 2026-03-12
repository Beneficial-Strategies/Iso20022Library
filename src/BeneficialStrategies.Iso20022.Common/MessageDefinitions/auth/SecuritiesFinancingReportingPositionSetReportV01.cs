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
/// This record is an implementation of the auth.105.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The SecuritiesFinancingReportingPositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties (except reuse report).
/// </summary>
[Description(@"The SecuritiesFinancingReportingPositionSetReport message is sent by the trade repositories to the supervisory authority system, to report aggregated exposures between a pair of counterparties (except reuse report).")]
[IsoId("_YpHNwcKvEeuzU9S_IANlog")]
[DisplayName("Securities Financing Reporting Position Set Report V")]
public partial record SecuritiesFinancingReportingPositionSetReportV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.105.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "SctiesFincgRptgPosSetRpt";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.105.001.01";
    
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
    /// Representation of exposures between a pair of counterparties that comprise positions sets, collateral position sets, currency positions sets and currency collateral position sets.
    /// </summary>
    [IsoId("_YpHNw8KvEeuzU9S_IANlog")]
    [DisplayName("Aggregated Positions")]
    [IsoXmlTag("AggtdPoss")]
    public required PositionSetReport3Choice_ AggregatedPositions { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_YpHNxcKvEeuzU9S_IANlog")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since SecuritiesFinancingReportingPositionSetReportV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to SecuritiesFinancingReportingPositionSetReportV01.

