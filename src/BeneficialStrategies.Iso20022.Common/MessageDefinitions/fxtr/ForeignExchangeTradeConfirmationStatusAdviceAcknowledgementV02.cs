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
/// This record is an implementation of the fxtr.038.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_KI1l8XfYEe2I4Iip2NEM0A")]
[DisplayName("Foreign Exchange Trade Confirmation Status Advice Acknowledgement V02")]
public partial record ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.038.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfStsAdvcAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.038.001.02";
    
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
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation5? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Advice Acknowledgement Identification.
    /// </summary>
    [DisplayName("Advice Acknowledgement Identification")]
    [IsoXmlTag("AdvcAckId")]
    public MessageIdentification1? AdviceAcknowledgementIdentification { get; init; } 
    
    /// <summary>
    /// Affirmation Status.
    /// </summary>
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public required AffirmStatus1Code AffirmationStatus { get; init; } 
    
    /// <summary>
    /// Confirmation Status.
    /// </summary>
    [DisplayName("Confirmation Status")]
    [IsoXmlTag("ConfSts")]
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; } 
    
    /// <summary>
    /// Market Identification.
    /// </summary>
    [DisplayName("Market Identification")]
    [IsoXmlTag("MktId")]
    public required MarketIdentification88 MarketIdentification { get; init; } 
    
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
    /// Trade Date.
    /// </summary>
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public required IsoISODate TradeDate { get; init; } 
    
    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public required IsoMax35Text TradeIdentification { get; init; } 
    
    /// <summary>
    /// Trading Mode.
    /// </summary>
    [DisplayName("Trading Mode")]
    [IsoXmlTag("TradgMd")]
    public required TradingModeType1Code TradingMode { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationStatusAdviceAcknowledgementV02.

