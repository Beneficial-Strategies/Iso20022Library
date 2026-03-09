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
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
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
    
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeTradeConfirmationStatusAdviceV01 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeConfirmationStatusAdviceV01( Header23 reqHeader,TradePartyIdentification7 reqTradingSideIdentification,TradePartyIdentification7 reqCounterpartySideIdentification,Trade2 reqTradeDetail,Confirmation1 reqConfirmationInformation )
    {
        Header = reqHeader;
        TradingSideIdentification = reqTradingSideIdentification;
        CounterpartySideIdentification = reqCounterpartySideIdentification;
        TradeDetail = reqTradeDetail;
        ConfirmationInformation = reqConfirmationInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Advice message management information.
    /// </summary>
    [IsoId("_SxWkUKbSEeSnSIf9q_Ahng")]
    [DisplayName("Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Hdr")]
    #endif
    [IsoXmlTag("Hdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Header23 Header { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Header23 Header { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Header23 Header { get; init; } 
    #else
    public Header23 Header { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the advice message.
    /// </summary>
    [IsoId("_rREcwESAEeStEe_B2dcrqg")]
    [DisplayName("Advice Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AdvcId")]
    #endif
    [IsoXmlTag("AdvcId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MessageIdentification1? AdviceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MessageIdentification1? AdviceIdentification { get; init; } 
    #else
    public MessageIdentification1? AdviceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the trading side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_vtpVwESAEeStEe_B2dcrqg")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification7 TradingSideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification7 TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification7 TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification7 TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the counterparty side of the treasury trade which is captured.
    /// </summary>
    [IsoId("_x6tqQESAEeStEe_B2dcrqg")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification7 CounterpartySideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification7 CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification7 CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification7 CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the treasury trade confirmed.
    /// </summary>
    [IsoId("_2CJZsESAEeStEe_B2dcrqg")]
    [DisplayName("Trade Detail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradDtl")]
    #endif
    [IsoXmlTag("TradDtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Trade2 TradeDetail { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Trade2 TradeDetail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trade2 TradeDetail { get; init; } 
    #else
    public Trade2 TradeDetail { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the confirmation in the CMU.
    /// </summary>
    [IsoId("_4B8HMESAEeStEe_B2dcrqg")]
    [DisplayName("Confirmation Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfInf")]
    #endif
    [IsoXmlTag("ConfInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Confirmation1 ConfirmationInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Confirmation1 ConfirmationInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Confirmation1 ConfirmationInformation { get; init; } 
    #else
    public Confirmation1 ConfirmationInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Additional reference of this message.
    /// </summary>
    [IsoId("_70VawESAEeStEe_B2dcrqg")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalReferences? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalReferences? Reference { get; init; } 
    #else
    public AdditionalReferences? Reference { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_Ab9F4KHmEeS69KkQis5bYg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}


// Since ForeignExchangeTradeConfirmationStatusAdviceV01Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeConfirmationStatusAdviceV01.

