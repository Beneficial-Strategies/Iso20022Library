// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aYLSwdp-Ed-ak6NoX_4Aeg_-433562560")]
[Description(@"Specifies the status of an instruction.")]
[Derivations(typeof(SettlementConditionModificationProcessingStatus1Code),typeof(IntraPositionTransactionProcessingStatus1Code),typeof(TransactionProcessingStatus2Code),typeof(TransactionProcessingStatus3Code),typeof(TransactionProcessingStatus1Code),typeof(TransactionProcessingStatus4Code),typeof(InstructionProcessingStatus1Code))]
public enum InstructionProcessingStatusCode
{
    /// <summary>
    /// Pending cancellation; only one side has been input and a cancellation request has been sent.
    /// Encoded/decoded by serializers as &quot;CAN1&quot;.
    /// </summary>
    [EnumMember(Value = "CAN1")]
    [IsoId("_aYLSwtp-Ed-ak6NoX_4Aeg_-2037415472")]
    [Description(@"Pending cancellation; only one side has been input and a cancellation request has been sent.")]
    Cancellation1,
    
    /// <summary>
    /// Pending cancellation; both sides have been input, the trade has not yet been matched, and one side has sent a cancellation request.
    /// Encoded/decoded by serializers as &quot;CAN2&quot;.
    /// </summary>
    [EnumMember(Value = "CAN2")]
    [IsoId("_aYLSw9p-Ed-ak6NoX_4Aeg_1552437209")]
    [Description(@"Pending cancellation; both sides have been input, the trade has not yet been matched, and one side has sent a cancellation request.")]
    Cancellation2,
    
    /// <summary>
    /// Pending cancellation; both sides have been input, the trade is matched, and one side has sent a cancellation request.
    /// Encoded/decoded by serializers as &quot;CAN3&quot;.
    /// </summary>
    [EnumMember(Value = "CAN3")]
    [IsoId("_aYLSxNp-Ed-ak6NoX_4Aeg_-1097262652")]
    [Description(@"Pending cancellation; both sides have been input, the trade is matched, and one side has sent a cancellation request.")]
    Cancellation3,
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aYLSxdp-Ed-ak6NoX_4Aeg_441525790")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled,
    
    /// <summary>
    /// Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_aYLSxtp-Ed-ak6NoX_4Aeg_-733665235")]
    [Description(@"Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange.")]
    CancelledByAnotherParty,
    
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aYLSx9p-Ed-ak6NoX_4Aeg_327202593")]
    [Description(@"Cancellation request from yourself for this instruction is pending waiting for further processing.")]
    PendingCancellation,
    
    /// <summary>
    /// Account servicer or third party created the transaction. It was not instructed directly by the account owner.
    /// Encoded/decoded by serializers as &quot;CGEN&quot;.
    /// </summary>
    [EnumMember(Value = "CGEN")]
    [IsoId("_aYLSyNp-Ed-ak6NoX_4Aeg_1972470028")]
    [Description(@"Account servicer or third party created the transaction. It was not instructed directly by the account owner.")]
    Generated,
    
    /// <summary>
    /// Order is fully executed and the confirmation was sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aYVDwNp-Ed-ak6NoX_4Aeg_-783708826")]
    [Description(@"Order is fully executed and the confirmation was sent.")]
    FullyExecutedConfirmationSent,
    
    /// <summary>
    /// Cancellation request from the counterparty is awaiting for your cancellation request or your consent.
    /// Encoded/decoded by serializers as &quot;CPRC&quot;.
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_aYVDwdp-Ed-ak6NoX_4Aeg_-1958899851")]
    [Description(@"Cancellation request from the counterparty is awaiting for your cancellation request or your consent.")]
    CancellationRequested,
    
    /// <summary>
    /// Default action is taken.
    /// Encoded/decoded by serializers as &quot;DFLA&quot;.
    /// </summary>
    [EnumMember(Value = "DFLA")]
    [IsoId("_aYVDwtp-Ed-ak6NoX_4Aeg_1630952830")]
    [Description(@"Default action is taken.")]
    DefaultAction,
    
