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
[IsoId("_aG9UEVdTEeqBUKlIwxdUog")]
[Description(@"Specifies the element that has been encrypted, as published in an external data to encrypt type code set.|External code sets can be downloaded from www.iso20022.org.||These codes have the same value as the tag assignments shown in ISO 13492 for the data encryption dataset.  The codes are variable in length and conform to ISO/IEC 8825-1.")]
[Derivations(typeof(ExternalEncryptedElementIdentification1Code))]
public enum ExternalEncryptedElementIdentificationCode
{
    /// <summary>
    /// Primary Account Number
    /// Encoded/decoded by serializers as &quot;8A&quot;.
    /// </summary>
    [EnumMember(Value = "8A")]
    [IsoId("_upNYFvRYEeuLhpyIdtJzwg")]
    [Description(@"Primary Account Number")]
    PAN,
    
    /// <summary>
    /// Track1
    /// Encoded/decoded by serializers as &quot;8C&quot;.
    /// </summary>
    [EnumMember(Value = "8C")]
    [IsoId("_upNYGfRYEeuLhpyIdtJzwg")]
    [Description(@"Track1")]
    Track1,
    
    /// <summary>
    /// Track2
    /// Encoded/decoded by serializers as &quot;8D&quot;.
    /// </summary>
    [EnumMember(Value = "8D")]
    [IsoId("_upXJEPRYEeuLhpyIdtJzwg")]
    [Description(@"Track2")]
    Track2,
    
    /// <summary>
    /// Track3
    /// Encoded/decoded by serializers as &quot;8E&quot;.
    /// </summary>
    [EnumMember(Value = "8E")]
    [IsoId("_upXJE_RYEeuLhpyIdtJzwg")]
    [Description(@"Track3")]
    Track3,
    
    /// <summary>
    /// Visible Card Security Code
    /// Encoded/decoded by serializers as &quot;8F&quot;.
    /// </summary>
    [EnumMember(Value = "8F")]
    [IsoId("_upg6EPRYEeuLhpyIdtJzwg")]
    [Description(@"Visible Card Security Code")]
    VisibleCSC,
    
    /// <summary>
    /// Pre-agreed structure for encrypting data. Permits combination of data elements as per bilateral agreement.
    /// Encoded/decoded by serializers as &quot;89&quot;.
    /// </summary>
    [EnumMember(Value = "89")]
    [IsoId("_upg6E_RYEeuLhpyIdtJzwg")]
    [Description(@"Pre-agreed structure for encrypting data. Permits combination of data elements as per bilateral agreement.")]
    Preagreedstructure,
    
    /// <summary>
    /// Expiry Date
    /// Encoded/decoded by serializers as &quot;90&quot;.
    /// </summary>
    [EnumMember(Value = "90")]
    [IsoId("_upg6FvRYEeuLhpyIdtJzwg")]
    [Description(@"Expiry Date")]
    ExpiryDate,
    
    /// <summary>
    /// Payment Account Reference (PAR)
    /// Encoded/decoded by serializers as &quot;91&quot;.
    /// </summary>
    [EnumMember(Value = "91")]
    [IsoId("_upqEAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payment Account Reference (PAR)")]
    PaymentAccountReferencePAR,
    
    /// <summary>
    /// Payer Customer Identification 
    /// Encoded/decoded by serializers as &quot;92&quot;.
    /// </summary>
    [EnumMember(Value = "92")]
    [IsoId("_upqEA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Identification ")]
    PayerIdentification,
    
    /// <summary>
    /// Payer Customer Name
    /// Encoded/decoded by serializers as &quot;93&quot;.
    /// </summary>
    [EnumMember(Value = "93")]
    [IsoId("_upz1APRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Name")]
    PayerName,
    
    /// <summary>
    /// Payer Customer Address
    /// Encoded/decoded by serializers as &quot;94&quot;.
    /// </summary>
    [EnumMember(Value = "94")]
    [IsoId("_upz1A_RYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Address")]
    PayerAddress,
    
