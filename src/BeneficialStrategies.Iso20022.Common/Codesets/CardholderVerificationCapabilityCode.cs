// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TWPA1AEcEeCQm6a_G2yO_w_1625416412")]
[Description(@"Cardholder verification capabilities of the POI (Personal Identification Number) performing the transaction.")]
[Derivations(typeof(CardholderVerificationCapability5Code),typeof(CardholderVerificationCapability2Code),typeof(CardholderVerificationCapability1Code),typeof(CardholderVerificationCapability3Code),typeof(CardholderVerificationCapability4Code))]
public enum CardholderVerificationCapabilityCode
{
    /// <summary>
    /// Manual signature verification.
    /// Encoded/decoded by serializers as &quot;MNSG&quot;.
    /// </summary>
    [EnumMember(Value = "MNSG")]
    [IsoId("_TWPA1QEcEeCQm6a_G2yO_w_1195784045")]
    [Description(@"Manual signature verification.")]
    ManualSignature,
    
    /// <summary>
    /// Online PIN (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_TWPA1gEcEeCQm6a_G2yO_w_-814172813")]
    [Description(@"Online PIN (Personal Identification Number).")]
    OnLinePIN,
    
    /// <summary>
    /// Offline PIN in clear (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_TWPA1wEcEeCQm6a_G2yO_w_-1449204659")]
    [Description(@"Offline PIN in clear (Personal Identification Number).")]
    OfflinePINClear,
    
    /// <summary>
    /// Offline PIN encrypted (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FEPN&quot;.
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_TWPA2AEcEeCQm6a_G2yO_w_986626635")]
    [Description(@"Offline PIN encrypted (Personal Identification Number).")]
    OfflinePINEncrypted,
    
    /// <summary>
    /// Offline digital signature analysis.
    /// Encoded/decoded by serializers as &quot;FDSG&quot;.
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_TWPA2QEcEeCQm6a_G2yO_w_1365064615")]
    [Description(@"Offline digital signature analysis.")]
    OfflineDigitalSignature,
    
    /// <summary>
    /// Offline biometrics.
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_TWPA2gEcEeCQm6a_G2yO_w_2114730991")]
    [Description(@"Offline biometrics.")]
    OfflineBiometrics,
    
    /// <summary>
    /// Other manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MNVR&quot;.
    /// </summary>
    [EnumMember(Value = "MNVR")]
    [IsoId("_TWPA2wEcEeCQm6a_G2yO_w_-589241705")]
    [Description(@"Other manual verification, for example passport or drivers license.")]
    ManualVerification,
    
    /// <summary>
    /// Offline biographics.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_TWPA3AEcEeCQm6a_G2yO_w_1155907205")]
    [Description(@"Offline biographics.")]
    OfflineBiographics,
    
    /// <summary>
    /// Account based digital signature.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_TWPA3QEcEeCQm6a_G2yO_w_726274838")]
    [Description(@"Account based digital signature.")]
    AccountDigitalSignature,
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature.
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_TWPA3gEcEeCQm6a_G2yO_w_-840693528")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    PKISignature,
    
    /// <summary>
    /// Cardholder authentication data.
    /// Encoded/decoded by serializers as &quot;CHDT&quot;.
    /// </summary>
    [EnumMember(Value = "CHDT")]
    [IsoId("_TWPA3wEcEeCQm6a_G2yO_w_517117428")]
    [Description(@"Cardholder authentication data.")]
    CardholderData,
    
    /// <summary>
    /// Three domain secure (three domain secure authentication of the cardholder).
    /// Encoded/decoded by serializers as &quot;SCEC&quot;.
    /// </summary>
    [EnumMember(Value = "SCEC")]
    [IsoId("_TWPA4AEcEeCQm6a_G2yO_w_-872664292")]
    [Description(@"Three domain secure (three domain secure authentication of the cardholder).")]
    SecureElectronicCommerce,
    
    /// <summary>
    /// Unknown cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_fnCJYHr4EeSZrs_hiwNOWA")]
    [Description(@"Unknown cardholder verification capability.")]
    Unknown,
    
    /// <summary>
    /// Personal code of the customer for banking services.
    /// Encoded/decoded by serializers as &quot;PCOD&quot;.
    /// </summary>
    [EnumMember(Value = "PCOD")]
    [IsoId("_lRX7wIn7EeShMpas3885ww")]
    [Description(@"Personal code of the customer for banking services.")]
    PersonalCode,
    
    /// <summary>
    /// No cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_lnLzAC6nEeWc7f-D6ByqMg")]
    [Description(@"No cardholder verification capability.")]
    NoCapabilities,
    
    /// <summary>
    /// Online biometrics.
    /// Encoded/decoded by serializers as &quot;NBIO&quot;.
    /// </summary>
    [EnumMember(Value = "NBIO")]
    [IsoId("_rTICIC6nEeWc7f-D6ByqMg")]
    [Description(@"Online biometrics.")]
    OnLineBiometrics,
    
    /// <summary>
    /// Other cardholder verification capabilities.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uQkqsC6nEeWc7f-D6ByqMg")]
    [Description(@"Other cardholder verification capabilities.")]
    Other,
    
    /// <summary>
    /// Other type of cardholder verification defined at national level
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_XnX7FXx8EemHsOqJOzMVfg")]
    [Description(@"Other type of cardholder verification defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other type of cardholder verification defined in a private manner.
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_XnX7Fnx8EemHsOqJOzMVfg")]
    [Description(@"Other type of cardholder verification defined in a private manner.")]
    OtherPrivate,
    
    /// <summary>
    /// Handwritten signature verification
    /// Encoded/decoded by serializers as &quot;SIGN&quot;.
    /// </summary>
    [EnumMember(Value = "SIGN")]
    [IsoId("_XnX7F3x8EemHsOqJOzMVfg")]
    [Description(@"Handwritten signature verification")]
    Signature,
    
    /// <summary>
    /// Cardholder verification capability unspecified.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_XnX7GHx8EemHsOqJOzMVfg")]
    [Description(@"Cardholder verification capability unspecified.")]
    Unspecified,
    
    /// <summary>
    /// Recognition by voice.
    /// Encoded/decoded by serializers as &quot;VORN&quot;.
    /// </summary>
    [EnumMember(Value = "VORN")]
    [IsoId("_XnX7GXx8EemHsOqJOzMVfg")]
    [Description(@"Recognition by voice.")]
    VoiceRecognition,
    
    /// <summary>
    /// Device has no pin entry capability.
    /// Encoded/decoded by serializers as &quot;NOPN&quot;.
    /// </summary>
    [EnumMember(Value = "NOPN")]
    [IsoId("_swD6UJKcEempjNUC7bi_Ng")]
    [Description(@"Device has no pin entry capability.")]
    NoPINEntry,
    
    /// <summary>
    /// Device has no online pin entry capability.
    /// Encoded/decoded by serializers as &quot;NOOP&quot;.
    /// </summary>
    [EnumMember(Value = "NOOP")]
    [IsoId("_EGQOoBqaEeqH1IQNpbVpEw")]
    [Description(@"Device has no online pin entry capability.")]
    NoOnLinePINEntry,
    
}
