// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the status of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rREogIpbEeiaB-4Hjqs8aw")]
[Description(@"Specifies the status of a system.")]
[DerivedFrom(typeof(SystemStatusCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<SystemStatus3Code>))]
#endif
public enum SystemStatus3Code
{
    /// <summary>
    /// System is functioning normally, that is, operational.
    /// Encoded/decoded by serializers as &quot;ACTV&quot;.
    /// </summary>
    [EnumMember(Value = "ACTV")]
    [IsoId("_wPvh8YpbEeiaB-4Hjqs8aw")]
    [Description(@"System is functioning normally, that is, operational.")]
    Active = SystemStatusCode.Active, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System is closed (eg. normal closure of an RTGS).
    /// Encoded/decoded by serializers as &quot;CLSD&quot;.
    /// </summary>
    [EnumMember(Value = "CLSD")]
    [IsoId("_wYa80YpbEeiaB-4Hjqs8aw")]
    [Description(@"System is closed (eg. normal closure of an RTGS).")]
    Closed = SystemStatusCode.Closed, // same ordinal as derivation source for type conversions

    /// <summary>
    /// System is starting a new maintenance period.
    /// Encoded/decoded by serializers as &quot;RMPS&quot;.
    /// </summary>
    [EnumMember(Value = "RMPS")]
    [IsoId("_YxOXIYpdEeiaB-4Hjqs8aw")]
    [Description(@"System is starting a new maintenance period.")]
    ReserveMaintenancePeriodStart = SystemStatusCode.ReserveMaintenancePeriodStart, // same ordinal as derivation source for type conversions
}
