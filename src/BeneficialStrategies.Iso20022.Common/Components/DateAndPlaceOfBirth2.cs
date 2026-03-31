// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and place of birth of a person.
/// </summary>
[IsoId("_NYK_BxcAEeiyVv5j1vf1VQ")]
[DisplayName("Date And Place Of Birth")]
public record DateAndPlaceOfBirth2
{
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    [IsoId("_NpR9IRcAEeiyVv5j1vf1VQ")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; }

    /// <summary>
    /// Province where a person was born.
    /// </summary>
    [IsoId("_NpR9IxcAEeiyVv5j1vf1VQ")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <summary>
    /// City where a person was born.
    /// </summary>
    [IsoId("_NpR9JRcAEeiyVv5j1vf1VQ")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CityOfBirth { get; init; }

    /// <summary>
    /// Country where a person was born.
    /// </summary>
    [IsoId("_NpR9JxcAEeiyVv5j1vf1VQ")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public CountryCode? CountryOfBirth { get; init; }
}
