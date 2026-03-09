// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the classification of the risk of the security used as collateral.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LBcKoC7YEea1cMkrGwA6Gg")]
[Description(@"Specifies the classification of the risk of the security used as collateral.")]
[Derivations(typeof(CollateralQualityType1Code))]
public enum CollateralQualityTypeCode
{
    /// <summary>
    /// Security that is classified as investment grade according to external ratings.
    /// Encoded/decoded by serializers as &quot;INVG&quot;.
    /// </summary>
    [EnumMember(Value = "INVG")]
    [IsoId("_TmHhcC7YEea1cMkrGwA6Gg")]
    [Description(@"Security that is classified as investment grade according to external ratings.")]
    InvestmentGrade,
    
    /// <summary>
    /// Security with a rating different than investment grade.
    /// Encoded/decoded by serializers as &quot;NIVG&quot;.
    /// </summary>
    [EnumMember(Value = "NIVG")]
    [IsoId("_Tnv5IC7YEea1cMkrGwA6Gg")]
    [Description(@"Security with a rating different than investment grade.")]
    NonInvestmentGrade,
    
    /// <summary>
    /// Security without a rating assigned.
    /// Encoded/decoded by serializers as &quot;NOTR&quot;.
    /// </summary>
    [EnumMember(Value = "NOTR")]
    [IsoId("_TpY34C7YEea1cMkrGwA6Gg")]
    [Description(@"Security without a rating assigned.")]
    NotRated,
    
    /// <summary>
    /// Collateral quality type is not applicable.
    /// Encoded/decoded by serializers as &quot;NOAP&quot;.
    /// </summary>
    [EnumMember(Value = "NOAP")]
    [IsoId("_mr6hEMkVEeeiAIB1i4AlQw")]
    [Description(@"Collateral quality type is not applicable.")]
    NonApplicable,
    
}
