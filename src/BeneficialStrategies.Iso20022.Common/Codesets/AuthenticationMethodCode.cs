// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Method used to authenticate a cardholder.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TV8F4AEcEeCQm6a_G2yO_w_-487459684")]
[Description(@"Method used to authenticate a cardholder.")]
[Derivations(
    typeof(AuthenticationMethod11Code),
    typeof(AuthenticationMethod4Code),
    typeof(AuthenticationMethod2Code),
    typeof(AuthenticationMethod7Code),
    typeof(AuthenticationMethod5Code),
    typeof(AuthenticationMethod6Code),
    typeof(AuthenticationMethod3Code),
    typeof(AuthenticationMethod12Code),
    typeof(AuthenticationMethod8Code),
    typeof(AuthenticationMethod1Code)
)]
public enum AuthenticationMethodCode
{
    /// <summary>
    /// Authentication method is performed unknown.
    /// Encoded/decoded by serializers as &quot;UKNW&quot;.
    /// </summary>
    [EnumMember(Value = "UKNW")]
    [IsoId("_TV8F4QEcEeCQm6a_G2yO_w_567294757")]
    [Description(@"Authentication method is performed unknown.")]
    UnknownMethod,

    /// <summary>
    /// Authentication bypassed by the merchant.
    /// Encoded/decoded by serializers as &quot;BYPS&quot;.
    /// </summary>
    [EnumMember(Value = "BYPS")]
    [IsoId("_TV8F4gEcEeCQm6a_G2yO_w_-822486963")]
    [Description(@"Authentication bypassed by the merchant.")]
    Bypass,

    /// <summary>
    /// On-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;NPIN&quot;.
    /// </summary>
    [EnumMember(Value = "NPIN")]
    [IsoId("_TV8F4wEcEeCQm6a_G2yO_w_1462523475")]
    [Description(@"On-line PIN authentication (Personal Identification Number).")]
    OnLinePIN,

    /// <summary>
    /// Off-line PIN authentication (Personal Identification Number).
    /// Encoded/decoded by serializers as &quot;FPIN&quot;.
    /// </summary>
    [EnumMember(Value = "FPIN")]
    [IsoId("_TV8F5AEcEeCQm6a_G2yO_w_-1792409526")]
    [Description(@"Off-line PIN authentication (Personal Identification Number).")]
    OfflinePIN,

    /// <summary>
    /// Electronic signature capture (handwritten signature).
    /// Encoded/decoded by serializers as &quot;CPSG&quot;.
    /// </summary>
    [EnumMember(Value = "CPSG")]
    [IsoId("_TV8F5QEcEeCQm6a_G2yO_w_2072925403")]
    [Description(@"Electronic signature capture (handwritten signature).")]
    SignatureCapture,

    /// <summary>
    /// Handwritten paper signature.
    /// Encoded/decoded by serializers as &quot;PPSG&quot;.
    /// </summary>
    [EnumMember(Value = "PPSG")]
    [IsoId("_TV8F5gEcEeCQm6a_G2yO_w_-2090444660")]
    [Description(@"Handwritten paper signature.")]
    PaperSignature,

    /// <summary>
    /// Manual verification, for example passport or drivers license.
    /// Encoded/decoded by serializers as &quot;MANU&quot;.
    /// </summary>
    [EnumMember(Value = "MANU")]
    [IsoId("_TV8F5wEcEeCQm6a_G2yO_w_-743732481")]
    [Description(@"Manual verification, for example passport or drivers license.")]
    ManualVerification,

    /// <summary>
    /// Merchant-related authentication.
    /// Encoded/decoded by serializers as &quot;MERC&quot;.
    /// </summary>
    [EnumMember(Value = "MERC")]
    [IsoId("_TV8F6AEcEeCQm6a_G2yO_w_-2133514201")]
    [Description(@"Merchant-related authentication.")]
    MerchantAuthentication,

    /// <summary>
    /// Electronic commerce transaction secured with the X.509 certificate of a customer.
    /// Encoded/decoded by serializers as &quot;SCRT&quot;.
    /// </summary>
    [EnumMember(Value = "SCRT")]
    [IsoId("_TV8F6QEcEeCQm6a_G2yO_w_151496237")]
    [Description(
        @"Electronic commerce transaction secured with the X.509 certificate of a customer."
    )]
    SecureCertificate,

