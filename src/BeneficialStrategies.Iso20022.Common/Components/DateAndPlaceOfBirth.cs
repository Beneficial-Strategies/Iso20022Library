// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDateAndPlaceOfBirth"/>
[IsoId("_QBE8Gdp-Ed-ak6NoX_4Aeg_1131681932")]
[DisplayName("Date And Place Of Birth")]
public partial record DateAndPlaceOfBirth
{
    /// <inheritdoc cref="IDateAndPlaceOfBirth.BirthDate"/>
    [IsoId("_QBE8Gtp-Ed-ak6NoX_4Aeg_-1166836636")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; }

    /// <inheritdoc cref="IDateAndPlaceOfBirth.ProvinceOfBirth"/>
    [IsoId("_QBOtENp-Ed-ak6NoX_4Aeg_-5969904")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <inheritdoc cref="IDateAndPlaceOfBirth.CityOfBirth"/>
    [IsoId("_QBOtEdp-Ed-ak6NoX_4Aeg_-893474033")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CityOfBirth { get; init; }

    /// <inheritdoc cref="IDateAndPlaceOfBirth.CountryOfBirth"/>
    [IsoId("_QBOtEtp-Ed-ak6NoX_4Aeg_8803974")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public required CountryCode CountryOfBirth { get; init; }
}
