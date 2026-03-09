// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Capability of verifying the cardholder&apos;s identity or authenticity.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_4lWdQEevEee9r7QjOdsbFw")]
[Description(@"Capability of verifying the cardholder's identity or authenticity.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
public enum CardholderVerificationCapability5Code
{
    /// <summary>
    /// Account based digital signature.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_3CLlwX0kEemfrNOe0zHQyg")]
    [Description(@"Account based digital signature.")]
    AccountDigitalSignature = CardholderVerificationCapabilityCode.AccountDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_3CLlw30kEemfrNOe0zHQyg")]
    [Description(@"No cardholder verification capability.")]
    NoCapabilities = CardholderVerificationCapabilityCode.NoCapabilities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline biographics.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_3CLlxX0kEemfrNOe0zHQyg")]
    [Description(@"Offline biographics.")]
    OfflineBiographics = CardholderVerificationCapabilityCode.OfflineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline biometrics.
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_3CLlx30kEemfrNOe0zHQyg")]
    [Description(@"Offline biometrics.")]
    OfflineBiometrics = CardholderVerificationCapabilityCode.OfflineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline digital signature analysis.
    /// Encoded/decoded by serializers as &quot;FDSG&quot;.
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_3CLlyX0kEemfrNOe0zHQyg")]
    [Description(@"Offline digital signature analysis.")]
    OfflineDigitalSignature = CardholderVerificationCapabilityCode.OfflineDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline PIN in clear (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_3CLly30kEemfrNOe0zHQyg")]
    [Description(@"Offline PIN in clear (Personal Identification Number).")]
    OfflinePINClear = CardholderVerificationCapabilityCode.OfflinePINClear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline PIN encrypted (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FEPN&quot;.
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_3CLlzX0kEemfrNOe0zHQyg")]
    [Description(@"Offline PIN encrypted (Personal Identification Number).")]
    OfflinePINEncrypted = CardholderVerificationCapabilityCode.OfflinePINEncrypted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online biometrics.
    /// Encoded/decoded by serializers as &quot;NBIO&quot;.
    /// </summary>
    [EnumMember(Value = "NBIO")]
    [IsoId("_3CLlz30kEemfrNOe0zHQyg")]
    [Description(@"Online biometrics.")]
    OnLineBiometrics = CardholderVerificationCapabilityCode.OnLineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online PIN (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_3CLl0X0kEemfrNOe0zHQyg")]
    [Description(@"Online PIN (Personal Identification Number).")]
    OnLinePIN = CardholderVerificationCapabilityCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of cardholder verification defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_3CLl030kEemfrNOe0zHQyg")]
    [Description(@"Other type of cardholder verification defined at national level")]
    OtherNational = CardholderVerificationCapabilityCode.OtherNational, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other type of cardholder verification defined in a private manner.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_3CLl1X0kEemfrNOe0zHQyg")]
    [Description(@"Other type of cardholder verification defined in a private manner.")]
    OtherPrivate = CardholderVerificationCapabilityCode.OtherPrivate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Handwritten signature verification
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_3CLl130kEemfrNOe0zHQyg")]
    [Description(@"Handwritten signature verification")]
    Signature = CardholderVerificationCapabilityCode.Signature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder verification capability unspecified.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_3CLl2X0kEemfrNOe0zHQyg")]
    [Description(@"Cardholder verification capability unspecified.")]
    Unspecified = CardholderVerificationCapabilityCode.Unspecified, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Recognition by voice.
    /// Encoded/decoded by serializers as &quot;VORN&quot;.
    /// </summary>
    [EnumMember(Value = "VORN")]
    [IsoId("_3CLl230kEemfrNOe0zHQyg")]
    [Description(@"Recognition by voice.")]
    VoiceRecognition = CardholderVerificationCapabilityCode.VoiceRecognition, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature.
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_3CLl3X0kEemfrNOe0zHQyg")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    PKISignature = CardholderVerificationCapabilityCode.PKISignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device has no pin entry capability.
    /// Encoded/decoded by serializers as &quot;NOPN&quot;.
    /// </summary>
    [EnumMember(Value = "NOPN")]
    [IsoId("_9pG7EZKcEempjNUC7bi_Ng")]
    [Description(@"Device has no pin entry capability.")]
    NoPINEntry = CardholderVerificationCapabilityCode.NoPINEntry, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Device has no online pin entry capability.
    /// Encoded/decoded by serializers as &quot;NOOP&quot;.
    /// </summary>
    [EnumMember(Value = "NOOP")]
    [IsoId("_ZEDeQRqaEeqH1IQNpbVpEw")]
    [Description(@"Device has no online pin entry capability.")]
    NoOnLinePINEntry = CardholderVerificationCapabilityCode.NoOnLinePINEntry, // same ordinal as derivation source for type conversions
    
}