    /// <summary>
    /// Payer Customer Credentials Alien Registration Number
    /// Encoded/decoded by serializers as &quot;95&quot;.
    /// </summary>
    [EnumMember(Value = "95")]
    [IsoId("_upz1BvRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Alien Registration Number")]
    PayerCredentialsAlienRegistrationNumber,
    
    /// <summary>
    /// Payer Customer Credentials Driver Licence Identification
    /// Encoded/decoded by serializers as &quot;96&quot;.
    /// </summary>
    [EnumMember(Value = "96")]
    [IsoId("_upz1CfRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Driver Licence Identification")]
    PayerCredentialsDriverLicenceIdentification,
    
    /// <summary>
    /// Payer Customer Credentials National Identifier
    /// Encoded/decoded by serializers as &quot;97&quot;.
    /// </summary>
    [EnumMember(Value = "97")]
    [IsoId("_up9mAPRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials National Identifier")]
    PayerCredentialsNationalIdentifier,
    
    /// <summary>
    /// Payer Customer Credentials Passport Number
    /// Encoded/decoded by serializers as &quot;98&quot;.
    /// </summary>
    [EnumMember(Value = "98")]
    [IsoId("_up9mA_RYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Passport Number")]
    PayerCredentialsPassportNumber,
    
    /// <summary>
    /// Payer Customer Credentials Social Security Number
    /// Encoded/decoded by serializers as &quot;99&quot;.
    /// </summary>
    [EnumMember(Value = "99")]
    [IsoId("_up9mBvRYEeuLhpyIdtJzwg")]
    [Description(@"Payer Customer Credentials Social Security Number")]
    PayerCredentialsSocialSecurityNumber,
    
    /// <summary>
    /// Payee Customer Identification 
    /// Encoded/decoded by serializers as &quot;9A&quot;.
    /// </summary>
    [EnumMember(Value = "9A")]
    [IsoId("_uqGv8PRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Identification ")]
    PayeeIdentification,
    
    /// <summary>
    /// Payee Customer Name
    /// Encoded/decoded by serializers as &quot;9B&quot;.
    /// </summary>
    [EnumMember(Value = "9B")]
    [IsoId("_uqGv8_RYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Name")]
    PayeeName,
    
    /// <summary>
    /// Payee Customer Address
    /// Encoded/decoded by serializers as &quot;9C&quot;.
    /// </summary>
    [EnumMember(Value = "9C")]
    [IsoId("_uqGv9vRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Address")]
    PayeeAddress,
    
    /// <summary>
    /// Payee Customer Credentials Alien Registration Number
    /// Encoded/decoded by serializers as &quot;9D&quot;.
    /// </summary>
    [EnumMember(Value = "9D")]
    [IsoId("_uqGv-fRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Alien Registration Number")]
    PayeeCredentialsAlienRegistrationNumber,
    
    /// <summary>
    /// Payee Customer Credentials Driver Licence Identification
    /// Encoded/decoded by serializers as &quot;9E&quot;.
    /// </summary>
    [EnumMember(Value = "9E")]
    [IsoId("_uqQg8PRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Driver Licence Identification")]
    PayeeCredentialsDriverLicenceIdentification,
    
    /// <summary>
    /// Payee Customer Credentials National Identifier
    /// Encoded/decoded by serializers as &quot;9F1F&quot;.
    /// </summary>
    [EnumMember(Value = "9F1F")]
    [IsoId("_uqQg8_RYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials National Identifier")]
    PayeeCredentialsNationalIdentifier,
    
    /// <summary>
    /// Payee Customer Credentials Passport Number
    /// Encoded/decoded by serializers as &quot;9F20&quot;.
    /// </summary>
    [EnumMember(Value = "9F20")]
    [IsoId("_uqQg9vRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Passport Number")]
    PayeeCredentialsPassportNumber,
    
    /// <summary>
    /// Payee Customer Credentials Social Security Number
    /// Encoded/decoded by serializers as &quot;9F21&quot;.
    /// </summary>
    [EnumMember(Value = "9F21")]
    [IsoId("_uqQg-fRYEeuLhpyIdtJzwg")]
    [Description(@"Payee Customer Credentials Social Security Number")]
    PayeeCredentialsSocialSecurityNumber,
    
