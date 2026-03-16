// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sort criteria.
/// </summary>
[IsoId("_Q7Vk6Np-Ed-ak6NoX_4Aeg_934154443")]
[DisplayName("Additional Parameters")]
public record AdditionalParameters1
{
    /// <summary>
    /// Specifies the country.
    /// </summary>
    [IsoId("_Q7Vk6dp-Ed-ak6NoX_4Aeg_1338656735")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public CountryCode? Country { get; init; }

    /// <summary>
    /// Specifies the currency.
    /// </summary>
    [IsoId("_Q7Vk6tp-Ed-ak6NoX_4Aeg_1338656995")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public ActiveOrHistoricCurrencyCode? Currency { get; init; }

    /// <summary>
    /// Specifies the geographical area, eg, Asia-Pacific, Europe, Middle-East.
    /// </summary>
    [IsoId("_Q7fV4Np-Ed-ak6NoX_4Aeg_1747776290")]
    [DisplayName("Geographical Area")]
    [IsoXmlTag("GeoArea")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? GeographicalArea { get; init; }
}
