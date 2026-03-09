// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of variation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__JYLoHynEeGWJuGCfvwOsQ")]
[Description(@"Specifies the type of variation.")]
[DerivedFrom(typeof(VariationTypeCode))]
public enum VariationType1Code
{
    /// <summary>
    /// Decrease to undertaking amount.
    /// Encoded/decoded by serializers as &quot;DECR&quot;.
    /// </summary>
    [EnumMember(Value = "DECR")]
    [IsoId("_GXO5dnyoEeGWJuGCfvwOsQ")]
    [Description(@"Decrease to undertaking amount.")]
    Decrease = VariationTypeCode.Decrease, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Increase to undertaking amount.
    /// Encoded/decoded by serializers as &quot;INCR&quot;.
    /// </summary>
    [EnumMember(Value = "INCR")]
    [IsoId("_GeibVnyoEeGWJuGCfvwOsQ")]
    [Description(@"Increase to undertaking amount.")]
    Increase = VariationTypeCode.Increase, // same ordinal as derivation source for type conversions
    
}
