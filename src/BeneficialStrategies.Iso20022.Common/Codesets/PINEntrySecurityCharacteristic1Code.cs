// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identifies the security characteristic of the PIN entry device.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8axYUKH3EeuiuNcvKhXmNQ")]
[Description(@"Identifies the security characteristic of the PIN entry device.")]
[DerivedFrom(typeof(PINEntrySecurityCharacteristicCode))]
public enum PINEntrySecurityCharacteristic1Code
{
    /// <summary>
    /// Other nationally assigned code.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_V-zMMaH4EeuiuNcvKhXmNQ")]
    [Description(@"Other nationally assigned code.")]
    OtherNational = PINEntrySecurityCharacteristicCode.OtherNational, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other privately assigned code.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_WHtQkaH4EeuiuNcvKhXmNQ")]
    [Description(@"Other privately assigned code.")]
    OtherPrivate = PINEntrySecurityCharacteristicCode.OtherPrivate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN entry is protected via an approved software solution.
    /// Encoded/decoded by serializers as &quot;SECS&quot;.
    /// </summary>
    [EnumMember(Value = "SECS")]
    [IsoId("_WvNVcaH4EeuiuNcvKhXmNQ")]
    [Description(@"PIN entry is protected via an approved software solution.")]
    SecureSoftware = PINEntrySecurityCharacteristicCode.SecureSoftware, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PIN entry is protected via a secure hardware solution.
    /// Encoded/decoded by serializers as &quot;SECH&quot;.
    /// </summary>
    [EnumMember(Value = "SECH")]
    [IsoId("_W4tPsaH4EeuiuNcvKhXmNQ")]
    [Description(@"PIN entry is protected via a secure hardware solution.")]
    SecureHardware = PINEntrySecurityCharacteristicCode.SecureHardware, // same ordinal as derivation source for type conversions
}
