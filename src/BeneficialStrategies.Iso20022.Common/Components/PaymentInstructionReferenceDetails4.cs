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
/// Identifies a payment instruction by a set of characteristics (as per EBA system requirements) which provides an unambiguous identification of the instruction.
/// </summary>
[IsoId("_Pirv4Np-Ed-ak6NoX_4Aeg_624722546")]
[DisplayName("Payment Instruction Reference Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstructionReferenceDetails4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentInstructionReferenceDetails4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentInstructionReferenceDetails4( System.String reqPaymentInstructionReference,ImpliedCurrencyAndAmount reqInterbankSettlementAmount,System.DateOnly reqInterbankValueDate,System.String reqInstructingAgentIdentification,System.String reqInstructedAgentIdentification )
    {
        PaymentInstructionReference = reqPaymentInstructionReference;
        InterbankSettlementAmount = reqInterbankSettlementAmount;
        InterbankValueDate = reqInterbankValueDate;
        InstructingAgentIdentification = reqInstructingAgentIdentification;
        InstructedAgentIdentification = reqInstructedAgentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
    /// </summary>
    [IsoId("_Pirv4dp-Ed-ak6NoX_4Aeg_624722548")]
    [DisplayName("Payment Instruction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtInstrRef")]
    #endif
    [IsoXmlTag("PmtInstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text PaymentInstructionReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PaymentInstructionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PaymentInstructionReference { get; init; } 
    #else
    public System.String PaymentInstructionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_Pirv4tp-Ed-ak6NoX_4Aeg_624722616")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    #else
    public ImpliedCurrencyAndAmount InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_Pirv49p-Ed-ak6NoX_4Aeg_624722581")]
    [DisplayName("Interbank Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkValDt")]
    #endif
    [IsoXmlTag("IntrBkValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODate InterbankValueDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateOnly InterbankValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly InterbankValueDate { get; init; } 
    #else
    public System.DateOnly InterbankValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// The message type with which the instruction has been initiated.
    /// </summary>
    [IsoId("_Pirv5Np-Ed-ak6NoX_4Aeg_624722858")]
    [DisplayName("Payment Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtMtd")]
    #endif
    [IsoXmlTag("PmtMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    #else
    public PaymentOrigin1Choice_? PaymentMethod { get; set; } 
    #endif
    
    /// <summary>
    /// The identification of the instructing agent that transmitted the payment instruction.
    /// </summary>
    [IsoId("_Pirv5dp-Ed-ak6NoX_4Aeg_624722918")]
    [DisplayName("Instructing Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstgAgtId")]
    #endif
    [IsoXmlTag("InstgAgtId")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBICIdentifier InstructingAgentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstructingAgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructingAgentIdentification { get; init; } 
    #else
    public System.String InstructingAgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// The identification of the instructed agent in the payment instruction.
    /// </summary>
    [IsoId("_Pirv5tp-Ed-ak6NoX_4Aeg_624722953")]
    [DisplayName("Instructed Agent Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgtId")]
    #endif
    [IsoXmlTag("InstdAgtId")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBICIdentifier InstructedAgentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InstructedAgentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InstructedAgentIdentification { get; init; } 
    #else
    public System.String InstructedAgentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// An optional qualifier providing additional system specific information about the entry.||Usage:
    /// </summary>
    [IsoId("_Pirv59p-Ed-ak6NoX_4Aeg_1458662443")]
    [DisplayName("Entry Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtryTp")]
    #endif
    [IsoXmlTag("NtryTp")]
    [IsoSimpleType(IsoSimpleType.EntryTypeIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoEntryTypeIdentifier? EntryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntryType { get; init; } 
    #else
    public System.String? EntryType { get; set; } 
    #endif
    
    /// <summary>
    /// The related reference as stipulated in the payment instruction.
    /// </summary>
    [IsoId("_Pirv6Np-Ed-ak6NoX_4Aeg_624722893")]
    [DisplayName("Related Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdRef")]
    #endif
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RelatedReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RelatedReference { get; init; } 
    #else
    public System.String? RelatedReference { get; set; } 
    #endif
    
    
    #nullable disable
    
}
