// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of an instruction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_j3smZe5NEeCisYr99QEiWA_1984710351")]
[Description(@"Specifies the status of an instruction.")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum TransactionProcessingStatus4Code
{
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_j3smZu5NEeCisYr99QEiWA_1509485244")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted = InstructionProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Processing of the instruction is pending.
    /// Encoded/decoded by serializers as &quot;PPRC&quot;.
    /// </summary>
    [EnumMember(Value = "PPRC")]
    [IsoId("_j3smZ-5NEeCisYr99QEiWA_405378159")]
    [Description(@"Processing of the instruction is pending.")]
    PendingProcessing = InstructionProcessingStatusCode.PendingProcessing, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_j32XYO5NEeCisYr99QEiWA_87601498")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected = InstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_j32XYe5NEeCisYr99QEiWA_-398456535")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair = InstructionProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_j32XYu5NEeCisYr99QEiWA_563889893")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = InstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request from yourself for this instruction is pending waiting for further processing.
    /// Encoded/decoded by serializers as &quot;CANP&quot;.
    /// </summary>
    [EnumMember(Value = "CANP")]
    [IsoId("_j32XY-5NEeCisYr99QEiWA_826912670")]
    [Description(@"Cancellation request from yourself for this instruction is pending waiting for further processing.")]
    PendingCancellation = InstructionProcessingStatusCode.PendingCancellation, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request from the counterparty is awaiting for your cancellation request or your consent.
    /// Encoded/decoded by serializers as &quot;CPRC&quot;.
    /// </summary>
    [EnumMember(Value = "CPRC")]
    [IsoId("_j32XZO5NEeCisYr99QEiWA_1615433270")]
    [Description(@"Cancellation request from the counterparty is awaiting for your cancellation request or your consent.")]
    CancellationRequested = InstructionProcessingStatusCode.CancellationRequested, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Modification request from the counterparty is awaiting for your modification request or your consent.
    /// Encoded/decoded by serializers as &quot;MPRC&quot;.
    /// </summary>
    [EnumMember(Value = "MPRC")]
    [IsoId("_j32XZe5NEeCisYr99QEiWA_1449930477")]
    [Description(@"Modification request from the counterparty is awaiting for your modification request or your consent.")]
    ModificationRequested = InstructionProcessingStatusCode.ModificationRequested, // same ordinal as derivation source for type conversions
    
}