    /// <summary>
    /// Order is partially filled and no further executions forthcoming for the trading day.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_aYVDw9p-Ed-ak6NoX_4Aeg_-1018747031")]
    [Description(@"Order is partially filled and no further executions forthcoming for the trading day.")]
    Done,
    
    /// <summary>
    /// Order is partially filled and no further executions will take place.
    /// Encoded/decoded by serializers as &quot;DONF&quot;.
    /// </summary>
    [EnumMember(Value = "DONF")]
    [IsoId("_aYVDxNp-Ed-ak6NoX_4Aeg_520041411")]
    [Description(@"Order is partially filled and no further executions will take place.")]
    PartiallyFilledOrder,
    
    /// <summary>
    /// Order has been received at the stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aYVDxdp-Ed-ak6NoX_4Aeg_-655149614")]
    [Description(@"Order has been received at the stock exchange.")]
    ReceivedAtStockExchange,
    
    /// <summary>
    /// Order was fully executed and the execution sent.
    /// Encoded/decoded by serializers as &quot;EXSE&quot;.
    /// </summary>
    [EnumMember(Value = "EXSE")]
    [IsoId("_aYVDxtp-Ed-ak6NoX_4Aeg_-1360264229")]
    [Description(@"Order was fully executed and the execution sent.")]
    FullyExecutedExecutionSent,
    
    /// <summary>
    /// Message has been sent automatically by the service provider to notify that settlement will not take place.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_aYVDx9p-Ed-ak6NoX_4Aeg_285003206")]
    [Description(@"Message has been sent automatically by the service provider to notify that settlement will not take place.")]
    ForcedRejection,
    
    /// <summary>
    /// All checks relative to the instruction (except collateral) are successful.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_aYVDyNp-Ed-ak6NoX_4Aeg_1823791648")]
    [Description(@"All checks relative to the instruction (except collateral) are successful.")]
    Future,
    
    /// <summary>
    /// Order has been received at the intermediary.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_aYVDydp-Ed-ak6NoX_4Aeg_648600623")]
    [Description(@"Order has been received at the intermediary.")]
    ReceivedAtIntermediary,
    
    /// <summary>
    /// No/incomplete instruction was received for the corporate action event. No further processing has been carried out.
    /// Encoded/decoded by serializers as &quot;NOIN&quot;.
    /// </summary>
    [EnumMember(Value = "NOIN")]
    [IsoId("_aYVDytp-Ed-ak6NoX_4Aeg_-56513992")]
    [Description(@"No/incomplete instruction was received for the corporate action event. No further processing has been carried out.")]
    NoInstruction,
    
    /// <summary>
    /// Instruction cannot be cancelled as it has already been matched and affirmed.
    /// Encoded/decoded by serializers as &quot;NOTC&quot;.
    /// </summary>
    [EnumMember(Value = "NOTC")]
    [IsoId("_aYe0wNp-Ed-ak6NoX_4Aeg_1588753443")]
    [Description(@"Instruction cannot be cancelled as it has already been matched and affirmed.")]
    AlreadyMatchedAndAffirmed,
    
    /// <summary>
    /// Order is open.
    /// Encoded/decoded by serializers as &quot;OPOD&quot;.
    /// </summary>
    [EnumMember(Value = "OPOD")]
    [IsoId("_aYe0wdp-Ed-ak6NoX_4Aeg_-1090386710")]
    [Description(@"Order is open.")]
    OpenOrder,
    
    /// <summary>
    /// Quantity of financial instrument of the block trade has been overallocated.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_aYe0wtp-Ed-ak6NoX_4Aeg_417484520")]
    [Description(@"Quantity of financial instrument of the block trade has been overallocated.")]
    OverAllocated,
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aYe0w9p-Ed-ak6NoX_4Aeg_-287630095")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted,
    
