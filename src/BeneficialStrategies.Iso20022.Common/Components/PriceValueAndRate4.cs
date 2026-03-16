// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Price and rate.
/// </summary>
[IsoId("_m-cPsvNBEeCuA5Tr22BnwA_-566679044")]
[DisplayName("Price Value And Rate")]
public record PriceValueAndRate4
{
    /// <summary>
    /// Price expressed as a currency and amount.
    /// </summary>
    [IsoId("_m-cPs_NBEeCuA5Tr22BnwA_1971232942")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public PriceAndDirection1? Value { get; init; }

    /// <summary>
    /// Price expressed as a percentage.
    /// </summary>
    [IsoId("_m-cPtPNBEeCuA5Tr22BnwA_-208337999")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }
}
