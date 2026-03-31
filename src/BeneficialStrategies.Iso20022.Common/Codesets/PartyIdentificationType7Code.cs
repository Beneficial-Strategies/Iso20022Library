// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies an alternative identification of a party, for example, national registration identification number, passport number, tax identification number.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_G1XwkCCOEeWJd9HF2tO7BA")]
[Description(
    @"Specifies an alternative identification of a party, for example, national registration identification number, passport number, tax identification number."
)]
[DerivedFrom(typeof(PersonIdentificationTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PartyIdentificationType7Code>))]
#endif
public enum PartyIdentificationType7Code
{
    /// <summary>
    /// Temporary tax processing number (used in the domestic adoption of a child).
    /// Encoded/decoded by serializers as &quot;ATIN&quot;.
    /// </summary>
    [EnumMember(Value = "ATIN")]
    [IsoId("_VAo8cSCOEeWJd9HF2tO7BA")]
    [Description(@"Temporary tax processing number (used in the domestic adoption of a child).")]
    AdoptionTaxpayerIdentificationNumber =
        PersonIdentificationTypeCode.AdoptionTaxpayerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a national authority to an identity card.
    /// Encoded/decoded by serializers as &quot;IDCD&quot;.
    /// </summary>
    [EnumMember(Value = "IDCD")]
    [IsoId("_VzhK4SCOEeWJd9HF2tO7BA")]
    [Description(@"Number assigned by a national authority to an identity card.")]
    IdentityCardNumber = PersonIdentificationTypeCode.IdentityCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National registration identification number. In Singapore this is known as the NRIC.
    /// Encoded/decoded by serializers as &quot;NRIN&quot;.
    /// </summary>
    [EnumMember(Value = "NRIN")]
    [IsoId("_Xuj7QSCOEeWJd9HF2tO7BA")]
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
    [IsoId("_YWvVkSCOEeWJd9HF2tO7BA")]
    [Description(@"Another type of identification type.")]
    Other = PersonIdentificationTypeCode.Other, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;PASS&quot;.
    /// </summary>
    [EnumMember(Value = "PASS")]
    [IsoId("_ZAZWkSCOEeWJd9HF2tO7BA")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = PersonIdentificationTypeCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Post office card number as assigned by a national post office.
    /// Encoded/decoded by serializers as &quot;POCD&quot;.
    /// </summary>
    [EnumMember(Value = "POCD")]
    [IsoId("_ZQBG8SCOEeWJd9HF2tO7BA")]
    [Description(@"Post office card number as assigned by a national post office.")]
    PostOfficeCardNumber = PersonIdentificationTypeCode.PostOfficeCardNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a social security agency.
    /// Encoded/decoded by serializers as &quot;SOCS&quot;.
    /// </summary>
    [EnumMember(Value = "SOCS")]
    [IsoId("_ZrsWUSCOEeWJd9HF2tO7BA")]
    [Description(@"Number assigned by a social security agency.")]
    SocialSecurityNumber = PersonIdentificationTypeCode.SocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Supplementary retirement scheme account number.
    /// Encoded/decoded by serializers as &quot;SRSA&quot;.
    /// </summary>
    [EnumMember(Value = "SRSA")]
    [IsoId("_Z06jwSCOEeWJd9HF2tO7BA")]
    [Description(@"Supplementary retirement scheme account number.")]
    SRSAccountNumber = PersonIdentificationTypeCode.SRSAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Gun license number as assigned by a gun licensing authority.
    /// Encoded/decoded by serializers as &quot;GUNL&quot;.
    /// </summary>
    [EnumMember(Value = "GUNL")]
    [IsoId("_aYxewSCOEeWJd9HF2tO7BA")]
    [Description(@"Gun license number as assigned by a gun licensing authority.")]
    GunLicenseNumber = PersonIdentificationTypeCode.GunLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Generic tax identification number.
    /// Encoded/decoded by serializers as &quot;GTIN&quot;.
    /// </summary>
    [EnumMember(Value = "GTIN")]
    [IsoId("_dlWIcSCOEeWJd9HF2tO7BA")]
    [Description(@"Generic tax identification number.")]
    GenericTaxIdentificationNumber = PersonIdentificationTypeCode.GenericTaxIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax processing number.
    /// Encoded/decoded by serializers as &quot;ITIN&quot;.
    /// </summary>
    [EnumMember(Value = "ITIN")]
    [IsoId("_fCyW0SCOEeWJd9HF2tO7BA")]
    [Description(@"Tax processing number.")]
    IndividualTaxpayerIdentificationNumber =
        PersonIdentificationTypeCode.IndividualTaxpayerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account issued by the Central Provident Fund Board (Singapore).
    /// Encoded/decoded by serializers as &quot;CPFA&quot;.
    /// </summary>
    [EnumMember(Value = "CPFA")]
    [IsoId("_mharkSCOEeWJd9HF2tO7BA")]
    [Description(@"Account issued by the Central Provident Fund Board (Singapore).")]
    CPFAccountNumber = PersonIdentificationTypeCode.CPFAccountNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;AREG&quot;.
    /// </summary>
    [EnumMember(Value = "AREG")]
    [IsoId("_sbdoISCOEeWJd9HF2tO7BA")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = PersonIdentificationTypeCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_tIiJgSCOEeWJd9HF2tO7BA")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber = PersonIdentificationTypeCode.DriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_uDANsSCOEeWJd9HF2tO7BA")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = PersonIdentificationTypeCode.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number that identifies the type of investor registered at a securities and exchange commission.
    /// Encoded/decoded by serializers as &quot;NINV&quot;.
    /// </summary>
    [EnumMember(Value = "NINV")]
    [IsoId("_hklJESDZEeWCLu74WLgP4w")]
    [Description(
        @"Number that identifies the type of investor registered at a securities and exchange commission."
    )]
    NonResidentInvestor = PersonIdentificationTypeCode.NonResidentInvestor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number, typically assigned by a government to describe ownership, administrative and authoritative relations.
    /// Encoded/decoded by serializers as &quot;INCL&quot;.
    /// </summary>
    [EnumMember(Value = "INCL")]
    [IsoId("_tBp6ESMuEeWw25nezi_B1g")]
    [Description(
        @"Number, typically assigned by a government to describe ownership, administrative and authoritative relations."
    )]
    IndustryClassification = PersonIdentificationTypeCode.IndustryClassification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Global intermediary tax identification number.
    /// Encoded/decoded by serializers as &quot;GIIN&quot;.
    /// </summary>
    [EnumMember(Value = "GIIN")]
    [IsoId("_bodkMTa3EeWxoIK_IhudJg")]
    [Description(@"Global intermediary tax identification number.")]
    GlobalIntermediaryIdentificationNumber =
        PersonIdentificationTypeCode.GlobalIntermediaryIdentificationNumber, // same ordinal as derivation source for type conversions
}
