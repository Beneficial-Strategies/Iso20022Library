// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_QHCaJNp-Ed-ak6NoX_4Aeg_1389999614")]
public interface IPostalAddress6 : IIsoComponent
{
    /// <summary>
    /// Identifies the nature of the postal address.
    /// </summary>
    [IsoId("_QHCaJdp-Ed-ak6NoX_4Aeg_1389999616")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    AddressType2Code? AddressType { get; }

    /// <summary>
    /// Identification of a division of a large organisation or building.
    /// </summary>
    [IsoId("_QHCaJtp-Ed-ak6NoX_4Aeg_596895935")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    Max70Text? Department { get; }

    /// <summary>
    /// Identification of a sub-division of a large organisation or building.
    /// </summary>
    [IsoId("_QHCaJ9p-Ed-ak6NoX_4Aeg_1609731352")]
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    Max70Text? SubDepartment { get; }

    /// <summary>
    /// Name of a street or thoroughfare.
    /// </summary>
    [IsoId("_QHCaKNp-Ed-ak6NoX_4Aeg_1389999977")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    Max70Text? StreetName { get; }

    /// <summary>
    /// Number that identifies the position of a building on a street.
    /// </summary>
    [IsoId("_QHCaKdp-Ed-ak6NoX_4Aeg_1390000378")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    Max16Text? BuildingNumber { get; }

    /// <summary>
    /// Identifier consisting of a group of letters and/or numbers that is added to a postal address to assist the sorting of mail.
    /// </summary>
    [IsoId("_QHMLINp-Ed-ak6NoX_4Aeg_1390000038")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    Max16Text? PostCode { get; }

    /// <summary>
    /// Name of a built-up area, with defined boundaries, and a local government.
    /// </summary>
    [IsoId("_QHMLIdp-Ed-ak6NoX_4Aeg_1390000069")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    Max35Text? TownName { get; }

    /// <summary>
    /// Identifies a subdivision of a country such as state, region, county.
    /// </summary>
    [IsoId("_QHMLItp-Ed-ak6NoX_4Aeg_1390000099")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    Max35Text? CountrySubDivision { get; }

    /// <summary>
    /// Nation with its own government.
    /// </summary>
    [IsoId("_QHMLI9p-Ed-ak6NoX_4Aeg_1389999699")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    CountryCode? Country { get; }

    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services, presented in free format text.
    /// </summary>
    [IsoId("_QHMLJNp-Ed-ak6NoX_4Aeg_1389999668")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    IEnumerable<string> AddressLine { get; }
}
