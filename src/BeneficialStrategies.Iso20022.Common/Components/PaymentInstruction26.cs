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
/// Provides details on the payment instruction.
/// </summary>
[IsoId("_NZNuIZlPEee-Zps0fZQaFQ")]
[DisplayName("Payment Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentInstruction26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original payment transaction message|Usage: this is the former TransactionReference.
    /// </summary>
    [IsoId("_NhZZs5lPEee-Zps0fZQaFQ")]
    [DisplayName("Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgId")]
    #endif
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MessageIdentification { get; init; } 
    #else
    public System.String? MessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the cash is at the disposal of the credit account owner, or ceases to be at the disposal of the debit account owner.
    /// </summary>
    [IsoId("_NhZZtZlPEee-Zps0fZQaFQ")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    #else
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the status of a transfer.||.
    /// </summary>
    [IsoId("_NhZZt5lPEee-Zps0fZQaFQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatus3? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatus3? Status { get; init; } 
    #else
    public PaymentStatus3? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    [IsoId("_NhZZuZlPEee-Zps0fZQaFQ")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount3Choice_? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount3Choice_? InstructedAmount { get; init; } 
    #else
    public Amount3Choice_? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_NhZZu5lPEee-Zps0fZQaFQ")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Amount2Choice_? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Amount2Choice_? InterbankSettlementAmount { get; init; } 
    #else
    public Amount2Choice_? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    [IsoId("_NhZZvZlPEee-Zps0fZQaFQ")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max10Text)]
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [IsoId("_NhZZv5lPEee-Zps0fZQaFQ")]
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
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    [IsoId("_NhZZwZlPEee-Zps0fZQaFQ")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriorityCode3Choice_? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriorityCode3Choice_? Priority { get; init; } 
    #else
    public PriorityCode3Choice_? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time range within which the payment instruction must be processed.|.
    /// </summary>
    [IsoId("_NhZZw5lPEee-Zps0fZQaFQ")]
    [DisplayName("Processing Validity Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrcgVldtyTm")]
    #endif
    [IsoXmlTag("PrcgVldtyTm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; init; } 
    #else
    public DateTimePeriod1Choice_? ProcessingValidityTime { get; set; } 
    #endif
    
    /// <summary>
    /// Copy of the original instruction, in free form text.
    /// </summary>
    [IsoId("_NhZZxZlPEee-Zps0fZQaFQ")]
    [DisplayName("Instruction Copy")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrCpy")]
    #endif
    [IsoXmlTag("InstrCpy")]
    [IsoSimpleType(IsoSimpleType.Max20000Text)]
    [StringLength(maximumLength: 20000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax20000Text? InstructionCopy { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionCopy { get; init; } 
    #else
    public System.String? InstructionCopy { get; set; } 
    #endif
    
    /// <summary>
    /// Type, or nature, of the payment, such as express payment.|.
    /// </summary>
    [IsoId("_NhZZx5lPEee-Zps0fZQaFQ")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentType4Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentType4Choice_? Type { get; init; } 
    #else
    public PaymentType4Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Payment is a liquidity transfer order that has been executed automatically following a predefined or standing order.
    /// </summary>
    [IsoId("_NhZZyZlPEee-Zps0fZQaFQ")]
    [DisplayName("Generated Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnrtdOrdr")]
    #endif
    [IsoXmlTag("GnrtdOrdr")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? GeneratedOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? GeneratedOrder { get; init; } 
    #else
    public System.String? GeneratedOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.
    /// Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.
    /// Usage: This is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_NhZZy5lPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionIdentification { get; init; } 
    #else
    public System.String? TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_NhZZzZlPEee-Zps0fZQaFQ")]
    [DisplayName("Interbank Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmDt")]
    #endif
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? InterbankSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? InterbankSettlementDate { get; init; } 
    #else
    public System.DateOnly? InterbankSettlementDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.
    /// It can be included in several messages related to the transaction.
    /// Usage: This is the former related reference.
    /// </summary>
    [IsoId("_NhZZz5lPEee-Zps0fZQaFQ")]
    [DisplayName("End To End Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EndToEndId")]
    #endif
    [IsoXmlTag("EndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? EndToEndIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EndToEndIdentification { get; init; } 
    #else
    public System.String? EndToEndIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the party fields used to search for a payment.
    /// </summary>
    [IsoId("_NhZZ0ZlPEee-Zps0fZQaFQ")]
    [DisplayName("Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Pties")]
    #endif
    [IsoXmlTag("Pties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionParty2? Parties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionParty2? Parties { get; init; } 
    #else
    public PaymentTransactionParty2? Parties { get; set; } 
    #endif
    
    
    #nullable disable
    
}
