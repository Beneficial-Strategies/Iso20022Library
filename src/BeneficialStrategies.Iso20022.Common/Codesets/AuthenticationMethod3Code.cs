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
[IsoId("_WJVuUWjNEeSHBr6v3XO0Mg")]
[Description(@"Methods used to authenticate a person.")]
[DerivedFrom(typeof(AuthenticationMethodCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<AuthenticationMethod3Code>))]
#endif
public enum AuthenticationMethod3Code
{
    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_WW8siWjNEeSHBr6v3XO0Mg")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN = AuthenticationMethodCode.OnLinePIN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_WW8si2jNEeSHBr6v3XO0Mg")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature = AuthenticationMethodCode.PaperSignature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_WW8sjWjNEeSHBr6v3XO0Mg")]
    [Description(@"Authentication by a password.")]
    Password = AuthenticationMethodCode.Password, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_WW8sj2jNEeSHBr6v3XO0Mg")]
    [Description(
        @"Electronic commerce transaction secured with the X.509 certificate of a customer."
    )]
    SecureCertificate = AuthenticationMethodCode.SecureCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_WW8skWjNEeSHBr6v3XO0Mg")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel = AuthenticationMethodCode.SecuredChannel, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as &quot;SNCT&quot;.
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_WW8sk2jNEeSHBr6v3XO0Mg")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate = AuthenticationMethodCode.SecureNoCertificate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_WW8slWjNEeSHBr6v3XO0Mg")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture = AuthenticationMethodCode.SignatureCapture, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as &quot;ADDB&quot;.
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_RqDDEWjOEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification = AuthenticationMethodCode.BillingAddressVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_RxyCwWjOEeSHBr6v3XO0Mg")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry = AuthenticationMethodCode.Biometry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as &quot;CDHI&quot;.
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_XzNZsWjOEeSHBr6v3XO0Mg")]
    [Description(
        @"Cardholder data provided for verification, for instance social security number, driver license number, passport number."
    )]
    CardholderIdentificationData = AuthenticationMethodCode.CardholderIdentificationData, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRYP&quot;.
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_X-MhsWjOEeSHBr6v3XO0Mg")]
    [Description(
        @"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram)."
    )]
    CryptogramVerification = AuthenticationMethodCode.CryptogramVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as &quot;CSCV&quot;.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_YIV8MWjOEeSHBr6v3XO0Mg")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification = AuthenticationMethodCode.CSCVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as &quot;PSVE&quot;.
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_vs0TIWjOEeSHBr6v3XO0Mg")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication = AuthenticationMethodCode.PassiveAuthentication, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_wKgUsWjOEeSHBr6v3XO0Mg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce = AuthenticationMethodCode.SecureElectronicCommerce, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_wc0MsWjOEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification = AuthenticationMethodCode.ShippingAddressVerification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_wva_oWjOEeSHBr6v3XO0Mg")]
    [Description(
        @"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token."
    )]
    TokenAuthentication = AuthenticationMethodCode.TokenAuthentication, // same ordinal as derivation source for type conversions
}
