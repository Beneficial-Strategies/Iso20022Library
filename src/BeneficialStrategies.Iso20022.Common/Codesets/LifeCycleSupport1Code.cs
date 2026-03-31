// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Qs4p0FJ4EeeHVODnW-1ONQ")]
[Description(
    @"Indicates the point in the transaction lifecycle at which the lifecycle identifier was assigned."
)]
[DerivedFrom(typeof(LifeCycleSupportCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<LifeCycleSupport1Code>))]
#endif
public enum LifeCycleSupport1Code
{
    /// <summary>
    /// Assigned at authorisation time.
    /// Encoded/decoded by serializers as &quot;AUTH&quot;.
    /// </summary>
    [EnumMember(Value = "AUTH")]
    [IsoId("_bBJH4VJ4EeeHVODnW-1ONQ")]
    [Description(@"Assigned at authorisation time.")]
    Authorisation = LifeCycleSupportCode.Authorisation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Assigned at financial time.
    /// Encoded/decoded by serializers as &quot;FINC&quot;.
    /// </summary>
    [EnumMember(Value = "FINC")]
    [IsoId("_bLtZIVJ4EeeHVODnW-1ONQ")]
    [Description(@"Assigned at financial time.")]
    Financial = LifeCycleSupportCode.Financial, // same ordinal as derivation source for type conversions
}
