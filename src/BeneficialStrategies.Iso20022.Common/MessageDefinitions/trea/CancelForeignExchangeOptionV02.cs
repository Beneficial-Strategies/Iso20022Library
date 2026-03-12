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

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif


namespace BeneficialStrategies.Iso20022.trea;

/// <summary>
/// This record is an implementation of the trea.011.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the cancellation of a foreign currency option contract.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.
/// </summary>
[Description(@"Scope|The CancelForeignExchangeOption message is sent by a participant to a central system or to a counterparty to notify the cancellation of a foreign currency option contract.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.|This message is only suitable for Simple (i.e. not Barrier) Vanilla (i.e. not Binary, Digital, Notouch) Foreign Exchange Options.")]
[IsoId("_KP1cKNE8Ed-BzquC8wXy7w_-352671200")]
[DisplayName("Cancel Foreign Exchange Option V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelForeignExchangeOptionV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.011.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclFXOptnV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.011.001.02";
    
    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";
    
    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CancelForeignExchangeOptionV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelForeignExchangeOptionV02( TradeAgreement2 reqTradeInformation )
    {
        TradeInformation = reqTradeInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides reference and date of the foreign exchange option trade which is cancelled.
    /// </summary>
    [IsoId("_KP1cKdE8Ed-BzquC8wXy7w_1862314429")]
    [DisplayName("Trade Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradInf")]
    #endif
    [IsoXmlTag("TradInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeAgreement2 TradeInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeAgreement2 TradeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeAgreement2 TradeInformation { get; init; } 
    #else
    public TradeAgreement2 TradeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading side of the currency option trade which is cancelled.
    /// </summary>
    [IsoId("_KP1cKtE8Ed-BzquC8wXy7w_-332565898")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentification4? TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification4? TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification4? TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty of the currency option trade which is cancelled.
    /// </summary>
    [IsoId("_KP1cK9E8Ed-BzquC8wXy7w_-131240239")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentification4? CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification4? CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification4? CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the parameters of the currency option which is bought by the trading side.
    /// </summary>
    [IsoId("_KP1cLNE8Ed-BzquC8wXy7w_-743534321")]
    [DisplayName("Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Optn")]
    #endif
    [IsoXmlTag("Optn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Option3? Option { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Option3? Option { get; init; } 
    #else
    public Option3? Option { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CancelForeignExchangeOptionV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelForeignExchangeOptionV02.

