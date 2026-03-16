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



namespace BeneficialStrategies.Iso20022.fxtr;

/// <summary>
/// This record is an implementation of the fxtr.032.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_KI2NH3fYEe2I4Iip2NEM0A")]
[DisplayName("Foreign Exchange Trade Capture Report Request V02")]
public partial record ForeignExchangeTradeCaptureReportRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.032.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.032.001.02";
    
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
    /// Query By Period.
    /// </summary>
    [DisplayName("Query By Period")]
    [IsoXmlTag("QryByPrd")]
    public required IsoTrueFalseIndicator QueryByPeriod { get; init; } 
    
    /// <summary>
    /// Query End Identification.
    /// </summary>
    [DisplayName("Query End Identification")]
    [IsoXmlTag("QryEndId")]
    public IsoMax35Text? QueryEndIdentification { get; init; } 
    
    /// <summary>
    /// Query Order Status.
    /// </summary>
    [DisplayName("Query Order Status")]
    [IsoXmlTag("QryOrdrSts")]
    public required QueryOrderStatus1Code QueryOrderStatus { get; init; } 
    
    /// <summary>
    /// Query Page Size.
    /// </summary>
    [DisplayName("Query Page Size")]
    [IsoXmlTag("QryPgSz")]
    public IsoMax35NumericText? QueryPageSize { get; init; } 
    
    /// <summary>
    /// Query Parameter Value.
    /// </summary>
    [DisplayName("Query Parameter Value")]
    [IsoXmlTag("QryParamVal")]
    public IsoMax35Text? QueryParameterValue { get; init; } 
    
    /// <summary>
    /// Query Period.
    /// </summary>
    [DisplayName("Query Period")]
    [IsoXmlTag("QryPrd")]
    public Period12? QueryPeriod { get; init; } 
    
    /// <summary>
    /// Query Request Identification.
    /// </summary>
    [DisplayName("Query Request Identification")]
    [IsoXmlTag("QryReqId")]
    public required MessageIdentification1 QueryRequestIdentification { get; init; } 
    
    /// <summary>
    /// Query Start Number.
    /// </summary>
    [DisplayName("Query Start Number")]
    [IsoXmlTag("QryStartNb")]
    public required IsoMax35NumericText QueryStartNumber { get; init; } 
    
    /// <summary>
    /// Query Trade Identification.
    /// </summary>
    [DisplayName("Query Trade Identification")]
    [IsoXmlTag("QryTradId")]
    public IsoMax35Text? QueryTradeIdentification { get; init; } 
    
    /// <summary>
    /// Query Type.
    /// </summary>
    [DisplayName("Query Type")]
    [IsoXmlTag("QryTp")]
    public QueryDataType1Code? QueryType { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeCaptureReportRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportRequestV02.

