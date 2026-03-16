// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a payment schedule type.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YyKVAQqPEeWqX7rjSIiMuQ")]
[Description(@"Specifies a payment schedule type.")]
[Derivations(typeof(PaymentScheduleType1Code), typeof(PaymentScheduleType2Code))]
public enum PaymentScheduleTypeCode
{
    /// <summary>
    /// Payment schedule is defined as per contract.
    /// Encoded/decoded by serializers as &quot;CNTR&quot;.
    /// </summary>
    [EnumMember(Value = "CNTR")]
    [IsoId("_bA1MAAqPEeWqX7rjSIiMuQ")]
    [Description(@"Payment schedule is defined as per contract.")]
    Contract,

    /// <summary>
    /// Payment schedule is estimated.
    /// Encoded/decoded by serializers as &quot;ESTM&quot;.
    /// </summary>
    [EnumMember(Value = "ESTM")]
    [IsoId("_bWG4cAqPEeWqX7rjSIiMuQ")]
    [Description(@"Payment schedule is estimated.")]
    Estimated,

    /// <summary>
    /// Contract Payment schedule is both defined as per Contract and estimated.
    /// Encoded/decoded by serializers as &quot;BOTH&quot;.
    /// </summary>
    [EnumMember(Value = "BOTH")]
    [IsoId("_0kZo8LbzEeu9Cp6InX88Vw")]
    [Description(@"Contract Payment schedule is both defined as per Contract and estimated.")]
    Both,
}
