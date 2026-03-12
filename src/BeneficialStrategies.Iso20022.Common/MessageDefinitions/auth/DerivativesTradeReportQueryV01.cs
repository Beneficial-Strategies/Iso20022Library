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
/// This record is an implementation of the auth.029.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.
/// </summary>
[Description(@"The DerivativesTradeReportQuery message is sent by the supervisory authority system to the trade repositories, to query data based on the search criteria for the trade transaction as defined by the system user.")]
[IsoId("_wdKwQxWsEeqvRcdYcNYAVw")]
[DisplayName("Derivatives Trade Report Query V")]
public partial record DerivativesTradeReportQueryV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "auth.029.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "DerivsTradRptQry";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:auth.029.001.01";
    
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
    /// Indicates the authority that requests the query report.
    /// </summary>
    [IsoId("_wdKwRRWsEeqvRcdYcNYAVw")]
    [DisplayName("Requesting Authority")]
    [IsoXmlTag("RqstngAuthrty")]
    public required PartyIdentification121Choice_ RequestingAuthority { get; init; } 
    
    /// <summary>
    /// Criteria for defining recurrent and ad-hoc queries.
    /// </summary>
    [IsoId("_wdKwRxWsEeqvRcdYcNYAVw")]
    [DisplayName("Trade Query Data")]
    [IsoXmlTag("TradQryData")]
    public required TradeReportQuery4Choice_ TradeQueryData { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_wdKwSRWsEeqvRcdYcNYAVw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since DerivativesTradeReportQueryV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to DerivativesTradeReportQueryV01.

