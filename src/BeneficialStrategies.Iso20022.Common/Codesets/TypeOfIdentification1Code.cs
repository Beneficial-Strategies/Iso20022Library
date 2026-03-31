// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of alternate identification which can be used to give an alternate identification of the party identified.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YwnfFdp-Ed-ak6NoX_4Aeg_-1079654789")]
[Description(
    @"Specifies the type of alternate identification which can be used to give an alternate identification of the party identified."
)]
[DerivedFrom(typeof(TypeOfIdentificationCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<TypeOfIdentification1Code>))]
#endif
public enum TypeOfIdentification1Code
{
    /// <summary>
    /// Number assigned by a government agency to identify foreign nationals.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("_YwnfFtp-Ed-ak6NoX_4Aeg_-632668460")]
    [Description(@"Number assigned by a government agency to identify foreign nationals.")]
    AlienRegistrationNumber = TypeOfIdentificationCode.AlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a passport authority.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("_YwnfF9p-Ed-ak6NoX_4Aeg_-334369828")]
    [Description(@"Number assigned by a passport authority.")]
    PassportNumber = TypeOfIdentificationCode.PassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a tax exempt entity.
    /// Encoded/decoded by serializers as &quot;CHTY&quot;.
    /// </summary>
    [EnumMember(Value = "CHTY")]
    [IsoId("_YwxQENp-Ed-ak6NoX_4Aeg_-332526291")]
    [Description(@"Number assigned to a tax exempt entity.")]
    TaxExemptIdentificationNumber = TypeOfIdentificationCode.TaxExemptIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a corporate entity.
    /// Encoded/decoded by serializers as &quot;CORP&quot;.
    /// </summary>
    [EnumMember(Value = "CORP")]
    [IsoId("_YwxQEdp-Ed-ak6NoX_4Aeg_-332522818")]
    [Description(@"Number assigned to a corporate entity.")]
    CorporateIdentification = TypeOfIdentificationCode.CorporateIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a driver&apos;s license.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("_YwxQEtp-Ed-ak6NoX_4Aeg_-331599633")]
    [Description(@"Number assigned to a driver's license.")]
    DriverLicenseNumber = TypeOfIdentificationCode.DriverLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned to a foreign investor (other than the alien number).
    /// Encoded/decoded by serializers as &quot;FIIN&quot;.
    /// </summary>
    [EnumMember(Value = "FIIN")]
    [IsoId("_YwxQE9p-Ed-ak6NoX_4Aeg_-330676223")]
    [Description(@"Number assigned to a foreign investor (other than the alien number).")]
    ForeignInvestmentIdentityNumber = TypeOfIdentificationCode.ForeignInvestmentIdentityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Number assigned by a tax authority to an entity.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("_YwxQFNp-Ed-ak6NoX_4Aeg_-329752873")]
    [Description(@"Number assigned by a tax authority to an entity.")]
    TaxIdentificationNumber = TypeOfIdentificationCode.TaxIdentificationNumber, // same ordinal as derivation source for type conversions
}
