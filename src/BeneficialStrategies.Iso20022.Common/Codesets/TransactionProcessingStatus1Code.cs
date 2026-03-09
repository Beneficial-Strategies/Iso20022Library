// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YsAE2Np-Ed-ak6NoX_4Aeg_-482977155")]
[Description(@"Provides the processing status of a transaction (at account servicer level).")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum TransactionProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_YsAE2dp-Ed-ak6NoX_4Aeg_-108953148")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = InstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_YsJOwNp-Ed-ak6NoX_4Aeg_18493372")]
    [Description(@"Cancellation request from yourself for this instruction is pending waiting for further processing.")]
    PendingCancellation = InstructionProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request from the counterparty is awaiting for your cancellation request or your consent.
    /// Encoded/decoded by serializers as &quot;CPRC&quot;.
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_YsJOwdp-Ed-ak6NoX_4Aeg_-1206295875")]
    [Description(@"Cancellation request from the counterparty is awaiting for your cancellation request or your consent.")]
    CancellationRequested = InstructionProcessingStatusCode.CancellationRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_YsJOwtp-Ed-ak6NoX_4Aeg_-1063150046")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing = InstructionProcessingStatusCode.PendingProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_YsJOw9p-Ed-ak6NoX_4Aeg_-676197587")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted = InstructionProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_YsJOxNp-Ed-ak6NoX_4Aeg_-629098663")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected = InstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_YsJOxdp-Ed-ak6NoX_4Aeg_26008587")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair = InstructionProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
    
}
