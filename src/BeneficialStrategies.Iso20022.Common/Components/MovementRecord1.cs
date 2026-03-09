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
/// Details of a movement record requested in a single settlement instruction. 
/// </summary>
[IsoId("_FhFKIJIhEeu5eNv5D0Izbw")]
[DisplayName("Movement Record")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MovementRecord1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MovementRecord1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MovementRecord1( System.String reqIdentification,AmountAndDirection5 reqAmount )
    {
        Identification = reqIdentification;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the instructing agent, and sent to the market infrastructure to unambiguously identify the specific movement record (transaction) within a settlement request.
    /// Usage: The movement identification is a point to point reference that can be used between the instructing agent and the market infrastructure to refer to the individual movement record within a settlement request. It can be included in several messages related to the movement.
    /// </summary>
    [IsoId("_ehBZgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// An index to identify the individual movement record entry.
    /// </summary>
    [IsoId("_b66S4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? SequenceNumber { get; init; } 
    #else
    public System.UInt64? SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money requested by the instructing agent for settlement at the market infrastructure in a single movement record entry.
    /// </summary>
    [IsoId("_hECv4JIhEeu5eNv5D0Izbw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection5 Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection5 Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection5 Amount { get; init; } 
    #else
    public AmountAndDirection5 Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Agent in whose account the funds settle on behalf of the participant.
    /// </summary>
    [IsoId("_GEsfkJfqEeuFlO6opWbACw")]
    [DisplayName("Settlement Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAgt")]
    #endif
    [IsoXmlTag("SttlmAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? SettlementAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? SettlementAgent { get; init; } 
    #else
    public PartyIdentification135? SettlementAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the settlement agent.
    /// </summary>
    [IsoId("_jbDDgJIhEeu5eNv5D0Izbw")]
    [DisplayName("Settlement Agent Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmAgtAcct")]
    #endif
    [IsoXmlTag("SttlmAgtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? SettlementAgentAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? SettlementAgentAccount { get; init; } 
    #else
    public CashAccount40? SettlementAgentAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of a participant on behalf of which the settlement agent instructs the market infrastructure to settle the obligations using accounts held in the settlement service.
    /// </summary>
    [IsoId("_DF5MIJfqEeuFlO6opWbACw")]
    [DisplayName("Participant")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ptcpt")]
    #endif
    [IsoXmlTag("Ptcpt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification135? Participant { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification135? Participant { get; init; } 
    #else
    public PartyIdentification135? Participant { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of the account of the participant held in the settlement service.
    /// </summary>
    [IsoId("_B7u7UKcuEeuNdKCg1u4vDw")]
    [DisplayName("Participant Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtcptAcct")]
    #endif
    [IsoXmlTag("PtcptAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount40? ParticipantAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount40? ParticipantAccount { get; init; } 
    #else
    public CashAccount40? ParticipantAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Reference information to complement a movement record.
    /// </summary>
    [IsoId("_JW7sYJfqEeuFlO6opWbACw")]
    [DisplayName("Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ref")]
    #endif
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? Reference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reference { get; init; } 
    #else
    public System.String? Reference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
