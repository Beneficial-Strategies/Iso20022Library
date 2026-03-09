// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a basis for ex post calculations.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2nZSYJ9XEeqxTNfi5y7ywQ")]
[Description(@"Specifies a basis for ex post calculations.")]
[DerivedFrom(typeof(ExPostCostCalculationBasisCode))]
public enum ExPostCostCalculationBasis1Code
{
    /// <summary>
    /// Basic for cost calculation is fixed, that is calendar year.
    /// Encoded/decoded by serializers as &quot;FIXB&quot;.
    /// </summary>
    [EnumMember(Value = "FIXB")]
    [IsoId("_QMy0sbVQEeqkjqDuFVh1-A")]
    [Description(@"Basic for cost calculation is fixed, that is calendar year.")]
    FixedBasis = ExPostCostCalculationBasisCode.FixedBasis, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Basis for cost calculation is rolling, that is, the last twelve months.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_QTDNsbVQEeqkjqDuFVh1-A")]
    [Description(@"Basis for cost calculation is rolling, that is, the last twelve months.")]
    RollingBasis = ExPostCostCalculationBasisCode.RollingBasis, // same ordinal as derivation source for type conversions
    
}
