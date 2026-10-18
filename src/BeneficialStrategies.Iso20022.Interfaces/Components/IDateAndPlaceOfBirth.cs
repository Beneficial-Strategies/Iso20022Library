// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and place of birth of a person.
/// </summary>
[IsoId("_QBE8Gdp-Ed-ak6NoX_4Aeg_1131681932")]
public interface IDateAndPlaceOfBirth : IIsoComponent
{
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_QBE8Gtp-Ed-ak6NoX_4Aeg_-1166836636")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    ISODate BirthDate { get; }

    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_QBOtENp-Ed-ak6NoX_4Aeg_-5969904")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    Max35Text? ProvinceOfBirth { get; }

    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_QBOtEdp-Ed-ak6NoX_4Aeg_-893474033")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    Max35Text CityOfBirth { get; }

    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_QBOtEtp-Ed-ak6NoX_4Aeg_8803974")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    CountryCode CountryOfBirth { get; }
}
