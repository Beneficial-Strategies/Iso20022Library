// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method to authenticate the customer or its card.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_8QhnAIoaEeSirOZJBRz_nA")]
[Description(@"Method to authenticate the customer or its card.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
public enum AuthenticationMethod7Code
{
    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as &quot;TOKA&quot;.
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("_BIbxIYobEeSirOZJBRz_nA")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken = AuthenticationMethodCode.AuthenticationToken, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_CGhKAYobEeSirOZJBRz_nA")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_CV8tIYobEeSirOZJBRz_nA")]
    [Description(@"Customer mobile device.")]
    Mobile = AuthenticationMethodCode.Mobile, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other customer authentication.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_ChAGkYobEeSirOZJBRz_nA")]
    [Description(@"Other customer authentication.")]
    Other = AuthenticationMethodCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_DaprYYobEeSirOZJBRz_nA")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_DgP9EYobEeSirOZJBRz_nA")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_FZTJYYobEeSirOZJBRz_nA")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_FquQkYobEeSirOZJBRz_nA")]
    [Description(
        @"Electronic commerce transaction secured with the X.509 certificate of a customer."
    )]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_G1VpkYobEeSirOZJBRz_nA")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions
}
