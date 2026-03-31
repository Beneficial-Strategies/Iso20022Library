// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a restriction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_v1wYICFnEeW9XJWqfgXIIA")]
[Description(@"Specifies the status of a restriction.")]
[DerivedFrom(typeof(RestrictionStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RestrictionStatus1Code>))]
#endif
public enum RestrictionStatus1Code
{
    /// <summary>
    /// Status of the restriction is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_yA_goSFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is active.")]
    Active = RestrictionStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Status of the restriction is inactive.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_yH-5cSFnEeW9XJWqfgXIIA")]
    [Description(@"Status of the restriction is inactive.")]
    Inactive = RestrictionStatusCode.Inactive, // same ordinal as derivation source for type conversions
}
