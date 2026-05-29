// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Capability of verifying the cardholder's identity or authenticity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_cXnnsWP0EfCX7uJiAWHfoQ")]
[Description(@"Capability of verifying the cardholder's identity or authenticity.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<CardholderVerificationCapability6Code>))]
public enum CardholderVerificationCapability6Code
{
    /// <summary>
    /// Account digital signature.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_caD3sWP0EfCX7uJiAWHfoQ")]
    [Description(@"Account digital signature.")]
    AccountDigitalSignature = CardholderVerificationCapabilityCode.AccountDigitalSignature,

    /// <summary>
    /// No cardholder verification capabilities.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_caD3s2P0EfCX7uJiAWHfoQ")]
    [Description(@"No cardholder verification capabilities.")]
    NoCapabilities = CardholderVerificationCapabilityCode.NoCapabilities,

    /// <summary>
    /// Off-line biographics.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_caD3tWP0EfCX7uJiAWHfoQ")]
    [Description(@"Off-line biographics.")]
    OfflineBiographics = CardholderVerificationCapabilityCode.OfflineBiographics,

    /// <summary>
    /// Off-line biometrics.
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_caD3t2P0EfCX7uJiAWHfoQ")]
    [Description(@"Off-line biometrics.")]
    OfflineBiometrics = CardholderVerificationCapabilityCode.OfflineBiometrics,

    /// <summary>
    /// Off-line digital signature.
    /// Encoded/decoded by serializers as &quot;FDSG&quot;.
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_caD3uWP0EfCX7uJiAWHfoQ")]
    [Description(@"Off-line digital signature.")]
    OfflineDigitalSignature = CardholderVerificationCapabilityCode.OfflineDigitalSignature,

    /// <summary>
    /// Off-line PIN in clear.
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_caD3u2P0EfCX7uJiAWHfoQ")]
    [Description(@"Off-line PIN in clear.")]
    OfflinePINClear = CardholderVerificationCapabilityCode.OfflinePINClear,

    /// <summary>
    /// Off-line encrypted PIN.
    /// Encoded/decoded by serializers as &quot;FEPN&quot;.
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_caD3vWP0EfCX7uJiAWHfoQ")]
    [Description(@"Off-line encrypted PIN.")]
    OfflinePINEncrypted = CardholderVerificationCapabilityCode.OfflinePINEncrypted,

    /// <summary>
    /// On-line biometrics.
    /// Encoded/decoded by serializers as &quot;NBIO&quot;.
    /// </summary>
    [EnumMember(Value = "NBIO")]
    [IsoId("_caD3v2P0EfCX7uJiAWHfoQ")]
    [Description(@"On-line biometrics.")]
    OnLineBiometrics = CardholderVerificationCapabilityCode.OnLineBiometrics,

    /// <summary>
    /// On-line PIN.
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_caD3wWP0EfCX7uJiAWHfoQ")]
    [Description(@"On-line PIN.")]
    OnLinePIN = CardholderVerificationCapabilityCode.OnLinePIN,

    /// <summary>
    /// Signature.
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_caD3x2P0EfCX7uJiAWHfoQ")]
    [Description(@"Signature.")]
    Signature = CardholderVerificationCapabilityCode.Signature,

    /// <summary>
    /// Unspecified cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_caD3yWP0EfCX7uJiAWHfoQ")]
    [Description(@"Unspecified cardholder verification capability.")]
    Unspecified = CardholderVerificationCapabilityCode.Unspecified,

    /// <summary>
    /// Voice recognition.
    /// Encoded/decoded by serializers as &quot;VORN&quot;.
    /// </summary>
    [EnumMember(Value = "VORN")]
    [IsoId("_caD3y2P0EfCX7uJiAWHfoQ")]
    [Description(@"Voice recognition.")]
    VoiceRecognition = CardholderVerificationCapabilityCode.VoiceRecognition,

    /// <summary>
    /// PKI signature.
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_caD3zWP0EfCX7uJiAWHfoQ")]
    [Description(@"PKI signature.")]
    PKISignature = CardholderVerificationCapabilityCode.PKISignature,

    /// <summary>
    /// No PIN entry.
    /// Encoded/decoded by serializers as &quot;NOPN&quot;.
    /// </summary>
    [EnumMember(Value = "NOPN")]
    [IsoId("_caD3z2P0EfCX7uJiAWHfoQ")]
    [Description(@"No PIN entry.")]
    NoPINEntry = CardholderVerificationCapabilityCode.NoPINEntry,

    /// <summary>
    /// No on-line PIN entry.
    /// Encoded/decoded by serializers as &quot;NOOP&quot;.
    /// </summary>
    [EnumMember(Value = "NOOP")]
    [IsoId("_caD30WP0EfCX7uJiAWHfoQ")]
    [Description(@"No on-line PIN entry.")]
    NoOnLinePINEntry = CardholderVerificationCapabilityCode.NoOnLinePINEntry,

    /// <summary>
    /// Other cardholder verification capabilities.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_MvJ4MX3WEfCmC4yYaU27Kg")]
    [Description(@"Other cardholder verification capabilities.")]
    Other = CardholderVerificationCapabilityCode.Other,
}
