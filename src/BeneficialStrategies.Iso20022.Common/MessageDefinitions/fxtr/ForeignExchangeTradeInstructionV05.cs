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
/// This record is an implementation of the fxtr.014.001.05 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope|
/// The ForeignExchangeTradeInstruction message is sent by a participant to a central settlement system to notify the creation of the foreign exchange trade agreed by both trading parties.|
/// Usage|
/// The ForeignExchangeTradeInstruction message is sent from a participant to a central settlement system to advise of the creation of a foreign exchange trade.
/// </summary>
[Description(@"Scope||The ForeignExchangeTradeInstruction message is sent by a participant to a central settlement system to notify the creation of the foreign exchange trade agreed by both trading parties.||Usage||The ForeignExchangeTradeInstruction message is sent from a participant to a central settlement system to advise of the creation of a foreign exchange trade.")]
[IsoId("_mJeVLQM-Ee2nqoJcXIhTdw")]
[DisplayName("Foreign Exchange Trade Instruction V")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTradeInstructionV05 : IOuterRecord
{
    
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "fxtr.014.001.05";
    
    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "FXTradInstr";
    
    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:fxtr.014.001.05";
    
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
    /// Constructs a ForeignExchangeTradeInstructionV05 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTradeInstructionV05( TradeAgreement14 reqTradeInformation,TradePartyIdentification8 reqTradingSideIdentification,TradePartyIdentification8 reqCounterpartySideIdentification,AmountsAndValueDate6 reqTradeAmounts,AgreedRate3 reqAgreedRate )
    {
        TradeInformation = reqTradeInformation;
        TradingSideIdentification = reqTradingSideIdentification;
        CounterpartySideIdentification = reqCounterpartySideIdentification;
        TradeAmounts = reqTradeAmounts;
        AgreedRate = reqAgreedRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General information related to the trade.
    /// </summary>
    [IsoId("_mJeVLwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trade Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradInf")]
    #endif
    [IsoXmlTag("TradInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradeAgreement14 TradeInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradeAgreement14 TradeInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeAgreement14 TradeInformation { get; init; } 
    #else
    public TradeAgreement14 TradeInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Party(ies) on the trading side of the trade.
    /// </summary>
    [IsoId("_mJeVMQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trading Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdId")]
    #endif
    [IsoXmlTag("TradgSdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification8 TradingSideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification8 TradingSideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification8 TradingSideIdentification { get; init; } 
    #else
    public TradePartyIdentification8 TradingSideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Party(ies) on the counterparty side of the trade.
    /// </summary>
    [IsoId("_mJeVMwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Counterparty Side Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdId")]
    #endif
    [IsoXmlTag("CtrPtySdId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TradePartyIdentification8 CounterpartySideIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TradePartyIdentification8 CounterpartySideIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradePartyIdentification8 CounterpartySideIdentification { get; init; } 
    #else
    public TradePartyIdentification8 CounterpartySideIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the trade.
    /// </summary>
    [IsoId("_mJeVNQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trade Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradAmts")]
    #endif
    [IsoXmlTag("TradAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountsAndValueDate6 TradeAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountsAndValueDate6 TradeAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate6 TradeAmounts { get; init; } 
    #else
    public AmountsAndValueDate6 TradeAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_mJeVNwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Agreed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrdRate")]
    #endif
    [IsoXmlTag("AgrdRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AgreedRate3 AgreedRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AgreedRate3 AgreedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate3 AgreedRate { get; init; } 
    #else
    public AgreedRate3 AgreedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions for a non deliverable opening or fixing confirmation.
    /// </summary>
    [IsoId("_mJeVOQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Non Deliverable Forward Conditions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NDFConds")]
    #endif
    [IsoXmlTag("NDFConds")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NonDeliverableForwardConditions1? NonDeliverableForwardConditions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NonDeliverableForwardConditions1? NonDeliverableForwardConditions { get; init; } 
    #else
    public NonDeliverableForwardConditions1? NonDeliverableForwardConditions { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement instructions for the amounts received by the trading side.
    /// </summary>
    [IsoId("_mJeVOwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Trading Side Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgSdSttlmInstrs")]
    #endif
    [IsoXmlTag("TradgSdSttlmInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties120? TradingSideSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties120? TradingSideSettlementInstructions { get; init; } 
    #else
    public SettlementParties120? TradingSideSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement instructions for the amounts received by the counterparty.
    /// </summary>
    [IsoId("_mJeVPQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Counterparty Side Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySdSttlmInstrs")]
    #endif
    [IsoXmlTag("CtrPtySdSttlmInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties120? CounterpartySideSettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties120? CounterpartySideSettlementInstructions { get; init; } 
    #else
    public SettlementParties120? CounterpartySideSettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the trade is a block or an individual trade. It also contains supplementary information such as free format information, broker&apos;s identification, dealing branches and references.
    /// </summary>
    [IsoId("_mJeVPwM-Ee2nqoJcXIhTdw")]
    [DisplayName("Optional General Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnlGnlInf")]
    #endif
    [IsoXmlTag("OptnlGnlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GeneralInformation8? OptionalGeneralInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeneralInformation8? OptionalGeneralInformation { get; init; } 
    #else
    public GeneralInformation8? OptionalGeneralInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Information that is to be provided to trade repositories in the context of the regulatory standards around over-the-counter (OTC) derivatives, central counterparties and trade repositories.
    /// </summary>
    [IsoId("_mJeVQQM-Ee2nqoJcXIhTdw")]
    [DisplayName("Regulatory Reporting")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RgltryRptg")]
    #endif
    [IsoXmlTag("RgltryRptg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RegulatoryReporting7? RegulatoryReporting { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RegulatoryReporting7? RegulatoryReporting { get; init; } 
    #else
    public RegulatoryReporting7? RegulatoryReporting { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_mJeVQwM-Ee2nqoJcXIhTdw")]
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


// Since ForeignExchangeTradeInstructionV05Document is not really part of the logical business domain model, 
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to ForeignExchangeTradeInstructionV05.

