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
/// This record is an implementation of the fxtr.036.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// </summary>
[IsoId("_KI0X0XfYEe2I4Iip2NEM0A")]
[DisplayName("Foreign Exchange Trade Confirmation Request Cancellation Request V02")]
public partial record ForeignExchangeTradeConfirmationRequestCancellationRequestV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.036.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradConfReqCxlReq";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.036.001.02";
    
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
    /// Cancellation Request Identification.
    /// </summary>
    [DisplayName("Cancellation Request Identification")]
    [IsoXmlTag("CxlReqId")]
    public MessageIdentification1? CancellationRequestIdentification { get; init; } 
    
    /// <summary>
    /// Counterparty Role Identification.
    /// </summary>
    [DisplayName("Counterparty Role Identification")]
    [IsoXmlTag("CtrPtyRoleId")]
    public required TradePartyIdentification9 CounterpartyRoleIdentification { get; init; } 
    
    /// <summary>
    /// Header.
    /// </summary>
    [DisplayName("Header")]
    [IsoXmlTag("Hdr")]
    public required Header23 Header { get; init; } 
    
    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
    
    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public required IsoMax35Text TradeIdentification { get; init; } 
    
    /// <summary>
    /// Trading Side Identification.
    /// </summary>
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification9 TradingSideIdentification { get; init; } 
    
    /// <summary>
    /// Underlying Product Type.
    /// </summary>
    [DisplayName("Underlying Product Type")]
    [IsoXmlTag("UndrlygPdctTp")]
    public required UnderlyingProductIdentifier1Code UnderlyingProductType { get; init; } 
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationRequestCancellationRequestV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationRequestCancellationRequestV02.

