// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Cardholder verification capabilities by the terminal. 
/// It correspond to the ISO 8583, field number 22-2 for the versions 87 and 93, and 27-2 for the version 2003.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_juNaIHr4EeSZrs_hiwNOWA")]
[Description(@"Cardholder verification capabilities by the terminal. |It correspond to the ISO 8583, field number 22-2 for the versions 87 and 93, and 27-2 for the version 2003.")]
[DerivedFrom(typeof(CardholderVerificationCapabilityCode))]
public enum CardholderVerificationCapability2Code
{
    /// <summary>
    /// Account based digital signature.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_oXmnIXr4EeSZrs_hiwNOWA")]
    [Description(@"Account based digital signature.")]
    AccountDigitalSignature = CardholderVerificationCapabilityCode.AccountDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Cardholder authentication data.
    /// Encoded/decoded by serializers as &quot;CHDT&quot;.
    /// </summary>
    [EnumMember(Value = "CHDT")]
    [IsoId("_o1Ks4Xr4EeSZrs_hiwNOWA")]
    [Description(@"Cardholder authentication data.")]
    CardholderData = CardholderVerificationCapabilityCode.CardholderData, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Manual signature verification.
    /// Encoded/decoded by serializers as &quot;MNSG&quot;.
    /// </summary>
    [EnumMember(Value = "MNSG")]
    [IsoId("_o6OzEXr4EeSZrs_hiwNOWA")]
    [Description(@"Manual signature verification.")]
    ManualSignature = CardholderVerificationCapabilityCode.ManualSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MNVR&quot;.
    /// </summary>
    [EnumMember(Value = "MNVR")]
    [IsoId("_o-aIcXr4EeSZrs_hiwNOWA")]
    [Description(@"Other manual verification, for example passport or drivers license.")]
    ManualVerification = CardholderVerificationCapabilityCode.ManualVerification, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline biographics.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_pEN1gXr4EeSZrs_hiwNOWA")]
    [Description(@"Offline biographics.")]
    OfflineBiographics = CardholderVerificationCapabilityCode.OfflineBiographics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline biometrics.
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_pJldsXr4EeSZrs_hiwNOWA")]
    [Description(@"Offline biometrics.")]
    OfflineBiometrics = CardholderVerificationCapabilityCode.OfflineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline digital signature analysis.
    /// Encoded/decoded by serializers as &quot;FDSG&quot;.
    /// </summary>
    [EnumMember(Value = "FDSG")]
    [IsoId("_pOzU4Xr4EeSZrs_hiwNOWA")]
    [Description(@"Offline digital signature analysis.")]
    OfflineDigitalSignature = CardholderVerificationCapabilityCode.OfflineDigitalSignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline PIN in clear (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_pWQAsXr4EeSZrs_hiwNOWA")]
    [Description(@"Offline PIN in clear (Personal Identification Number).")]
    OfflinePINClear = CardholderVerificationCapabilityCode.OfflinePINClear, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Offline PIN encrypted (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FEPN&quot;.
    /// </summary>
    [EnumMember(Value = "FEPN")]
    [IsoId("_pbd34Xr4EeSZrs_hiwNOWA")]
    [Description(@"Offline PIN encrypted (Personal Identification Number).")]
    OfflinePINEncrypted = CardholderVerificationCapabilityCode.OfflinePINEncrypted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online PIN (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_pglBYXr4EeSZrs_hiwNOWA")]
    [Description(@"Online PIN (Personal Identification Number).")]
    OnLinePIN = CardholderVerificationCapabilityCode.OnLinePIN, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature.
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_pmGakXr4EeSZrs_hiwNOWA")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature.")]
    PKISignature = CardholderVerificationCapabilityCode.PKISignature, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Three domain secure (three domain secure authentication of the cardholder).
    /// Encoded/decoded by serializers as &quot;SCEC&quot;.
    /// </summary>
    [EnumMember(Value = "SCEC")]
    [IsoId("_prnMsXr4EeSZrs_hiwNOWA")]
    [Description(@"Three domain secure (three domain secure authentication of the cardholder).")]
    SecureElectronicCommerce = CardholderVerificationCapabilityCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Unknown cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;UNKW&quot;.
    /// </summary>
    [EnumMember(Value = "UNKW")]
    [IsoId("_pwPOAXr4EeSZrs_hiwNOWA")]
    [Description(@"Unknown cardholder verification capability.")]
    Unknown = CardholderVerificationCapabilityCode.Unknown, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Online biometrics.
    /// Encoded/decoded by serializers as &quot;NBIO&quot;.
    /// </summary>
    [EnumMember(Value = "NBIO")]
    [IsoId("_tV7gAS6qEeWc7f-D6ByqMg")]
    [Description(@"Online biometrics.")]
    OnLineBiometrics = CardholderVerificationCapabilityCode.OnLineBiometrics, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// No cardholder verification capability.
    /// Encoded/decoded by serializers as &quot;NOVF&quot;.
    /// </summary>
    [EnumMember(Value = "NOVF")]
    [IsoId("_tp5k4S6qEeWc7f-D6ByqMg")]
    [Description(@"No cardholder verification capability.")]
    NoCapabilities = CardholderVerificationCapabilityCode.NoCapabilities, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other cardholder verification capabilities.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_uD1H0S6qEeWc7f-D6ByqMg")]
    [Description(@"Other cardholder verification capabilities.")]
    Other = CardholderVerificationCapabilityCode.Other, // same ordinal as derivation source for type conversions
    
}
