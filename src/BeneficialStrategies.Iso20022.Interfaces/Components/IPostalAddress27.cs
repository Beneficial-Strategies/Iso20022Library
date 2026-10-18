// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Postal Address27.
/// </summary>
[IsoId("_vvaRYTEyEe6g-ffJsqGiSA")]
public interface IPostalAddress27 : IIsoComponent
{
    /// <summary>
    /// Address Line.
    /// </summary>
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    IEnumerable<IsoMax70Text> AddressLine { get; }

    /// <summary>
    /// Address Type.
    /// </summary>
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    IAddressType3Choice? AddressType { get; }

    /// <summary>
    /// Building Name.
    /// </summary>
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    IsoMax140Text? BuildingName { get; }

    /// <summary>
    /// Building Number.
    /// </summary>
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    IsoMax16Text? BuildingNumber { get; }

    /// <summary>
    /// Care Of.
    /// </summary>
    [DisplayName("Care Of")]
    [IsoXmlTag("CareOf")]
    IsoMax140Text? CareOf { get; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    CountryCode? Country { get; }

    /// <summary>
    /// Country Sub Division.
    /// </summary>
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    IsoMax35Text? CountrySubDivision { get; }

    /// <summary>
    /// Department.
    /// </summary>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    IsoMax70Text? Department { get; }

    /// <summary>
    /// District Name.
    /// </summary>
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    IsoMax140Text? DistrictName { get; }

    /// <summary>
    /// Floor.
    /// </summary>
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    IsoMax70Text? Floor { get; }

    /// <summary>
    /// Post Box.
    /// </summary>
    [DisplayName("Post Box")]
    [IsoXmlTag("PstBx")]
    IsoMax16Text? PostBox { get; }

    /// <summary>
    /// Post Code.
    /// </summary>
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    IsoMax16Text? PostCode { get; }

    /// <summary>
    /// Room.
    /// </summary>
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    IsoMax70Text? Room { get; }

    /// <summary>
    /// Street Name.
    /// </summary>
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    IsoMax140Text? StreetName { get; }

    /// <summary>
    /// Sub Department.
    /// </summary>
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    IsoMax70Text? SubDepartment { get; }

    /// <summary>
    /// Town Location Name.
    /// </summary>
    [DisplayName("Town Location Name")]
    [IsoXmlTag("TwnLctnNm")]
    IsoMax140Text? TownLocationName { get; }

    /// <summary>
    /// Town Name.
    /// </summary>
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    IsoMax140Text? TownName { get; }

    /// <summary>
    /// Unit Number.
    /// </summary>
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    IsoMax16Text? UnitNumber { get; }
}
