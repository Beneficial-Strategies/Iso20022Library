// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a drawdown status.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_t4qL0FKiEeiSDqv62fL07g")]
[Description(@"Specifies a drawdown status.")]
[Derivations(typeof(DrawdownStatus1Code))]
public enum DrawdownStatusCode
{
    /// <summary>
    /// Pension is not in drawdown.
    /// Encoded/decoded by serializers as &quot;NONE&quot;.
    /// </summary>
    [EnumMember(Value = "NONE")]
    [IsoId("_0F5KIFKiEeiSDqv62fL07g")]
    [Description(@"Pension is not in drawdown.")]
    None,

    /// <summary>
    /// Pension is in partial drawdown.
    /// Encoded/decoded by serializers as &quot;PART&quot;.
    /// </summary>
    [EnumMember(Value = "PART")]
    [IsoId("_3fsXgFKiEeiSDqv62fL07g")]
    [Description(@"Pension is in partial drawdown.")]
    Partial,

    /// <summary>
    /// Pension is fully in drawdown.
    /// Encoded/decoded by serializers as &quot;FULL&quot;.
    /// </summary>
    [EnumMember(Value = "FULL")]
    [IsoId("_5jNucFKiEeiSDqv62fL07g")]
    [Description(@"Pension is fully in drawdown.")]
    Full,
}
