// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the element that has been encrypted, as published in an external data to encrypt type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_2F7gYFdTEeqBUKlIwxdUog")]
[Description(
    @"Specifies the element that has been encrypted, as published in an external data to encrypt type code set.|External code sets can be downloaded from www.iso20022.org.||These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1."
)]
[DerivedFrom(typeof(ExternalEncryptedElementIdentificationCode))]
public enum ExternalEncryptedElementIdentification1Code
{
    /// <summary>
    /// Primary Account Number
    /// Encoded/decoded by serializers as &quot;8A&quot;.
    /// </summary>
    [EnumMember(Value = "8A")]
    [IsoId("_upNYGPRYEeuLhpyIdtJzwg")]
    [Description(@"Primary Account Number")]
    PAN = ExternalEncryptedElementIdentificationCode.PAN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Track1
    /// Encoded/decoded by serializers as &quot;8C&quot;.
    /// </summary>
    [EnumMember(Value = "8C")]
    [IsoId("_upNYG_RYEeuLhpyIdtJzwg")]
    [Description(@"Track1")]
    Track1 = ExternalEncryptedElementIdentificationCode.Track1, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Track2
    /// Encoded/decoded by serializers as &quot;8D&quot;.
    /// </summary>
    [EnumMember(Value = "8D")]
    [IsoId("_upXJEvRYEeuLhpyIdtJzwg")]
    [Description(@"Track2")]
    Track2 = ExternalEncryptedElementIdentificationCode.Track2, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Track3
    /// Encoded/decoded by serializers as &quot;8E&quot;.
    /// </summary>
    [EnumMember(Value = "8E")]
    [IsoId("_upXJFfRYEeuLhpyIdtJzwg")]
    [Description(@"Track3")]
    Track3 = ExternalEncryptedElementIdentificationCode.Track3, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Visible Card Security Code
    /// Encoded/decoded by serializers as &quot;8F&quot;.
    /// </summary>
    [EnumMember(Value = "8F")]
    [IsoId("_upg6EvRYEeuLhpyIdtJzwg")]
    [Description(@"Visible Card Security Code")]
    VisibleCSC = ExternalEncryptedElementIdentificationCode.VisibleCSC, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Pre-agreed structure for encrypting data. Permits combination of data elements as per bilateral agreement.
    /// Encoded/decoded by serializers as &quot;89&quot;.
    /// </summary>
    [EnumMember(Value = "89")]
    [IsoId("_upg6FfRYEeuLhpyIdtJzwg")]
    [Description(
        @"Pre-agreed structure for encrypting data. Permits combination of data elements as per bilateral agreement."
    )]
    Preagreedstructure = ExternalEncryptedElementIdentificationCode.Preagreedstructure, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Expiry Date
    /// Encoded/decoded by serializers as &quot;90&quot;.
    /// </summary>
    [EnumMember(Value = "90")]
    [IsoId("_upg6GPRYEeuLhpyIdtJzwg")]
    [Description(@"Expiry Date")]
    ExpiryDate = ExternalEncryptedElementIdentificationCode.ExpiryDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payment Account Reference (PAR)
    /// Encoded/decoded by serializers as &quot;91&quot;.
    /// </summary>
    [EnumMember(Value = "91")]
    [IsoId("_upqEAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payment Account Reference (PAR)")]
    PaymentAccountReferencePAR =
        ExternalEncryptedElementIdentificationCode.PaymentAccountReferencePAR, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Identification
    /// Encoded/decoded by serializers as &quot;92&quot;.
    /// </summary>
    [EnumMember(Value = "92")]
    [IsoId("_upqEBfRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Identification ")]
    PayerIdentification = ExternalEncryptedElementIdentificationCode.PayerIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Name
    /// Encoded/decoded by serializers as &quot;93&quot;.
    /// </summary>
    [EnumMember(Value = "93")]
    [IsoId("_upz1AvRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Name")]
    PayerName = ExternalEncryptedElementIdentificationCode.PayerName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Address
    /// Encoded/decoded by serializers as &quot;94&quot;.
    /// </summary>
    [EnumMember(Value = "94")]
    [IsoId("_upz1BfRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Address")]
    PayerAddress = ExternalEncryptedElementIdentificationCode.PayerAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Credentials Alien Registration Number
    /// Encoded/decoded by serializers as &quot;95&quot;.
    /// </summary>
    [EnumMember(Value = "95")]
    [IsoId("_upz1CPRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Alien Registration Number")]
    PayerCredentialsAlienRegistrationNumber =
        ExternalEncryptedElementIdentificationCode.PayerCredentialsAlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Credentials Driver Licence Identification
    /// Encoded/decoded by serializers as &quot;96&quot;.
    /// </summary>
    [EnumMember(Value = "96")]
    [IsoId("_upz1C_RYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Driver Licence Identification")]
    PayerCredentialsDriverLicenceIdentification =
        ExternalEncryptedElementIdentificationCode.PayerCredentialsDriverLicenceIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Credentials National Identifier
    /// Encoded/decoded by serializers as &quot;97&quot;.
    /// </summary>
    [EnumMember(Value = "97")]
    [IsoId("_up9mAvRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials National Identifier")]
    PayerCredentialsNationalIdentifier =
        ExternalEncryptedElementIdentificationCode.PayerCredentialsNationalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Credentials Passport Number
    /// Encoded/decoded by serializers as &quot;98&quot;.
    /// </summary>
    [EnumMember(Value = "98")]
    [IsoId("_up9mBfRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Passport Number")]
    PayerCredentialsPassportNumber =
        ExternalEncryptedElementIdentificationCode.PayerCredentialsPassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payer Customer Credentials Social Security Number
    /// Encoded/decoded by serializers as &quot;99&quot;.
    /// </summary>
    [EnumMember(Value = "99")]
    [IsoId("_up9mCPRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Social Security Number")]
    PayerCredentialsSocialSecurityNumber =
        ExternalEncryptedElementIdentificationCode.PayerCredentialsSocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Identification
    /// Encoded/decoded by serializers as &quot;9A&quot;.
    /// </summary>
    [EnumMember(Value = "9A")]
    [IsoId("_uqGv8vRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Identification ")]
    PayeeIdentification = ExternalEncryptedElementIdentificationCode.PayeeIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Name
    /// Encoded/decoded by serializers as &quot;9B&quot;.
    /// </summary>
    [EnumMember(Value = "9B")]
    [IsoId("_uqGv9fRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Name")]
    PayeeName = ExternalEncryptedElementIdentificationCode.PayeeName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Address
    /// Encoded/decoded by serializers as &quot;9C&quot;.
    /// </summary>
    [EnumMember(Value = "9C")]
    [IsoId("_uqGv-PRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Address")]
    PayeeAddress = ExternalEncryptedElementIdentificationCode.PayeeAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Credentials Alien Registration Number
    /// Encoded/decoded by serializers as &quot;9D&quot;.
    /// </summary>
    [EnumMember(Value = "9D")]
    [IsoId("_uqGv-_RYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Alien Registration Number")]
    PayeeCredentialsAlienRegistrationNumber =
        ExternalEncryptedElementIdentificationCode.PayeeCredentialsAlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Credentials Driver Licence Identification
    /// Encoded/decoded by serializers as &quot;9E&quot;.
    /// </summary>
    [EnumMember(Value = "9E")]
    [IsoId("_uqQg8vRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Driver Licence Identification")]
    PayeeCredentialsDriverLicenceIdentification =
        ExternalEncryptedElementIdentificationCode.PayeeCredentialsDriverLicenceIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Credentials National Identifier
    /// Encoded/decoded by serializers as &quot;9F1F&quot;.
    /// </summary>
    [EnumMember(Value = "9F1F")]
    [IsoId("_uqQg9fRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials National Identifier")]
    PayeeCredentialsNationalIdentifier =
        ExternalEncryptedElementIdentificationCode.PayeeCredentialsNationalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Credentials Passport Number
    /// Encoded/decoded by serializers as &quot;9F20&quot;.
    /// </summary>
    [EnumMember(Value = "9F20")]
    [IsoId("_uqQg-PRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Passport Number")]
    PayeeCredentialsPassportNumber =
        ExternalEncryptedElementIdentificationCode.PayeeCredentialsPassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Payee Customer Credentials Social Security Number
    /// Encoded/decoded by serializers as &quot;9F21&quot;.
    /// </summary>
    [EnumMember(Value = "9F21")]
    [IsoId("_uqQg-_RYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Social Security Number")]
    PayeeCredentialsSocialSecurityNumber =
        ExternalEncryptedElementIdentificationCode.PayeeCredentialsSocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Device Identification
    /// Encoded/decoded by serializers as &quot;9F22&quot;.
    /// </summary>
    [EnumMember(Value = "9F22")]
    [IsoId("_uqZq4vRYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device Identification")]
    CustomerDeviceIdentification =
        ExternalEncryptedElementIdentificationCode.CustomerDeviceIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Device Location
    /// Encoded/decoded by serializers as &quot;9F23&quot;.
    /// </summary>
    [EnumMember(Value = "9F23")]
    [IsoId("_uqZq5fRYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device Location")]
    CustomerDeviceLocation = ExternalEncryptedElementIdentificationCode.CustomerDeviceLocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Device Internet Protocol Address
    /// Encoded/decoded by serializers as &quot;9F24&quot;.
    /// </summary>
    [EnumMember(Value = "9F24")]
    [IsoId("_uqZq6PRYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device Internet Protocol Address")]
    CustomerDeviceIPAddress = ExternalEncryptedElementIdentificationCode.CustomerDeviceIPAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer Device E-mail
    /// Encoded/decoded by serializers as &quot;9F25&quot;.
    /// </summary>
    [EnumMember(Value = "9F25")]
    [IsoId("_uqZq6_RYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device E-mail")]
    CustomerDeviceEmail = ExternalEncryptedElementIdentificationCode.CustomerDeviceEmail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token Payment Token
    /// Encoded/decoded by serializers as &quot;9F26&quot;.
    /// </summary>
    [EnumMember(Value = "9F26")]
    [IsoId("_uqjb4vRYEeuLhpyIdtJzwg")]
    [Description(@"Token Payment Token")]
    TokenPaymentToken = ExternalEncryptedElementIdentificationCode.TokenPaymentToken, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Token Token Requestor Identification
    /// Encoded/decoded by serializers as &quot;9F27&quot;.
    /// </summary>
    [EnumMember(Value = "9F27")]
    [IsoId("_uqjb5fRYEeuLhpyIdtJzwg")]
    [Description(@"Token Token Requestor Identification")]
    TokenTokenRequestorIdentification =
        ExternalEncryptedElementIdentificationCode.TokenTokenRequestorIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Name
    /// Encoded/decoded by serializers as &quot;9F28&quot;.
    /// </summary>
    [EnumMember(Value = "9F28")]
    [IsoId("_uqjb6PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Name")]
    CardholderName = ExternalEncryptedElementIdentificationCode.CardholderName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Customer Identification
    /// Encoded/decoded by serializers as &quot;9F29&quot;.
    /// </summary>
    [EnumMember(Value = "9F29")]
    [IsoId("_uqjb6_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Customer Identification")]
    CardholderIdentification = ExternalEncryptedElementIdentificationCode.CardholderIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Alien Registration Number
    /// Encoded/decoded by serializers as &quot;9F2A&quot;.
    /// </summary>
    [EnumMember(Value = "9F2A")]
    [IsoId("_uqjb7vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Alien Registration Number")]
    CardholderAlienRegistrationNumber =
        ExternalEncryptedElementIdentificationCode.CardholderAlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Driver Licence Identification
    /// Encoded/decoded by serializers as &quot;9F2B&quot;.
    /// </summary>
    [EnumMember(Value = "9F2B")]
    [IsoId("_uqtM4vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Driver Licence Identification")]
    CardholderDriverLicenceIdentification =
        ExternalEncryptedElementIdentificationCode.CardholderDriverLicenceIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Email
    /// Encoded/decoded by serializers as &quot;9F2C&quot;.
    /// </summary>
    [EnumMember(Value = "9F2C")]
    [IsoId("_uqtM5fRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Email")]
    CardholderEmail = ExternalEncryptedElementIdentificationCode.CardholderEmail, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification NatinalIdentifier
    /// Encoded/decoded by serializers as &quot;9F2D&quot;.
    /// </summary>
    [EnumMember(Value = "9F2D")]
    [IsoId("_uqtM6PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification NatinalIdentifier")]
    CardholderNatinalIdentifier =
        ExternalEncryptedElementIdentificationCode.CardholderNatinalIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Passport Number
    /// Encoded/decoded by serializers as &quot;9F2E&quot;.
    /// </summary>
    [EnumMember(Value = "9F2E")]
    [IsoId("_uqtM6_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Passport Number")]
    CardholderPassportNumber = ExternalEncryptedElementIdentificationCode.CardholderPassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification PhoneNumber
    /// Encoded/decoded by serializers as &quot;9F2F&quot;.
    /// </summary>
    [EnumMember(Value = "9F2F")]
    [IsoId("_uq2W0vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification PhoneNumber")]
    CardholderPhoneNumber = ExternalEncryptedElementIdentificationCode.CardholderPhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Social Security Number
    /// Encoded/decoded by serializers as &quot;9F30&quot;.
    /// </summary>
    [EnumMember(Value = "9F30")]
    [IsoId("_urAH0vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Social Security Number")]
    CardholderSocialSecurityNumber =
        ExternalEncryptedElementIdentificationCode.CardholderSocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Identification Address
    /// Encoded/decoded by serializers as &quot;9F31&quot;.
    /// </summary>
    [EnumMember(Value = "9F31")]
    [IsoId("_urAH1fRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Address")]
    CardholderAddress = ExternalEncryptedElementIdentificationCode.CardholderAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Name
    /// Encoded/decoded by serializers as &quot;9F32&quot;.
    /// </summary>
    [EnumMember(Value = "9F32")]
    [IsoId("_urJ40vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Name")]
    CardholderContactInformationName =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Home Phone Number
    /// Encoded/decoded by serializers as &quot;9F33&quot;.
    /// </summary>
    [EnumMember(Value = "9F33")]
    [IsoId("_urJ41fRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Home Phone Number")]
    CardholderContactInformationHomePhoneNumber =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationHomePhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Business Phone Number
    /// Encoded/decoded by serializers as &quot;9F34&quot;.
    /// </summary>
    [EnumMember(Value = "9F34")]
    [IsoId("_urTCwvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Business Phone Number")]
    CardholderContactInformationBusinessPhoneNumber =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationBusinessPhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Mobile Phone Number
    /// Encoded/decoded by serializers as &quot;9F35&quot;.
    /// </summary>
    [EnumMember(Value = "9F35")]
    [IsoId("_urTCxfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Mobile Phone Number")]
    CardholderContactInformationMobilePhoneNumber =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationMobilePhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Other Phone Number
    /// Encoded/decoded by serializers as &quot;9F36&quot;.
    /// </summary>
    [EnumMember(Value = "9F36")]
    [IsoId("_urTCyPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Other Phone Number")]
    CardholderContactInformationOtherPhoneNumber =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationOtherPhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Personal Email Address
    /// Encoded/decoded by serializers as &quot;9F37&quot;.
    /// </summary>
    [EnumMember(Value = "9F37")]
    [IsoId("_urTCy_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Personal Email Address")]
    CardholderContactInformationPersonalEmailAddress =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationPersonalEmailAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Business Email Address
    /// Encoded/decoded by serializers as &quot;9F38&quot;.
    /// </summary>
    [EnumMember(Value = "9F38")]
    [IsoId("_urczwvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Business Email Address")]
    CardholderContactInformationBusinessEmailAddress =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationBusinessEmailAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Contact Information Other Email Address
    /// Encoded/decoded by serializers as &quot;9F39&quot;.
    /// </summary>
    [EnumMember(Value = "9F39")]
    [IsoId("_urczxfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Other Email Address")]
    CardholderContactInformationOtherEmailAddress =
        ExternalEncryptedElementIdentificationCode.CardholderContactInformationOtherEmailAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Address Digits
    /// Encoded/decoded by serializers as &quot;9F3A&quot;.
    /// </summary>
    [EnumMember(Value = "9F3A")]
    [IsoId("_url9svRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Address Digits")]
    CardholderAddressDigits = ExternalEncryptedElementIdentificationCode.CardholderAddressDigits, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Billing Address
    /// Encoded/decoded by serializers as &quot;9F3B&quot;.
    /// </summary>
    [EnumMember(Value = "9F3B")]
    [IsoId("_url9tfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Billing Address")]
    CardholderBillingAddress = ExternalEncryptedElementIdentificationCode.CardholderBillingAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Birth Date
    /// Encoded/decoded by serializers as &quot;9F3C&quot;.
    /// </summary>
    [EnumMember(Value = "9F3C")]
    [IsoId("_url9uPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Birth Date")]
    CardholderBirthDate = ExternalEncryptedElementIdentificationCode.CardholderBirthDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Place Of Birth
    /// Encoded/decoded by serializers as &quot;9F3D&quot;.
    /// </summary>
    [EnumMember(Value = "9F3D")]
    [IsoId("_urvusvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Place Of Birth")]
    CardholderPlaceOfBirth = ExternalEncryptedElementIdentificationCode.CardholderPlaceOfBirth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Employee Identification Number
    /// Encoded/decoded by serializers as &quot;9F3E&quot;.
    /// </summary>
    [EnumMember(Value = "9F3E")]
    [IsoId("_urvutfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Employee Identification Number")]
    CardholderEmployeeIdentificationNumber =
        ExternalEncryptedElementIdentificationCode.CardholderEmployeeIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Employer Identification Number
    /// Encoded/decoded by serializers as &quot;9F3F&quot;.
    /// </summary>
    [EnumMember(Value = "9F3F")]
    [IsoId("_ur5fsvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Employer Identification Number")]
    CardholderEmployerIdentificationNumber =
        ExternalEncryptedElementIdentificationCode.CardholderEmployerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Password
    /// Encoded/decoded by serializers as &quot;9F40&quot;.
    /// </summary>
    [EnumMember(Value = "9F40")]
    [IsoId("_ur5ftfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Password")]
    CardholderPassword = ExternalEncryptedElementIdentificationCode.CardholderPassword, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Postal Code
    /// Encoded/decoded by serializers as &quot;9F41&quot;.
    /// </summary>
    [EnumMember(Value = "9F41")]
    [IsoId("_ur5fuPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Postal Code")]
    CardholderPostalCode = ExternalEncryptedElementIdentificationCode.CardholderPostalCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Shipping Address
    /// Encoded/decoded by serializers as &quot;9F42&quot;.
    /// </summary>
    [EnumMember(Value = "9F42")]
    [IsoId("_ur5fu_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Shipping Address")]
    CardholderShippingAddress =
        ExternalEncryptedElementIdentificationCode.CardholderShippingAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Shipping Address From
    /// Encoded/decoded by serializers as &quot;9F43&quot;.
    /// </summary>
    [EnumMember(Value = "9F43")]
    [IsoId("_usCpovRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Shipping Address From")]
    CardholderShippingAddressFrom =
        ExternalEncryptedElementIdentificationCode.CardholderShippingAddressFrom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Shipping Address To
    /// Encoded/decoded by serializers as &quot;9F44&quot;.
    /// </summary>
    [EnumMember(Value = "9F44")]
    [IsoId("_usCppfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Shipping Address To")]
    CardholderShippingAddressTo =
        ExternalEncryptedElementIdentificationCode.CardholderShippingAddressTo, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cardholder Tax Identification Number
    /// Encoded/decoded by serializers as &quot;9F45&quot;.
    /// </summary>
    [EnumMember(Value = "9F45")]
    [IsoId("_usCpqPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Tax Identification Number")]
    CardholderTaxIdentificationNumber =
        ExternalEncryptedElementIdentificationCode.CardholderTaxIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account From Account Identification
    /// Encoded/decoded by serializers as &quot;9F46&quot;.
    /// </summary>
    [EnumMember(Value = "9F46")]
    [IsoId("_usCpq_RYEeuLhpyIdtJzwg")]
    [Description(@"Account From Account Identification")]
    AccountFromAccountIdentification =
        ExternalEncryptedElementIdentificationCode.AccountFromAccountIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account To Account Identification
    /// Encoded/decoded by serializers as &quot;9F47&quot;.
    /// </summary>
    [EnumMember(Value = "9F47")]
    [IsoId("_usMaovRYEeuLhpyIdtJzwg")]
    [Description(@"Account To Account Identification")]
    AccountToAccountIdentification =
        ExternalEncryptedElementIdentificationCode.AccountToAccountIdentification, // same ordinal as derivation source for type conversions
}
