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
/// This record is an implementation of the fxtr.033.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeCaptureReportAcknowledgement message is sent by trading members to the trading system for notifying the trade capture report is received.
/// 
/// Usage
/// The acknowledgement is sent by the trading member to the trading system after they received the trade capture report. 
/// Note that one capture acknowledgement responds to one capture report.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeCaptureReportAcknowledgement message is sent by trading members to the trading system for notifying the trade capture report is received.||Usage|The acknowledgement is sent by the trading member to the trading system after they received the trade capture report. |Note that one capture acknowledgement responds to one capture report.")]
[IsoId("_5_POYHO0EeSG-OV0nXMl5w")]
[DisplayName("Foreign Exchange Trade Capture Report Acknowledgement V")]
public partial record ForeignExchangeTradeCaptureReportAcknowledgementV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.033.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradCaptrRptAck";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.033.001.01";
    
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
    /// Identifies the acknowledgement message.
    /// </summary>
    [IsoId("_BoI5cHO1EeSG-OV0nXMl5w")]
    [DisplayName("Acknowledgement Identification")]
    [IsoXmlTag("AckId")]
    public MessageIdentification1? AcknowledgementIdentification { get; init; } 
    
    /// <summary>
    /// Unique reference identification assigned to the trade by the instructing party. This reference will be used throughout the trade life cycle to identify the particular trade.
    /// </summary>
    [IsoId("_EnLdcHO1EeSG-OV0nXMl5w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeIdentification { get; init; } 
    
    /// <summary>
    /// Acknowlegement status of recevied trade capture report.
    /// </summary>
    [IsoId("_I7vC4HO1EeSG-OV0nXMl5w")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status5Code Status { get; init; } 
    
    /// <summary>
    /// Reference of the acknowledge, specifies the message this acknowledge responds to.
    /// </summary>
    [IsoId("_OS-0YHO1EeSG-OV0nXMl5w")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public AdditionalReferences? Reference { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_ankbAKHiEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeCaptureReportAcknowledgementV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeCaptureReportAcknowledgementV01.

