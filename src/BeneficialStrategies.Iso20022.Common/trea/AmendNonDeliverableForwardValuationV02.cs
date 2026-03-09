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
/// This record is an implementation of the trea.005.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The AmendNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the amendment of the valuation of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message is sent from a participant to a central settlement system to advise of the update of a previously sent notification and it contains a &quot;Related Reference&quot; to link it to the previous notification.
/// </summary>
[Description(@"Scope|The AmendNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the amendment of the valuation of a non deliverable trade previously confirmed by the sender.|Usage|The message is sent from a participant to a central settlement system to advise of the update of a previously sent notification and it contains a ""Related Reference"" to link it to the previous notification.")]
[IsoId("_JckzONE8Ed-BzquC8wXy7w_-1127631553")]
[DisplayName("Amend Non Deliverable Forward Valuation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmendNonDeliverableForwardValuationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.005.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "AmdNDFValtnV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.005.001.02";
    
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
    /// Constructs a AmendNonDeliverableForwardValuationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmendNonDeliverableForwardValuationV02( TradeAgreement2 reqTradeInformation,TradePartyIdentification3 reqTradingSideIdentification,TradePartyIdentification3 reqCounterpartySideIdentification,AmountsAndValueDate1 reqTradeAmounts,AgreedRate1 reqValuationRate,ValuationData2 reqValuationInformation )
    {
        TradeInformation = reqTradeInformation;
        TradingSideIdentification = reqTradingSideIdentification;
        CounterpartySideIdentification = reqCounterpartySideIdentification;
        TradeAmounts = reqTradeAmounts;
        ValuationRate = reqValuationRate;
        ValuationInformation = reqValuationInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides references and date of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JckzOdE8Ed-BzquC8wXy7w_-1108779628")]
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
    /// Specifies the trading side of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JckzOtE8Ed-BzquC8wXy7w_-1401408196")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification3 TradingSideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification3 TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification3 TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification3 TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JckzO9E8Ed-BzquC8wXy7w_-2032175429")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification3 CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification3 CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification3 CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amounts of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JcukMNE8Ed-BzquC8wXy7w_-2028607038")]
    [DisplayName("Trade Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAmts")]
    #endif
    [IsoXmlTag("TradAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate1 TradeAmounts { get; init; } 
    #else
    public AmountsAndValueDate1 TradeAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation rate of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JcukMdE8Ed-BzquC8wXy7w_-1317493499")]
    [DisplayName("Valuation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRate")]
    #endif
    [IsoXmlTag("ValtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate1 ValuationRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate1 ValuationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1 ValuationRate { get; init; } 
    #else
    public AgreedRate1 ValuationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation information of the valuation of the non deliverable trade which is amended.
    /// </summary>
    [IsoId("_JcukMtE8Ed-BzquC8wXy7w_-1709991694")]
    [DisplayName("Valuation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnInf")]
    #endif
    [IsoXmlTag("ValtnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ValuationData2 ValuationInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ValuationData2 ValuationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationData2 ValuationInformation { get; init; } 
    #else
    public ValuationData2 ValuationInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since AmendNonDeliverableForwardValuationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to AmendNonDeliverableForwardValuationV02.

