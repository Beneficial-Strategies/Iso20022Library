// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the negotiation process leading to a treasury trade.
/// </summary>
[IsoId("_BjP6AQN1Ee2-vqzwMUAewg")]
[DisplayName("General Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralInformation8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the trade is a block or single trade.
    /// </summary>
    [IsoId("_BowsIQN1Ee2-vqzwMUAewg")]
    [DisplayName("Block Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckInd")]
    #endif
    [IsoXmlTag("BlckInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BlockIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockIndicator { get; init; } 
    #else
    public System.String? BlockIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference to a preceding transaction, for example, an option or swap.
    /// </summary>
    [IsoId("_BowsIwN1Ee2-vqzwMUAewg")]
    [DisplayName("Related Trade Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdTradRef")]
    #endif
    [IsoXmlTag("RltdTradRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedTradeReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedTradeReference { get; init; } 
    #else
    public System.String? RelatedTradeReference { get; set; } 
    #endif
    
    /// <summary>
    /// Method used by the trading parties to negotiate and/or execute a deal.
    /// </summary>
    [IsoId("_BowsJQN1Ee2-vqzwMUAewg")]
    [DisplayName("Dealing Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgMtd")]
    #endif
    [IsoXmlTag("DealgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Trading1MethodCode? DealingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Trading1MethodCode? DealingMethod { get; init; } 
    #else
    public Trading1MethodCode? DealingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the broker which arranged the deal between the trading side and the counterparty side or, when two money brokers are involved, between the trading side and the other money broker.
    /// </summary>
    [IsoId("_BowsJwN1Ee2-vqzwMUAewg")]
    [DisplayName("Broker Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrId")]
    #endif
    [IsoXmlTag("BrkrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? BrokerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? BrokerIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_? BrokerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Counterparty&apos;s reference for the trade.
    /// </summary>
    [IsoId("_BowsKQN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyRef")]
    #endif
    [IsoXmlTag("CtrPtyRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CounterpartyReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterpartyReference { get; init; } 
    #else
    public System.String? CounterpartyReference { get; set; } 
    #endif
    
    /// <summary>
    /// Brokerage fee for a broker confirmation.
    /// </summary>
    [IsoId("_BowsKwN1Ee2-vqzwMUAewg")]
    [DisplayName("Brokers Commission")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrsComssn")]
    #endif
    [IsoXmlTag("BrkrsComssn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? BrokersCommission { get; init; } 
    #else
    public ActiveCurrencyAndAmount? BrokersCommission { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies additional information for the receiver and applies to the whole message.
    /// </summary>
    [IsoId("_BowsLQN1Ee2-vqzwMUAewg")]
    [DisplayName("Sender To Receiver Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrToRcvrInf")]
    #endif
    [IsoXmlTag("SndrToRcvrInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax210Text? SenderToReceiverInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SenderToReceiverInformation { get; init; } 
    #else
    public System.String? SenderToReceiverInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the branch at the trading side with which the deal was done.
    /// </summary>
    [IsoId("_BowsLwN1Ee2-vqzwMUAewg")]
    [DisplayName("Dealing Branch Trading Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgBrnchTradgSd")]
    #endif
    [IsoXmlTag("DealgBrnchTradgSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? DealingBranchTradingSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? DealingBranchTradingSide { get; init; } 
    #else
    public PartyIdentification242Choice_? DealingBranchTradingSide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the branch at the counterparty side with which the deal was done.
    /// </summary>
    [IsoId("_BowsMQN1Ee2-vqzwMUAewg")]
    [DisplayName("Dealing Branch Counterparty Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DealgBrnchCtrPtySd")]
    #endif
    [IsoXmlTag("DealgBrnchCtrPtySd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? DealingBranchCounterpartySide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? DealingBranchCounterpartySide { get; init; } 
    #else
    public PartyIdentification242Choice_? DealingBranchCounterpartySide { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the name and/or electronic address of the receiver of the message who may be contacted for any queries concerning this trade.
    /// </summary>
    [IsoId("_BowsMwN1Ee2-vqzwMUAewg")]
    [DisplayName("Contact Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctInf")]
    #endif
    [IsoXmlTag("CtctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContactInformation1? ContactInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContactInformation1? ContactInformation { get; init; } 
    #else
    public ContactInformation1? ContactInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type, date and version of the agreement used in a trade.
    /// </summary>
    [IsoId("_BowsNQN1Ee2-vqzwMUAewg")]
    [DisplayName("Agreement Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgrmtDtls")]
    #endif
    [IsoXmlTag("AgrmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreementConditions1? AgreementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreementConditions1? AgreementDetails { get; init; } 
    #else
    public AgreementConditions1? AgreementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the year of definitions of the agreement.
    /// </summary>
    [IsoId("_BowsNwN1Ee2-vqzwMUAewg")]
    [DisplayName("Definitions Year")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DefsYr")]
    #endif
    [IsoXmlTag("DefsYr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOYear? DefinitionsYear { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt16? DefinitionsYear { get; init; } 
    #else
    public System.UInt16? DefinitionsYear { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a reference applied to the trade instruction by a broker.
    /// </summary>
    [IsoId("_BowsOQN1Ee2-vqzwMUAewg")]
    [DisplayName("Brokers Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BrkrsRef")]
    #endif
    [IsoXmlTag("BrkrsRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BrokersReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BrokersReference { get; init; } 
    #else
    public System.String? BrokersReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
