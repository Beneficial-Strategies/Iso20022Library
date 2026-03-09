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
/// Describes the amount, direction and parties involved in a payment obligation between two participants (and their netting group or trading party) of a netting service.
/// </summary>
[IsoId("_Chfq8QN1Ee2-vqzwMUAewg")]
[DisplayName("Net Obligation")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NetObligation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NetObligation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NetObligation2( System.String reqObligationIdentification,ActiveCurrencyAndAmount reqAmount,NettingIdentification2Choice_ reqParticipantNettingIdentification,PaymentReceipt1Code reqObligationDirection,NettingIdentification2Choice_ reqCounterpartyNettingIdentification )
    {
        ObligationIdentification = reqObligationIdentification;
        Amount = reqAmount;
        ParticipantNettingIdentification = reqParticipantNettingIdentification;
        ObligationDirection = reqObligationDirection;
        CounterpartyNettingIdentification = reqCounterpartyNettingIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification for the obligation.
    /// </summary>
    [IsoId("_CnI_9QN1Ee2-vqzwMUAewg")]
    [DisplayName("Obligation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtnId")]
    #endif
    [IsoXmlTag("OblgtnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text ObligationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ObligationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ObligationIdentification { get; init; } 
    #else
    public System.String ObligationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the obligation.
    /// </summary>
    [IsoId("_CnI_9wN1Ee2-vqzwMUAewg")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount Amount { get; init; } 
    #else
    public ActiveCurrencyAndAmount Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the party or netting group (of the participant receiving the report) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("_CnI_-QN1Ee2-vqzwMUAewg")]
    [DisplayName("Participant Netting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptNetgId")]
    #endif
    [IsoXmlTag("PtcptNetgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingIdentification2Choice_ ParticipantNettingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NettingIdentification2Choice_ ParticipantNettingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingIdentification2Choice_ ParticipantNettingIdentification { get; init; } 
    #else
    public NettingIdentification2Choice_ ParticipantNettingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the direction of the obligation.
    /// </summary>
    [IsoId("_CnI_-wN1Ee2-vqzwMUAewg")]
    [DisplayName("Obligation Direction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OblgtnDrctn")]
    #endif
    [IsoXmlTag("OblgtnDrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentReceipt1Code ObligationDirection { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentReceipt1Code ObligationDirection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReceipt1Code ObligationDirection { get; init; } 
    #else
    public PaymentReceipt1Code ObligationDirection { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the party or netting group (of the counterparty in the obligation) involved in the calculation of the obligation.
    /// </summary>
    [IsoId("_CnI__QN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Netting Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyNetgId")]
    #endif
    [IsoXmlTag("CtrPtyNetgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NettingIdentification2Choice_ CounterpartyNettingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NettingIdentification2Choice_ CounterpartyNettingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NettingIdentification2Choice_ CounterpartyNettingIdentification { get; init; } 
    #else
    public NettingIdentification2Choice_ CounterpartyNettingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the counterparty participant involved in the obligation.
    /// </summary>
    [IsoId("_CnI__wN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Counterparty Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetSvcCtrPtyId")]
    #endif
    [IsoXmlTag("NetSvcCtrPtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; init; } 
    #else
    public PartyIdentification242Choice_? NetServiceCounterpartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the standard settlement instructions used to issue a payment to the counterparty in order to settle the obligation.
    /// </summary>
    [IsoId("_CnJAAQN1Ee2-vqzwMUAewg")]
    [DisplayName("Counterparty Settlement Instructions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtySttlmInstrs")]
    #endif
    [IsoXmlTag("CtrPtySttlmInstrs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementParties120? CounterpartySettlementInstructions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementParties120? CounterpartySettlementInstructions { get; init; } 
    #else
    public SettlementParties120? CounterpartySettlementInstructions { get; set; } 
    #endif
    
    /// <summary>
    /// Number of transactions used to calculate the obligation. This is used in reconciliation between the net report obligation and the previously provided transaction status updates.
    /// </summary>
    [IsoId("_CnJAAwN1Ee2-vqzwMUAewg")]
    [DisplayName("Transactions Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxsNb")]
    #endif
    [IsoXmlTag("TxsNb")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10NumericText? TransactionsNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionsNumber { get; init; } 
    #else
    public System.String? TransactionsNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
