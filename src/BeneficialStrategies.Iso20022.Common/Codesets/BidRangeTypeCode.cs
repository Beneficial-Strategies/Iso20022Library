// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Types of acceptable bid range values.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_vkpAsO3MEeqc-LCjwLsUVg")]
[Description(@"Types of acceptable bid range values.")]
[Derivations(typeof(BidRangeType1Code))]
public enum BidRangeTypeCode
{
    /// <summary>
    /// All values (including minimum and maximum prices) are divisible by the bid interval.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_3wBtwO3MEeqc-LCjwLsUVg")]
    [Description(
        @"All values (including minimum and maximum prices) are divisible by the bid interval."
    )]
    Divisible,

    /// <summary>
    /// Minimum and maximum prices are not divisible by the bid interval.  All successive values between the minimum and maximum prices are in multiples of the bid interval.
    /// Encoded/decoded by serializers as &quot;MULT&quot;.
    /// </summary>
    [EnumMember(Value = "MULT")]
    [IsoId("_8sdykO3MEeqc-LCjwLsUVg")]
    [Description(
        @"Minimum and maximum prices are not divisible by the bid interval.  All successive values between the minimum and maximum prices are in multiples of the bid interval."
    )]
    InMultiple,

    /// <summary>
    /// No values within the bid range are divisible by the bid interval including the minimum and maximum prices.  Each value between the minimum and maximum prices is incremented by the bid interval.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_ALoBEO3NEeqc-LCjwLsUVg")]
    [Description(
        @"No values within the bid range are divisible by the bid interval including the minimum and maximum prices.  Each value between the minimum and maximum prices is incremented by the bid interval."
    )]
    Incremental,
}
