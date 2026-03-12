// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains information coming from the related payment instruction (specified for example in the related MT 199 or MT 103), or the StatusConfirmationUpdate.
/// </summary>
[IsoId("_6UM5FIElEei51tn2YGQhvg")]
[DisplayName("Payment Event")]
public partial record PaymentEvent7
{
    #nullable enable
    
    /// <summary>
    /// Specifies the reference assigned by the network when sending the payment.
    /// </summary>
    [IsoId("_6UM5KYElEei51tn2YGQhvg")]
    [DisplayName("Network Reference")]
    [IsoXmlTag("NtwkRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public required IsoMax50Text NetworkReference { get; init; } 
    
    /// <summary>
    /// Identifies the original message name identifier to which the message refers.
    /// </summary>
    [IsoId("_6UM5N4ElEei51tn2YGQhvg")]
    [DisplayName("Message Name Identification")]
    [IsoXmlTag("MsgNmId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageNameIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the business service agreed between the two MessagingEndpoints under which rules this Business Message is exchanged.
    /// Usage:
    /// To be used when there is a choice of processing services or processing service levels.
    /// </summary>
    [IsoId("_6UM5M4ElEei51tn2YGQhvg")]
    [DisplayName("Business Service")]
    [IsoXmlTag("BizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? BusinessService { get; init; } 
    
    /// <summary>
    /// Specifies the type of payment event.
    /// </summary>
    [IsoId("_6UM5JYElEei51tn2YGQhvg")]
    [DisplayName("Tracker Event Type")]
    [IsoXmlTag("TrckrEvtTp")]
    public required TrackerEventType1Code TrackerEventType { get; init; } 
    
    /// <summary>
    /// Indicates if a payment is consistent (YES) or isn&apos;t (NO).
    /// </summary>
    [IsoId("_6UM5NIElEei51tn2YGQhvg")]
    [DisplayName("Valid")]
    [IsoXmlTag("Vld")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Valid { get; init; } 
    
    /// <summary>
    /// Contains a coded reason as to why the event is not a valid component of a payments transaction.
    /// </summary>
    [IsoId("_6UM5J4ElEei51tn2YGQhvg")]
    [DisplayName("Invalidity Reason")]
    [IsoXmlTag("InvldtyRsn")]
    public ExternalInvalidPaymentsEvent1Code? InvalidityReason { get; init; } 
    
    /// <summary>
    /// Contains a textual description as to why the event is not a valid component of a payments transaction.
    /// </summary>
    [IsoId("_6UM5H4ElEei51tn2YGQhvg")]
    [DisplayName("Invalidity Description")]
    [IsoXmlTag("InvldtyDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? InvalidityDescription { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    [IsoId("_6UM5IIElEei51tn2YGQhvg")]
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? InstructionIdentification { get; init; } 
    
    /// <summary>
    /// Identification referring to the underlying payment transaction.
    /// </summary>
    [IsoId("_6UM5G4ElEei51tn2YGQhvg")]
    [DisplayName("Related Reference")]
    [IsoXmlTag("RltdRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? RelatedReference { get; init; } 
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_6UM5GIElEei51tn2YGQhvg")]
    [DisplayName("Case Identification")]
    [IsoXmlTag("CaseId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CaseIdentification { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    [IsoId("_6UM5I4ElEei51tn2YGQhvg")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    
    /// <summary>
    /// Uniquely identifies the case assignment.
    /// </summary>
    [IsoId("_6UM5HIElEei51tn2YGQhvg")]
    [DisplayName("Assignment Identification")]
    [IsoXmlTag("AssgnmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AssignmentIdentification { get; init; } 
    
    /// <summary>
    /// Uniquely identifies the case.
    /// </summary>
    [IsoId("_6UM5IYElEei51tn2YGQhvg")]
    [DisplayName("Resolved Case Identification")]
    [IsoXmlTag("RslvdCaseId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ResolvedCaseIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    [IsoId("_6UM5HYElEei51tn2YGQhvg")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public PaymentStatus5? TransactionStatus { get; init; } 
    
    /// <summary>
    /// Provides further information with regards to the cancellation of the payments event.
    /// </summary>
    [IsoId("_6UM5MIElEei51tn2YGQhvg")]
    [DisplayName("Underlying Cancellation Details")]
    [IsoXmlTag("UndrlygCxlDtls")]
    public UnderlyingCancellationDetails2? UnderlyingCancellationDetails { get; init; } 
    
    /// <summary>
    /// Identifies the entity to which the entity reporting the status has forwarded the payment transaction.
    /// Usage:
    /// This element can only be used in case the status is ACSP and the reason is G000 or G001.
    /// </summary>
    [IsoId("_6UM5GoElEei51tn2YGQhvg")]
    [DisplayName("Forwarded To Agent")]
    [IsoXmlTag("FwddToAgt")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? ForwardedToAgent { get; init; } 
    
    /// <summary>
    /// Specifies the date and time at which the funds are available,  as reported in the ACSC status update.
    /// Usage:
    /// Must only be used when TransactionStatus is &quot;ACSC&quot;.
    /// </summary>
    [IsoId("_6UM5KIElEei51tn2YGQhvg")]
    [DisplayName("Funds Available")]
    [IsoXmlTag("FndsAvlbl")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? FundsAvailable { get; init; } 
    
    /// <summary>
    /// Specifies the sending MessagingEndpoint that has created this business message for the receiving MessagingEndpoint that will process this business message.
    /// Usage:
    /// The sending MessagingEndpoint might be different from the sending address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_6UM5JIElEei51tn2YGQhvg")]
    [DisplayName("From")]
    [IsoXmlTag("Fr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier From { get; init; } 
    
    /// <summary>
    /// Specifies the MessagingEndpoint designated by the sending MessagingEndpoint to be the recipient who will ultimately process this business message.
    /// Usage:
    /// The receiving MessagingEndpoint might be different from the receiving address potentially contained in the transport header (as defined in the transport layer).
    /// </summary>
    [IsoId("_6UM5MYElEei51tn2YGQhvg")]
    [DisplayName("To")]
    [IsoXmlTag("To")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public required IsoAnyBICIdentifier To { get; init; } 
    
    /// <summary>
    /// Party that issues the status.
    /// </summary>
    [IsoId("_6UM5MoElEei51tn2YGQhvg")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    [IsoSimpleType(IsoSimpleType.AnyBICIdentifier)]
    public IsoAnyBICIdentifier? Originator { get; init; } 
    
    /// <summary>
    /// Identifies the parties involved in a serial payment scenario.
    /// </summary>
    [IsoId("_6UM5LoElEei51tn2YGQhvg")]
    [DisplayName("Serial Parties")]
    [IsoXmlTag("SrlPties")]
    public CustomerCreditTransferTransactionParties1? SerialParties { get; init; } 
    
    /// <summary>
    /// Identifies the parties involved in a cover payment scenario.
    /// </summary>
    [IsoId("_6UM5KoElEei51tn2YGQhvg")]
    [DisplayName("Cover Parties")]
    [IsoXmlTag("CoverPties")]
    public CreditTransferTransactionParties1? CoverParties { get; init; } 
    
    /// <summary>
    /// Date and time at which the sender was acknowledged receipt of the message.
    /// </summary>
    [IsoId("_6UM5IoElEei51tn2YGQhvg")]
    [DisplayName("Sender Acknowledgement Receipt")]
    [IsoXmlTag("SndrAckRct")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime SenderAcknowledgementReceipt { get; init; } 
    
    /// <summary>
    /// Date and time at which the message was acknowledged by the receiver.
    /// </summary>
    [IsoId("_6UM5LYElEei51tn2YGQhvg")]
    [DisplayName("Received Date")]
    [IsoXmlTag("RcvdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ReceivedDate { get; init; } 
    
    /// <summary>
    /// Amount of money to be moved between the debtor (ordering customer) and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    [IsoId("_6UM5JoElEei51tn2YGQhvg")]
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    
    /// <summary>
    /// Specifies the amount confirmed by the originator. Depending on the transaction status, this amount can be the credited amount, pending amount, rejected amount or transferred amount.
    /// </summary>
    [IsoId("_6UM5HoElEei51tn2YGQhvg")]
    [DisplayName("Confirmed Amount")]
    [IsoXmlTag("ConfdAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ConfirmedAmount { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    [IsoId("_6UM5FYElEei51tn2YGQhvg")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public ActiveCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    
    /// <summary>
    /// Specifies the date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_6UM5GYElEei51tn2YGQhvg")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; } 
    
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("_6UM5K4ElEei51tn2YGQhvg")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType3Code? ChargeBearer { get; init; } 
    
    /// <summary>
    /// Specifies the amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_6UM5LIElEei51tn2YGQhvg")]
    [DisplayName("Charge Amount")]
    [IsoXmlTag("ChrgAmt")]
    public ActiveOrHistoricCurrencyAndAmount? ChargeAmount { get; init; } 
    
    /// <summary>
    /// Specifies the exchange rate details between two currencies.
    /// </summary>
    [IsoId("_6UM5NoElEei51tn2YGQhvg")]
    [DisplayName("Foreign Exchange Details")]
    [IsoXmlTag("FXDtls")]
    public CurrencyExchange12? ForeignExchangeDetails { get; init; } 
    
    /// <summary>
    /// Contains the network reference of the payment for which the status confirmation was applicable.
    /// Usage:
    /// Implements the correlation between a payment message and a status update on it.
    /// </summary>
    [IsoId("_6UM5FoElEei51tn2YGQhvg")]
    [DisplayName("Update Payment")]
    [IsoXmlTag("UpdPmt")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? UpdatePayment { get; init; } 
    
    /// <summary>
    /// Network reference of the original recorded payment.
    /// </summary>
    [IsoId("_6UM5L4ElEei51tn2YGQhvg")]
    [DisplayName("Duplicate Message Reference")]
    [IsoXmlTag("DplctMsgRef")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? DuplicateMessageReference { get; init; } 
    
    /// <summary>
    /// Specifies the copied business service of the market infrastructure.
    /// </summary>
    [IsoId("_6UM5F4ElEei51tn2YGQhvg")]
    [DisplayName("Copied Business Service")]
    [IsoXmlTag("CpdBizSvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? CopiedBusinessService { get; init; } 
    
    /// <summary>
    /// Last date and time at which the status of this payment event was updated.
    /// </summary>
    [IsoId("_6UM5NYElEei51tn2YGQhvg")]
    [DisplayName("Last Update Time")]
    [IsoXmlTag("LastUpdTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime LastUpdateTime { get; init; } 
    
    
    #nullable disable
    
}
