// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of an individual person, for example, national registration identification number, passport number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_QTJ5MQhFEeSUPbC7DbLJpQ")]
[Description(
    @"Specifies an alternative identification of an individual person, for example, national registration identification number, passport number."
)]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
public enum PersonIdentificationType6Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;AREG&quot;.
    /// </summary>
    [EnumMember(Value = "AREG")]
    [IsoId("_QvIDgQhFEeSUPbC7DbLJpQ")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = PersonIdentificationTypeCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as &quot;CPFA&quot;.
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_QvIDgwhFEeSUPbC7DbLJpQ")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber = PersonIdentificationTypeCode.CPFAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_QvIDhQhFEeSUPbC7DbLJpQ")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber = PersonIdentificationTypeCode.DriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_QvIDhwhFEeSUPbC7DbLJpQ")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = PersonIdentificationTypeCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_QvIDiQhFEeSUPbC7DbLJpQ")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = PersonIdentificationTypeCode.IdentityCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_QvIDiwhFEeSUPbC7DbLJpQ")]
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
    [IsoId("_QvIDjQhFEeSUPbC7DbLJpQ")]
    [Description(@"Another type of identification type.")]
    Other = PersonIdentificationTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_QvIDjwhFEeSUPbC7DbLJpQ")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = PersonIdentificationTypeCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Post office card number as assigned by a national post office.
    /// Encoded/decoded by serializers as &quot;POCD&quot;.
    /// </summary>
    [EnumMember(Value = "POCD")]
    [IsoId("_QvIDkQhFEeSUPbC7DbLJpQ")]
    [Description(@"Post office card number as assigned by a national post office.")]
    PostOfficeCardNumber = PersonIdentificationTypeCode.PostOfficeCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_QvIDkwhFEeSUPbC7DbLJpQ")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = PersonIdentificationTypeCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_QvIDlQhFEeSUPbC7DbLJpQ")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber = PersonIdentificationTypeCode.SRSAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gun license number as assigned by a gun licensing authority.
    /// Encoded/decoded by serializers as &quot;GUNL&quot;.
    /// </summary>
    [EnumMember(Value = "GUNL")]
    [IsoId("_QvIDlwhFEeSUPbC7DbLJpQ")]
    [Description(@"Gun license number as assigned by a gun licensing authority.")]
    GunLicenseNumber = PersonIdentificationTypeCode.GunLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Temporary tax processing number (used in the domestic adoption of a child).
    /// Encoded/decoded by serializers as &quot;ATIN&quot;.
    /// </summary>
    [EnumMember(Value = "ATIN")]
    [IsoId("_7sydoWXEEeSrv8256XoCZg")]
    [Description(@"Temporary tax processing number (used in the domestic adoption of a child).")]
    AdoptionTaxpayerIdentificationNumber =
        PersonIdentificationTypeCode.AdoptionTaxpayerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic tax identification number.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_8aBXEWXEEeSrv8256XoCZg")]
    [Description(@"Generic tax identification number.")]
    GenericTaxIdentificationNumber = PersonIdentificationTypeCode.GenericTaxIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax processing number.
    /// Encoded/decoded by serializers as &quot;ITIN&quot;.
    /// </summary>
    [EnumMember(Value = "ITIN")]
    [IsoId("_9sJGQWXEEeSrv8256XoCZg")]
    [Description(@"Tax processing number.")]
    IndividualTaxpayerIdentificationNumber =
        PersonIdentificationTypeCode.IndividualTaxpayerIdentificationNumber, // same ordinal as derivation source for type conversions
}