    /// <summary>
    /// Secure electronic transaction without cardholder certificate.
    /// Encoded/decoded by serializers as &quot;SNCT&quot;.
    /// </summary>
    [EnumMember(Value = "SNCT")]
    [IsoId("_TV8F6gEcEeCQm6a_G2yO_w_1554634082")]
    [Description(@"Secure electronic transaction without cardholder certificate.")]
    SecureNoCertificate,

    /// <summary>
    /// Channel-encrypted transaction.
    /// Encoded/decoded by serializers as &quot;SCNL&quot;.
    /// </summary>
    [EnumMember(Value = "SCNL")]
    [IsoId("_TV8F6wEcEeCQm6a_G2yO_w_761898165")]
    [Description(@"Channel-encrypted transaction.")]
    SecuredChannel,

    /// <summary>
    /// Authentication by a password.
    /// Encoded/decoded by serializers as &quot;PSWD&quot;.
    /// </summary>
    [EnumMember(Value = "PSWD")]
    [IsoId("_sQJJ8b4pEeKkGaJ0UrThyA_1833629628")]
    [Description(@"Authentication by a password.")]
    Password,

    /// <summary>
    /// Cardholder billing address verification.
    /// Encoded/decoded by serializers as &quot;ADDB&quot;.
    /// </summary>
    [EnumMember(Value = "ADDB")]
    [IsoId("_e8XqMGjNEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder billing address verification.")]
    BillingAddressVerification,

    /// <summary>
    /// Biometric authentication of the cardholder.
    /// Encoded/decoded by serializers as &quot;BIOM&quot;.
    /// </summary>
    [EnumMember(Value = "BIOM")]
    [IsoId("_h4zmIGjNEeSHBr6v3XO0Mg")]
    [Description(@"Biometric authentication of the cardholder.")]
    Biometry,

    /// <summary>
    /// Cardholder data provided for verification, for instance social security number, driver license number, passport number.
    /// Encoded/decoded by serializers as &quot;CDHI&quot;.
    /// </summary>
    [EnumMember(Value = "CDHI")]
    [IsoId("_lJxnoGjNEeSHBr6v3XO0Mg")]
    [Description(
        @"Cardholder data provided for verification, for instance social security number, driver license number, passport number."
    )]
    CardholderIdentificationData,

    /// <summary>
    /// Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;CRYP&quot;.
    /// </summary>
    [EnumMember(Value = "CRYP")]
    [IsoId("_vHcKoGjNEeSHBr6v3XO0Mg")]
    [Description(
        @"Verification of a cryptogram generated by a chip card or another device, for instance ARQC (Authorisation Request Cryptogram)."
    )]
    CryptogramVerification,

    /// <summary>
    /// Verification of Card Security Code.
    /// Encoded/decoded by serializers as &quot;CSCV&quot;.
    /// </summary>
    [EnumMember(Value = "CSCV")]
    [IsoId("_01RQIGjNEeSHBr6v3XO0Mg")]
    [Description(@"Verification of Card Security Code.")]
    CSCVerification,

