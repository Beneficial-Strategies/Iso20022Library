// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aGcplNp-Ed-ak6NoX_4Aeg_1146103115")]
[Description(
    @"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number."
)]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PersonIdentificationType1Code>))]
#endif
public enum PersonIdentificationType1Code
{
    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_aGcpldp-Ed-ak6NoX_4Aeg_-962231662")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = PersonIdentificationTypeCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as &quot;CPFA&quot;.
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_aGcpltp-Ed-ak6NoX_4Aeg_-962231602")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber = PersonIdentificationTypeCode.CPFAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_aGcpl9p-Ed-ak6NoX_4Aeg_-962231560")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber = PersonIdentificationTypeCode.SRSAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_aGcpmNp-Ed-ak6NoX_4Aeg_-962231259")]
    [Description(
        @"National registration identification number. In Singapore this is known as the NRIC."
    )]
    NationalRegistrationIdentificationNumber =
        PersonIdentificationTypeCode.NationalRegistrationIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Another type of identification type.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_aGmakNp-Ed-ak6NoX_4Aeg_-962231217")]
    [Description(@"Another type of identification type.")]
    Other = PersonIdentificationTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aGmakdp-Ed-ak6NoX_4Aeg_-2107022610")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber = PersonIdentificationTypeCode.DriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_aGmaktp-Ed-ak6NoX_4Aeg_-2107022143")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = PersonIdentificationTypeCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;AREG&quot;.
    /// </summary>
    [EnumMember(Value = "AREG")]
    [IsoId("_aGmak9p-Ed-ak6NoX_4Aeg_-2107022083")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = PersonIdentificationTypeCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_aGmalNp-Ed-ak6NoX_4Aeg_-2106102034")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = PersonIdentificationTypeCode.IdentityCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aGmaldp-Ed-ak6NoX_4Aeg_-2106101948")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = PersonIdentificationTypeCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions
}
