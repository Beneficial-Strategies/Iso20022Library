// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the relationship between two variables.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cS11gNGxEeaokquJJ-K6uA")]
[Description(@"Indicates the relationship between two variables.")]
[Derivations(typeof(Operation3Code))]
public enum OperationV2Code
{
    /// <summary>
    /// Indicates that only when all if all of its elements are valid, the whole expression is valid.
    /// Encoded/decoded by serializers as &quot;ANDD&quot;.
    /// </summary>
    [EnumMember(Value = "ANDD")]
    [IsoId("_gq4MwNGxEeaokquJJ-K6uA")]
    [Description(
        @"Indicates that only when all if all of its elements are valid, the whole expression is valid."
    )]
    And,

    /// <summary>
    /// Indicates that when at least one of its elements is valid, the whole expression is valid.
    /// Encoded/decoded by serializers as &quot;ORRR&quot;.
    /// </summary>
    [EnumMember(Value = "ORRR")]
    [IsoId("_hCk7ENGxEeaokquJJ-K6uA")]
    [Description(
        @"Indicates that when at least one of its elements is valid, the whole expression is valid."
    )]
    Or,

    /// <summary>
    /// Indicates that only when both elements differ (one is valid, one is invalid), the whole expression is valid.
    /// Encoded/decoded by serializers as &quot;XORR&quot;.
    /// </summary>
    [EnumMember(Value = "XORR")]
    [IsoId("_hI1UENGxEeaokquJJ-K6uA")]
    [Description(
        @"Indicates that only when both elements differ (one is valid, one is invalid), the whole expression is valid."
    )]
    ExclusiveOr,

    /// <summary>
    /// Indicates a range delimited by two variables.
    /// Encoded/decoded by serializers as &quot;TILL&quot;.
    /// </summary>
    [EnumMember(Value = "TILL")]
    [IsoId("_hWZO8NGxEeaokquJJ-K6uA")]
    [Description(@"Indicates a range delimited by two variables.")]
    Till,
}
