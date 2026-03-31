// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cardholder verification capabilities by the terminal.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_xNKR4ZdFEeWhUvuI1bSHSA")]
[Description(@"Cardholder verification capabilities by the terminal.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<CardholderVerificationCapability4Code>))]
#endif
public enum CardholderVerificationCapability4Code
{
    /// <summary>
    /// Account based digital signature.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_xYoiEZdFEeWhUvuI1bSHSA")]
    [Description(@"Account based digital signature.")]
    AccountDigitalSignature = CardholderVerificationCapabilityCode.AccountDigitalSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder authentication data.
    /// Encoded/decoded by serializers as &quot;CHDT&quot;.
    /// </summary>
    [EnumMember(Value = "CHDT")]
    [IsoId("_xYoiE5dFEeWhUvuI1bSHSA")]
    [Description(@"Cardholder authentication data.")]
    CardholderData = CardholderVerificationCapabilityCode.CardholderData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manual signature verification.
    /// Encoded/decoded by serializers as &quot;MNSG&quot;.
    /// </summary>
    [EnumMember(Value = "MNSG")]
    [IsoId("_xYoiFZdFEeWhUvuI1bSHSA")]
    [Description(@"Manual signature verification.")]
    ManualSignature = CardholderVerificationCapabilityCode.ManualSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MNVR&quot;.
    /// </summary>
    [EnumMember(Value = "MNVR")]
    [IsoId("_xYoiF5dFEeWhUvuI1bSHSA")]
    [Description(@"Other manual verification, for example passport or drivers license.")]
    ManualVerification = CardholderVerificationCapabilityCode.ManualVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline biographics.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_xYoiGZdFEeWhUvuI1bSHSA")]
    [Description(@"Offline biographics.")]
    OfflineBiographics = CardholderVerificationCapabilityCode.OfflineBiographics, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline biometrics.
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_xYoiG5dFEeWhUvuI1bSHSA")]
    [Description(@"Offline biometrics.")]
    OfflineBiometrics = CardholderVerificationCapabilityCode.OfflineBiometrics, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline digital signature analysis.
    /// Encoded/decoded by serializers as &quot;FDSG&quot;.
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_xYoiHZdFEeWhUvuI1bSHSA")]
    [Description(@"Offline digital signature analysis.")]
    OfflineDigitalSignature = CardholderVerificationCapabilityCode.OfflineDigitalSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline PIN in clear (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_xYoiH5dFEeWhUvuI1bSHSA")]
    [Description(@"Offline PIN in clear (Personal Identification Number).")]
    OfflinePINClear = CardholderVerificationCapabilityCode.OfflinePINClear, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Offline PIN encrypted (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FEPN&quot;.
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_xYoiIZdFEeWhUvuI1bSHSA")]
    [Description(@"Offline PIN encrypted (Personal Identification Number).")]
    OfflinePINEncrypted = CardholderVerificationCapabilityCode.OfflinePINEncrypted, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Online PIN (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_xYoiI5dFEeWhUvuI1bSHSA")]
    [Description(@"Online PIN (Personal Identification Number).")]
    OnLinePIN = CardholderVerificationCapabilityCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature.
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_xYoiJZdFEeWhUvuI1bSHSA")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    PKISignature = CardholderVerificationCapabilityCode.PKISignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Three domain secure (three domain secure authentication of the cardholder).
    /// Encoded/decoded by serializers as &quot;SCEC&quot;.
    /// </summary>
    [EnumMember(Value = "SCEC")]
    [IsoId("_xYoiJ5dFEeWhUvuI1bSHSA")]
    [Description(@"Three domain secure (three domain secure authentication of the cardholder).")]
    SecureElectronicCommerce = CardholderVerificationCapabilityCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Online biometrics.
    /// Encoded/decoded by serializers as &quot;NBIO&quot;.
    /// </summary>
    [EnumMember(Value = "NBIO")]
    [IsoId("_xYoiK5dFEeWhUvuI1bSHSA")]
    [Description(@"Online biometrics.")]
    OnLineBiometrics = CardholderVerificationCapabilityCode.OnLineBiometrics, // same ordinal as derivation source for type conversions

    /// <summary>
    /// No cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_xYoiLZdFEeWhUvuI1bSHSA")]
    [Description(@"No cardholder verification capability.")]
    NoCapabilities = CardholderVerificationCapabilityCode.NoCapabilities, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other cardholder verification capabilities.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_xYoiL5dFEeWhUvuI1bSHSA")]
    [Description(@"Other cardholder verification capabilities.")]
    Other = CardholderVerificationCapabilityCode.Other, // same ordinal as derivation source for type conversions
}