    /// <summary>
    /// Authentication based on statistical cardholder behaviour.
    /// Encoded/decoded by serializers as &quot;PSVE&quot;.
    /// </summary>
    [EnumMember(Value = "PSVE")]
    [IsoId("_31GeUGjNEeSHBr6v3XO0Mg")]
    [Description(@"Authentication based on statistical cardholder behaviour.")]
    PassiveAuthentication,

    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;CSEC&quot;.
    /// </summary>
    [EnumMember(Value = "CSEC")]
    [IsoId("_8Qu8IGjNEeSHBr6v3XO0Mg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    SecureElectronicCommerce,

    /// <summary>
    /// Cardholder shipping address verification.
    /// Encoded/decoded by serializers as &quot;ADDS&quot;.
    /// </summary>
    [EnumMember(Value = "ADDS")]
    [IsoId("_ADNIMGjOEeSHBr6v3XO0Mg")]
    [Description(@"Cardholder shipping address verification.")]
    ShippingAddressVerification,

    /// <summary>
    /// Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_ECBHIGjOEeSHBr6v3XO0Mg")]
    [Description(
        @"Cryptogram generated by the token requestor or a customer device to validate the authorised use of a token."
    )]
    TokenAuthentication,

    /// <summary>
    /// Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token.
    /// Encoded/decoded by serializers as &quot;TOKP&quot;.
    /// </summary>
    [EnumMember(Value = "TOKP")]
    [IsoId("_-TkAYIIEEeS7UOLM47txvA")]
    [Description(
        @"Verification or authentication related to the use of a payment token, for instance the validation of the authorised use of a token."
    )]
    PaymentToken,

    /// <summary>
    /// A token is used to verify an already performed authentication.
    /// Encoded/decoded by serializers as &quot;TOKA&quot;.
    /// </summary>
    [EnumMember(Value = "TOKA")]
    [IsoId("_or5w0IoaEeSirOZJBRz_nA")]
    [Description(@"A token is used to verify an already performed authentication.")]
    AuthenticationToken,

    /// <summary>
    /// Customer mobile device.
    /// Encoded/decoded by serializers as &quot;MOBL&quot;.
    /// </summary>
    [EnumMember(Value = "MOBL")]
    [IsoId("_sHfG4IoaEeSirOZJBRz_nA")]
    [Description(@"Customer mobile device.")]
    Mobile,

    /// <summary>
    /// Other customer authentication.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_xzNTkIoaEeSirOZJBRz_nA")]
    [Description(@"Other customer authentication.")]
    Other,

    /// <summary>
    /// Digits of the address.
    /// Encoded/decoded by serializers as &quot;ADVF&quot;.
    /// </summary>
    [EnumMember(Value = "ADVF")]
    [IsoId("_NYJzdHyPEemHsOqJOzMVfg")]
    [Description(@"Digits of the address.")]
    AddressDigits,

    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNB&quot;.
    /// </summary>
    [EnumMember(Value = "ARNB")]
    [IsoId("_NYJzdXyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber,

    /// <summary>
    /// Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram).
    /// Encoded/decoded by serializers as &quot;ARQC&quot;.
    /// </summary>
    [EnumMember(Value = "ARQC")]
    [IsoId("_NYJzdnyPEemHsOqJOzMVfg")]
    [Description(
        @"Verification of a cryptogram generated by a chip card, for instance an ARQC (Authorisation Request Cryptogram)."
    )]
    ARQCVerification,

    /// <summary>
    /// Date of birth of a person.
    /// Encoded/decoded by serializers as &quot;BTHD&quot;.
    /// </summary>
    [EnumMember(Value = "BTHD")]
    [IsoId("_NYJzd3yPEemHsOqJOzMVfg")]
    [Description(@"Date of birth of a person.")]
    BirthDate,

    /// <summary>
    /// Name of cardholder
    /// Encoded/decoded by serializers as &quot;CHDN&quot;.
    /// </summary>
    [EnumMember(Value = "CHDN")]
    [IsoId("_NYJzeHyPEemHsOqJOzMVfg")]
    [Description(@"Name of cardholder")]
    CardholderName,

    /// <summary>
    /// City of birth to authenticate a person.
    /// Encoded/decoded by serializers as &quot;COFB&quot;.
    /// </summary>
    [EnumMember(Value = "COFB")]
    [IsoId("_NYJzeXyPEemHsOqJOzMVfg")]
    [Description(@"City of birth to authenticate a person.")]
    CityOfBirth,

    /// <summary>
    /// Customer number used as a mechanism of authentication.
    /// Encoded/decoded by serializers as &quot;CUID&quot;.
    /// </summary>
    [EnumMember(Value = "CUID")]
    [IsoId("_NYJzenyPEemHsOqJOzMVfg")]
    [Description(@"Customer number used as a mechanism of authentication.")]
    CustomerIdentification,

    /// <summary>
    /// Identification of a driver in a fleet of vehicles.
    /// Encoded/decoded by serializers as &quot;DRVI&quot;.
    /// </summary>
    [EnumMember(Value = "DRVI")]
    [IsoId("_NYJze3yPEemHsOqJOzMVfg")]
    [Description(@"Identification of a driver in a fleet of vehicles.")]
    DriverIdentification,

    /// <summary>
    /// Number assigned by a driving license authority to a person driving a car.
    /// Encoded/decoded by serializers as &quot;DRLN&quot;.
    /// </summary>
    [EnumMember(Value = "DRLN")]
    [IsoId("_NYJzfHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a driving license authority to a person driving a car.")]
    DriverLicenseNumber,

    /// <summary>
    /// Electronic mail address
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_NYJzfXyPEemHsOqJOzMVfg")]
    [Description(@"Electronic mail address")]
    Email,

    /// <summary>
    /// Number assigned to an employee by an employer.
    /// Encoded/decoded by serializers as &quot;EMIN&quot;.
    /// </summary>
    [EnumMember(Value = "EMIN")]
    [IsoId("_NYJzfnyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned to an employee by an employer.")]
    EmployeeIdentificationNumber,

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMRN&quot;.
    /// </summary>
    [EnumMember(Value = "EMRN")]
    [IsoId("_NYJzf3yPEemHsOqJOzMVfg")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber,

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCN&quot;.
    /// </summary>
    [EnumMember(Value = "IDCN")]
    [IsoId("_NYJzgHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber,

    /// <summary>
    /// Verification of a one-time password provided by the issuer.
    /// Encoded/decoded by serializers as &quot;OTPW&quot;.
    /// </summary>
    [EnumMember(Value = "OTPW")]
    [IsoId("_NYJzgXyPEemHsOqJOzMVfg")]
    [Description(@"Verification of a one-time password provided by the issuer.")]
    OneTimePassword,

    /// <summary>
    /// Other cardholder data provided for identification.
    /// Encoded/decoded by serializers as &quot;OCHI&quot;.
    /// </summary>
    [EnumMember(Value = "OCHI")]
    [IsoId("_NYJzgnyPEemHsOqJOzMVfg")]
    [Description(@"Other cardholder data provided for identification.")]
    OtherCardholderIdentification,

    /// <summary>
    /// Verification of a cryptogram generated by a non-card form factor.
    /// Encoded/decoded by serializers as &quot;OTHC&quot;.
    /// </summary>
    [EnumMember(Value = "OTHC")]
    [IsoId("_NYJzg3yPEemHsOqJOzMVfg")]
    [Description(@"Verification of a cryptogram generated by a non-card form factor.")]
    OtherCryptogram,

    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASN&quot;.
    /// </summary>
    [EnumMember(Value = "PASN")]
    [IsoId("_NYJzhHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber,

    /// <summary>
    /// Verification based on digits of the postal code.
    /// Encoded/decoded by serializers as &quot;PCDV&quot;.
    /// </summary>
    [EnumMember(Value = "PCDV")]
    [IsoId("_NYJzhXyPEemHsOqJOzMVfg")]
    [Description(@"Verification based on digits of the postal code.")]
    PostalCode,

    /// <summary>
    /// Shipping address from verification.
    /// Encoded/decoded by serializers as &quot;SHAF&quot;.
    /// </summary>
    [EnumMember(Value = "SHAF")]
    [IsoId("_NYJzhnyPEemHsOqJOzMVfg")]
    [Description(@"Shipping address from verification.")]
    ShippingAddressFrom,

    /// <summary>
    /// Shipping address to verification
    /// Encoded/decoded by serializers as &quot;SHAT&quot;.
    /// </summary>
    [EnumMember(Value = "SHAT")]
    [IsoId("_NYJzh3yPEemHsOqJOzMVfg")]
    [Description(@"Shipping address to verification")]
    ShippingAddressTo,

    /// <summary>
    /// Verification whether the address corresponds to the cardholder&apos;s one.
    /// Encoded/decoded by serializers as &quot;CHSA&quot;.
    /// </summary>
    [EnumMember(Value = "CHSA")]
    [IsoId("_Wxx1N3yPEemHsOqJOzMVfg")]
    [Description(@"Verification whether the address corresponds to the cardholder's one.")]
    CardholderAddress,

    /// <summary>
    /// Non visible Card Security Code.
    /// Encoded/decoded by serializers as &quot;NVSC&quot;.
    /// </summary>
    [EnumMember(Value = "NVSC")]
    [IsoId("_Wxx1OHyPEemHsOqJOzMVfg")]
    [Description(@"Non visible Card Security Code.")]
    NonVisibleCSC,

    /// <summary>
    /// Other type of verification defined at national level.
    /// Encoded/decoded by serializers as &quot;OTHN&quot;.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_Wxx1OXyPEemHsOqJOzMVfg")]
    [Description(@"Other type of verification defined at national level.")]
    OtherNational,

    /// <summary>
    /// Other type of verification defined at private level
    /// Encoded/decoded by serializers as &quot;OTHP&quot;.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_Wxx1OnyPEemHsOqJOzMVfg")]
    [Description(@"Other type of verification defined at private level")]
    OtherPrivate,

    /// <summary>
    /// Place of birth of a person.
    /// Encoded/decoded by serializers as &quot;PLOB&quot;.
    /// </summary>
    [EnumMember(Value = "PLOB")]
    [IsoId("_Wxx1O3yPEemHsOqJOzMVfg")]
    [Description(@"Place of birth of a person.")]
    PlaceOfBirth,

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SSNB&quot;.
    /// </summary>
    [EnumMember(Value = "SSNB")]
    [IsoId("_Wxx1PHyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber,

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXIN&quot;.
    /// </summary>
    [EnumMember(Value = "TXIN")]
    [IsoId("_Wxx1PXyPEemHsOqJOzMVfg")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber,

    /// <summary>
    /// Account-based digital signature authentication.
    /// Encoded/decoded by serializers as &quot;APKI&quot;.
    /// </summary>
    [EnumMember(Value = "APKI")]
    [IsoId("_wcguD3yPEemHsOqJOzMVfg")]
    [Description(@"Account-based digital signature authentication.")]
    AccountDigitalSignature,

    /// <summary>
    /// Response Card Cryptogram (ARPC)  verification.
    /// Encoded/decoded by serializers as &quot;ARPC&quot;.
    /// </summary>
    [EnumMember(Value = "ARPC")]
    [IsoId("_wcguEHyPEemHsOqJOzMVfg")]
    [Description(@"Response Card Cryptogram (ARPC)  verification.")]
    ARPCVerification,

    /// <summary>
    /// Application Transaction Counter
    /// Encoded/decoded by serializers as &quot;ATCC&quot;.
    /// </summary>
    [EnumMember(Value = "ATCC")]
    [IsoId("_wcguEXyPEemHsOqJOzMVfg")]
    [Description(@"Application Transaction Counter")]
    ATC,

    /// <summary>
    /// Biographics authentication in an offline mode.
    /// Encoded/decoded by serializers as &quot;FBIG&quot;.
    /// </summary>
    [EnumMember(Value = "FBIG")]
    [IsoId("_wcguEnyPEemHsOqJOzMVfg")]
    [Description(@"Biographics authentication in an offline mode.")]
    OffLineBiographics,

    /// <summary>
    /// Biometrics authentication in an offline mode
    /// Encoded/decoded by serializers as &quot;FBIO&quot;.
    /// </summary>
    [EnumMember(Value = "FBIO")]
    [IsoId("_wcguE3yPEemHsOqJOzMVfg")]
    [Description(@"Biometrics authentication in an offline mode")]
    OffLineBiometrics,

    /// <summary>
    /// Authentication of data in an offline mode
    /// Encoded/decoded by serializers as &quot;OLDA&quot;.
    /// </summary>
    [EnumMember(Value = "OLDA")]
    [IsoId("_wcguFHyPEemHsOqJOzMVfg")]
    [Description(@"Authentication of data in an offline mode")]
    OffLineDataAuthentication,

    /// <summary>
    /// Analysis of signature transmitted offline
    /// Encoded/decoded by serializers as &quot;OLDS&quot;.
    /// </summary>
    [EnumMember(Value = "OLDS")]
    [IsoId("_wcguFXyPEemHsOqJOzMVfg")]
    [Description(@"Analysis of signature transmitted offline")]
    OffLineDigitisedSignatureAnalysis,

    /// <summary>
    /// PIN generated offline and transmitted encrypted
    /// Encoded/decoded by serializers as &quot;OFPE&quot;.
    /// </summary>
    [EnumMember(Value = "OFPE")]
    [IsoId("_wcguFnyPEemHsOqJOzMVfg")]
    [Description(@"PIN generated offline and transmitted encrypted")]
    OffLinePINEncrypted,

    /// <summary>
    /// PIN generated offline and transmitted in clear
    /// Encoded/decoded by serializers as &quot;FCPN&quot;.
    /// </summary>
    [EnumMember(Value = "FCPN")]
    [IsoId("_wcguF3yPEemHsOqJOzMVfg")]
    [Description(@"PIN generated offline and transmitted in clear")]
    OffLinePINInClear,

    /// <summary>
    /// Biographics authentication in an online mode.
    /// Encoded/decoded by serializers as &quot;NBIG&quot;.
    /// </summary>
    [EnumMember(Value = "NBIG")]
    [IsoId("_wcguGHyPEemHsOqJOzMVfg")]
    [Description(@"Biographics authentication in an online mode.")]
    OnLineBiographics,

    /// <summary>
    /// Customer home phone number.
    /// Encoded/decoded by serializers as &quot;PHOM&quot;.
    /// </summary>
    [EnumMember(Value = "PHOM")]
    [IsoId("_wcguGXyPEemHsOqJOzMVfg")]
    [Description(@"Customer home phone number.")]
    PhoneHome,

    /// <summary>
    /// Customer work phone number
    /// Encoded/decoded by serializers as &quot;PWOR&quot;.
    /// </summary>
    [EnumMember(Value = "PWOR")]
    [IsoId("_wcguGnyPEemHsOqJOzMVfg")]
    [Description(@"Customer work phone number")]
    PhoneWork,

    /// <summary>
    /// PKI (Public Key Infrastructure) based digital signature
    /// Encoded/decoded by serializers as &quot;PKIS&quot;.
    /// </summary>
    [EnumMember(Value = "PKIS")]
    [IsoId("_wcguG3yPEemHsOqJOzMVfg")]
    [Description(@"PKI (Public Key Infrastructure) based digital signature")]
    PKISignature,

    /// <summary>
    /// QualifiedCertificate
    /// Encoded/decoded by serializers as &quot;QWAC&quot;.
    /// </summary>
    [EnumMember(Value = "QWAC")]
    [IsoId("_wcguHHyPEemHsOqJOzMVfg")]
    [Description(@"QualifiedCertificate")]
    QualifiedCertificate,

    /// <summary>
    /// Authentication performed during a secure electronic commerce transaction.
    /// Encoded/decoded by serializers as &quot;THDS&quot;.
    /// </summary>
    [EnumMember(Value = "THDS")]
    [IsoId("_wcguHXyPEemHsOqJOzMVfg")]
    [Description(@"Authentication performed during a secure electronic commerce transaction.")]
    ThreeDS,

    /// <summary>
    /// Serial number of the cardholder&apos;s certificate.
    /// Encoded/decoded by serializers as &quot;CHSN&quot;.
    /// </summary>
    [EnumMember(Value = "CHSN")]
    [IsoId("_Zq8WAMVTEeuPIIgba4mCug")]
    [Description(@"Serial number of the cardholder's certificate.")]
    CardholderCertificateSerialNumber,

    /// <summary>
    /// Serial number of the acceptor&apos;s certificate.
    /// Encoded/decoded by serializers as &quot;ACSN&quot;.
    /// </summary>
    [EnumMember(Value = "ACSN")]
    [IsoId("_4mZhkMVTEeuPIIgba4mCug")]
    [Description(@"Serial number of the acceptor's certificate.")]
    AcceptorCertificateSerialNumber,

    /// <summary>
    /// Nationally assigned identifier.
    /// Encoded/decoded by serializers as &quot;NTID&quot;.
    /// </summary>
    [EnumMember(Value = "NTID")]
    [IsoId("_JkrAkMVUEeuPIIgba4mCug")]
    [Description(@"Nationally assigned identifier.")]
    NationalIdentifier,
}