    /// <summary>
    /// Customer Device Identification
    /// Encoded/decoded by serializers as &quot;9F22&quot;.
    /// </summary>
    [EnumMember(Value = "9F22")]
    [IsoId("_uqZq4PRYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device Identification")]
    CustomerDeviceIdentification,
    
    /// <summary>
    /// Customer Device Location
    /// Encoded/decoded by serializers as &quot;9F23&quot;.
    /// </summary>
    [EnumMember(Value = "9F23")]
    [IsoId("_uqZq4_RYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device Location")]
    CustomerDeviceLocation,
    
    /// <summary>
    /// Customer Device Internet Protocol Address
    /// Encoded/decoded by serializers as &quot;9F24&quot;.
    /// </summary>
    [EnumMember(Value = "9F24")]
    [IsoId("_uqZq5vRYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device Internet Protocol Address")]
    CustomerDeviceIPAddress,
    
    /// <summary>
    /// Customer Device E-mail
    /// Encoded/decoded by serializers as &quot;9F25&quot;.
    /// </summary>
    [EnumMember(Value = "9F25")]
    [IsoId("_uqZq6fRYEeuLhpyIdtJzwg")]
    [Description(@"Customer Device E-mail")]
    CustomerDeviceEmail,
    
    /// <summary>
    /// Token Payment Token
    /// Encoded/decoded by serializers as &quot;9F26&quot;.
    /// </summary>
    [EnumMember(Value = "9F26")]
    [IsoId("_uqjb4PRYEeuLhpyIdtJzwg")]
    [Description(@"Token Payment Token")]
    TokenPaymentToken,
    
    /// <summary>
    /// Token Token Requestor Identification
    /// Encoded/decoded by serializers as &quot;9F27&quot;.
    /// </summary>
    [EnumMember(Value = "9F27")]
    [IsoId("_uqjb4_RYEeuLhpyIdtJzwg")]
    [Description(@"Token Token Requestor Identification")]
    TokenTokenRequestorIdentification,
    
    /// <summary>
    /// Cardholder Name
    /// Encoded/decoded by serializers as &quot;9F28&quot;.
    /// </summary>
    [EnumMember(Value = "9F28")]
    [IsoId("_uqjb5vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Name")]
    CardholderName,
    
    /// <summary>
    /// Cardholder Identification Customer Identification
    /// Encoded/decoded by serializers as &quot;9F29&quot;.
    /// </summary>
    [EnumMember(Value = "9F29")]
    [IsoId("_uqjb6fRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Customer Identification")]
    CardholderIdentification,
    
    /// <summary>
    /// Cardholder Identification Alien Registration Number
    /// Encoded/decoded by serializers as &quot;9F2A&quot;.
    /// </summary>
    [EnumMember(Value = "9F2A")]
    [IsoId("_uqjb7PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Alien Registration Number")]
    CardholderAlienRegistrationNumber,
    
    /// <summary>
    /// Cardholder Identification Driver Licence Identification
    /// Encoded/decoded by serializers as &quot;9F2B&quot;.
    /// </summary>
    [EnumMember(Value = "9F2B")]
    [IsoId("_uqtM4PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Driver Licence Identification")]
    CardholderDriverLicenceIdentification,
    
    /// <summary>
    /// Cardholder Identification Email
    /// Encoded/decoded by serializers as &quot;9F2C&quot;.
    /// </summary>
    [EnumMember(Value = "9F2C")]
    [IsoId("_uqtM4_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Email")]
    CardholderEmail,
    
    /// <summary>
    /// Cardholder Identification NatinalIdentifier
    /// Encoded/decoded by serializers as &quot;9F2D&quot;.
    /// </summary>
    [EnumMember(Value = "9F2D")]
    [IsoId("_uqtM5vRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification NatinalIdentifier")]
    CardholderNatinalIdentifier,
    
