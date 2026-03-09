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
/// This record is an implementation of the trea.006.001.02 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope
/// The CancelNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the cancellation of the valuation of a non deliverable trade previously confirmed by the sender.
/// Usage
/// The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.
/// </summary>
[Description(@"Scope|The CancelNonDeliverableForwardValuation message is sent by a participant to a central system or to a counterparty to notify the cancellation of the valuation of a non deliverable trade previously confirmed by the sender.|Usage|The message will contain a Related Reference to link it to the previously sent notification. It may contain a reason for cancellation.")]
[IsoId("_MYoUotE8Ed-BzquC8wXy7w_-340131062")]
[DisplayName("Cancel Non Deliverable Forward Valuation V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CancelNonDeliverableForwardValuationV02 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "trea.006.001.02";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "CclNDFValtnV02";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:trea.006.001.02";
    
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
    /// Constructs a CancelNonDeliverableForwardValuationV02 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CancelNonDeliverableForwardValuationV02( TradeAgreement2 reqTradeInformation )
    {
        TradeInformation = reqTradeInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides references and date of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUo9E8Ed-BzquC8wXy7w_-745317673")]
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
    /// Specifies the trading side of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUpNE8Ed-BzquC8wXy7w_200370128")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentification3? TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification3? TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification3? TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUpdE8Ed-BzquC8wXy7w_67383181")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradePartyIdentification3? CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification3? CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification3? CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amounts of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUptE8Ed-BzquC8wXy7w_-761938752")]
    [DisplayName("Trade Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAmts")]
    #endif
    [IsoXmlTag("TradAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountsAndValueDate1? TradeAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate1? TradeAmounts { get; init; } 
    #else
    public AmountsAndValueDate1? TradeAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation rate of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUp9E8Ed-BzquC8wXy7w_-748089195")]
    [DisplayName("Valuation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnRate")]
    #endif
    [IsoXmlTag("ValtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreedRate1? ValuationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1? ValuationRate { get; init; } 
    #else
    public AgreedRate1? ValuationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the valuation information of the valuation of the non deliverable trade which is cancelled.
    /// </summary>
    [IsoId("_MYoUqNE8Ed-BzquC8wXy7w_-750859823")]
    [DisplayName("Valuation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnInf")]
    #endif
    [IsoXmlTag("ValtnInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ValuationData2? ValuationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ValuationData2? ValuationInformation { get; init; } 
    #else
    public ValuationData2? ValuationInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since CancelNonDeliverableForwardValuationV02Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to CancelNonDeliverableForwardValuationV02.

