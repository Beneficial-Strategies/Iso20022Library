// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of assessment of a POI component (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TBs-0Lk3EeKg8PSpEMv-Sg")]
[Description(@"Type of assessment of a POI component (Point of Interaction).")]
[DerivedFrom(typeof(POIComponentAssessmentCode))]
public enum POIComponentAssessment1Code
{
    /// <summary>
    /// Approval number delivered by an approval centre.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_fAoO8bk3EeKg8PSpEMv-Sg")]
    [Description(@"Approval number delivered by an approval centre.")]
    Approval = POIComponentAssessmentCode.Approval, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certification number delivered by a certification body.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_fLolE7k3EeKg8PSpEMv-Sg")]
    [Description(@"Certification number delivered by a certification body.")]
    Certification = POIComponentAssessmentCode.Certification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Evaluation by a lab or a tool.
    /// Encoded/decoded by serializers as &quot;EVAL&quot;.
    /// </summary>
    [EnumMember(Value = "EVAL")]
    [IsoId("_fUtokbk3EeKg8PSpEMv-Sg")]
    [Description(@"Evaluation by a lab or a tool.")]
    Evaluation = POIComponentAssessmentCode.Evaluation, // same ordinal as derivation source for type conversions
}
