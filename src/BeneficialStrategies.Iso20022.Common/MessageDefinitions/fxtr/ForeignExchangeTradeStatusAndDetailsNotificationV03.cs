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
/// This record is an implementation of the fxtr.017.001.03 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeStatusAndDetails message is sent by a central system to the participant to provide notification of the status and details of a foreign exchange trade.|
/// Usage|
/// The notification is sent by a central settlement system to the two trading parties after it has received foreign exchange trade instructions from both.
/// </summary>
[Description(@"Scope||The ForeignExchangeTradeStatusAndDetails message is sent by a central system to the participant to provide notification of the status and details of a foreign exchange trade.||Usage||The notification is sent by a central settlement system to the two trading parties after it has received foreign exchange trade instructions from both.")]
[IsoId("_0WwVgTJ5EeOd1OidA-8_VQ")]
[DisplayName("Foreign Exchange Trade Status And Details Notification V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeStatusAndDetailsNotificationV03 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.017.001.03";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradStsAndDtlsNtfctn";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.017.001.03";
    
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
    /// Constructs a ForeignExchangeTradeStatusAndDetailsNotificationV03 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeStatusAndDetailsNotificationV03( TradeData9 reqStatusDetails,TradeAgreement12 reqTradeInformation,TradePartyIdentification6 reqTradingSideIdentification,TradePartyIdentification6 reqCounterpartySideIdentification,AmountsAndValueDate1 reqTradeAmounts,AgreedRate1 reqAgreedRate )
    {
        StatusDetails = reqStatusDetails;
        TradeInformation = reqTradeInformation;
        TradingSideIdentification = reqTradingSideIdentification;
        CounterpartySideIdentification = reqCounterpartySideIdentification;
        TradeAmounts = reqTradeAmounts;
        AgreedRate = reqAgreedRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the central system.
    /// </summary>
    [IsoId("_0WwVhzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Status Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsDtls")]
    #endif
    [IsoXmlTag("StsDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeData9 StatusDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeData9 StatusDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData9 StatusDetails { get; init; } 
    #else
    public TradeData9 StatusDetails { get; set; } 
    #endif
    
    /// <summary>
    /// General information related to the foreign exchange trade.
    /// </summary>
    [IsoId("_0WwViTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trade Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradInf")]
    #endif
    [IsoXmlTag("TradInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeAgreement12 TradeInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeAgreement12 TradeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeAgreement12 TradeInformation { get; init; } 
    #else
    public TradeAgreement12 TradeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party(ies) on the trading side of the foreign exchange trade.
    /// </summary>
    [IsoId("_0WwVizJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification6 TradingSideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification6 TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification6 TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification6 TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party(ies) on the counterparty side of the foreign exchange trade.
    /// </summary>
    [IsoId("_0WwVjTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification6 CounterpartySideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification6 CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification6 CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification6 CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_0WwVjzJ5EeOd1OidA-8_VQ")]
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
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_0WwVkTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Agreed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdRate")]
    #endif
    [IsoXmlTag("AgrdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate1 AgreedRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate1 AgreedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate1 AgreedRate { get; init; } 
    #else
    public AgreedRate1 AgreedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_0WwVkzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Trading Side Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdSttlmInstrs")]
    #endif
    [IsoXmlTag("TradgSdSttlmInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties29? TradingSideSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties29? TradingSideSettlementInstructions { get; init; } 
    #else
    public SettlementParties29? TradingSideSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_0WwVlTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Counterparty Side Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdSttlmInstrs")]
    #endif
    [IsoXmlTag("CtrPtySdSttlmInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties29? CounterpartySideSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties29? CounterpartySideSettlementInstructions { get; init; } 
    #else
    public SettlementParties29? CounterpartySideSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Additional Information about the foreign exchange trade.
    /// </summary>
    [IsoId("_0WwVlzJ5EeOd1OidA-8_VQ")]
    [DisplayName("General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlInf")]
    #endif
    [IsoXmlTag("GnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GeneralInformation4? GeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeneralInformation4? GeneralInformation { get; init; } 
    #else
    public GeneralInformation4? GeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the split trade.
    /// </summary>
    [IsoId("_0WwVmTJ5EeOd1OidA-8_VQ")]
    [DisplayName("Split Trade Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpltTradInf")]
    #endif
    [IsoXmlTag("SpltTradInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SplitTradeDetails1? SplitTradeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SplitTradeDetails1? SplitTradeInformation { get; init; } 
    #else
    public SplitTradeDetails1? SplitTradeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_0WwVmzJ5EeOd1OidA-8_VQ")]
    [DisplayName("Regulatory Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRptg")]
    #endif
    [IsoXmlTag("RgltryRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryReporting4? RegulatoryReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryReporting4? RegulatoryReporting { get; init; } 
    #else
    public RegulatoryReporting4? RegulatoryReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_0WwVnTJ5EeOd1OidA-8_VQ")]
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


// Since ForeignExchangeTradeStatusAndDetailsNotificationV03Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeStatusAndDetailsNotificationV03.

