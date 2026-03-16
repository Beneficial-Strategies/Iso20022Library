// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsJOxtp-Ed-ak6NoX_4Aeg_1783969936")]
[Description(@"Provides the processing status of a transaction (at account servicer level).")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum TransactionProcessingStatus2Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_YsJOx9p-Ed-ak6NoX_4Aeg_1783970831")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = InstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_YsJOyNp-Ed-ak6NoX_4Aeg_1783971358")]
    [Description(
        @"Cancellation request from yourself for this instruction is pending waiting for further processing."
    )]
    PendingCancellation = InstructionProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cancellation request from the counterparty is awaiting for your cancellation request or your consent.
    /// Encoded/decoded by serializers as &quot;CPRC&quot;.
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_YsS_wNp-Ed-ak6NoX_4Aeg_1783971359")]
    [Description(
        @"Cancellation request from the counterparty is awaiting for your cancellation request or your consent."
    )]
    CancellationRequested = InstructionProcessingStatusCode.CancellationRequested, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_YsS_wdp-Ed-ak6NoX_4Aeg_1783971393")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing = InstructionProcessingStatusCode.PendingProcessing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YsS_wtp-Ed-ak6NoX_4Aeg_1783971418")]
    [Description(
        @"Instruction has been acknowledged/accepted for further processing by the account servicer."
    )]
    AcknowledgedAccepted = InstructionProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account servicer or third party created the transaction. It was not instructed directly by the account owner.
    /// Encoded/decoded by serializers as &quot;CGEN&quot;.
    /// </summary>
    [EnumMember(Value = "CGEN")]
    [IsoId("_YsS_w9p-Ed-ak6NoX_4Aeg_1783971419")]
    [Description(
        @"Account servicer or third party created the transaction. It was not instructed directly by the account owner."
    )]
    Generated = InstructionProcessingStatusCode.Generated, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_YsS_xNp-Ed-ak6NoX_4Aeg_1783971435")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair = InstructionProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
}
