// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Code that specifies risk assessment result.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1BC5kJljEeu76rs9yGlfEg")]
[Description(@"Code that specifies risk assessment result.")]
[DerivedFrom(typeof(RiskAssessmentCode))]
public enum RiskAssessment1Code
{
    /// <summary>
    /// Recommended to approve conditionally.
    /// Encoded/decoded by serializers as &quot;APPC&quot;.
    /// </summary>
    [EnumMember(Value = "APPC")]
    [IsoId("_5HcuQZljEeu76rs9yGlfEg")]
    [Description(@"Recommended to approve conditionally.")]
    ApproveConditionally = RiskAssessmentCode.ApproveConditionally, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recommended to approve conditionally; high risk conditions exist.
    /// Encoded/decoded by serializers as &quot;APPH&quot;.
    /// </summary>
    [EnumMember(Value = "APPH")]
    [IsoId("_5PkIcZljEeu76rs9yGlfEg")]
    [Description(@"Recommended to approve conditionally; high risk conditions exist.")]
    ApproveConditionallyWithHighRisk = RiskAssessmentCode.ApproveConditionallyWithHighRisk, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recommended to approve unconditionally.
    /// Encoded/decoded by serializers as &quot;APPU&quot;.
    /// </summary>
    [EnumMember(Value = "APPU")]
    [IsoId("_5xslIZljEeu76rs9yGlfEg")]
    [Description(@"Recommended to approve unconditionally.")]
    ApproveUnconditionally = RiskAssessmentCode.ApproveUnconditionally, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recommended to not approve.
    /// Encoded/decoded by serializers as &quot;DONT&quot;.
    /// </summary>
    [EnumMember(Value = "DONT")]
    [IsoId("_56CBwZljEeu76rs9yGlfEg")]
    [Description(@"Recommended to not approve.")]
    DoNotApprove = RiskAssessmentCode.DoNotApprove, // same ordinal as derivation source for type conversions
    
}
