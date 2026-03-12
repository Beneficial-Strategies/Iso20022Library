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
/// This record is an implementation of the fxtr.034.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
///  The ForeignExchangeTradeConfirmationRequest message is sent from a market participant to a Central matching utility (CMU) to request a foreign exchange(spot/forward/swap) trade confirmation.
/// 
/// Usage
/// The confirmation request is sent by the market participants to the CMU after they receiving the capture reports.
/// Note that a confirmation request could be cancelled or amended.
/// </summary>
[Description(@"Scope| The ForeignExchangeTradeConfirmationRequest message is sent from a market participant to a Central matching utility (CMU) to request a foreign exchange(spot/forward/swap) trade confirmation.||Usage|The confirmation request is sent by the market participants to the CMU after they receiving the capture reports.|Note that a confirmation request could be cancelled or amended.")]
[IsoId("_2qmO4ESCEeStEe_B2dcrqg")]
[DisplayName("Foreign Exchange Trade Confirmation Request V")]
public partial record ForeignExchangeTradeConfirmationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.034.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.034.001.01";
    
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
    /// Message management information.
    /// </summary>
    [IsoId("_7SxT4ESCEeStEe_B2dcrqg")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; } 
    
    /// <summary>
    /// Identifies the confirm request messge.
    /// </summary>
    [IsoId("_FSjWwESDEeStEe_B2dcrqg")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; } 
    
    /// <summary>
    /// Details of the treasury trade confirmed.
    /// </summary>
    [IsoId("_IqUj0ESDEeStEe_B2dcrqg")]
    [DisplayName("Trade Detail")]
    [IsoXmlTag("TradDtl")]
    public required Trade2 TradeDetail { get; init; } 
    
    /// <summary>
    /// Identifies the type of confirmation message being sent.
    /// </summary>
    [IsoId("_x4TUcIsWEeS_1fMypAW06w")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required ConfirmationRequest1Code ConfirmationType { get; init; } 
    
    /// <summary>
    /// Period of the inquiry.
    /// </summary>
    [IsoId("_11BnEESpEeSTS-T7FO4CUQ")]
    [DisplayName("Query Period")]
    [IsoXmlTag("QryPrd")]
    public required Period4 QueryPeriod { get; init; } 
    
    /// <summary>
    /// Start number in request result.
    /// </summary>
    [IsoId("_WDuD4KaZEeSR8qifggAitQ")]
    [DisplayName("Query Start Number")]
    [IsoXmlTag("QryStartNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText QueryStartNumber { get; init; } 
    
    /// <summary>
    /// Specifies the inquiry status of the trade.
    /// </summary>
    [IsoId("_15tBMKadEeSR8qifggAitQ")]
    [DisplayName("Query Trade Status")]
    [IsoXmlTag("QryTradSts")]
    public required QueryTradeStatus1Code QueryTradeStatus { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_upa4YKHlEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestV01.

