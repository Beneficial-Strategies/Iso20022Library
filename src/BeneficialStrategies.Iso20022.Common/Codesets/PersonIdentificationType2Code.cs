// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aGmaltp-Ed-ak6NoX_4Aeg_2029700849")]
[Description(
    @"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number."
)]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
public enum PersonIdentificationType2Code
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_aGmal9p-Ed-ak6NoX_4Aeg_864875963")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = PersonIdentificationTypeCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as &quot;CPFA&quot;.
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_aGmamNp-Ed-ak6NoX_4Aeg_864876360")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber = PersonIdentificationTypeCode.CPFAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_aGvkgNp-Ed-ak6NoX_4Aeg_864876377")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber = PersonIdentificationTypeCode.SRSAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_aGvkgdp-Ed-ak6NoX_4Aeg_864876395")]
    [Description(
        @"National registration identification number. In Singapore this is known as the NRIC."
    )]
    NationalRegistrationIdentificationNumber =
        PersonIdentificationTypeCode.NationalRegistrationIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aGvkgtp-Ed-ak6NoX_4Aeg_864876430")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber = PersonIdentificationTypeCode.DriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_aGvkg9p-Ed-ak6NoX_4Aeg_864876455")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = PersonIdentificationTypeCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;AREG&quot;.
    /// </summary>
    [EnumMember(Value = "AREG")]
    [IsoId("_aGvkhNp-Ed-ak6NoX_4Aeg_864876472")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = PersonIdentificationTypeCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_aGvkhdp-Ed-ak6NoX_4Aeg_864876738")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = PersonIdentificationTypeCode.IdentityCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aGvkhtp-Ed-ak6NoX_4Aeg_864876763")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = PersonIdentificationTypeCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions
}
