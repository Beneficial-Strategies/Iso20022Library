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
[IsoId("_-9M9UGeyEfCydp-m0gJhgA")]
[Description(@"Specifies the status of the security.")]
[DerivedFrom(typeof(SecurityStatusCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<SecurityStatus3Code>))]
public enum SecurityStatus3Code
{
    /// <summary>
    /// The status is active.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_I7M3gWezEfCydp-m0gJhgA")]
    [Description(@"The status is active.")]
    Active = SecurityStatusCode.Active,

    /// <summary>
    /// The status is subject to a trading halt.
    /// Encoded/decoded by serializers as &quot;HALT&quot;.
    /// </summary>
    [EnumMember(Value = "HALT")]
    [IsoId("_I-v6wWezEfCydp-m0gJhgA")]
    [Description(@"The status is subject to a trading halt.")]
    Halted = SecurityStatusCode.Halted,

    /// <summary>
    /// The status is removed
    /// Encoded/decoded by serializers as &quot;RMOV&quot;.
    /// </summary>
    [EnumMember(Value = "RMOV")]
    [IsoId("_JHm70WezEfCydp-m0gJhgA")]
    [Description(@"The status is removed")]
    Removed = SecurityStatusCode.Removed,

    /// <summary>
    /// The status is suspended.
    /// Encoded/decoded by serializers as &quot;SUSP&quot;.
    /// </summary>
    [EnumMember(Value = "SUSP")]
    [IsoId("_JLL0QWezEfCydp-m0gJhgA")]
    [Description(@"The status is suspended.")]
    Suspended = SecurityStatusCode.Suspended,
}
