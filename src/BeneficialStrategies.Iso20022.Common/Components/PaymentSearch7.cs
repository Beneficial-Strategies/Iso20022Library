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
/// Defines the criteria used to search for a payment.
/// </summary>
[IsoId("_VKVrmZlQEee-Zps0fZQaFQ")]
[DisplayName("Payment Search")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentSearch7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the original initiating party, to unambiguously identify the original payment transaction message. |Usage: this is the former transaction reference.
    /// </summary>
    [IsoId("_VShXP5lQEee-Zps0fZQaFQ")]
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
    [IsoId("_VShXQZlQEee-Zps0fZQaFQ")]
    [DisplayName("Requested Execution Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdExctnDt")]
    #endif
    [IsoXmlTag("ReqdExctnDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTimeSearch3Choice_? RequestedExecutionDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTimeSearch3Choice_? RequestedExecutionDate { get; init; } 
    #else
    public DateAndDateTimeSearch3Choice_? RequestedExecutionDate { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.|.
    /// </summary>
    [IsoId("_VShXQ5lQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentIdentification5Choice_? PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification5Choice_? PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification5Choice_? PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed information about the status of a transfer.||.
    /// </summary>
    [IsoId("_VShXRZlQEee-Zps0fZQaFQ")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstructionStatusSearch4? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructionStatusSearch4? Status { get; init; } 
    #else
    public InstructionStatusSearch4? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the instructed amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_VShXR5lQEee-Zps0fZQaFQ")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricAmountRange2Choice_? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricAmountRange2Choice_? InstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricAmountRange2Choice_? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the instructed amount is expressed.
    /// </summary>
    [IsoId("_VShXSZlQEee-Zps0fZQaFQ")]
    [DisplayName("Instructed Amount Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmtCcy")]
    #endif
    [IsoXmlTag("InstdAmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? InstructedAmountCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InstructedAmountCurrency { get; init; } 
    #else
    public string? InstructedAmountCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the payment instruction is a debit or a credit.|.
    /// </summary>
    [IsoId("_VShXS5lQEee-Zps0fZQaFQ")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the interbank settlement amount(s) on which the query is performed.
    /// </summary>
    [IsoId("_VShXTZlQEee-Zps0fZQaFQ")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveAmountRange3Choice_? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveAmountRange3Choice_? InterbankSettlementAmount { get; init; } 
    #else
    public ActiveAmountRange3Choice_? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which the interbank settlement amount is expressed.
    /// </summary>
    [IsoId("_VShXT5lQEee-Zps0fZQaFQ")]
    [DisplayName("Interbank Settlement Amount Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmtCcy")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? InterbankSettlementAmountCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InterbankSettlementAmountCurrency { get; init; } 
    #else
    public string? InterbankSettlementAmountCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the message or event from which an instruction has been initiated.
    /// </summary>
    [IsoId("_VShXUZlQEee-Zps0fZQaFQ")]
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
    /// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.|.
    /// </summary>
    [IsoId("_VShXU5lQEee-Zps0fZQaFQ")]
    [DisplayName("Payment Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtTp")]
    #endif
    [IsoXmlTag("PmtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentType4Choice_? PaymentType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentType4Choice_? PaymentType { get; init; } 
    #else
    public PaymentType4Choice_? PaymentType { get; set; } 
    #endif
    
    /// <summary>
    /// Urgency or order of importance that the originator would like the recipient of the payment instruction to apply to the processing of the payment instruction.|.
    /// </summary>
    [IsoId("_VShXVZlQEee-Zps0fZQaFQ")]
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
    [IsoId("_VShXV5lQEee-Zps0fZQaFQ")]
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
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.|.
    /// </summary>
    [IsoId("_VShXWZlQEee-Zps0fZQaFQ")]
    [DisplayName("Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Instr")]
    #endif
    [IsoXmlTag("Instr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Instruction1Code? Instruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Instruction1Code? Instruction { get; init; } 
    #else
    public Instruction1Code? Instruction { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference.
    /// </summary>
    [IsoId("_VShXW5lQEee-Zps0fZQaFQ")]
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
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.|Usage: this is the former InterbankValueDate.
    /// </summary>
    [IsoId("_VShXXZlQEee-Zps0fZQaFQ")]
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
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.|Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.|It can be included in several messages related to the transaction.|Usage: this is the former RelatedReference.
    /// </summary>
    [IsoId("_VShXX5lQEee-Zps0fZQaFQ")]
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
    [IsoId("_VShXYZlQEee-Zps0fZQaFQ")]
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
