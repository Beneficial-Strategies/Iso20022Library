// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Bb8GsQjcEeS5F6qHcKOrew")]
[Description(@"Specifies the status of a plan.")]
[Derivations(typeof(PlanStatus1Code))]
public enum PlanStatusCode
{
    /// <summary>
    /// Plan is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_F5AH4AjcEeS5F6qHcKOrew")]
    [Description(@"Plan is active.")]
    Active,

    /// <summary>
    /// Plan is suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_Illp8AjcEeS5F6qHcKOrew")]
    [Description(@"Plan is suspended.")]
    Suspended,

    /// <summary>
    /// Plan is closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_MFzBUAjcEeS5F6qHcKOrew")]
    [Description(@"Plan is closed.")]
    Closed,
}
