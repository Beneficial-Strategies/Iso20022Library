// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to authenticate a cardholder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TSNccAEcEeCQm6a_G2yO_w_-183697186")]
[Description(@"Method used to authenticate a cardholder.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod1Code
{
    /// <summary>
    /// Authentication method is performed unknown.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_TSNccQEcEeCQm6a_G2yO_w_1383005329")]
    [Description(@"Authentication method is performed unknown.")]
    UnknownMethod = AuthenticationMethodCode.UnknownMethod, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication bypassed by the merchant.
    /// Encoded/decoded by serializers as &quot;BYPS&quot;.
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_TSNccgEcEeCQm6a_G2yO_w_-487293540")]
    [Description(@"Authentication bypassed by the merchant.")]
    Bypass = AuthenticationMethodCode.Bypass, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_TSNccwEcEeCQm6a_G2yO_w_-33206271")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_TSNcdAEcEeCQm6a_G2yO_w_-44305048")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_TSNcdQEcEeCQm6a_G2yO_w_877858262")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_TSNcdgEcEeCQm6a_G2yO_w_431064513")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_TSNcdwEcEeCQm6a_G2yO_w_-1926677610")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Merchant-related authentication.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TSNceAEcEeCQm6a_G2yO_w_756182020")]
    [Description(@"Merchant-related authentication.")]
    MerchantAuthentication = AuthenticationMethodCode.MerchantAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_TSNceQEcEeCQm6a_G2yO_w_-1601560103")]
    [Description(
        @"Electronic commerce transaction secured with the X.509 certificate of a customer."
    )]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as &quot;SNCT&quot;.
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_TSNcegEcEeCQm6a_G2yO_w_838368064")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate = AuthenticationMethodCode.SecureNoCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_TSNcewEcEeCQm6a_G2yO_w_1370210617")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions
}
