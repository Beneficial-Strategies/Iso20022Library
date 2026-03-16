// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of person&apos;s identification.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aGvkh9p-Ed-ak6NoX_4Aeg_266470200")]
[Description(@"Specifies the type of person's identification.")]
[DerivedFrom(typeof(PersonIdentificationTypeV2Code))]
public enum PersonIdentificationType3Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_aGvkiNp-Ed-ak6NoX_4Aeg_266470202")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = PersonIdentificationTypeV2Code.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a passport authority to a passport.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_aGvkidp-Ed-ak6NoX_4Aeg_266470231")]
    [Description(@"Number assigned by a passport authority to a passport.")]
    PassportNumber = PersonIdentificationTypeV2Code.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to an employer by a registration authority.
    /// Encoded/decoded by serializers as &quot;EMID&quot;.
    /// </summary>
    [EnumMember(Value = "EMID")]
    [IsoId("_aG5VgNp-Ed-ak6NoX_4Aeg_266470232")]
    [Description(@"Number assigned to an employer by a registration authority.")]
    EmployerIdentificationNumber = PersonIdentificationTypeV2Code.EmployerIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a license authority to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_aG5Vgdp-Ed-ak6NoX_4Aeg_266470233")]
    [Description(@"Number assigned by a license authority to a driver's license.")]
    DriversLicenseNumber = PersonIdentificationTypeV2Code.DriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as &quot;FINN&quot;.
    /// </summary>
    [EnumMember(Value = "FINN")]
    [IsoId("_aG5Vgtp-Ed-ak6NoX_4Aeg_266470261")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber =
        PersonIdentificationTypeV2Code.ForeignInvestmentIdentityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_aG5Vg9p-Ed-ak6NoX_4Aeg_266470262")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber = PersonIdentificationTypeV2Code.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
}
