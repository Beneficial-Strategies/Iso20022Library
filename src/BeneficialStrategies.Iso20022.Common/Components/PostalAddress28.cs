// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Postal Address28.
/// </summary>
[IsoId("_qXriATHSEe6Q5sI3912YOA")]
[DisplayName("Postal Address28")]
public record PostalAddress28
{
    /// <summary>
    /// Address Line.
    /// </summary>
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    public SimpleValueList<Max70Text> AddressLine { get; init; } = [];

    /// <summary>
    /// Address Type.
    /// </summary>
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType3Choice_? AddressType { get; init; }

    /// <summary>
    /// Building Name.
    /// </summary>
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    public Max140Text? BuildingName { get; init; }

    /// <summary>
    /// Building Number.
    /// </summary>
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    public Max16Text? BuildingNumber { get; init; }

    /// <summary>
    /// Care Of.
    /// </summary>
    [DisplayName("Care Of")]
    [IsoXmlTag("CareOf")]
    public Max140Text? CareOf { get; init; }

    /// <summary>
    /// Country.
    /// </summary>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Country Sub Division.
    /// </summary>
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    public Max35Text? CountrySubDivision { get; init; }

    /// <summary>
    /// Department.
    /// </summary>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    public Max70Text? Department { get; init; }

    /// <summary>
    /// District Name.
    /// </summary>
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    public Max140Text? DistrictName { get; init; }

    /// <summary>
    /// Floor.
    /// </summary>
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    public Max70Text? Floor { get; init; }

    /// <summary>
    /// Post Box.
    /// </summary>
    [DisplayName("Post Box")]
    [IsoXmlTag("PstBx")]
    public Max16Text? PostBox { get; init; }

    /// <summary>
    /// Post Code.
    /// </summary>
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    public Max16Text? PostCode { get; init; }

    /// <summary>
    /// Room.
    /// </summary>
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    public Max70Text? Room { get; init; }

    /// <summary>
    /// Street Name.
    /// </summary>
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    public Max140Text? StreetName { get; init; }

    /// <summary>
    /// Sub Department.
    /// </summary>
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    public Max70Text? SubDepartment { get; init; }

    /// <summary>
    /// Town Location Name.
    /// </summary>
    [DisplayName("Town Location Name")]
    [IsoXmlTag("TwnLctnNm")]
    public Max140Text? TownLocationName { get; init; }

    /// <summary>
    /// Town Name.
    /// </summary>
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    public Max140Text? TownName { get; init; }

    /// <summary>
    /// Unit Number.
    /// </summary>
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    public Max16Text? UnitNumber { get; init; }

    /// <summary>
    /// Valid From.
    /// </summary>
    [DisplayName("Valid From")]
    [IsoXmlTag("VldFr")]
    public DateOnly? ValidFrom { get; init; }
}
