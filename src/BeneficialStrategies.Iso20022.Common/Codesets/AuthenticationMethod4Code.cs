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
[IsoId("_xot1wWjnEeSDR-pyia6Xtg")]
[Description(@"Methods used to authenticate a person.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AuthenticationMethod4Code>))]
#endif
public enum AuthenticationMethod4Code
{
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_x2RJkWjnEeSDR-pyia6Xtg")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_x2RJk2jnEeSDR-pyia6Xtg")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_x2RJlWjnEeSDR-pyia6Xtg")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_x2RJl2jnEeSDR-pyia6Xtg")]
    [Description(
        @"Electronic commerce transaction secured with the X.509 certificate of a customer."
    )]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_x2RJmWjnEeSDR-pyia6Xtg")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as &quot;SNCT&quot;.
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_x2RJm2jnEeSDR-pyia6Xtg")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate = AuthenticationMethodCode.SecureNoCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_x2RJnWjnEeSDR-pyia6Xtg")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as &quot;ADDB&quot;.
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_x2RJn2jnEeSDR-pyia6Xtg")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification = AuthenticationMethodCode.BillingAddressVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_x2RJoWjnEeSDR-pyia6Xtg")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as &quot;CDHI&quot;.
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_x2RJo2jnEeSDR-pyia6Xtg")]
    [Description(
        @"Cardholder data provided for verification, for instance social security number, driver license number, passport number."
    )]
    CardholderIdentificationData = AuthenticationMethodCode.CardholderIdentificationData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRYP&quot;.
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_x2RJpWjnEeSDR-pyia6Xtg")]
    [Description(
        @"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram)."
    )]
    CryptogramVerification = AuthenticationMethodCode.CryptogramVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as &quot;CSCV&quot;.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_x2RJp2jnEeSDR-pyia6Xtg")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification = AuthenticationMethodCode.CSCVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as &quot;PSVE&quot;.
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_x2RJqWjnEeSDR-pyia6Xtg")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication = AuthenticationMethodCode.PassiveAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_x2RJq2jnEeSDR-pyia6Xtg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce = AuthenticationMethodCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_x2RJrWjnEeSDR-pyia6Xtg")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification = AuthenticationMethodCode.ShippingAddressVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_x2RJr2jnEeSDR-pyia6Xtg")]
    [Description(
        @"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token."
    )]
    TokenAuthentication = AuthenticationMethodCode.TokenAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_0j-tAWjnEeSDR-pyia6Xtg")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification = AuthenticationMethodCode.ManualVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_06-3wWjnEeSDR-pyia6Xtg")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN = AuthenticationMethodCode.OfflinePIN, // same ordinal as derivation source for type conversions
}
