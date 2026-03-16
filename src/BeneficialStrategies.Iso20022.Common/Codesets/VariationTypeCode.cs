// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of variation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aqnvkHynEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of variation.")]
[Derivations(typeof(VariationType1Code))]
public enum VariationTypeCode
{
    /// <summary>
    /// Increase to undertaking amount.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_t2XLsHynEeGWJuGCfvwOsQ")]
    [Description(@"Increase to undertaking amount.")]
    Increase,

    /// <summary>
    /// Decrease to undertaking amount.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_0QpukHynEeGWJuGCfvwOsQ")]
    [Description(@"Decrease to undertaking amount.")]
    Decrease,
}
