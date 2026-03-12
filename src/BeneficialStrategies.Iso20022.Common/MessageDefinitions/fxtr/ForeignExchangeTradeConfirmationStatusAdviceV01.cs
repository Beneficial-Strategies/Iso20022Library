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
/// This record is an implementation of the fxtr.037.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchageTradeConfirmationStatusAdvice message is sent from a Central matching utility (CMU) to a market participant to advise the matching status of the trade. 
/// 
/// Usage
/// The confirmation status advice is sent by the CMU to the market participants after they received the confirmation request.
/// </summary>
[Description(@"Scope|The ForeignExchageTradeConfirmationStatusAdvice message is sent from a Central matching utility (CMU) to a market participant to advise the matching status of the trade. ||Usage|The confirmation status advice is sent by the CMU to the market participants after they received the confirmation request.")]
[IsoId("_giUbEESAEeStEe_B2dcrqg")]
[DisplayName("Foreign Exchange Trade Confirmation Status Advice V")]
public partial record ForeignExchangeTradeConfirmationStatusAdviceV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.037.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfStsAdvc";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.037.001.01";
    
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
    /// Advice message management information.
    /// </summary>
    [IsoId("_SxWkUKbSEeSnSIf9q_Ahng")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; } 
    
    /// <summary>
    /// Identifies the advice message.
    /// </summary>
    [IsoId("_rREcwESAEeStEe_B2dcrqg")]
    [DisplayName("Advice Identification")]
    [IsoXmlTag("AdvcId")]
    public MessageIdentification1? AdviceIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_vtpVwESAEeStEe_B2dcrqg")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification7 TradingSideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_x6tqQESAEeStEe_B2dcrqg")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification7 CounterpartySideIdentification { get; init; } 
    
    /// <summary>
    /// Details of the treasury trade confirmed.
    /// </summary>
    [IsoId("_2CJZsESAEeStEe_B2dcrqg")]
    [DisplayName("Trade Detail")]
    [IsoXmlTag("TradDtl")]
    public required Trade2 TradeDetail { get; init; } 
    
    /// <summary>
    /// Details of the confirmation in the CMU.
    /// </summary>
    [IsoId("_4B8HMESAEeStEe_B2dcrqg")]
    [DisplayName("Confirmation Information")]
    [IsoXmlTag("ConfInf")]
    public required Confirmation1 ConfirmationInformation { get; init; } 
    
    /// <summary>
    /// Additional reference of this message.
    /// </summary>
    [IsoId("_70VawESAEeStEe_B2dcrqg")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    public AdditionalReferences? Reference { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ab9F4KHmEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationStatusAdviceV01.

