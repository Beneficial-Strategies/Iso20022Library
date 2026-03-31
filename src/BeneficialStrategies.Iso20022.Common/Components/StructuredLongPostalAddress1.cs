// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Address of a party expressed in a formal structure, usually according to the country&apos;s postal services specifications.
/// </summary>
[IsoId("_QGckRNp-Ed-ak6NoX_4Aeg_829983721")]
[DisplayName("Structured Long Postal Address")]
public record StructuredLongPostalAddress1
{
    /// <summary>
    /// Name of the building or house.
    /// </summary>
    [IsoId("_QGckRdp-Ed-ak6NoX_4Aeg_1005453911")]
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BuildingName { get; init; }

    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_QGckRtp-Ed-ak6NoX_4Aeg_1005453819")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StreetName { get; init; }

    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_QGluMNp-Ed-ak6NoX_4Aeg_1005453850")]
    [DisplayName("Street Building Identification")]
    [IsoXmlTag("StrtBldgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StreetBuildingIdentification { get; init; }

    /// <summary>
    /// Floor or storey within a building.
    /// </summary>
    [IsoId("_QGluMdp-Ed-ak6NoX_4Aeg_1005454212")]
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? Floor { get; init; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_QGluMtp-Ed-ak6NoX_4Aeg_1005453881")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TownName { get; init; }

    /// <summary>
    /// Name of a district, that is, a part of a town or region.
    /// </summary>
    [IsoId("_QGluM9p-Ed-ak6NoX_4Aeg_1005453964")]
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DistrictName { get; init; }

    /// <summary>
    /// Identification of an administrative division of a country, state, or territory.
    /// </summary>
    [IsoId("_QGluNNp-Ed-ak6NoX_4Aeg_1005454644")]
    [DisplayName("Region Identification")]
    [IsoXmlTag("RgnId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RegionIdentification { get; init; }

    /// <summary>
    /// Organised political community or area forming a part of a federation.
    /// </summary>
    [IsoId("_QGluNdp-Ed-ak6NoX_4Aeg_1005454674")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? State { get; init; }

    /// <summary>
    /// Identifier of a county.
    /// </summary>
    [IsoId("_QGluNtp-Ed-ak6NoX_4Aeg_1005453942")]
    [DisplayName("County Identification")]
    [IsoXmlTag("CtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CountyIdentification { get; init; }

    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_QGluN9p-Ed-ak6NoX_4Aeg_1005453697")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; }

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_QGluONp-Ed-ak6NoX_4Aeg_1005453789")]
    [DisplayName("Post Code Identification")]
    [IsoXmlTag("PstCdId")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public required IsoMax16Text PostCodeIdentification { get; init; }

    /// <summary>
    /// Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.
    /// </summary>
    [IsoId("_QGluOdp-Ed-ak6NoX_4Aeg_1005454273")]
    [DisplayName("Post Office Box")]
    [IsoXmlTag("POB")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? PostOfficeBox { get; init; }
}
