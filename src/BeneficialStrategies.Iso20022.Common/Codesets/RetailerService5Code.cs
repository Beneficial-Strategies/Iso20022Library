// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for SessionManagementResponse.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cBfSsN6LEeiwsev40qZGEQ")]
[Description(@"List of specific services for SessionManagementResponse.")]
[DerivedFrom(typeof(RetailerServiceCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<RetailerService5Code>))]
#endif
public enum RetailerService5Code
{
    /// <summary>
    /// The POI System responds to a login request.
    /// Encoded/decoded by serializers as &quot;SMIP&quot;.
    /// </summary>
    [EnumMember(Value = "SMIP")]
    [IsoId("_fuo54d6LEeiwsev40qZGEQ")]
    [Description(@"The POI System responds to a login request.")]
    AdministrativeSessionManagementLoginResponse =
        RetailerServiceCode.AdministrativeSessionManagementLoginResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a logout request.
    /// Encoded/decoded by serializers as &quot;SMOP&quot;.
    /// </summary>
    [EnumMember(Value = "SMOP")]
    [IsoId("_gFTtcd6LEeiwsev40qZGEQ")]
    [Description(@"The POI System responds to a logout request.")]
    AdministrativeSessionManagementLogoutResponse =
        RetailerServiceCode.AdministrativeSessionManagementLogoutResponse, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The POI System responds to a diagnosis request.
    /// Encoded/decoded by serializers as &quot;SMDP&quot;.
    /// </summary>
    [EnumMember(Value = "SMDP")]
    [IsoId("_guks4d6LEeiwsev40qZGEQ")]
    [Description(@"The POI System responds to a diagnosis request.")]
    AdministrativeSessionManagementDiagnosisResponse =
        RetailerServiceCode.AdministrativeSessionManagementDiagnosisResponse, // same ordinal as derivation source for type conversions
}
