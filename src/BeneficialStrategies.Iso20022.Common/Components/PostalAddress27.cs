// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPostalAddress27"/>
[IsoId("_vvaRYTEyEe6g-ffJsqGiSA")]
[DisplayName("Postal Address27")]
public partial record PostalAddress27
{
    /// <inheritdoc cref="IPostalAddress27.AddressLine"/>
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    public SimpleValueList<IsoMax70Text> AddressLine { get; init; } = [];

    /// <inheritdoc cref="IPostalAddress27.AddressType"/>
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType3Choice_? AddressType { get; init; }

    /// <inheritdoc cref="IPostalAddress27.BuildingName"/>
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    public IsoMax140Text? BuildingName { get; init; }

    /// <inheritdoc cref="IPostalAddress27.BuildingNumber"/>
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    public IsoMax16Text? BuildingNumber { get; init; }

    /// <inheritdoc cref="IPostalAddress27.CareOf"/>
    [DisplayName("Care Of")]
    [IsoXmlTag("CareOf")]
    public IsoMax140Text? CareOf { get; init; }

    /// <inheritdoc cref="IPostalAddress27.Country"/>
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <inheritdoc cref="IPostalAddress27.CountrySubDivision"/>
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    public IsoMax35Text? CountrySubDivision { get; init; }

    /// <inheritdoc cref="IPostalAddress27.Department"/>
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    public IsoMax70Text? Department { get; init; }

    /// <inheritdoc cref="IPostalAddress27.DistrictName"/>
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    public IsoMax140Text? DistrictName { get; init; }

    /// <inheritdoc cref="IPostalAddress27.Floor"/>
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    public IsoMax70Text? Floor { get; init; }

    /// <inheritdoc cref="IPostalAddress27.PostBox"/>
    [DisplayName("Post Box")]
    [IsoXmlTag("PstBx")]
    public IsoMax16Text? PostBox { get; init; }

    /// <inheritdoc cref="IPostalAddress27.PostCode"/>
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    public IsoMax16Text? PostCode { get; init; }

    /// <inheritdoc cref="IPostalAddress27.Room"/>
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    public IsoMax70Text? Room { get; init; }

    /// <inheritdoc cref="IPostalAddress27.StreetName"/>
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    public IsoMax140Text? StreetName { get; init; }

    /// <inheritdoc cref="IPostalAddress27.SubDepartment"/>
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    public IsoMax70Text? SubDepartment { get; init; }

    /// <inheritdoc cref="IPostalAddress27.TownLocationName"/>
    [DisplayName("Town Location Name")]
    [IsoXmlTag("TwnLctnNm")]
    public IsoMax140Text? TownLocationName { get; init; }

    /// <inheritdoc cref="IPostalAddress27.TownName"/>
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    public IsoMax140Text? TownName { get; init; }

    /// <inheritdoc cref="IPostalAddress27.UnitNumber"/>
    [DisplayName("Unit Number")]
    [IsoXmlTag("UnitNb")]
    public IsoMax16Text? UnitNumber { get; init; }
}
