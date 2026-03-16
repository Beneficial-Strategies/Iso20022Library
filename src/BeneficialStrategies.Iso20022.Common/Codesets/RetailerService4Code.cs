// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// List of specific services for SessionManagementRequest.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_q-rAgN6HEeiwsev40qZGEQ")]
[Description(@"List of specific services for SessionManagementRequest.")]
[DerivedFrom(typeof(RetailerServiceCode))]
public enum RetailerService4Code
{
    /// <summary>
    /// The Sale System requests a login to the POI System.
    /// Encoded/decoded by serializers as &quot;SMIQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMIQ")]
    [IsoId("_vHX7Qd6HEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests a login to the POI System.")]
    AdministrativeSessionManagementLoginRequest =
        RetailerServiceCode.AdministrativeSessionManagementLoginRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests a logout to the POI System.
    /// Encoded/decoded by serializers as &quot;SMOQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMOQ")]
    [IsoId("_vWt-0d6HEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests a logout to the POI System.")]
    AdministrativeSessionManagementLogoutRequest =
        RetailerServiceCode.AdministrativeSessionManagementLogoutRequest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// The Sale System requests a session diagnosis to the POI System.
    /// Encoded/decoded by serializers as &quot;SMDQ&quot;.
    /// </summary>
    [EnumMember(Value = "SMDQ")]
    [IsoId("_vzpycd6HEeiwsev40qZGEQ")]
    [Description(@"The Sale System requests a session diagnosis to the POI System.")]
    AdministrativeSessionManagementDiagnosisRequest =
        RetailerServiceCode.AdministrativeSessionManagementDiagnosisRequest, // same ordinal as derivation source for type conversions
}
