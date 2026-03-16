// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Sepcifes the reason for a request for a change to an account status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_OJzv4Hi9EeaRm5xIK6nGuQ")]
[Description(@"Sepcifes the reason for a request for a change to an account status.")]
[DerivedFrom(typeof(AccountStatusUpdateRequestReasonCode))]
public enum AccountStatusUpdateRequestReason1Code
{
    /// <summary>
    /// Previous account closure instruction was sent in error.
    /// Encoded/decoded by serializers as &quot;CLOE&quot;.
    /// </summary>
    [EnumMember(Value = "CLOE")]
    [IsoId("_cw_7YXjAEeaRm5xIK6nGuQ")]
    [Description(@"Previous account closure instruction was sent in error.")]
    AccountClosureInstructionError =
        AccountStatusUpdateRequestReasonCode.AccountClosureInstructionError, // same ordinal as derivation source for type conversions
}
