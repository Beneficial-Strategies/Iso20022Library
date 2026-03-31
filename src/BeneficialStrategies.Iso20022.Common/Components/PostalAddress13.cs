// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_zlTVEUuAEeOC3MFxIpMwug")]
[DisplayName("Postal Address")]
public record PostalAddress13
{
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, that is presented in free format text.
    /// </summary>
    [IsoId("_zwLIU0uAEeOC3MFxIpMwug")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<System.String> AddressLine { get; init; } = [];

    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_zwLIVUuAEeOC3MFxIpMwug")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; }

    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_zwLIV0uAEeOC3MFxIpMwug")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; }

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_zwLIWUuAEeOC3MFxIpMwug")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text PostCode { get; init; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_zwLIW0uAEeOC3MFxIpMwug")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TownName { get; init; }

    /// <summary>
    /// Identifies a subdivision of a country eg, state, region, county.
    /// </summary>
    [IsoId("_zwLIXUuAEeOC3MFxIpMwug")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; }

    /// <summary>
    /// Nation with its own government, occupying a particular territory.
    /// </summary>
    [IsoId("_zwLIX0uAEeOC3MFxIpMwug")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }
}
