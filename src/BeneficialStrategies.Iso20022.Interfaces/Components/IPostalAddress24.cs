// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_9XYD524-EeiU9cctagi5ow")]
public interface IPostalAddress24 : IIsoComponent
{
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    [IsoId("_9gwpY24-EeiU9cctagi5ow")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    IAddressType3Choice? AddressType { get; }

    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_9gwpZW4-EeiU9cctagi5ow")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    IsoMax70Text? Department { get; }

    /// <summary>
    /// Identification of a sub-division of a large organisation or building.
    /// </summary>
    [IsoId("_9gwpZ24-EeiU9cctagi5ow")]
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    IsoMax70Text? SubDepartment { get; }

    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_9gwpaW4-EeiU9cctagi5ow")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    IsoMax70Text? StreetName { get; }

    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_9gwpa24-EeiU9cctagi5ow")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    IsoMax16Text? BuildingNumber { get; }

    /// <summary>
    /// Name of the building or house.
    /// </summary>
    [IsoId("_ZOcTkG5OEeiU9cctagi5ow")]
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    IsoMax35Text? BuildingName { get; }

    /// <summary>
    /// Floor or storey within a building.
    /// </summary>
    [IsoId("_F1IHQ3RpEeiH1ZOt2UD8vQ")]
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    IsoMax70Text? Floor { get; }

    /// <summary>
    /// Numbered box in a post office, assigned to a person or organisation, where letters are kept until called for.
    /// </summary>
    [IsoId("_F1IHRHRpEeiH1ZOt2UD8vQ")]
    [DisplayName("Post Box")]
    [IsoXmlTag("PstBx")]
    IsoMax16Text? PostBox { get; }

    /// <summary>
    /// Building room number.
    /// </summary>
    [IsoId("_F1IHRXRpEeiH1ZOt2UD8vQ")]
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    IsoMax70Text? Room { get; }

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_9gwpbW4-EeiU9cctagi5ow")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    IsoMax16Text? PostCode { get; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_9gwpb24-EeiU9cctagi5ow")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    IsoMax35Text? TownName { get; }

    /// <summary>
    /// Specific location name within the town.
    /// </summary>
    [IsoId("_rvZGQ25OEeiU9cctagi5ow")]
    [DisplayName("Town Location Name")]
    [IsoXmlTag("TwnLctnNm")]
    IsoMax35Text? TownLocationName { get; }

    /// <summary>
    /// Identifies a subdivision within a country sub-division.
    /// </summary>
    [IsoId("_rvZGRG5OEeiU9cctagi5ow")]
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    IsoMax35Text? DistrictName { get; }

    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_9gwpcW4-EeiU9cctagi5ow")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    IsoMax35Text? CountrySubDivision { get; }

    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_9gwpc24-EeiU9cctagi5ow")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    CountryCode? Country { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
    /// </summary>
    [IsoId("_9gwpdW4-EeiU9cctagi5ow")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    IEnumerable<string> AddressLine { get; }
}