    /// <summary>
    /// Order has been partially filled and the remaining quantity is warehoused.
    /// Encoded/decoded by serializers as &quot;PAFI&quot;.
    /// </summary>
    [EnumMember(Value = "PAFI")]
    [IsoId("_aYe0xNp-Ed-ak6NoX_4Aeg_1357637340")]
    [Description(@"Order has been partially filled and the remaining quantity is warehoused.")]
    PartialFill,
    
    /// <summary>
    /// Order has been partially cancelled as requested.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aYe0xdp-Ed-ak6NoX_4Aeg_-1398541514")]
    [Description(@"Order has been partially cancelled as requested.")]
    PartialCancel,
    
    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_aYe0xtp-Ed-ak6NoX_4Aeg_1721234757")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing,
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aYe0x9p-Ed-ak6NoX_4Aeg_1016120142")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected,
    
    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_aYe0yNp-Ed-ak6NoX_4Aeg_-1633579719")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair,
    
    /// <summary>
    /// Settlement instruction has been sent to your custodian.
    /// Encoded/decoded by serializers as &quot;SESE&quot;.
    /// </summary>
    [EnumMember(Value = "SESE")]
    [IsoId("_aYe0ydp-Ed-ak6NoX_4Aeg_-94791277")]
    [Description(@"Settlement instruction has been sent to your custodian.")]
    SettlementInstructionSent,
    
    /// <summary>
    /// Standing instruction has been applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_aYn-sNp-Ed-ak6NoX_4Aeg_-1269982302")]
    [Description(@"Standing instruction has been applied.")]
    StandingInstruction,
    
    /// <summary>
    /// Trading is suspended by the stock exchange.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_aYn-sdp-Ed-ak6NoX_4Aeg_-1975096917")]
    [Description(@"Trading is suspended by the stock exchange.")]
    TradingSuspendedByStockExchange,
    
    /// <summary>
    /// Transaction has been treated (triparty collateral status).
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_aYn-stp-Ed-ak6NoX_4Aeg_-329829482")]
    [Description(@"Transaction has been treated (triparty collateral status).")]
    Treated,
    
    /// <summary>
    /// Quantity of financial instrument of the block trade has been under allocated.
    /// Encoded/decoded by serializers as &quot;UNDE&quot;.
    /// </summary>
    [EnumMember(Value = "UNDE")]
    [IsoId("_aYn-s9p-Ed-ak6NoX_4Aeg_1208958960")]
    [Description(@"Quantity of financial instrument of the block trade has been under allocated.")]
    UnderAllocated,
    
    /// <summary>
    /// Modification request from the counterparty is awaiting for your modification request or your consent.
    /// Encoded/decoded by serializers as &quot;MPRC&quot;.
    /// </summary>
    [EnumMember(Value = "MPRC")]
    [IsoId("_aYn-tNp-Ed-ak6NoX_4Aeg_-150625715")]
    [Description(@"Modification request from the counterparty is awaiting for your modification request or your consent.")]
    ModificationRequested,
    
    /// <summary>
    /// Transaction terms communicated have been acknowledged/accepted for further processing by the account owner.
    /// Encoded/decoded by serializers as &quot;ACAO&quot;.
    /// </summary>
    [EnumMember(Value = "ACAO")]
    [IsoId("_vAGssdUWEeOpzo6bWCQeYA")]
    [Description(@"Transaction terms communicated have been acknowledged/accepted for further processing by the account owner.")]
    AcknowledgedAcceptedByAccountOwner,
    
    /// <summary>
    /// Transaction terms communicated have been rejected for further processing by the account owner.
    /// Encoded/decoded by serializers as &quot;RJAO&quot;.
    /// </summary>
    [EnumMember(Value = "RJAO")]
    [IsoId("_4BgbwdUWEeOpzo6bWCQeYA")]
    [Description(@"Transaction terms communicated have been rejected for further processing by the account owner.")]
    RejectedByAccountOwner,
    
}
