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



namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// This record is an implementation of the trea.009.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CreateForeignExchangeOption message is sent by a participant to a central system or to a counterparty to confirm a foreign currency option contract.
/// Usage
/// Both trading parties will send a notification to the central settlement system. The central settlement system will then send a ForeignExchangeOptionNotification to both.
/// This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.
/// </summary>
[Description(@"Scope|The CreateForeignExchangeOption message is sent by a participant to a central system or to a counterparty to confirm a foreign currency option contract.|Usage|Both trading parties will send a notification to the central settlement system. The central settlement system will then send a ForeignExchangeOptionNotification to both.|This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.")]
[IsoId("_NMokeNE8Ed-BzquC8wXy7w_-2015071704")]
[DisplayName("Create Foreign Exchange Option V")]
public partial record CreateForeignExchangeOptionV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.009.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CretFXOptnV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.009.001.02";
    
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
    /// Provides identification and date of the foreign exchange option trade which is created.
    /// </summary>
    [IsoId("_NMokedE8Ed-BzquC8wXy7w_538111256")]
    [DisplayName("Trade Information")]
    [IsoXmlTag("TradInf")]
    public required TradeAgreement1 TradeInformation { get; init; } 
    
    /// <summary>
    /// Specifies the trading side of the currency option trade which is created.
    /// </summary>
    [IsoId("_NMoketE8Ed-BzquC8wXy7w_-1232874677")]
    [DisplayName("Trading Side Identification")]
    [IsoXmlTag("TradgSdId")]
    public required TradePartyIdentification4 TradingSideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the counterparty of the currency option trade which is created.
    /// </summary>
    [IsoId("_NMoke9E8Ed-BzquC8wXy7w_-1637375932")]
    [DisplayName("Counterparty Side Identification")]
    [IsoXmlTag("CtrPtySdId")]
    public required TradePartyIdentification4 CounterpartySideIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the parameters of the currency option which is sold by the trading side.
    /// </summary>
    [IsoId("_NMxuYNE8Ed-BzquC8wXy7w_2080302723")]
    [DisplayName("Option")]
    [IsoXmlTag("Optn")]
    public required Option3 Option { get; init; } 
    
    
    #nullable disable
    
}


// Since CreateForeignExchangeOptionV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CreateForeignExchangeOptionV02.

