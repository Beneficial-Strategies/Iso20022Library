// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and place of birth of a person.
/// </summary>
[IsoId("_jU8IEa9UEeeJJK1oRb-jTw")]
public interface IDateAndPlaceOfBirth1 : IIsoComponent
{
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_jexZga9UEeeJJK1oRb-jTw")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    IsoISODate BirthDate { get; }

    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_jexZg69UEeeJJK1oRb-jTw")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    IsoMax35Text? ProvinceOfBirth { get; }

    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_jexZha9UEeeJJK1oRb-jTw")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    IsoMax35Text CityOfBirth { get; }

    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_jexZh69UEeeJJK1oRb-jTw")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    CountryCode CountryOfBirth { get; }
}
