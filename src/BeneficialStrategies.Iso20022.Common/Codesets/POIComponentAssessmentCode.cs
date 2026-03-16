// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of assessment of a POI component (Point of Interaction).
/// </summary>
[DataContract]
[Serializable]
[IsoId("_boLEIAyKEeKa_56Jbsi1RQ")]
[Description(@"Type of assessment of a POI component (Point of Interaction).")]
[Derivations(typeof(POIComponentAssessment1Code))]
public enum POIComponentAssessmentCode
{
    /// <summary>
    /// Evaluation by a lab or a tool.
    /// Encoded/decoded by serializers as &quot;EVAL&quot;.
    /// </summary>
    [EnumMember(Value = "EVAL")]
    [IsoId("_xXWtYAyKEeKa_56Jbsi1RQ")]
    [Description(@"Evaluation by a lab or a tool.")]
    Evaluation,

    /// <summary>
    /// Certification number delivered by a certification body.
    /// Encoded/decoded by serializers as &quot;CERT&quot;.
    /// </summary>
    [EnumMember(Value = "CERT")]
    [IsoId("_1l-C4AyKEeKa_56Jbsi1RQ")]
    [Description(@"Certification number delivered by a certification body.")]
    Certification,

    /// <summary>
    /// Approval number delivered by an approval centre.
    /// Encoded/decoded by serializers as &quot;APPL&quot;.
    /// </summary>
    [EnumMember(Value = "APPL")]
    [IsoId("_5B2T4AyKEeKa_56Jbsi1RQ")]
    [Description(@"Approval number delivered by an approval centre.")]
    Approval,
}
