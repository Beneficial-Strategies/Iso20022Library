// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPostalAddress6"/>
[IsoId("_QHCaJNp-Ed-ak6NoX_4Aeg_1389999614")]
[DisplayName("Postal Address")]
public partial record PostalAddress6
{
    /// <inheritdoc cref="IPostalAddress6.AddressType"/>
    [IsoId("_QHCaJdp-Ed-ak6NoX_4Aeg_1389999616")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType2Code? AddressType { get; init; }

    /// <inheritdoc cref="IPostalAddress6.Department"/>
    [IsoId("_QHCaJtp-Ed-ak6NoX_4Aeg_596895935")]
    [DisplayName("Department")]
    [IsoXmlTag("Dept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? Department { get; init; }

    /// <inheritdoc cref="IPostalAddress6.SubDepartment"/>
    [IsoId("_QHCaJ9p-Ed-ak6NoX_4Aeg_1609731352")]
    [DisplayName("Sub Department")]
    [IsoXmlTag("SubDept")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? SubDepartment { get; init; }

    /// <inheritdoc cref="IPostalAddress6.StreetName"/>
    [IsoId("_QHCaKNp-Ed-ak6NoX_4Aeg_1389999977")]
    [DisplayName("Street Name")]
    [IsoXmlTag("StrtNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? StreetName { get; init; }

    /// <inheritdoc cref="IPostalAddress6.BuildingNumber"/>
    [IsoId("_QHCaKdp-Ed-ak6NoX_4Aeg_1390000378")]
    [DisplayName("Building Number")]
    [IsoXmlTag("BldgNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? BuildingNumber { get; init; }

    /// <inheritdoc cref="IPostalAddress6.PostCode"/>
    [IsoId("_QHMLINp-Ed-ak6NoX_4Aeg_1390000038")]
    [DisplayName("Post Code")]
    [IsoXmlTag("PstCd")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoMax16Text? PostCode { get; init; }

    /// <inheritdoc cref="IPostalAddress6.TownName"/>
    [IsoId("_QHMLIdp-Ed-ak6NoX_4Aeg_1390000069")]
    [DisplayName("Town Name")]
    [IsoXmlTag("TwnNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TownName { get; init; }

    /// <inheritdoc cref="IPostalAddress6.CountrySubDivision"/>
    [IsoId("_QHMLItp-Ed-ak6NoX_4Aeg_1390000099")]
    [DisplayName("Country Sub Division")]
    [IsoXmlTag("CtrySubDvsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CountrySubDivision { get; init; }

    /// <inheritdoc cref="IPostalAddress6.Country"/>
    [IsoId("_QHMLI9p-Ed-ak6NoX_4Aeg_1389999699")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <inheritdoc cref="IPostalAddress6.AddressLine"/>
    [IsoId("_QHMLJNp-Ed-ak6NoX_4Aeg_1389999668")]
    [DisplayName("Address Line")]
    [IsoXmlTag("AdrLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [MinLength(0)]
    [MaxLength(7)]
    public SimpleValueList<string> AddressLine { get; init; } = [];
}
