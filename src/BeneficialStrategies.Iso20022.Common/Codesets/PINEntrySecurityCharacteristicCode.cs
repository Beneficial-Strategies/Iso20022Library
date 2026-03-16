// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the security characteristic of the PIN entry device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Emn04KH3EeuiuNcvKhXmNQ")]
[Description(@"Identifies the security characteristic of the PIN entry device.")]
[Derivations(typeof(PINEntrySecurityCharacteristic1Code))]
public enum PINEntrySecurityCharacteristicCode
{
    /// <summary>
    /// PIN entry is protected via a secure hardware solution.
    /// Encoded/decoded by serializers as &quot;SECH&quot;.
    /// </summary>
    [EnumMember(Value = "SECH")]
    [IsoId("_ZexIcKH3EeuiuNcvKhXmNQ")]
    [Description(@"PIN entry is protected via a secure hardware solution.")]
    SecureHardware,

    /// <summary>
    /// PIN entry is protected via an approved software solution.
    /// Encoded/decoded by serializers as &quot;SECS&quot;.
    /// </summary>
    [EnumMember(Value = "SECS")]
    [IsoId("_tKYXcKH3EeuiuNcvKhXmNQ")]
    [Description(@"PIN entry is protected via an approved software solution.")]
    SecureSoftware,

    /// <summary>
    /// Other nationally assigned code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_AsLjIKH4EeuiuNcvKhXmNQ")]
    [Description(@"Other nationally assigned code.")]
    OtherNational,

    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_FOFBAKH4EeuiuNcvKhXmNQ")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate,
}
