// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPostalAddress24"/>
[IsoId("_9XYD524-EeiU9cctagi5ow")]
[DisplayName("Postal Address")]
public partial record PostalAddress24
{
    /// <inheritdoc cref="IPostalAddress24.AddressType"/>
    [IsoId("_9gwpY24-EeiU9cctagi5ow")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType3Choice_? AddressType { get; init; }

    /// <inheritdoc cref="IPostalAddress24.Department"/>
    [IsoId("_9gwpZW4-EeiU9cctagi5ow")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; }

    /// <inheritdoc cref="IPostalAddress24.SubDepartment"/>
    [IsoId("_9gwpZ24-EeiU9cctagi5ow")]
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SubDepartment { get; init; }

    /// <inheritdoc cref="IPostalAddress24.StreetName"/>
    [IsoId("_9gwpaW4-EeiU9cctagi5ow")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; }

    /// <inheritdoc cref="IPostalAddress24.BuildingNumber"/>
    [IsoId("_9gwpa24-EeiU9cctagi5ow")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; }

    /// <inheritdoc cref="IPostalAddress24.BuildingName"/>
    [IsoId("_ZOcTkG5OEeiU9cctagi5ow")]
    [DisplayName("Building Name")]
    [IsoXmlTag("BldgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? BuildingName { get; init; }

    /// <inheritdoc cref="IPostalAddress24.Floor"/>
    [IsoId("_F1IHQ3RpEeiH1ZOt2UD8vQ")]
    [DisplayName("Floor")]
    [IsoXmlTag("Flr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Floor { get; init; }

    /// <inheritdoc cref="IPostalAddress24.PostBox"/>
    [IsoId("_F1IHRHRpEeiH1ZOt2UD8vQ")]
    [DisplayName("Post Box")]
    [IsoXmlTag("PstBx")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? PostBox { get; init; }

    /// <inheritdoc cref="IPostalAddress24.Room"/>
    [IsoId("_F1IHRXRpEeiH1ZOt2UD8vQ")]
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Room { get; init; }

    /// <inheritdoc cref="IPostalAddress24.PostCode"/>
    [IsoId("_9gwpbW4-EeiU9cctagi5ow")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; }

    /// <inheritdoc cref="IPostalAddress24.TownName"/>
    [IsoId("_9gwpb24-EeiU9cctagi5ow")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; }

    /// <inheritdoc cref="IPostalAddress24.TownLocationName"/>
    [IsoId("_rvZGQ25OEeiU9cctagi5ow")]
    [DisplayName("Town Location Name")]
    [IsoXmlTag("TwnLctnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TownLocationName { get; init; }

    /// <inheritdoc cref="IPostalAddress24.DistrictName"/>
    [IsoId("_rvZGRG5OEeiU9cctagi5ow")]
    [DisplayName("District Name")]
    [IsoXmlTag("DstrctNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DistrictName { get; init; }

    /// <inheritdoc cref="IPostalAddress24.CountrySubDivision"/>
    [IsoId("_9gwpcW4-EeiU9cctagi5ow")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; }

    /// <inheritdoc cref="IPostalAddress24.Country"/>
    [IsoId("_9gwpc24-EeiU9cctagi5ow")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <inheritdoc cref="IPostalAddress24.AddressLine"/>
    [IsoId("_9gwpdW4-EeiU9cctagi5ow")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(7)]
    public SimpleValueList<string> AddressLine { get; init; } = [];
}
