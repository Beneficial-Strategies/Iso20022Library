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
/// This record is an implementation of the fxtr.036.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The ForeignExchangeTradeConfirmationRequestCancellationRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.
/// 
/// Usage
/// The request is sent by the market participants to the CMU after the confirmation is requested.
/// </summary>
[Description(@"Scope|The ForeignExchangeTradeConfirmationRequestCancellationRequest message is sent from a market participant to a Central matching utility (CMU) to amend the ForeignExchangeTradeConfirmationRequest previously sent.||Usage|The request is sent by the market participants to the CMU after the confirmation is requested.")]
[IsoId("_NXUBUoHiEeSY3ulMDfpmvA")]
[DisplayName("Foreign Exchange Trade Confirmation Request Cancellation Request V")]
public partial record ForeignExchangeTradeConfirmationRequestCancellationRequestV01 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.036.001.01";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReqCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.01";
    
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
    [IsoId("_vw3rcIHiEeSY3ulMDfpmvA")]
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; } 
    
    /// <summary>
    /// Identifies the cancellation request messge.
    /// </summary>
    [IsoId("_wBWXcIHiEeSY3ulMDfpmvA")]
    [DisplayName("Cancellation Request Identification")]
    [IsoXmlTag("CxlReqId")]
    public MessageIdentification1? CancellationRequestIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_wPAY8IHiEeSY3ulMDfpmvA")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification7 TradingSideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_wezIcIHiEeSY3ulMDfpmvA")]
    [DisplayName("Counterparty Role Identification")]
    [IsoXmlTag("CtrPtyRoleId")]
    public required TradePartyIdentification7 CounterpartyRoleIdentification { get; init; } 
    
    /// <summary>
    /// Identifier of the trade that needs to be cancelled.
    /// </summary>
    [IsoId("_wvgd8IHiEeSY3ulMDfpmvA")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text TradeIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the underlying product type.
    /// </summary>
    [IsoId("_w_JccIHiEeSY3ulMDfpmvA")]
    [DisplayName("Underlying Product Type")]
    [IsoXmlTag("UndrlygPdctTp")]
    public required UnderlyingProductIdentifier1Code UnderlyingProductType { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_m-4V8KHiEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationRequestCancellationRequestV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestCancellationRequestV01.

