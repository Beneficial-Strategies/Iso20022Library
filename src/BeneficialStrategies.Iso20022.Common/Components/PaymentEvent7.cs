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
/// Contains information coming from the related payment instruction (specified for example in the related MT 199 or MT 103), or the StatusConfirmationUpdate.
/// </summary>
[IsoId("_6UM5FIElEei51tn2YGQhvg")]
[DisplayName("Payment Event")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentEvent7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PaymentEvent7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PaymentEvent7( System.String reqNetworkReference,System.String reqMessageNameIdentification,TrackerEventType1Code reqTrackerEventType,System.String reqValid,System.String reqFrom,System.String reqTo,System.DateTime reqSenderAcknowledgementReceipt,System.DateTime reqLastUpdateTime )
    {
        NetworkReference = reqNetworkReference;
        MessageNameIdentification = reqMessageNameIdentification;
        TrackerEventType = reqTrackerEventType;
        Valid = reqValid;
        From = reqFrom;
        To = reqTo;
        SenderAcknowledgementReceipt = reqSenderAcknowledgementReceipt;
        LastUpdateTime = reqLastUpdateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the reference assigned by the network when sending the payment.
    /// </summary>
    [IsoId("_6UM5KYElEei51tn2YGQhvg")]
    [DisplayName("Network Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NtwkRef")]
    #endif
    [IsoXmlTag("NtwkRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax50Text NetworkReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NetworkReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NetworkReference { get; init; } 
    #else
    public System.String NetworkReference { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_6UM5N4ElEei51tn2YGQhvg")]
    [DisplayName("Message Name Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNmId")]
    #endif
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageNameIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageNameIdentification { get; init; } 
    #else
    public System.String MessageNameIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    /// Usage:
    /// To be used when there is a choice of processing services or processing service levels.
    /// </summary>
    [IsoId("_6UM5M4ElEei51tn2YGQhvg")]
    [DisplayName("Business Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizSvc")]
    #endif
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? BusinessService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BusinessService { get; init; } 
    #else
    public System.String? BusinessService { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of payment event.
    /// </summary>
    [IsoId("_6UM5JYElEei51tn2YGQhvg")]
    [DisplayName("Tracker Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrEvtTp")]
    #endif
    [IsoXmlTag("TrckrEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerEventType1Code TrackerEventType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerEventType1Code TrackerEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerEventType1Code TrackerEventType { get; init; } 
    #else
    public TrackerEventType1Code TrackerEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if a payment is consistent (YES) or isn&apos;t (NO).
    /// </summary>
    [IsoId("_6UM5NIElEei51tn2YGQhvg")]
    [DisplayName("Valid")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vld")]
    #endif
    [IsoXmlTag("Vld")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator Valid { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Valid { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Valid { get; init; } 
    #else
    public System.String Valid { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a coded reason as to why the event is not a valid component of a payments transaction.
    /// </summary>
    [IsoId("_6UM5J4ElEei51tn2YGQhvg")]
    [DisplayName("Invalidity Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvldtyRsn")]
    #endif
    [IsoXmlTag("InvldtyRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternalInvalidPaymentsEvent1Code? InvalidityReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? InvalidityReason { get; init; } 
    #else
    public string? InvalidityReason { get; set; } 
    #endif
    
    /// <summary>
    /// Contains a textual description as to why the event is not a valid component of a payments transaction.
    /// </summary>
    [IsoId("_6UM5H4ElEei51tn2YGQhvg")]
    [DisplayName("Invalidity Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvldtyDesc")]
    #endif
    [IsoXmlTag("InvldtyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? InvalidityDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InvalidityDescription { get; init; } 
    #else
    public System.String? InvalidityDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_6UM5IIElEei51tn2YGQhvg")]
    [DisplayName("Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrId")]
    #endif
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? InstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? InstructionIdentification { get; init; } 
    #else
    public System.String? InstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification referring to the underlying payment transaction.
    /// </summary>
    [IsoId("_6UM5G4ElEei51tn2YGQhvg")]
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
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_6UM5GIElEei51tn2YGQhvg")]
    [DisplayName("Case Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CaseId")]
    #endif
    [IsoXmlTag("CaseId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CaseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CaseIdentification { get; init; } 
    #else
    public System.String? CaseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_6UM5I4ElEei51tn2YGQhvg")]
    [DisplayName("Original Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstrId")]
    #endif
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalInstructionIdentification { get; init; } 
    #else
    public System.String? OriginalInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_6UM5HIElEei51tn2YGQhvg")]
    [DisplayName("Assignment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssgnmtId")]
    #endif
    [IsoXmlTag("AssgnmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssignmentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssignmentIdentification { get; init; } 
    #else
    public System.String? AssignmentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_6UM5IYElEei51tn2YGQhvg")]
    [DisplayName("Resolved Case Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RslvdCaseId")]
    #endif
    [IsoXmlTag("RslvdCaseId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ResolvedCaseIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ResolvedCaseIdentification { get; init; } 
    #else
    public System.String? ResolvedCaseIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_6UM5HYElEei51tn2YGQhvg")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatus5? TransactionStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatus5? TransactionStatus { get; init; } 
    #else
    public PaymentStatus5? TransactionStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further information with regards to the cancellation of the payments event.
    /// </summary>
    [IsoId("_6UM5MIElEei51tn2YGQhvg")]
    [DisplayName("Underlying Cancellation Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygCxlDtls")]
    #endif
    [IsoXmlTag("UndrlygCxlDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnderlyingCancellationDetails2? UnderlyingCancellationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnderlyingCancellationDetails2? UnderlyingCancellationDetails { get; init; } 
    #else
    public UnderlyingCancellationDetails2? UnderlyingCancellationDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the entity to which the entity reporting the status has forwarded the payment transaction.
    /// Usage:
    /// This element can only be used in case the status is ACSP and the reason is G000 or G001.
    /// </summary>
    [IsoId("_6UM5GoElEei51tn2YGQhvg")]
    [DisplayName("Forwarded To Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FwddToAgt")]
    #endif
    [IsoXmlTag("FwddToAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? ForwardedToAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForwardedToAgent { get; init; } 
    #else
    public System.String? ForwardedToAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date and time at which the funds are available,  as reported in the ACSC status update.
    /// Usage:
    /// Must only be used when TransactionStatus is &quot;ACSC&quot;.
    /// </summary>
    [IsoId("_6UM5KIElEei51tn2YGQhvg")]
    [DisplayName("Funds Available")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndsAvlbl")]
    #endif
    [IsoXmlTag("FndsAvlbl")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? FundsAvailable { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? FundsAvailable { get; init; } 
    #else
    public System.DateTime? FundsAvailable { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the sending MessagingEndpoint that has created this business message for the receiving MessagingEndpoint that will process this business message.
    /// Usage:
    /// The sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_6UM5JIElEei51tn2YGQhvg")]
    [DisplayName("From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Fr")]
    #endif
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier From { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String From { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String From { get; init; } 
    #else
    public System.String From { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this business message.
    /// Usage:
    /// The receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_6UM5MYElEei51tn2YGQhvg")]
    [DisplayName("To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="To")]
    #endif
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoAnyBICIdentifier To { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String To { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String To { get; init; } 
    #else
    public System.String To { get; set; } 
    #endif
    
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_6UM5MoElEei51tn2YGQhvg")]
    [DisplayName("Originator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Orgtr")]
    #endif
    [IsoXmlTag("Orgtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICIdentifier? Originator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Originator { get; init; } 
    #else
    public System.String? Originator { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the parties involved in a serial payment scenario.
    /// </summary>
    [IsoId("_6UM5LoElEei51tn2YGQhvg")]
    [DisplayName("Serial Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrlPties")]
    #endif
    [IsoXmlTag("SrlPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerCreditTransferTransactionParties1? SerialParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerCreditTransferTransactionParties1? SerialParties { get; init; } 
    #else
    public CustomerCreditTransferTransactionParties1? SerialParties { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the parties involved in a cover payment scenario.
    /// </summary>
    [IsoId("_6UM5KoElEei51tn2YGQhvg")]
    [DisplayName("Cover Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CoverPties")]
    #endif
    [IsoXmlTag("CoverPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditTransferTransactionParties1? CoverParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditTransferTransactionParties1? CoverParties { get; init; } 
    #else
    public CreditTransferTransactionParties1? CoverParties { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the sender was acknowledged receipt of the message.
    /// </summary>
    [IsoId("_6UM5IoElEei51tn2YGQhvg")]
    [DisplayName("Sender Acknowledgement Receipt")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SndrAckRct")]
    #endif
    [IsoXmlTag("SndrAckRct")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime SenderAcknowledgementReceipt { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime SenderAcknowledgementReceipt { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime SenderAcknowledgementReceipt { get; init; } 
    #else
    public System.DateTime SenderAcknowledgementReceipt { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the message was acknowledged by the receiver.
    /// </summary>
    [IsoId("_6UM5LYElEei51tn2YGQhvg")]
    [DisplayName("Received Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcvdDt")]
    #endif
    [IsoXmlTag("RcvdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ReceivedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ReceivedDate { get; init; } 
    #else
    public System.DateTime? ReceivedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money to be moved between the debtor (ordering customer) and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_6UM5JoElEei51tn2YGQhvg")]
    [DisplayName("Instructed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAmt")]
    #endif
    [IsoXmlTag("InstdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount confirmed by the originator. Depending on the transaction status, this amount can be the credited amount, pending amount, rejected amount or transferred amount.
    /// </summary>
    [IsoId("_6UM5HoElEei51tn2YGQhvg")]
    [DisplayName("Confirmed Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConfdAmt")]
    #endif
    [IsoXmlTag("ConfdAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_6UM5FYElEei51tn2YGQhvg")]
    [DisplayName("Interbank Settlement Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrBkSttlmAmt")]
    #endif
    [IsoXmlTag("IntrBkSttlmAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_6UM5GYElEei51tn2YGQhvg")]
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
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_6UM5K4ElEei51tn2YGQhvg")]
    [DisplayName("Charge Bearer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgBr")]
    #endif
    [IsoXmlTag("ChrgBr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ChargeBearerType3Code? ChargeBearer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ChargeBearerType3Code? ChargeBearer { get; init; } 
    #else
    public ChargeBearerType3Code? ChargeBearer { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_6UM5LIElEei51tn2YGQhvg")]
    [DisplayName("Charge Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgAmt")]
    #endif
    [IsoXmlTag("ChrgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
    #else
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the exchange rate details between two currencies.
    /// </summary>
    [IsoId("_6UM5NoElEei51tn2YGQhvg")]
    [DisplayName("Foreign Exchange Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXDtls")]
    #endif
    [IsoXmlTag("FXDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    #else
    public CurrencyExchange12? ForeignExchangeDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Contains the network reference of the payment for which the status confirmation was applicable.
    /// Usage:
    /// Implements the correlation between a payment message and a status update on it.
    /// </summary>
    [IsoId("_6UM5FoElEei51tn2YGQhvg")]
    [DisplayName("Update Payment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdPmt")]
    #endif
    [IsoXmlTag("UpdPmt")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? UpdatePayment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UpdatePayment { get; init; } 
    #else
    public System.String? UpdatePayment { get; set; } 
    #endif
    
    /// <summary>
    /// Network reference of the original recorded payment.
    /// </summary>
    [IsoId("_6UM5L4ElEei51tn2YGQhvg")]
    [DisplayName("Duplicate Message Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DplctMsgRef")]
    #endif
    [IsoXmlTag("DplctMsgRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? DuplicateMessageReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DuplicateMessageReference { get; init; } 
    #else
    public System.String? DuplicateMessageReference { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the copied business service of the market infrastructure.
    /// </summary>
    [IsoId("_6UM5F4ElEei51tn2YGQhvg")]
    [DisplayName("Copied Business Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpdBizSvc")]
    #endif
    [IsoXmlTag("CpdBizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CopiedBusinessService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CopiedBusinessService { get; init; } 
    #else
    public System.String? CopiedBusinessService { get; set; } 
    #endif
    
    /// <summary>
    /// Last date and time at which the status of this payment event was updated.
    /// </summary>
    [IsoId("_6UM5NYElEei51tn2YGQhvg")]
    [DisplayName("Last Update Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdTm")]
    #endif
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime LastUpdateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime LastUpdateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime LastUpdateTime { get; init; } 
    #else
    public System.DateTime LastUpdateTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
