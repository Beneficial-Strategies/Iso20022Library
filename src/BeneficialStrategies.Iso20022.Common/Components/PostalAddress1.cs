// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPostalAddress1"/>
[IsoId("_QG4pKNp-Ed-ak6NoX_4Aeg_-839174134")]
[DisplayName("Postal Address")]
public partial record PostalAddress1
{
    /// <inheritdoc cref="IPostalAddress1.AddressType"/>
    [IsoId("_QG4pKdp-Ed-ak6NoX_4Aeg_-293371907")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType2Code? AddressType { get; init; }

    /// <inheritdoc cref="IPostalAddress1.AddressLine"/>
    [IsoId("_QG4pKtp-Ed-ak6NoX_4Aeg_-484540115")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<string> AddressLine { get; init; } = [];

    /// <inheritdoc cref="IPostalAddress1.StreetName"/>
    [IsoId("_QG4pK9p-Ed-ak6NoX_4Aeg_-1702876782")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; }

    /// <inheritdoc cref="IPostalAddress1.BuildingNumber"/>
    [IsoId("_QG4pLNp-Ed-ak6NoX_4Aeg_-1628995660")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; }

    /// <inheritdoc cref="IPostalAddress1.PostCode"/>
    [IsoId("_QHCaINp-Ed-ak6NoX_4Aeg_-14467862")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; }

    /// <inheritdoc cref="IPostalAddress1.TownName"/>
    [IsoId("_QHCaIdp-Ed-ak6NoX_4Aeg_15083256")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; }

    /// <inheritdoc cref="IPostalAddress1.CountrySubDivision"/>
    [IsoId("_QHCaItp-Ed-ak6NoX_4Aeg_44636499")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; }

    /// <inheritdoc cref="IPostalAddress1.Country"/>
    [IsoId("_QHCaI9p-Ed-ak6NoX_4Aeg_-34786848")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }
}
