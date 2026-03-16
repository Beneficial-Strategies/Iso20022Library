// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_RoFDgI6CEemzmeK8_tPygg")]
[Description(
    @"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified."
)]
[DerivedFrom(typeof(TypeOfIdentificationCode))]
public enum TypeOfIdentification4Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_VQxBcY6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = TypeOfIdentificationCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by an issuer to identify a customer via the concatenation of the birthdate and characters of the first name and surname.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("_VbVSso6CEemzmeK8_tPygg")]
    [Description(
        @"Number assigned by an issuer to identify a customer via the concatenation of the birthdate and characters of the first name and surname. "
    )]
    Concat = TypeOfIdentificationCode.Concat, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_Viecgo6CEemzmeK8_tPygg")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification = TypeOfIdentificationCode.CorporateIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_Vp6hQo6CEemzmeK8_tPygg")]
    [Description(@"Number assigned to a driver's license.")]
    DriverLicenseNumber = TypeOfIdentificationCode.DriverLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_XbksIY6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = TypeOfIdentificationCode.IdentityCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_Xk8qko6CEemzmeK8_tPygg")]
    [Description(
        @"National registration identification number. In Singapore this is known as the NRIC."
    )]
    NationalRegistrationIdentificationNumber =
        TypeOfIdentificationCode.NationalRegistrationIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a passport authority.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_Xrf-go6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a passport authority.")]
    PassportNumber = TypeOfIdentificationCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_X-PUUo6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = TypeOfIdentificationCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_Yqk14Y6CEemzmeK8_tPygg")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber = TypeOfIdentificationCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
}
