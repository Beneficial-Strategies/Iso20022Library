// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Risk assessment of activity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4ZREgJlhEeu76rs9yGlfEg")]
[Description(@"Risk assessment of activity.")]
[Derivations(typeof(RiskAssessment1Code))]
public enum RiskAssessmentCode
{
    /// <summary>
    /// Recommended to approve unconditionally.
    /// Encoded/decoded by serializers as &quot;APPU&quot;.
    /// </summary>
    [EnumMember(Value = "APPU")]
    [IsoId("_FPaQgJliEeu76rs9yGlfEg")]
    [Description(@"Recommended to approve unconditionally.")]
    ApproveUnconditionally,
    
    /// <summary>
    /// Recommended to approve conditionally.
    /// Encoded/decoded by serializers as &quot;APPC&quot;.
    /// </summary>
    [EnumMember(Value = "APPC")]
    [IsoId("_bKPwIJliEeu76rs9yGlfEg")]
    [Description(@"Recommended to approve conditionally.")]
    ApproveConditionally,
    
    /// <summary>
    /// Recommended to approve conditionally; high risk conditions exist.
    /// Encoded/decoded by serializers as &quot;APPH&quot;.
    /// </summary>
    [EnumMember(Value = "APPH")]
    [IsoId("_js9_IJliEeu76rs9yGlfEg")]
    [Description(@"Recommended to approve conditionally; high risk conditions exist.")]
    ApproveConditionallyWithHighRisk,
    
    /// <summary>
    /// Recommended to not approve.
    /// Encoded/decoded by serializers as &quot;DONT&quot;.
    /// </summary>
    [EnumMember(Value = "DONT")]
    [IsoId("_5xK2IJliEeu76rs9yGlfEg")]
    [Description(@"Recommended to not approve.")]
    DoNotApprove,
    
}
