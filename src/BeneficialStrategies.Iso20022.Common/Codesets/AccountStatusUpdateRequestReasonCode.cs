// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an instruction to change to an account status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-snCEHi8EeaRm5xIK6nGuQ")]
[Description(@"Specifies the reason for an instruction to change to an account status.")]
[Derivations(typeof(AccountStatusUpdateRequestReason1Code))]
public enum AccountStatusUpdateRequestReasonCode
{
    /// <summary>
    /// Previous account closure instruction was sent in error.
    /// Encoded/decoded by serializers as &quot;CLOE&quot;.
    /// </summary>
    [EnumMember(Value = "CLOE")]
    [IsoId("_BHVYEHi9EeaRm5xIK6nGuQ")]
    [Description(@"Previous account closure instruction was sent in error.")]
    AccountClosureInstructionError,
}
