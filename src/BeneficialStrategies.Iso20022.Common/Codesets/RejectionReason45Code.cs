// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specify the reason why the instruction cancellation request has a rejected status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_qjj_cFhpEeS5jeC8QHrlrg")]
[Description(@"Specify the reason why the instruction cancellation request has a rejected status.")]
[DerivedFrom(typeof(RejectionReasonCode))]
public enum RejectionReason45Code
{
    /// <summary>
    /// Instruction received after the account servicers specified deadline.
    /// Encoded/decoded by serializers as &quot;ADEA&quot;.
    /// </summary>
    [EnumMember(Value = "ADEA")]
    [IsoId("_t5pxgVhpEeS5jeC8QHrlrg")]
    [Description(@"Instruction received after the account servicers specified deadline.")]
    AccountServicerDeadlineMissed = RejectionReasonCode.AccountServicerDeadlineMissed, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Instruction contains an invalid message reference, reference is unknown.
    /// Encoded/decoded by serializers as &quot;ULNK&quot;.
    /// </summary>
    [EnumMember(Value = "ULNK")]
    [IsoId("_x231AVhpEeS5jeC8QHrlrg")]
    [Description(@"Instruction contains an invalid message reference, reference is unknown.")]
    InvalidReference = RejectionReasonCode.InvalidReference, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other reason.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_3byPEVhpEeS5jeC8QHrlrg")]
    [Description(@"Other reason.")]
    Other = RejectionReasonCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request was rejected since the instruction has already been cancelled.
    /// Encoded/decoded by serializers as &quot;DCAN&quot;.
    /// </summary>
    [EnumMember(Value = "DCAN")]
    [IsoId("_6I0dEVhpEeS5jeC8QHrlrg")]
    [Description(@"Cancellation request was rejected since the instruction has already been cancelled.")]
    RejectedSinceAlreadyCancelled = RejectionReasonCode.RejectedSinceAlreadyCancelled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cancellation request has been rejected because the instruction process is in progress or has been processed.
    /// Encoded/decoded by serializers as &quot;DPRG&quot;.
    /// </summary>
    [EnumMember(Value = "DPRG")]
    [IsoId("_6hD98VhpEeS5jeC8QHrlrg")]
    [Description(@"Cancellation request has been rejected because the instruction process is in progress or has been processed.")]
    RejectedSinceInProgress = RejectionReasonCode.RejectedSinceInProgress, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// The instruction is irrevocable.
    /// Encoded/decoded by serializers as &quot;INIR&quot;.
    /// </summary>
    [EnumMember(Value = "INIR")]
    [IsoId("_FhOfwVhqEeS5jeC8QHrlrg")]
    [Description(@"The instruction is irrevocable.")]
    InstructionIrrevocable = RejectionReasonCode.InstructionIrrevocable, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Received after market deadline.
    /// Encoded/decoded by serializers as &quot;LATE&quot;.
    /// </summary>
    [EnumMember(Value = "LATE")]
    [IsoId("_QyNEwVhqEeS5jeC8QHrlrg")]
    [Description(@"Received after market deadline.")]
    MarketDeadlineMissed = RejectionReasonCode.MarketDeadlineMissed, // same ordinal as derivation source for type conversions
    
}
