// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a basis for ex post calculations.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_mUK7gJ9XEeqxTNfi5y7ywQ")]
[Description(@"Specifies a basis for ex post calculations.")]
[Derivations(typeof(ExPostCostCalculationBasis1Code))]
public enum ExPostCostCalculationBasisCode
{
    /// <summary>
    /// Basis for cost calculation is rolling, that is, the last twelve months.
    /// Encoded/decoded by serializers as &quot;ROLL&quot;.
    /// </summary>
    [EnumMember(Value = "ROLL")]
    [IsoId("_sQ4xkJ9XEeqxTNfi5y7ywQ")]
    [Description(@"Basis for cost calculation is rolling, that is, the last twelve months.")]
    RollingBasis,

    /// <summary>
    /// Basic for cost calculation is fixed, that is calendar year.
    /// Encoded/decoded by serializers as &quot;FIXB&quot;.
    /// </summary>
    [EnumMember(Value = "FIXB")]
    [IsoId("_xs4gMJ9XEeqxTNfi5y7ywQ")]
    [Description(@"Basic for cost calculation is fixed, that is calendar year.")]
    FixedBasis,
}
