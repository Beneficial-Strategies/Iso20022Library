// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the external proxy account type code, as published in the proxy account type external code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ioPgonh3EeidzqjNEfehPg")]
[Description(
    @"Specifies the external proxy account type code, as published in the proxy account type external code set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalProxyAccountTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<ExternalProxyAccountType1Code>))]
#endif
public enum ExternalProxyAccountType1Code
{
    /// <summary>
    /// A telephone number in the format specified by the &apos;The international public telecommunication numbering plan ITU-T E.164.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("_um0yePRYEeuLhpyIdtJzwg")]
    [Description(
        @"A telephone number in the format specified by the 'The international public telecommunication numbering plan ITU-T E.164. "
    )]
    TelephoneNumber = ExternalProxyAccountTypeCode.TelephoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internationalised address of an electronic mail box for internet messages.
    /// Encoded/decoded by serializers as &quot;EMAL&quot;.
    /// </summary>
    [EnumMember(Value = "EMAL")]
    [IsoId("_um0ye_RYEeuLhpyIdtJzwg")]
    [Description(@"Internationalised address of an electronic mail box for internet messages.")]
    EmailAddress = ExternalProxyAccountTypeCode.EmailAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Internationalised internet domain name.
    /// Encoded/decoded by serializers as &quot;DNAM&quot;.
    /// </summary>
    [EnumMember(Value = "DNAM")]
    [IsoId("_um-jcvRYEeuLhpyIdtJzwg")]
    [Description(@"Internationalised internet domain name.")]
    DomainName = ExternalProxyAccountTypeCode.DomainName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Corporate Identification issued by a national  institution or regulator, used as account proxy. |(applied for corporate account proxy).
    /// Encoded/decoded by serializers as &quot;CINC&quot;.
    /// </summary>
    [EnumMember(Value = "CINC")]
    [IsoId("_D2324ZuVEeya_t2LwNmi4g")]
    [Description(
        @"Corporate Identification issued by a national  institution or regulator, used as account proxy. |(applied for corporate account proxy)."
    )]
    CertificateOfIncorporationNumber =
        ExternalProxyAccountTypeCode.CertificateOfIncorporationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique government-issued tax Identification used as account proxy to identify the corporate (for example for government tax) and typically linked to the corporate bank account (applied for corporate account proxy).
    /// Encoded/decoded by serializers as &quot;COTX&quot;.
    /// </summary>
    [EnumMember(Value = "COTX")]
    [IsoId("_D8_F8ZuVEeya_t2LwNmi4g")]
    [Description(
        @"Unique government-issued tax Identification used as account proxy to identify the corporate (for example for government tax) and typically linked to the corporate bank account (applied for corporate account proxy)."
    )]
    CorporateTaxIdentification = ExternalProxyAccountTypeCode.CorporateTaxIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identification issued by a national  institution or regulator (different from a national scheme like a clearing provider), used as account proxy (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;COID&quot;.
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("_EC8kAZuVEeya_t2LwNmi4g")]
    [Description(
        @"Identification issued by a national  institution or regulator (different from a national scheme like a clearing provider), used as account proxy (applied for corporate or individual account proxy)."
    )]
    CountryAuthorityIdentification = ExternalProxyAccountTypeCode.CountryAuthorityIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Any other customer identification number issued by a corporate, bank or other organization, used as account proxy.|(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_EJM9AZuVEeya_t2LwNmi4g")]
    [Description(
        @"Any other customer identification number issued by a corporate, bank or other organization, used as account proxy.|(applied for corporate or individual account proxy)."
    )]
    CustomerIdentificationNumber = ExternalProxyAccountTypeCode.CustomerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique government-issued Identification used as account proxy to  identify the individual  (for example for government charges, road taxes and tolls,vaccination charges) and typically linked to the individual&apos;s bank account (applied for  individual account proxy).
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_ERQFwZuVEeya_t2LwNmi4g")]
    [Description(
        @"Unique government-issued Identification used as account proxy to  identify the individual  (for example for government charges, road taxes and tolls,vaccination charges) and typically linked to the individual's bank account (applied for  individual account proxy)."
    )]
    DriverLicenseNumber = ExternalProxyAccountTypeCode.DriverLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Government-issued Identification (different from a passport Identification or a national Identification). Used as account proxy to  identify the individual (for example for public benefits) and typically linked to the individual&apos;s bank account (applied for  individual account proxy).
    /// Encoded/decoded by serializers as &quot;EIDN&quot;.
    /// </summary>
    [EnumMember(Value = "EIDN")]
    [IsoId("_EXNj0ZuVEeya_t2LwNmi4g")]
    [Description(
        @"Government-issued Identification (different from a passport Identification or a national Identification). Used as account proxy to  identify the individual (for example for public benefits) and typically linked to the individual's bank account (applied for  individual account proxy)."
    )]
    ElectronicIdentification = ExternalProxyAccountTypeCode.ElectronicIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Market-adopted prepaid instruments like e-Wallets, payments to / from e-wallets from / to bank accounts (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;EWAL&quot;.
    /// </summary>
    [EnumMember(Value = "EWAL")]
    [IsoId("_EcuV8ZuVEeya_t2LwNmi4g")]
    [Description(
        @"Market-adopted prepaid instruments like e-Wallets, payments to / from e-wallets from / to bank accounts (applied for corporate or individual account proxy)."
    )]
    EWalletIdentification = ExternalProxyAccountTypeCode.EWalletIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique government-issued  tax Identification  used as account proxy to  identify the individual  for example for government tax) and typically linked to the individual&apos;s bank account (applied for  individual account proxy).
    /// Encoded/decoded by serializers as &quot;PVTX&quot;.
    /// </summary>
    [EnumMember(Value = "PVTX")]
    [IsoId("_EiY5EZuVEeya_t2LwNmi4g")]
    [Description(
        @"Unique government-issued  tax Identification  used as account proxy to  identify the individual  for example for government tax) and typically linked to the individual's bank account (applied for  individual account proxy)."
    )]
    IndividualTaxIdentification = ExternalProxyAccountTypeCode.IndividualTaxIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal Entity Identifier used as account proxy (applied for corporate account proxy).|Use cases: Can be used by corporates as a &quot;government-issued&quot; Identification for registration with payment schemes as a proxy. The proxy may be further used for payments and collections using the underlying instant payment rails for a variety of corporate use cases.
    /// Encoded/decoded by serializers as &quot;LEIC&quot;.
    /// </summary>
    [EnumMember(Value = "LEIC")]
    [IsoId("_En5rMZuVEeya_t2LwNmi4g")]
    [Description(
        @"Legal Entity Identifier used as account proxy (applied for corporate account proxy).|Use cases: Can be used by corporates as a ""government-issued"" Identification for registration with payment schemes as a proxy. The proxy may be further used for payments and collections using the underlying instant payment rails for a variety of corporate use cases."
    )]
    LegalEntityIdentifierCode = ExternalProxyAccountTypeCode.LegalEntityIdentifierCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Mobile phone number in the format specified by the “The international public telecommunication numbering plan ITU- T E 164&quot; (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;MBNO&quot;.
    /// </summary>
    [EnumMember(Value = "MBNO")]
    [IsoId("_Eq4GsZuVEeya_t2LwNmi4g")]
    [Description(
        @"Mobile phone number in the format specified by the “The international public telecommunication numbering plan ITU- T E 164"" (applied for corporate or individual account proxy)."
    )]
    MobilePhoneNumber = ExternalProxyAccountTypeCode.MobilePhoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique government-issued Identification  used as account proxy to  identify the individual  or corporate for example for public benefits, government subsidies) and typically linked to the individual&apos;s / corporate bank account.|(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;NIDN&quot;.
    /// </summary>
    [EnumMember(Value = "NIDN")]
    [IsoId("_EvgIAZuVEeya_t2LwNmi4g")]
    [Description(
        @"Unique government-issued Identification  used as account proxy to  identify the individual  or corporate for example for public benefits, government subsidies) and typically linked to the individual's / corporate bank account.|(applied for corporate or individual account proxy)."
    )]
    NationalIdentificationNumber = ExternalProxyAccountTypeCode.NationalIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique government-issued Identification  used as account proxy to  identify the individual  (for example for government charges, road taxes, vaccination charges) and typically linked to the individual&apos;s bank account|(applied for  individual account proxy).
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_E0kOMZuVEeya_t2LwNmi4g")]
    [Description(
        @"Unique government-issued Identification  used as account proxy to  identify the individual  (for example for government charges, road taxes, vaccination charges) and typically linked to the individual's bank account|(applied for  individual account proxy)."
    )]
    PassportNumber = ExternalProxyAccountTypeCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account proxy issued by a payment scheme (applied for corporate or individual account proxy).|Use cases: Any proxies issued by clearing systems, for example VPA (India), FPS Identifier (Hong Kong), Jompay (Malaysia) CCIN (Canada).
    /// Encoded/decoded by serializers as &quot;SHID&quot;.
    /// </summary>
    [EnumMember(Value = "SHID")]
    [IsoId("_E3Gk0ZuVEeya_t2LwNmi4g")]
    [Description(
        @"Account proxy issued by a payment scheme (applied for corporate or individual account proxy).|Use cases: Any proxies issued by clearing systems, for example VPA (India), FPS Identifier (Hong Kong), Jompay (Malaysia) CCIN (Canada)."
    )]
    SchemeIdentificationNumber = ExternalProxyAccountTypeCode.SchemeIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Unique government-issued Identification  used as account proxy to identify the individual  (for example for public benefits) and typically linked to the individual&apos;s bank account (applied for individual account proxy).
    /// Encoded/decoded by serializers as &quot;SOSE&quot;.
    /// </summary>
    [EnumMember(Value = "SOSE")]
    [IsoId("_E-sakZuVEeya_t2LwNmi4g")]
    [Description(
        @"Unique government-issued Identification  used as account proxy to identify the individual  (for example for public benefits) and typically linked to the individual's bank account (applied for individual account proxy)."
    )]
    SocialSecurityNumber = ExternalProxyAccountTypeCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Electronic Identification used, for example, to mask an account number as a means of data secrecy.|(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;TOKN&quot;.
    /// </summary>
    [EnumMember(Value = "TOKN")]
    [IsoId("_FDxH0ZuVEeya_t2LwNmi4g")]
    [Description(
        @"Electronic Identification used, for example, to mask an account number as a means of data secrecy.|(applied for corporate or individual account proxy)."
    )]
    TokenIdentification = ExternalProxyAccountTypeCode.TokenIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Subscriber Identification for utilities and services. As opposed to a biller Identification, this identification is used for the subscriber of the service (applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;UBIL&quot;.
    /// </summary>
    [EnumMember(Value = "UBIL")]
    [IsoId("_FI1OAZuVEeya_t2LwNmi4g")]
    [Description(
        @"Subscriber Identification for utilities and services. As opposed to a biller Identification, this identification is used for the subscriber of the service (applied for corporate or individual account proxy)."
    )]
    UtilitiesSubscriptionIdentification =
        ExternalProxyAccountTypeCode.UtilitiesSubscriptionIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account proxy for receiving insurance claims, pay insurance premium, road tax payments, traffic tickets etc.(applied for corporate or individual account proxy).
    /// Encoded/decoded by serializers as &quot;VIPN&quot;.
    /// </summary>
    [EnumMember(Value = "VIPN")]
    [IsoId("_FLNzoZuVEeya_t2LwNmi4g")]
    [Description(
        @"Account proxy for receiving insurance claims, pay insurance premium, road tax payments, traffic tickets etc.(applied for corporate or individual account proxy)."
    )]
    VehicleIdentificationPlateNumber =
        ExternalProxyAccountTypeCode.VehicleIdentificationPlateNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Billers of specific utilities could register for a Biller Identification as supported in the clearing scheme, and use this identification for collections (applied for corporate account proxy).
    /// Encoded/decoded by serializers as &quot;BIID&quot;.
    /// </summary>
    [EnumMember(Value = "BIID")]
    [IsoId("_Z40uUZuZEeya_t2LwNmi4g")]
    [Description(
        @"Billers of specific utilities could register for a Biller Identification as supported in the clearing scheme, and use this identification for collections (applied for corporate account proxy)."
    )]
    BillerSubscriberIdentification = ExternalProxyAccountTypeCode.BillerSubscriberIdentification, // same ordinal as derivation source for type conversions
}
