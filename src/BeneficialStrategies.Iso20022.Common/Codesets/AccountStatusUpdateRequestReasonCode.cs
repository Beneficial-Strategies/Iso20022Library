// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason for an instruction to change to an account status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-snCEHi8EeaRm5xIK6nGuQ")]
[Description(@"Specifies the reason for an instruction to change to an account status.")]
[Derivations(typeof(AccountStatusUpdateRequestReason1Code))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AccountStatusUpdateRequestReasonCode>))]
#endif
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