    /// <summary>
    /// Cardholder Identification Passport Number
    /// Encoded/decoded by serializers as &quot;9F2E&quot;.
    /// </summary>
    [EnumMember(Value = "9F2E")]
    [IsoId("_uqtM6fRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Passport Number")]
    CardholderPassportNumber,
    
    /// <summary>
    /// Cardholder Identification PhoneNumber
    /// Encoded/decoded by serializers as &quot;9F2F&quot;.
    /// </summary>
    [EnumMember(Value = "9F2F")]
    [IsoId("_uq2W0PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification PhoneNumber")]
    CardholderPhoneNumber,
    
    /// <summary>
    /// Cardholder Identification Social Security Number
    /// Encoded/decoded by serializers as &quot;9F30&quot;.
    /// </summary>
    [EnumMember(Value = "9F30")]
    [IsoId("_urAH0PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Social Security Number")]
    CardholderSocialSecurityNumber,
    
    /// <summary>
    /// Cardholder Identification Address
    /// Encoded/decoded by serializers as &quot;9F31&quot;.
    /// </summary>
    [EnumMember(Value = "9F31")]
    [IsoId("_urAH0_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Identification Address")]
    CardholderAddress,
    
    /// <summary>
    /// Cardholder Contact Information Name
    /// Encoded/decoded by serializers as &quot;9F32&quot;.
    /// </summary>
    [EnumMember(Value = "9F32")]
    [IsoId("_urJ40PRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Name")]
    CardholderContactInformationName,
    
    /// <summary>
    /// Cardholder Contact Information Home Phone Number
    /// Encoded/decoded by serializers as &quot;9F33&quot;.
    /// </summary>
    [EnumMember(Value = "9F33")]
    [IsoId("_urJ40_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Home Phone Number")]
    CardholderContactInformationHomePhoneNumber,
    
    /// <summary>
    /// Cardholder Contact Information Business Phone Number
    /// Encoded/decoded by serializers as &quot;9F34&quot;.
    /// </summary>
    [EnumMember(Value = "9F34")]
    [IsoId("_urTCwPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Business Phone Number")]
    CardholderContactInformationBusinessPhoneNumber,
    
    /// <summary>
    /// Cardholder Contact Information Mobile Phone Number
    /// Encoded/decoded by serializers as &quot;9F35&quot;.
    /// </summary>
    [EnumMember(Value = "9F35")]
    [IsoId("_urTCw_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Mobile Phone Number")]
    CardholderContactInformationMobilePhoneNumber,
    
    /// <summary>
    /// Cardholder Contact Information Other Phone Number
    /// Encoded/decoded by serializers as &quot;9F36&quot;.
    /// </summary>
    [EnumMember(Value = "9F36")]
    [IsoId("_urTCxvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Other Phone Number")]
    CardholderContactInformationOtherPhoneNumber,
    
    /// <summary>
    /// Cardholder Contact Information Personal Email Address
    /// Encoded/decoded by serializers as &quot;9F37&quot;.
    /// </summary>
    [EnumMember(Value = "9F37")]
    [IsoId("_urTCyfRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Personal Email Address")]
    CardholderContactInformationPersonalEmailAddress,
    
    /// <summary>
    /// Cardholder Contact Information Business Email Address
    /// Encoded/decoded by serializers as &quot;9F38&quot;.
    /// </summary>
    [EnumMember(Value = "9F38")]
    [IsoId("_urczwPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Business Email Address")]
    CardholderContactInformationBusinessEmailAddress,
    
    /// <summary>
    /// Cardholder Contact Information Other Email Address
    /// Encoded/decoded by serializers as &quot;9F39&quot;.
    /// </summary>
    [EnumMember(Value = "9F39")]
    [IsoId("_urczw_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Contact Information Other Email Address")]
    CardholderContactInformationOtherEmailAddress,
    
    /// <summary>
    /// Cardholder Address Digits
    /// Encoded/decoded by serializers as &quot;9F3A&quot;.
    /// </summary>
    [EnumMember(Value = "9F3A")]
    [IsoId("_url9sPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Address Digits")]
    CardholderAddressDigits,
    
