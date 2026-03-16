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
/// This record is an implementation of the fxtr.034.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_KI0-4XfYEe2I4Iip2NEM0A")]
[DisplayName("Foreign Exchange Trade Confirmation Request V02")]
public partial record ForeignExchangeTradeConfirmationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.034.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.034.001.02";
    
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
    /// Confirmation Type.
    /// </summary>
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required ConfirmationRequest1Code ConfirmationType { get; init; } 
    
    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; } 
    
    /// <summary>
    /// Query Period.
    /// </summary>
    [DisplayName("Query Period")]
    [IsoXmlTag("QryPrd")]
    public required Period12 QueryPeriod { get; init; } 
    
    /// <summary>
    /// Query Start Number.
    /// </summary>
    [DisplayName("Query Start Number")]
    [IsoXmlTag("QryStartNb")]
    public required IsoMax35NumericText QueryStartNumber { get; init; } 
    
    /// <summary>
    /// Query Trade Status.
    /// </summary>
    [DisplayName("Query Trade Status")]
    [IsoXmlTag("QryTradSts")]
    public required QueryTradeStatus1Code QueryTradeStatus { get; init; } 
    
    /// <summary>
    /// Request Identification.
    /// </summary>
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    /// <summary>
    /// Trade Detail.
    /// </summary>
    [DisplayName("Trade Detail")]
    [IsoXmlTag("TradDtl")]
    public required Trade9 TradeDetail { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestV02.

