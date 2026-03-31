// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of the security.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_haryw2liEeGaMcKyqKNRfQ_-633101692")]
[Description(@"Specifies the status of the security.")]
[DerivedFrom(typeof(SecurityStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SecurityStatus2Code>))]
#endif
public enum SecurityStatus2Code
{
    /// <summary>
    /// The status is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_ha1jsGliEeGaMcKyqKNRfQ_1830027418")]
    [Description(@"The status is active.")]
    Active = SecurityStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The status is inactive.
    /// Encoded/decoded by serializers as &quot;INAC&quot;.
    /// </summary>
    [EnumMember(Value = "INAC")]
    [IsoId("_ha1jsWliEeGaMcKyqKNRfQ_-1878992852")]
    [Description(@"The status is inactive.")]
    Inactive = SecurityStatusCode.Inactive, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The status is suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_ha1jsmliEeGaMcKyqKNRfQ_-387389187")]
    [Description(@"The status is suspended.")]
    Suspended = SecurityStatusCode.Suspended, // same ordinal as derivation source for type conversions
}