    /// <summary>
    /// Cardholder Billing Address
    /// Encoded/decoded by serializers as &quot;9F3B&quot;.
    /// </summary>
    [EnumMember(Value = "9F3B")]
    [IsoId("_url9s_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Billing Address")]
    CardholderBillingAddress,
    
    /// <summary>
    /// Cardholder Birth Date
    /// Encoded/decoded by serializers as &quot;9F3C&quot;.
    /// </summary>
    [EnumMember(Value = "9F3C")]
    [IsoId("_url9tvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Birth Date")]
    CardholderBirthDate,
    
    /// <summary>
    /// Cardholder Place Of Birth
    /// Encoded/decoded by serializers as &quot;9F3D&quot;.
    /// </summary>
    [EnumMember(Value = "9F3D")]
    [IsoId("_urvusPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Place Of Birth")]
    CardholderPlaceOfBirth,
    
    /// <summary>
    /// Cardholder Employee Identification Number
    /// Encoded/decoded by serializers as &quot;9F3E&quot;.
    /// </summary>
    [EnumMember(Value = "9F3E")]
    [IsoId("_urvus_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Employee Identification Number")]
    CardholderEmployeeIdentificationNumber,
    
    /// <summary>
    /// Cardholder Employer Identification Number
    /// Encoded/decoded by serializers as &quot;9F3F&quot;.
    /// </summary>
    [EnumMember(Value = "9F3F")]
    [IsoId("_ur5fsPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Employer Identification Number")]
    CardholderEmployerIdentificationNumber,
    
    /// <summary>
    /// Cardholder Password
    /// Encoded/decoded by serializers as &quot;9F40&quot;.
    /// </summary>
    [EnumMember(Value = "9F40")]
    [IsoId("_ur5fs_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Password")]
    CardholderPassword,
    
    /// <summary>
    /// Cardholder Postal Code
    /// Encoded/decoded by serializers as &quot;9F41&quot;.
    /// </summary>
    [EnumMember(Value = "9F41")]
    [IsoId("_ur5ftvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Postal Code")]
    CardholderPostalCode,
    
    /// <summary>
    /// Cardholder Shipping Address
    /// Encoded/decoded by serializers as &quot;9F42&quot;.
    /// </summary>
    [EnumMember(Value = "9F42")]
    [IsoId("_ur5fufRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Shipping Address")]
    CardholderShippingAddress,
    
    /// <summary>
    /// Cardholder Shipping Address From
    /// Encoded/decoded by serializers as &quot;9F43&quot;.
    /// </summary>
    [EnumMember(Value = "9F43")]
    [IsoId("_usCpoPRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Shipping Address From")]
    CardholderShippingAddressFrom,
    
    /// <summary>
    /// Cardholder Shipping Address To
    /// Encoded/decoded by serializers as &quot;9F44&quot;.
    /// </summary>
    [EnumMember(Value = "9F44")]
    [IsoId("_usCpo_RYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Shipping Address To")]
    CardholderShippingAddressTo,
    
    /// <summary>
    /// Cardholder Tax Identification Number
    /// Encoded/decoded by serializers as &quot;9F45&quot;.
    /// </summary>
    [EnumMember(Value = "9F45")]
    [IsoId("_usCppvRYEeuLhpyIdtJzwg")]
    [Description(@"Cardholder Tax Identification Number")]
    CardholderTaxIdentificationNumber,
    
    /// <summary>
    /// Account From Account Identification
    /// Encoded/decoded by serializers as &quot;9F46&quot;.
    /// </summary>
    [EnumMember(Value = "9F46")]
    [IsoId("_usCpqfRYEeuLhpyIdtJzwg")]
    [Description(@"Account From Account Identification")]
    AccountFromAccountIdentification,
    
    /// <summary>
    /// Account To Account Identification
    /// Encoded/decoded by serializers as &quot;9F47&quot;.
    /// </summary>
    [EnumMember(Value = "9F47")]
    [IsoId("_usMaoPRYEeuLhpyIdtJzwg")]
    [Description(@"Account To Account Identification")]
    AccountToAccountIdentification,
    
}
