// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a plan.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QAWLUAjcEeS5F6qHcKOrew")]
[Description(@"Specifies the status of a plan.")]
[DerivedFrom(typeof(PlanStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PlanStatus1Code>))]
#endif
public enum PlanStatus1Code
{
    /// <summary>
    /// Plan is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_RvyIoQjcEeS5F6qHcKOrew")]
    [Description(@"Plan is active.")]
    Active = PlanStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Plan is closed.
    /// Encoded/decoded by serializers as &quot;CLOS&quot;.
    /// </summary>
    [EnumMember(Value = "CLOS")]
    [IsoId("_R4tbIQjcEeS5F6qHcKOrew")]
    [Description(@"Plan is closed.")]
    Closed = PlanStatusCode.Closed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Plan is suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_SBC3wQjcEeS5F6qHcKOrew")]
    [Description(@"Plan is suspended.")]
    Suspended = PlanStatusCode.Suspended, // same ordinal as derivation source for type conversions
}
