// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the lock status of a party.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cetAIGjMEeiRg5NzP0jkQg")]
[Description(@"Specifies the lock status of a party.")]
[Derivations(typeof(LockStatus1Code))]
public enum LockStatusCode
{
    /// <summary>
    /// Party has been locked for operations.
    /// Encoded/decoded by serializers as &quot;LOCK&quot;.
    /// </summary>
    [EnumMember(Value = "LOCK")]
    [IsoId("_fvXfoGjMEeiRg5NzP0jkQg")]
    [Description(@"Party has been locked for operations.")]
    Locked,

    /// <summary>
    /// Party is ready for operations.
    /// Encoded/decoded by serializers as &quot;ULCK&quot;.
    /// </summary>
    [EnumMember(Value = "ULCK")]
    [IsoId("_hh8QgGjMEeiRg5NzP0jkQg")]
    [Description(@"Party is ready for operations.")]
    Unlocked,
}
