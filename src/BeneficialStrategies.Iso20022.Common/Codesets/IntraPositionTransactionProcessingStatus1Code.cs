// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Provides the processing status of a transaction (at account servicer level).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aa3aYtp-Ed-ak6NoX_4Aeg_-836406022")]
[Description(@"Provides the processing status of a transaction (at account servicer level).")]
[DerivedFrom(typeof(InstructionProcessingStatusCode))]
public enum IntraPositionTransactionProcessingStatus1Code
{
    /// <summary>
    /// Instruction has been cancelled.
    /// Encoded/decoded by serializers as &quot;CAND&quot;.
    /// </summary>
    [EnumMember(Value = "CAND")]
    [IsoId("_aa3aY9p-Ed-ak6NoX_4Aeg_-836405991")]
    [Description(@"Instruction has been cancelled.")]
    Cancelled = InstructionProcessingStatusCode.Cancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been acknowledged/accepted for further processing by the account servicer.
    /// Encoded/decoded by serializers as &quot;PACK&quot;.
    /// </summary>
    [EnumMember(Value = "PACK")]
    [IsoId("_aa3aZNp-Ed-ak6NoX_4Aeg_-836405652")]
    [Description(@"Instruction has been acknowledged/accepted for further processing by the account servicer.")]
    AcknowledgedAccepted = InstructionProcessingStatusCode.AcknowledgedAccepted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction has been rejected for further processing.
    /// Encoded/decoded by serializers as &quot;REJT&quot;.
    /// </summary>
    [EnumMember(Value = "REJT")]
    [IsoId("_aa3aZdp-Ed-ak6NoX_4Aeg_-836405651")]
    [Description(@"Instruction has been rejected for further processing.")]
    Rejected = InstructionProcessingStatusCode.Rejected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction is accepted but in repair.
    /// Encoded/decoded by serializers as &quot;REPR&quot;.
    /// </summary>
    [EnumMember(Value = "REPR")]
    [IsoId("_aa3aZtp-Ed-ak6NoX_4Aeg_-836405621")]
    [Description(@"Instruction is accepted but in repair.")]
    InRepair = InstructionProcessingStatusCode.InRepair, // same ordinal as derivation source for type conversions
    
}
