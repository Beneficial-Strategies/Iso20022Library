// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Customer authentication capabilities available on an ATM.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_n75oUIn7EeShMpas3885ww")]
[Description(@"Customer authentication capabilities available on an ATM.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
public enum CardholderVerificationCapability3Code
{
    /// <summary>
    /// Online PIN (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_uI4vAYn7EeShMpas3885ww")]
    [Description(@"Online PIN (Personal Identification Number).")]
    OnLinePIN = CardholderVerificationCapabilityCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline PIN in clear (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_v1O8EYn7EeShMpas3885ww")]
    [Description(@"Offline PIN in clear (Personal Identification Number).")]
    OfflinePINClear = CardholderVerificationCapabilityCode.OfflinePINClear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline PIN encrypted (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FEPN&quot;.
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_v7pGEYn7EeShMpas3885ww")]
    [Description(@"Offline PIN encrypted (Personal Identification Number).")]
    OfflinePINEncrypted = CardholderVerificationCapabilityCode.OfflinePINEncrypted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline digital signature analysis.
    /// Encoded/decoded by serializers as &quot;FDSG&quot;.
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_xFjUcYn7EeShMpas3885ww")]
    [Description(@"Offline digital signature analysis.")]
    OfflineDigitalSignature = CardholderVerificationCapabilityCode.OfflineDigitalSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline biometrics.
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_x1FT8Yn7EeShMpas3885ww")]
    [Description(@"Offline biometrics.")]
    OfflineBiometrics = CardholderVerificationCapabilityCode.OfflineBiometrics, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline biographics.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_x6xsQYn7EeShMpas3885ww")]
    [Description(@"Offline biographics.")]
    OfflineBiographics = CardholderVerificationCapabilityCode.OfflineBiographics, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature.
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_ylWTQYn7EeShMpas3885ww")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    PKISignature = CardholderVerificationCapabilityCode.PKISignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Personal code of the customer for banking services.
    /// Encoded/decoded by serializers as &quot;PCOD&quot;.
    /// </summary>
    [EnumMember(Value = "PCOD")]
    [IsoId("_zQIVoYn7EeShMpas3885ww")]
    [Description(@"Personal code of the customer for banking services.")]
    PersonalCode = CardholderVerificationCapabilityCode.PersonalCode, // same ordinal as derivation source for type conversions
}
