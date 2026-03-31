// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Methods used to authenticate a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_gNeckBz3EeK5OKMB21JFBg")]
[Description(@"Methods used to authenticate a person.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AuthenticationMethod2Code>))]
#endif
public enum AuthenticationMethod2Code
{
    /// <summary>
    /// Authentication bypassed by the merchant.
    /// Encoded/decoded by serializers as &quot;BYPS&quot;.
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_iNkFARz3EeK5OKMB21JFBg")]
    [Description(@"Authentication bypassed by the merchant.")]
    Bypass = AuthenticationMethodCode.Bypass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_iU2_0xz3EeK5OKMB21JFBg")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant-related authentication.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_igBG8Rz3EeK5OKMB21JFBg")]
    [Description(@"Merchant-related authentication.")]
    MerchantAuthentication = AuthenticationMethodCode.MerchantAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_ilEmExz3EeK5OKMB21JFBg")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_iq4TIxz3EeK5OKMB21JFBg")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_iw1KIRz3EeK5OKMB21JFBg")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_i1u4QRz3EeK5OKMB21JFBg")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_i6y-cRz3EeK5OKMB21JFBg")]
    [Description(
        @"Electronic commerce transaction secured with the X.509 certificate of a customer."
    )]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_jAmEcRz3EeK5OKMB21JFBg")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as &quot;SNCT&quot;.
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_jG12YRz3EeK5OKMB21JFBg")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate = AuthenticationMethodCode.SecureNoCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_jL58kxz3EeK5OKMB21JFBg")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication method is performed unknown.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_jSTfgxz3EeK5OKMB21JFBg")]
    [Description(@"Authentication method is performed unknown.")]
    UnknownMethod = AuthenticationMethodCode.UnknownMethod, // same ordinal as derivation source for type conversions
}
