// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aXlc6dp-Ed-ak6NoX_4Aeg_486709953")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum InstructionProcessingStatus1Code
{
    /// <summary>
    /// Pending cancellation; only one side has been input and a cancellation request has been sent.
    /// Encoded/decoded by serializers as &quot;CAN1&quot;.
    /// </summary>
    [EnumMember(Value = "CAN1")]
    [IsoId("_aXum0Np-Ed-ak6NoX_4Aeg_2131977388")]
    [Description(
        @"Pending cancellation; only one side has been input and a cancellation request has been sent."
    )]
    Cancellation1 = InstructionProcessingStatusCode.Cancellation1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending cancellation; both sides have been input, the trade has not yet been matched, and one side has sent a cancellation request.
    /// Encoded/decoded by serializers as &quot;CAN2&quot;.
    /// </summary>
    [EnumMember(Value = "CAN2")]
    [IsoId("_aXum0dp-Ed-ak6NoX_4Aeg_-510362400")]
    [Description(
        @"Pending cancellation; both sides have been input, the trade has not yet been matched, and one side has sent a cancellation request."
    )]
    Cancellation2 = InstructionProcessingStatusCode.Cancellation2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pending cancellation; both sides have been input, the trade is matched, and one side has sent a cancellation request.
    /// Encoded/decoded by serializers as &quot;CAN3&quot;.
    /// </summary>
    [EnumMember(Value = "CAN3")]
    [IsoId("_aXum0tp-Ed-ak6NoX_4Aeg_-802320138")]
    [Description(
        @"Pending cancellation; both sides have been input, the trade is matched, and one side has sent a cancellation request."
    )]
    Cancellation3 = InstructionProcessingStatusCode.Cancellation3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aXum09p-Ed-ak6NoX_4Aeg_-624201466")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = InstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange.
    /// Encoded/decoded by serializers as &quot;CANO&quot;.
    /// </summary>
    [EnumMember(Value = "CANO")]
    [IsoId("_aXum1Np-Ed-ak6NoX_4Aeg_1134905035")]
    [Description(
        @"Instruction has been cancelled by another party than the instructing party, for example, market infrastructure such as a stock exchange."
    )]
    CancelledByAnotherParty = InstructionProcessingStatusCode.CancelledByAnotherParty, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_aXum1dp-Ed-ak6NoX_4Aeg_-1507434753")]
    [Description(
        @"Cancellation request from yourself for this instruction is pending waiting for further processing."
    )]
    PendingCancellation = InstructionProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account servicer or third party created the transaction. It was not instructed directly by the account owner.
    /// Encoded/decoded by serializers as &quot;CGEN&quot;.
    /// </summary>
    [EnumMember(Value = "CGEN")]
    [IsoId("_aXum1tp-Ed-ak6NoX_4Aeg_-1799392491")]
    [Description(
        @"Account servicer or third party created the transaction. It was not instructed directly by the account owner."
    )]
    Generated = InstructionProcessingStatusCode.Generated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is fully executed and the confirmation was sent.
    /// Encoded/decoded by serializers as &quot;COSE&quot;.
    /// </summary>
    [EnumMember(Value = "COSE")]
    [IsoId("_aXum19p-Ed-ak6NoX_4Aeg_-1621273819")]
    [Description(@"Order is fully executed and the confirmation was sent.")]
    FullyExecutedConfirmationSent = InstructionProcessingStatusCode.FullyExecutedConfirmationSent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request from the counterparty is awaiting for your cancellation request or your consent.
    /// Encoded/decoded by serializers as &quot;CPRC&quot;.
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_aXum2Np-Ed-ak6NoX_4Aeg_137832682")]
    [Description(
        @"Cancellation request from the counterparty is awaiting for your cancellation request or your consent."
    )]
    CancellationRequested = InstructionProcessingStatusCode.CancellationRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Default action is taken.
    /// Encoded/decoded by serializers as &quot;DFLA&quot;.
    /// </summary>
    [EnumMember(Value = "DFLA")]
    [IsoId("_aXum2dp-Ed-ak6NoX_4Aeg_1790460190")]
    [Description(@"Default action is taken.")]
    DefaultAction = InstructionProcessingStatusCode.DefaultAction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is partially filled and no further executions forthcoming for the trading day.
    /// Encoded/decoded by serializers as &quot;DONE&quot;.
    /// </summary>
    [EnumMember(Value = "DONE")]
    [IsoId("_aX4X0Np-Ed-ak6NoX_4Aeg_1498502452")]
    [Description(
        @"Order is partially filled and no further executions forthcoming for the trading day."
    )]
    Done = InstructionProcessingStatusCode.Done, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is partially filled and no further executions will take place.
    /// Encoded/decoded by serializers as &quot;DONF&quot;.
    /// </summary>
    [EnumMember(Value = "DONF")]
    [IsoId("_aX4X0dp-Ed-ak6NoX_4Aeg_1676621124")]
    [Description(@"Order is partially filled and no further executions will take place.")]
    PartiallyFilledOrder = InstructionProcessingStatusCode.PartiallyFilledOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received at the stock exchange.
    /// Encoded/decoded by serializers as &quot;EXCH&quot;.
    /// </summary>
    [EnumMember(Value = "EXCH")]
    [IsoId("_aX4X0tp-Ed-ak6NoX_4Aeg_-859239671")]
    [Description(@"Order has been received at the stock exchange.")]
    ReceivedAtStockExchange = InstructionProcessingStatusCode.ReceivedAtStockExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order was fully executed and the execution sent.
    /// Encoded/decoded by serializers as &quot;EXSE&quot;.
    /// </summary>
    [EnumMember(Value = "EXSE")]
    [IsoId("_aX4X09p-Ed-ak6NoX_4Aeg_793387837")]
    [Description(@"Order was fully executed and the execution sent.")]
    FullyExecutedExecutionSent = InstructionProcessingStatusCode.FullyExecutedExecutionSent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Message has been sent automatically by the service provider to notify that settlement will not take place.
    /// Encoded/decoded by serializers as &quot;FORC&quot;.
    /// </summary>
    [EnumMember(Value = "FORC")]
    [IsoId("_aX4X1Np-Ed-ak6NoX_4Aeg_501430099")]
    [Description(
        @"Message has been sent automatically by the service provider to notify that settlement will not take place."
    )]
    ForcedRejection = InstructionProcessingStatusCode.ForcedRejection, // same ordinal as derivation source for type conversions

    /// <summary>
    /// All checks relative to the instruction (except collateral) are successful.
    /// Encoded/decoded by serializers as &quot;FUTU&quot;.
    /// </summary>
    [EnumMember(Value = "FUTU")]
    [IsoId("_aX4X1dp-Ed-ak6NoX_4Aeg_679548771")]
    [Description(@"All checks relative to the instruction (except collateral) are successful.")]
    Future = InstructionProcessingStatusCode.Future, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been received at the intermediary.
    /// Encoded/decoded by serializers as &quot;INTE&quot;.
    /// </summary>
    [EnumMember(Value = "INTE")]
    [IsoId("_aX4X1tp-Ed-ak6NoX_4Aeg_-1856312024")]
    [Description(@"Order has been received at the intermediary.")]
    ReceivedAtIntermediary = InstructionProcessingStatusCode.ReceivedAtIntermediary, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction cannot be cancelled as it has already been matched and affirmed.
    /// Encoded/decoded by serializers as &quot;NOTC&quot;.
    /// </summary>
    [EnumMember(Value = "NOTC")]
    [IsoId("_aX4X19p-Ed-ak6NoX_4Aeg_-495642254")]
    [Description(@"Instruction cannot be cancelled as it has already been matched and affirmed.")]
    AlreadyMatchedAndAffirmed = InstructionProcessingStatusCode.AlreadyMatchedAndAffirmed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order is open.
    /// Encoded/decoded by serializers as &quot;OPOD&quot;.
    /// </summary>
    [EnumMember(Value = "OPOD")]
    [IsoId("_aX4X2Np-Ed-ak6NoX_4Aeg_-317523582")]
    [Description(@"Order is open.")]
    OpenOrder = InstructionProcessingStatusCode.OpenOrder, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instrument of the block trade has been overallocated.
    /// Encoded/decoded by serializers as &quot;OVER&quot;.
    /// </summary>
    [EnumMember(Value = "OVER")]
    [IsoId("_aX4X2dp-Ed-ak6NoX_4Aeg_1441582919")]
    [Description(@"Quantity of financial instrument of the block trade has been overallocated.")]
    OverAllocated = InstructionProcessingStatusCode.OverAllocated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aX4X2tp-Ed-ak6NoX_4Aeg_-1200756869")]
    [Description(
        @"Instruction has been acknowledged/accepted for further processing by the account servicer."
    )]
    AcknowledgedAccepted = InstructionProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been partially filled and the remaining quantity is warehoused.
    /// Encoded/decoded by serializers as &quot;PAFI&quot;.
    /// </summary>
    [EnumMember(Value = "PAFI")]
    [IsoId("_aYCI0Np-Ed-ak6NoX_4Aeg_-1492714607")]
    [Description(@"Order has been partially filled and the remaining quantity is warehoused.")]
    PartialFill = InstructionProcessingStatusCode.PartialFill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Order has been partially cancelled as requested.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_aYCI0dp-Ed-ak6NoX_4Aeg_-1314595935")]
    [Description(@"Order has been partially cancelled as requested.")]
    PartialCancel = InstructionProcessingStatusCode.PartialCancel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_aYCI0tp-Ed-ak6NoX_4Aeg_444510566")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing = InstructionProcessingStatusCode.PendingProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aYCI09p-Ed-ak6NoX_4Aeg_2097138074")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected = InstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_aYCI1Np-Ed-ak6NoX_4Aeg_1805180336")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair = InstructionProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Settlement instruction has been sent to your custodian.
    /// Encoded/decoded by serializers as &quot;SESE&quot;.
    /// </summary>
    [EnumMember(Value = "SESE")]
    [IsoId("_aYCI1dp-Ed-ak6NoX_4Aeg_1983299008")]
    [Description(@"Settlement instruction has been sent to your custodian.")]
    SettlementInstructionSent = InstructionProcessingStatusCode.SettlementInstructionSent, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Standing instruction has been applied.
    /// Encoded/decoded by serializers as &quot;STIN&quot;.
    /// </summary>
    [EnumMember(Value = "STIN")]
    [IsoId("_aYCI1tp-Ed-ak6NoX_4Aeg_-552561787")]
    [Description(@"Standing instruction has been applied.")]
    StandingInstruction = InstructionProcessingStatusCode.StandingInstruction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Trading is suspended by the stock exchange.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_aYCI19p-Ed-ak6NoX_4Aeg_1100065721")]
    [Description(@"Trading is suspended by the stock exchange.")]
    TradingSuspendedByStockExchange =
        InstructionProcessingStatusCode.TradingSuspendedByStockExchange, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transaction has been treated (triparty collateral status).
    /// Encoded/decoded by serializers as &quot;TREA&quot;.
    /// </summary>
    [EnumMember(Value = "TREA")]
    [IsoId("_aYCI2Np-Ed-ak6NoX_4Aeg_808107983")]
    [Description(@"Transaction has been treated (triparty collateral status).")]
    Treated = InstructionProcessingStatusCode.Treated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Quantity of financial instrument of the block trade has been under allocated.
    /// Encoded/decoded by serializers as &quot;UNDE&quot;.
    /// </summary>
    [EnumMember(Value = "UNDE")]
    [IsoId("_aYCI2dp-Ed-ak6NoX_4Aeg_986226655")]
    [Description(@"Quantity of financial instrument of the block trade has been under allocated.")]
    UnderAllocated = InstructionProcessingStatusCode.UnderAllocated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Modification request from the counterparty is awaiting for your modification request or your consent.
    /// Encoded/decoded by serializers as &quot;MPRC&quot;.
    /// </summary>
    [EnumMember(Value = "MPRC")]
    [IsoId("_aYLSwNp-Ed-ak6NoX_4Aeg_138473753")]
    [Description(
        @"Modification request from the counterparty is awaiting for your modification request or your consent."
    )]
    ModificationRequested = InstructionProcessingStatusCode.ModificationRequested, // same ordinal as derivation source for type conversions
}
