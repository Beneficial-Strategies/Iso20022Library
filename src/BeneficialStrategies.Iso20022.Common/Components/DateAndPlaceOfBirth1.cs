// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IDateAndPlaceOfBirth1"/>
[IsoId("_jU8IEa9UEeeJJK1oRb-jTw")]
[DisplayName("Date And Place Of Birth")]
public partial record DateAndPlaceOfBirth1
{
    /// <inheritdoc cref="IDateAndPlaceOfBirth1.BirthDate"/>
    [IsoId("_jexZga9UEeeJJK1oRb-jTw")]
    [DisplayName("Birth Date")]
    [IsoXmlTag("BirthDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate BirthDate { get; init; }

    /// <inheritdoc cref="IDateAndPlaceOfBirth1.ProvinceOfBirth"/>
    [IsoId("_jexZg69UEeeJJK1oRb-jTw")]
    [DisplayName("Province Of Birth")]
    [IsoXmlTag("PrvcOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProvinceOfBirth { get; init; }

    /// <inheritdoc cref="IDateAndPlaceOfBirth1.CityOfBirth"/>
    [IsoId("_jexZha9UEeeJJK1oRb-jTw")]
    [DisplayName("City Of Birth")]
    [IsoXmlTag("CityOfBirth")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CityOfBirth { get; init; }

    /// <inheritdoc cref="IDateAndPlaceOfBirth1.CountryOfBirth"/>
    [IsoId("_jexZh69UEeeJJK1oRb-jTw")]
    [DisplayName("Country Of Birth")]
    [IsoXmlTag("CtryOfBirth")]
    public required CountryCode CountryOfBirth { get; init; }
}
