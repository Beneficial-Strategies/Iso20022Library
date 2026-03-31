// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a price expressed as a rate.
/// </summary>
[IsoId("_Qa2uBdp-Ed-ak6NoX_4Aeg_101667231")]
[DisplayName("Price Rate")]
public record PriceRate1
{
    /// <summary>
    /// Type of rate, eg, yield.
    /// </summary>
    [IsoId("_Qa2uBtp-Ed-ak6NoX_4Aeg_112748166")]
    [DisplayName("Rate Type")]
    [IsoXmlTag("RateTp")]
    public required PriceRateType3FormatChoice_ RateType { get; init; }

    /// <summary>
    /// Price expressed as a rate, ie, percentage.
    /// </summary>
    [IsoId("_Qa2uB9p-Ed-ak6NoX_4Aeg_303697377")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }
}
